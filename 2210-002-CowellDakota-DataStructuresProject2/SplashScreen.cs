///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject2/DataStructuresProject2
//	File Name:         SplashScreen.cs
//	Description:       Window shown at the start of the application to welcome user to program
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
    /// Partial class used in the creation of a SplashScreen
    /// </summary>
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// Default Constructor used to initialize the window
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called after 3 seconds
        /// Closes the splash screen window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
