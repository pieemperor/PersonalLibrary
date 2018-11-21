///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject2/DataStructuresProject2
//	File Name:         Person.cs
//	Description:       Keeps track of Person information - This is used to keep track of a library's owner
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Dakota Cowell, cowelld@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Friday, October 11, 2018
//	Copyright:         Dakota Cowell, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2210_002_CowellDakota_DataStructuresProject2
{
    /// <summary>
    /// Class to keep track of a Person's information
    /// Used in the PersonalLibrary class to keep track of the owner
    /// </summary>
    public class Person
    {
        private string _zip;
        private string _id;
        private string _phone;
        private string _email;

        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode {
            get
            {
                return _zip;
            }
            set
            {
                //Make sure zipCode matches regular expression - otherwise set to default zipCode
                Regex zipRegEx = new Regex(@"^\d{5}(-\d{4})?$");
                Match zipMatch = zipRegEx.Match(value);

                if (zipMatch.Success)
                {
                    _zip = value;
                } else
                {
                    _zip = "00000";
                }
            }
        }
        public string Id {
            get
            {
                return _id;
            }
            set
            {
                //Make sure id matches regular expression - otherwise set to default id
                Regex idRegEx = new Regex(@"^E\d{8}$");
                Match idMatch = idRegEx.Match(value);

                if (idMatch.Success)
                {
                    _id = value;
                } else
                {
                    _id = "E00000000";
                }
            }
        }
        public string PhoneNumber {
            get
            {
                return _phone;
            }
            set
            {
                //Make sure phone number matches regular expression - otherwise set to default phone number
                Regex phoneRegEx = new Regex(@"^(\d{3}-\d{4})|(\(\d{3}\)\s?\d{3}-\d{4})$");
                Match phoneMatch = phoneRegEx.Match(value);

                if (phoneMatch.Success)
                {
                    _phone = value;
                } else
                {
                    _phone = "(000)000-0000";
                }
            }
        }
        public string EmailAddress {
            get
            {
                return _email;
            }
            set
            {
                //Make sure email matches regular expression - otherwise set to default email

                Regex emailRegex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[a-z]{2,}$");
                Match emailMatch = emailRegex.Match(value);

                if (emailMatch.Success)
                {
                    _email = value;
                } else
                {
                    _email = "default@default.com";
                }
            }
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name">Name of owner</param>
        /// <param name="streetAddress">Address of Owner</param>
        /// <param name="city">City where the owner lives</param>
        /// <param name="state">State where the owner lives</param>
        /// <param name="zipCode">Owner's zip code</param>
        /// <param name="id">Owner's ID (ETSU ID)</param>
        /// <param name="phoneNumber">Owner's Phone Number</param>
        /// <param name="emailAddress">Owner's Email Address</param>
        public Person(string name, string streetAddress, string city, string state, string zipCode, string id, string phoneNumber, string emailAddress)
        {
            this.Name = name;
            this.StreetAddress = streetAddress;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
        }

        /// <summary>
        /// Creates a pipe delimited string of the owner's information
        /// </summary>
        /// <returns> pipe delimited string of the owner information</returns>
        public override string ToString()
        {
            string owner = this.Name + "|" + this.StreetAddress + "|" + this.City + "|" +
                           this.State + "|" + this.ZipCode + "|" + this.Id + "|" + this.PhoneNumber + "|" + this.EmailAddress;
            return owner;
        }

    }
}
