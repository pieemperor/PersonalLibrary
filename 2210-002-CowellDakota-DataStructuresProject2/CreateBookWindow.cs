///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject2/DataStructuresProject2
//	File Name:         CreateBookWindow.cs
//	Description:       Displays a window and prompts user to enter new information of a Book. Then, creates a book from the info
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
    /// Partial class for presenting the user with a window to create a book
    /// </summary>
    public partial class CreateBookWindow : Form
    {
        //property to keep track of a created book
        public Book Book { get; set; }

        /// <summary>
        /// Default constructor that initializes the window
        /// </summary>
        public CreateBookWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the create button is clicked
        /// Create an object and set the Book property to it. Then, close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createButton_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(priceTextBox.Text, out decimal cost);
            Enum.TryParse(typeDropDown.Text, out BookType type);
            Enum.TryParse(categoryDropDown.Text, out BookCategory category);
            Book = new Book(type, titleTextBox.Text, authorTextBox.Text, coAuthorTextBox.Text, category, cost);
            this.Close();
        }
    }
}