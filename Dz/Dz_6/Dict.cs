using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    
    internal class Dict
    {
        private Dictionary<string, int> contacts = new Dictionary<string, int>();
        public  void AddContact(string name, int number) { contacts.Add(name, number); }
        public  void RemoveContact(string name) { contacts.Remove(name); }

        public  void GetAll()
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
    }
}
