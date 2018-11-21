///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject2/DataStructuresProject2
//	File Name:         AuthorFilterWindow.cs
//	Description:       Presents a window asking the user for an author to filter the library by
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
    /// partial class to display a window to filter the library on Author
    /// </summary>
    public partial class AuthorFilterWindow : Form
    {
        public string AuthorToFilter { get; set; }

        /// <summary>
        /// Constructor - Initialize Window
        /// </summary>
        public AuthorFilterWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the Submit button is clicked, set the AuthorToFilter to the text in the text box and close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AuthorToFilter = authorFilterTextBox.Text;
            this.Close();
        }
    }
}
