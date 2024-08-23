using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
namespace Dz_6;
internal class Program
{
    public static void Main(string[] args)
    {
        HshTable table = new HshTable();
        Que que = new Que();
        Lis lis = new Lis();
        Dict dict = new Dict();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        #region Task_1
        Console.WriteLine("Завдання 1 -----------------------------------------------------");
        dict.AddContact("Дмитро Пушкiн", 07788122);
        dict.AddContact("Юлiя Хмельницька", 08877221);
        dict.GetAll();
        dict.Searcher("Дмитро");
        dict.RemoveContact("Дмитро Пушкiн");
        Console.Write("Пiсля видалення: ");
        dict.GetAll();
        #endregion
        #region Task_2
        Console.WriteLine("Завдання 2 -----------------------------------------------------");
        lis.AddStudent("Влад");
        lis.AddStudent("Михайло");
        lis.StudentsCount();
        lis.StudentSearch("Влад");
        Console.Write("Пiсля видалення: ");
        lis.RemoveStudent("Влад");
        lis.StudentsCount();
        #endregion
        #region Task_3
        Console.WriteLine("Завдання 3 -----------------------------------------------------");
        que.AddBuyer("Покупець1");
        que.AddBuyer("Покупець2");
        que.BuyersCount();
        que.Maintenance();
        que.BuyersCount();
        #endregion
        #region Task_4
        Console.WriteLine("Завдання 4 -----------------------------------------------------");
        table.BookAdd(1, "Книга1");
        table.BookAdd(2, "Книга2");
        table.AllBooks();
        table.BookSearch(1);
        table.BookRemove(1);
        Console.Write("Пiсля видалення: ");
        table.AllBooks();
        table.BookSearch(1);
        #endregion
    }
}