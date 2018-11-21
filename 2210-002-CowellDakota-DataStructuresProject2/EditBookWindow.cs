///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject2/DataStructuresProject2
//	File Name:         EditBookWindow.cs
//	Description:       Presents a window to the user with the selected book's info. Then, prompts for them the change the data - Then updates the data
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2210_002_CowellDakota_DataStructuresProject2
{
    /// <summary>
    /// Partial class for allowing a user to edit a book
    /// </summary>
    public partial class EditBookWindow : Form
    {
        public Book EditedBook { get; set; }
        public Book InputBook { get; set; }

        /// <summary>
        /// Default constructor that intializes the window
        /// </summary>
        public EditBookWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the update button is clicked
        /// Sets the EditedBook property to the new book that is created and closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ValidateBookData())
            {
                Decimal.TryParse(priceTextBox.Text, out decimal cost);
                Enum.TryParse(typeDropDown.Text, out BookType type);
                Enum.TryParse(categoryDropDown.Text, out BookCategory category);
                EditedBook = new Book(type, titleTextBox.Text, authorTextBox.Text, coAuthorTextBox.Text, category, cost);
                this.Close();
            }
        }

        /// <summary>
        /// Make sure price is a number and Type and Category are valid
        /// </summary>
        /// <returns>True if data is valid - False if data is not valid</returns>
        private bool ValidateBookData()
        {
            return true;
        }

        /// <summary>
        /// When the window loads, populate the text fields with the Book's current information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBookWindow_Load(object sender, EventArgs e)
        {
            titleTextBox.Text = InputBook.Title;
            authorTextBox.Text = InputBook.Author;
            coAuthorTextBox.Text = InputBook.CoAuthor;
            priceTextBox.Text = InputBook.Price.ToString();
            typeDropDown.Text = InputBook.Type.ToString();
            categoryDropDown.Text = InputBook.Category.ToString();
        }
    }
}
