///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject2/DataStructuresProject2
//	File Name:         UpdateOwnerWindow.cs
//	Description:       Update an Owner's details for a library 
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2210_002_CowellDakota_DataStructuresProject2
{
    /// <summary>
    /// Partial class to prompt user to update an Owner's information
    /// </summary>
    public partial class UpdateOwnerWindow : Form
    {
        public Person InputOwner { get; set; }
        public Person OutputOwner { get; set; }

        /// <summary>
        /// Default constructor to intialize the window
        /// </summary>
        public UpdateOwnerWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the page loads, populate the text boxes with the Owner's current info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateOwnerWindow_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = InputOwner.Name;
            addressTextBox.Text = InputOwner.StreetAddress;
            stateTextBox.Text = InputOwner.State;
            emailTextBox.Text = InputOwner.EmailAddress;
            idTextBox.Text = InputOwner.Id;
            cityTextBox.Text = InputOwner.City;
            zipCodeTextBox.Text = InputOwner.ZipCode;
            phoneNumberTextBox.Text = InputOwner.PhoneNumber;
        }

        /// <summary>
        /// Called when the update button is clicked - Updates a person's info if the data is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ValidateOwnerData())
            {
                OutputOwner = new Person(nameTextBox.Text, addressTextBox.Text, cityTextBox.Text, stateTextBox.Text, zipCodeTextBox.Text, idTextBox.Text, phoneNumberTextBox.Text, emailTextBox.Text);
                this.Close();
            }
        }

        /// <summary>
        /// Validates the new information typed by the user. 
        /// Validates email, Zip Code, ID, And Phone Number
        /// If it's invalid, display an error message
        /// </summary>
        /// <returns>True if data is valid - False if data is inalid</returns>
        private bool ValidateOwnerData()
        {
            bool isValid = true;
            string errorMessage = "";

            //5 digits followed by an optional dash with 4 more digits
            Regex zipRegEx = new Regex(@"^\d{5}(-\d{4})?$");
            Match zipMatch = zipRegEx.Match(zipCodeTextBox.Text);

            //Must begin with E then have 8 digits
            Regex idRegEx = new Regex(@"^E\d{8}$");
            Match idMatch = idRegEx.Match(idTextBox.Text);

            //Could have 3 digits then 4 or parentheses with 3 digits in them then 3 digits and 4
            Regex phoneRegEx = new Regex(@"^(\d{3}-\d{4})|(\(\d{3}\)\s?\d{3}-\d{4})$");
            Match phoneMatch = phoneRegEx.Match(phoneNumberTextBox.Text);

            //Must have some characters and then an @ symbol and then more characters and the a . and 2 or more characters
            Regex emailRegex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[a-z]{2,}$");
            Match emailMatch = emailRegex.Match(emailTextBox.Text);

            if (!zipMatch.Success)
            {
                isValid = false;
                errorMessage += "Zip Code must be in the format of XXXXX or XXXXX-XXXX\n";
            }

            if (!idMatch.Success)
            {
                isValid = false;
                errorMessage += "ID must begin with an E and be followed by 8 digits - EXXXXXXXX\n";
            }

            if (!phoneMatch.Success)
            {
                isValid = false;
                errorMessage += "Phone number must be in the format (XXX)XXX-XXXX or XXX-XXXX\n";
            }

            if (!emailMatch.Success)
            {
                isValid = false;
                errorMessage += "Email must be in the format XXXXX@XXXX.XXX";
            }

            if(errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Invalid Information");
            }

            return isValid;
        }
    }
}
