using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_26
{
    internal class Library
    {
        private Stack<Book> returnQueue = new Stack<Book>();
        private ObservableCollection<Book> availableBooks = new ObservableCollection<Book>();
        private LinkedList<string> readers = new LinkedList<string>();
        private SortedSet<int> publicationYears = new SortedSet<int>();
        public Library()
        {
            availableBooks.CollectionChanged += AvailableBooks_CollectionChanged;
        }

        private void AvailableBooks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                foreach (Book newBook in e.NewItems)
                {
                    Console.WriteLine($"Book added to library: {newBook.Title}");
                }
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                foreach (Book oldBook in e.OldItems)
                {
                    Console.WriteLine($"Book removed from library: {oldBook.Title}");
                }
            }
        }

        public void ReturnBook(Book book)
        {
            returnQueue.Push(book);
            Console.WriteLine($"Book returned: {book.Title}");
        }

        public void ProcessReturn()
        {
            if (returnQueue.Count == 0)
            {
                Console.WriteLine("No books to process.");
                return;
            }

            Book bookToAdd = returnQueue.Pop();
            availableBooks.Add(bookToAdd);
        }

        public void AddBook(Book book)
        {
            availableBooks.Add(book);
            AddYear(book.Year);
        }
        public void AddYear(int year)
        {
            publicationYears.Add(year);
        }

        public void ShowYears()
        {
            Console.WriteLine("Publication Years:");
            foreach (var year in publicationYears)
            {
                Console.WriteLine(year);
            }
        }
        public void RemoveBook(string isbn)
        {
            var bookToRemove = availableBooks.FirstOrDefault(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                availableBooks.Remove(bookToRemove);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void ShowAllReaders()
        {
            foreach (string item in readers)
            {
                Console.WriteLine(item);
            }
        }

        public void RegisterReader(string name)
        {
            readers.AddLast(name);
        }

        public void RemoveReader(string name)
        {
            readers.Remove(name);
        }
    }
}
