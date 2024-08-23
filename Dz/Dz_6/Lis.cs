using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_6
{
    internal class Lis
    {
        private List<string> students = new List<string>();
        public void AddStudent(string student) { students.Add(student); }
        public void RemoveStudent(string student) { students.Remove(student); }
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
    }
}
