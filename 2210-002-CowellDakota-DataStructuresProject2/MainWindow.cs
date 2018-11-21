///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject2/DataStructuresProject2
//	File Name:         MainWindow.cs
//	Description:       Main window that the user interacts with - Creates instances of many other windows and displays information about the library
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Dakota Cowell, cowelld@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Friday, October 11, 2018
//	Copyright:         Dakota Cowell, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2210_002_CowellDakota_DataStructuresProject2
{
    /// <summary>
    /// Partial class that is associated with the MainWindow Form 
    /// Performs many different actions when buttons events occur on the main window
    /// This is the main window in this application
    /// </summary>
    public partial class MainWindow : Form
    {
        //variable to keep track of the current PersonalLibrary object that is being tracked
        PersonalLibrary currentLib = null;
        List<Book> booksListFilteredByAuthor = null;

        /// <summary>
        /// Initializing the Main Window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that is called when the about button is clicked on the main window's toolStrip
        /// Presents the about window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.Show();
        }

        /// <summary>
        /// Method to open a file and create a new PersonalLibrary from the data in the file
        /// This method is called when the open button is clicked in the main window toolStrip
        /// This method also updates the user interface with the information from the currentLib variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Temporary variables to store List of new books and owner
            List<Book> tempBooksList = new List<Book>();
            Person owner = null;

            //Clear listBox data source
            booksListBox.DataSource = null;

            //Create OpenFileDialog for library input
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.InitialDirectory = @"..\..\LibraryData";
            openDlg.Title = "Select the file where your library is stored.";

            //Display OpenFileDialog so user can select their file
            if(openDlg.ShowDialog() != DialogResult.Cancel)
            {
                //Name of the file selected by the user
                string fileName = openDlg.FileName;

                //Initialize Owner and book attributes
                StreamReader rdr = null;
                string[] ownerAttributes = null;
                string[] bookAttributes = null;
                //Used to keep track of what line the StreamReader is on
                int count = 0;
                BookType type = BookType.Digital;
                BookCategory category = BookCategory.Other;
                decimal cost = 0.0M;

                try
                {
                    //Create new StreamReader and loop through the file that was selected
                    rdr = new StreamReader(openDlg.FileName);
                    while(rdr.Peek() != -1)
                    {
                        //If the StreamReader is not reading the first line, split that line into the bookAttributes variable
                        //If the StreamReader is reading the first line, split the line into the ownerAttributes variable
                        if (count > 0)
                        {
                            bookAttributes = rdr.ReadLine().Split('|');

                            //Get Enum & decimal from string values
                            if(Enum.TryParse(bookAttributes[0], out BookType bookType))
                            {
                                type = bookType;
                            } 

                            if (Enum.TryParse(bookAttributes[4], out BookCategory bookCategory))
                            {
                                category = bookCategory;
                            }

                            if (Decimal.TryParse(bookAttributes[5], out decimal bookCost))
                            {
                                cost = bookCost;
                            }

                            //Create new book object and add it to the tempBooksList 
                            Book book = new Book(type, bookAttributes[1], bookAttributes[2], bookAttributes[3],category,cost);
                            tempBooksList.Add(book);
                        } else
                        {
                            //Split the line on the | character and create a new Person from that 
                            ownerAttributes = rdr.ReadLine().Split('|');
                            owner = new Person(ownerAttributes[0], ownerAttributes[1], ownerAttributes[2], ownerAttributes[3], ownerAttributes[4], ownerAttributes[5], ownerAttributes[6], ownerAttributes[7]);
                            count++;
                        }
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    //If the StreamReader is open, close it
                    if(rdr != null)
                    {
                        rdr.Close();
                    }
                }
                //Create new PersonalLibrary object from the data that was passed in and update the view with the information that was just added
                currentLib = new PersonalLibrary(tempBooksList, owner, fileName, false);
                for (int i = 0; i < currentLib.Count; i++)
                {
                    booksListBox.Items.Add(currentLib[i]);
                }
                this.Text = currentLib.PathAndFileName;
                SetOwnerLabels();
                statusBarLabel.Text = "Library Opened Successfully";
                statusBarBooksLabel.Text = currentLib.Count.ToString() + " Books in current library";
            }
        }

        /// <summary>
        /// Saves the current library to a pipe delimited file
        /// This is called when the save button is pressed in the main window's toolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If library is null, do not save anything
            if (currentLib != null)
            {
                //Create SaveFileDialog and set attributes
                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.InitialDirectory = @"..\..\LibraryData";
                saveDlg.Title = "Save your library";

                //Show SaveFileDialog
                if (saveDlg.ShowDialog() != DialogResult.Cancel)
                {
                    StreamWriter writer = null;
                    try
                    {
                        //Create new StreamWriter and write the current Owner to the file
                        writer = new StreamWriter(saveDlg.FileName);

                        //This uses the Owner's ToString method which returns the owner as a pipe delimited string
                        writer.WriteLine(currentLib.Owner);

                        //For each book, write to the file and after finished saving, change SaveNeeded to false
                        for (int i = 0; i < currentLib.Count; i++)
                        {
                            writer.WriteLine(currentLib[i].ToPipeDelimitedString());
                        }
                        currentLib.SaveNeeded = false;
                        statusBarLabel.Text = "File Saved Successfully";
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    finally
                    {
                        //if StreamWriter is open, close it
                        if (writer != null)
                        {
                            writer.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Closes the program
        /// Called when the quit button is pressed in the toolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Removes the selected book from the current library
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentLib != null)
            {
                if (booksListFilteredByAuthor == null)
                {
                    //If an Item is selected in the listBox, Remove the book from the library
                    if (booksListBox.SelectedIndex != -1)
                    {
                        int idx = booksListBox.SelectedIndex;
                        booksListBox.Items.Clear();
                        currentLib -= idx;
                        currentLib.SaveNeeded = true;
                        for (int i = 0; i < currentLib.Count; i++)
                        {
                            booksListBox.Items.Add(currentLib[i]);
                        }
                        statusBarLabel.Text = "Book Removed Successfully";
                        statusBarBooksLabel.Text = currentLib.Count.ToString() + " Books in current library";
                    }
                } else
                {
                    MessageBox.Show("Cannot modify while filtered by author");
                }
            }
        }

        /// <summary>
        /// Sorts the list of books in the current library
        /// Called when the sort button is clicked in the main window tool strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Make sure current library is not null. Then, sort the books list
            if (currentLib != null)
            {
                if (booksListFilteredByAuthor == null)
                {
                    booksListBox.Items.Clear();
                    currentLib.SortByTitle();
                    for (int i = 0; i < currentLib.Count; i++)
                    {
                        booksListBox.Items.Add(currentLib[i]);
                    }
                    statusBarLabel.Text = "Library Sorted Successfully";
                }
                else
                {
                    MessageBox.Show("Cannot Sort while filtered");
                }
            }
        }

        /// <summary>
        /// Updates the details panel with the info on the selected book
        /// Called when the selected item in the listbox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void booksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (booksListFilteredByAuthor != null)
            {
                this.titleLabel.Text = booksListFilteredByAuthor[booksListBox.SelectedIndex].Title;
                this.authorLabel.Text = booksListFilteredByAuthor[booksListBox.SelectedIndex].Author;
                this.coAuthorLabel.Text = booksListFilteredByAuthor[booksListBox.SelectedIndex].CoAuthor;
                this.typeLabel.Text = booksListFilteredByAuthor[booksListBox.SelectedIndex].Type.ToString();
                this.priceLabel.Text = booksListFilteredByAuthor[booksListBox.SelectedIndex].Price.ToString();
                this.categoryLabel.Text = booksListFilteredByAuthor[booksListBox.SelectedIndex].Category.ToString();
                detailsPanel.Visible = true;
            }
            //Make sure something is selected - Then, Update details panel labels
            else if (currentLib[booksListBox.SelectedIndex] != null)
            {
                this.titleLabel.Text = currentLib[booksListBox.SelectedIndex].Title;
                this.authorLabel.Text = currentLib[booksListBox.SelectedIndex].Author;
                this.coAuthorLabel.Text = currentLib[booksListBox.SelectedIndex].CoAuthor;
                this.typeLabel.Text = currentLib[booksListBox.SelectedIndex].Type.ToString();
                this.priceLabel.Text = currentLib[booksListBox.SelectedIndex].Price.ToString();
                this.categoryLabel.Text = currentLib[booksListBox.SelectedIndex].Category.ToString();
                detailsPanel.Visible = true;
            }

        }

        /// <summary>
        /// On load, load clock and hide the datails panel until there is information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            detailsPanel.Visible = false;
            LoadClock();
        }

        /// <summary>
        /// Allows user to filter library on author
        /// Called when the show all by author button is clicked in the toolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllByAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Make sure there is a library. 
            if (currentLib != null)
            {
                if (booksListFilteredByAuthor == null)
                {
                    //Prompt the user for an author's name using an AuthorFilterWindow
                    AuthorFilterWindow authorFilterWindow = new AuthorFilterWindow();
                    authorFilterWindow.ShowDialog();

                    //After they have entered an author, use the retrieveByAuthor method to get the author
                    if (authorFilterWindow.AuthorToFilter != "")
                    {
                        booksListBox.Items.Clear();
                        booksListFilteredByAuthor = currentLib.RetrieveByAuthor(authorFilterWindow.AuthorToFilter);
                        booksListBox.DataSource = booksListFilteredByAuthor;
                        statusBarLabel.Text = $"Filtered by Author: {authorFilterWindow.AuthorToFilter}";
                    }
                } else
                {
                    MessageBox.Show("Must clear filter before searching by another author");
                }
            }
        }

        /// <summary>
        /// Prompts the user for information for a new book. Then, add that book to the current library
        /// Called when the Add button is clicked in the Modify bar in the toolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Make sure there is a library
            if (currentLib != null)
            {
                if (booksListFilteredByAuthor == null)
                {
                    //Create a createBooWindow and show it to the user - Then after they submit the form, create new book, add it to the listBox, and update currentLibrary
                    CreateBookWindow createBookWindow = new CreateBookWindow();
                    createBookWindow.ShowDialog();
                    if (createBookWindow.Book != null)
                    {
                        booksListBox.Items.Clear();
                        currentLib += createBookWindow.Book;
                        currentLib.SaveNeeded = true;
                        for (int i = 0; i < currentLib.Count; i++)
                        {
                            booksListBox.Items.Add(currentLib[i]);
                        }
                        statusBarLabel.Text = "Book Added Successfully";
                        statusBarBooksLabel.Text = currentLib.Count.ToString() + " Books in current library";
                    } 
                } else
                {
                    MessageBox.Show("Cannot Modify while filtered");
                }
            }
        }

        /// <summary>
        /// Prompt user to edit a selected book's details
        /// Then, it updates the Book in the currentLibrary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Make sure there is a library
            if (currentLib != null && booksListBox.SelectedIndex != -1)
            {
                if (booksListFilteredByAuthor == null)
                {

                    //Create EditBookWindow and then present the window with the current selected book's info
                    EditBookWindow editBookWindow = new EditBookWindow();
                    editBookWindow.InputBook = currentLib[booksListBox.SelectedIndex];
                    editBookWindow.ShowDialog();

                    //If the user input valid data, remove the original book and add the book with new info to the currentLibrary
                    if (editBookWindow.EditedBook != null)
                    {
                        int selectedBookIndex = booksListBox.SelectedIndex;
                        booksListBox.Items.Clear();
                        currentLib -= selectedBookIndex;
                        currentLib += editBookWindow.EditedBook;
                        currentLib.SaveNeeded = true;
                        for (int i = 0; i < currentLib.Count; i++)
                        {
                            booksListBox.Items.Add(currentLib[i]);
                        }
                        statusBarLabel.Text = "Book Edited Successfully";
                    }
                }
                else
                {
                    MessageBox.Show("Cannot Modify while filtered");
                }
            }
        }

        /// <summary>
        /// Calls LoadClock every second - Allows for update of Time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            LoadClock();
        }

        /// <summary>
        /// Helper method to change the status bar label to the current date and time
        /// </summary>
        private void LoadClock()
        {
            statusBarDateLabel.Text = DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        /// <summary>
        /// Prompts user to update owner information
        /// You pass the owner to the UpdateOwnerView and then you get the edited owner back and update that in the current library
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Make sure there is a library
            if (currentLib != null)
            {
                //Create UpdateOwnerWindow and pass in the owner of this library
                UpdateOwnerWindow updateOwnerWindow = new UpdateOwnerWindow();
                updateOwnerWindow.InputOwner = currentLib.Owner;
                updateOwnerWindow.ShowDialog();

                //If the user input valid data, update the current library's owner with the new info
                if (updateOwnerWindow.OutputOwner != null)
                {
                    currentLib.Owner = updateOwnerWindow.OutputOwner;
                    SetOwnerLabels();
                    currentLib.SaveNeeded = true;
                    statusBarLabel.Text = "Owner Updated Successfully";
                }
            }
        }

        /// <summary>
        /// Sets the Labels in the Owner panel to the owner's information
        /// </summary>
        private void SetOwnerLabels()
        {
            ownerInfoLabel.Text = $"{currentLib.Owner.Name}    {currentLib.Owner.Id}    {currentLib.Owner.EmailAddress}    {currentLib.Owner.PhoneNumber}";
            ownerAddressLabel.Text = $"{currentLib.Owner.StreetAddress}   {currentLib.Owner.City}, {currentLib.Owner.State} {currentLib.Owner.ZipCode}";
        }

        private void clearAuthorFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(booksListFilteredByAuthor != null)
            {
                booksListFilteredByAuthor = null;
                booksListBox.DataSource = null;
                booksListBox.Items.Clear();

                for (int i = 0; i < currentLib.Count; i++)
                {
                    booksListBox.Items.Add(currentLib[i]);
                }
            }
        }
    }
}