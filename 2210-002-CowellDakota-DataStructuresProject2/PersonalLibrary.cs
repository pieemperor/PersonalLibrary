///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject2/DataStructuresProject2
//	File Name:         PersonalLibrary.cs
//	Description:       Keeps track of someone's library and all of the information associated with it
//                     Includes all books and an owner - Implements indexers and operators
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
    /// Class to keep track of a personal library
    /// It should allow for sorting and retrieval of books by author
    /// This class implements indexers and the + and - operators
    /// </summary>
    public class PersonalLibrary
    {
        private List<Book> Books;
        public Person Owner { get; set; }
        public string PathAndFileName { get; }
        public bool SaveNeeded { get; set; }
        public int Count {
            get
            {
                return Books.Count;
            }
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="books">List of books in the library</param>
        /// <param name="owner">Person object of the person who is the owner of this library</param>
        /// <param name="pathAndFileName">Path to where the current library is stored</param>
        /// <param name="saveNeeded">If save is needed</param>
        public PersonalLibrary(List<Book> books, Person owner, string pathAndFileName, bool saveNeeded)
        {
            Books = books;
            Owner = owner;
            PathAndFileName = pathAndFileName;
            SaveNeeded = false;
        }

        /// <summary>
        /// String indexer - Allows for retrieval of Books by title
        /// </summary>
        /// <param name="title">Title of book</param>
        /// <returns>Returns book object that corresponds to the index</returns>
        public Book this[string title]
        {
            get {
                foreach (Book book in Books)
                {
                    if (book.Title == title)
                    {
                        return book;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Integer indexer - Allows for retrieval of Books by integer position
        /// </summary>
        /// <param name="index">Position in List of books</param>
        /// <returns>Returns book object that corresponds to the index</returns>
        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < Books.Count)
                {
                    return Books[index];
                } else
                {
                    return null;
                }
            }
        }
        
        /// <summary>
        /// + operator for adding a Book to a PersonalLibrary
        /// </summary>
        /// <param name="library">Personal Library object to be added to</param>
        /// <param name="newBook">Book to be added to the Library</param>
        /// <returns>Library object with the book added</returns>
        public static PersonalLibrary operator+(PersonalLibrary library, Book newBook)
        {
            library.Books.Add(newBook);
            return library;
        }

        /// <summary>
        /// - operator for removing a Book from a PersonalLibrary
        /// </summary>
        /// <param name="library">Personal Library object to be added to</param>
        /// <param name="bookPosition">Position of the book to be removed from library</param>
        /// <returns>Returns library with book removed</returns>
        public static PersonalLibrary operator-(PersonalLibrary library, int bookPosition)
        {
            if(bookPosition >= 0 && bookPosition < library.Books.Count)
            {
                library.Books.RemoveAt(bookPosition);
            }
            return library;
        }

        /// <summary>
        /// Sorts the books list by title
        /// Can use sort because Book implements IComparable
        /// </summary>
        public void SortByTitle()
        {
            Books.Sort();
        }

        /// <summary>
        /// Retrieves all books based on an author passed in
        /// Retrieves all authors and co-authors
        /// </summary>
        /// <param name="author">Name of the author to be filtered by</param>
        /// <returns>Returns a list of books that are authored or co-authored by the passed in name</returns>
        public List<Book> RetrieveByAuthor(string author)
        {
            return Books.FindAll(b => b.Author.Equals(author, StringComparison.CurrentCultureIgnoreCase) || b.CoAuthor.Equals(author, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
