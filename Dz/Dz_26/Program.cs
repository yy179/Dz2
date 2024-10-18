namespace Dz_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book1 = new Book("Estrella", "John Ben", 1949, "1234567890");
            Book book2 = new Book("New World", "Joahn Doe", 1977, "0987654321");

            library.ReturnBook(book1);
            library.ReturnBook(book2);
            library.ProcessReturn();
            library.ProcessReturn();
            library.RegisterReader("Daniil");
            library.RegisterReader("Michael");
            library.ShowAllReaders();
            library.RemoveReader("Daniil");
            library.ShowAllReaders();
            library.AddBook(new Book("Test Book", "Author A", 2020, "1122334455"));
            library.AddBook(new Book("Test Book 2", "Author B", 1899, "2233445566"));
            library.RemoveBook("1234567890");
            library.ShowYears();
        }
    }
}