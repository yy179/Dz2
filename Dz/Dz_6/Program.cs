using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
namespace Dz_6;
internal class Program
{
    private Dictionary<string,int> contacts = new Dictionary<string, int>();
    private List<string> students = new List<string>();
    private Queue<string> buyers = new Queue<string>();
    private Hashtable books = new Hashtable();
    public static void Main(string[] args)
    {
        Program program = new Program();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        #region Task_1
        Console.WriteLine("Завдання 1 -----------------------------------------------------");
        program.AddContact("Дмитро Пушкiн", 07788122);
        program.AddContact("Юлiя Хмельницька", 08877221);
        program.GetAll();
        program.Searcher("Дмитро");
        program.RemoveContact("Дмитро Пушкiн");
        Console.Write("Пiсля видалення: ");
        program.GetAll();
        #endregion
        #region Task_2
        Console.WriteLine("Завдання 2 -----------------------------------------------------");
        program.AddStudent("Влад");
        program.AddStudent("Михайло");
        program.StudentSearch("Влад");
        Console.Write("Пiсля видалення: ");
        program.RemoveStudent("Влад");
        program.StudentsCount();
        #endregion
        #region Task_3
        Console.WriteLine("Завдання 3 -----------------------------------------------------");
        program.AddBuyer("Покупець1");
        program.AddBuyer("Покупець2");
        program.BuyersCount();
        program.Maintenance();
        program.BuyersCount();
        #endregion
        #region Task_4
        Console.WriteLine("Завдання 4 -----------------------------------------------------");
        program.BookAdd(1, "Книга1");
        program.BookAdd(2, "Книга2");
        program.AllBooks();
        program.BookSearch(1);
        program.BookRemove(1);
        Console.Write("Пiсля видалення: ");
        program.AllBooks();
        program.BookSearch(1);
        #endregion
    }
    #region Task_1_methods
    public void AddContact(string name, int number) { contacts.Add(name, number); }
    public void RemoveContact(string name) { contacts.Remove(name); }

    public void GetAll()
    {
        foreach (KeyValuePair<string, int> pair in contacts)
        {
            Console.WriteLine($"Ім'я: {pair.Key}, Номер телефону: {pair.Value}");
        }
    }
    public void Searcher(string partname)
    {
        var res = contacts.Where(contact => contact.Key.ToLower().Contains(partname.ToLower())).ToList();
        if (res.Any())
        {
            Console.WriteLine("Знайдені контакти:");
            foreach (var contact in res)
            {
                Console.WriteLine($"Ім'я: {contact.Key}, Номер: {contact.Value}");
            }
        }
        else
        {
            Console.WriteLine("Контакти не знайдено.");
        }
    }
    #endregion
    #region Task_2_methods
    public void AddStudent(string student) { students.Add(student); }
    public void RemoveStudent(string student) {students.Remove(student); }
    public void StudentSearch(string partname)
    {
        var res = students.Where(students => students.ToLower().Contains(partname.ToLower())).ToList();
        if (res.Any())
        {
            Console.WriteLine("Знайдені студенти:");
            foreach (var students in res)
            {
                Console.WriteLine($"Ім'я: {students}");
            }
        }
        else
        {
            Console.WriteLine("Студентiв не знайдено.");
        }
    }
    public void StudentsCount() { Console.WriteLine($"Кол-во студентiв: {students.Count}"); }
    #endregion
    #region Task_3_methods
    public void AddBuyer(string buyer) { buyers.Enqueue(buyer); }
    public void Maintenance() { Console.WriteLine(buyers.Dequeue()); }
    public void BuyersCount() { Console.WriteLine($"Buyers count in queue: {buyers.Count}"); }
    #endregion
    #region Task_4_methods
    public void BookAdd(int key, string name) {  books.Add(key, name); }
    public void BookRemove(int key) { books.Remove(key); }
    public void BookSearch(int key)
    {
        if (books.ContainsKey(key)) { Console.WriteLine(books[key]); }
        else { Console.WriteLine("Такий ключ вiдсутнiй"); }
    }
    public void AllBooks() { Console.WriteLine(string.Join(", ", books.Values.Cast<string>())); }
    #endregion
}