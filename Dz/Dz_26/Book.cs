using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_26
{
    internal class Book
    {
        private static HashSet<string> existingIsbns = new HashSet<string>();
        private string title;
        private string author;
        private int year;
        private string isbn;
        public Book(string title, string author, int year, string isbn) 
        {
            Title = title;
            Author = author;
            Year = year;
            ISBN = isbn;
        }
        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Cant be empty");
                title = value;
            }
        }
        public string Author
        {
            get => author;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Cant be empty");
                author = value;
            }
        }
        public int Year
        {
            get => year;
            set
            {
                if (value < 0 || value > DateTime.Now.Year)
                    throw new ArgumentException("Cant be 0 or from future");
                year = value;
            }
        }
        public string ISBN
        {
            get => isbn;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || (value.Length != 10 && value.Length != 13))
                    throw new ArgumentException("ISBN must be 10 or 13 characters long");
                if (!existingIsbns.Add(value))
                    throw new ArgumentException("ISBN must be unique");
                isbn = value;
            }
        }
    }
}
