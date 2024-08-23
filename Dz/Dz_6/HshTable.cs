using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Dz_6
{
    internal class HshTable
    {
        private Hashtable books = new Hashtable();
        public void BookAdd(int key, string name) { books.Add(key, name); }
        public void BookRemove(int key) { books.Remove(key); }
        public void BookSearch(int key)
        {
            if (books.ContainsKey(key)) { Console.WriteLine(books[key]); }
            else { Console.WriteLine("Такий ключ вiдсутнiй"); }
        }
        public void AllBooks() { Console.WriteLine(string.Join(", ", books.Values.Cast<string>())); }
    }
}
