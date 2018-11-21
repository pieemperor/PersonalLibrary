///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject2/DataStructuresProject2
//	File Name:         Book.cs
//	Description:       Keep track of Book information
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
using System.Threading.Tasks;

namespace _2210_002_CowellDakota_DataStructuresProject2
{
    /// <summary>
    /// Class to keep track of Books - Uses 2 different Enums
    /// Implements the IEquatable and IComparable interfaces
    /// </summary>
    public class Book : IEquatable<Book>, IComparable<Book>
    {
        public BookType Type { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoAuthor { get; set; }
        public BookCategory Category { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Paramaterized Constructor
        /// </summary>
        /// <param name="bookType">Digital or Print - Enum</param>
        /// <param name="title">Title of the book</param>
        /// <param name="author">Author of the book</param>
        /// <param name="coAuthor">Co-Author of the book</param>
        /// <param name="bookCategory">Book Category - BookCategory Enum</param>
        /// <param name="price">Price of the book</param>
        public Book(BookType bookType, string title, string author, string coAuthor, BookCategory bookCategory, decimal price)
        {
            this.Type = bookType;
            this.Title = title;
            this.Author = author;
            this.CoAuthor = coAuthor;
            this.Category = bookCategory;
            this.Price = price;
        }

        /// <summary>
        /// Converts book to a string - just returns title
        /// </summary>
        /// <returns>Returns title of the book</returns>
        public override string ToString()
        {
            return this.Title;
        }

        /// <summary>
        /// Converts book information to a pipe delimited string and returns that
        /// </summary>
        /// <returns>Pipe delimited string of book information</returns>
        public string ToPipeDelimitedString()
        {
            string bookString = this.Type + "|" + this.Title + "|" + this.Author + "|" + this.CoAuthor + "|" + this.Category + "|" + this.Price;
            return bookString;
        }

        /// <summary>
        /// Method for comparing books - Compares titles to check which is greater
        /// The IComparable Interface Method Implementation
        /// </summary>
        /// <param name="other">Other book object to compare to</param>
        /// <returns>Integer value representing which book is greater</returns>
        public int CompareTo(Book other)
        {
            return Title.CompareTo(other.Title);
        }

        /// <summary>
        /// Checks if 2 books are equal by comparing their title and author
        /// Part of the IEquatable Interface Implementation
        /// </summary>
        /// <param name="other">Other book to compare to</param>
        /// <returns>True if books are equal - false if not</returns>
        public bool Equals(Book other)
        {
            return other.Title == Title && other.Author == Author;
        }

        /// <summary>
        /// Calculate HashCode from Book title and Author
        /// Part of IEquatable Interface Implementation
        /// </summary>
        /// <returns>int representing the Book object</returns>
        public override int GetHashCode()
        {
            return this.Title.GetHashCode() * 17 + this.Author.GetHashCode();
        }
    }
}
