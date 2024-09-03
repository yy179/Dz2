using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
namespace Dz_11;

internal class Program
{
    [DocumentationAttribute("AuthorTest", 1)]
    public void Method() { }
    [DocumentationAttribute("AuthorTest2", 2, "TestDescription")]
    public void Method2() { }
    public static void Main(string[] args)
    {
        Type type = typeof(Program);
        MethodInfo[] methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
        foreach (MethodInfo method in methods)
        {
            var attributes = method.GetCustomAttributes(typeof(DocumentationAttribute), false);
            foreach (DocumentationAttribute attribute in attributes)
            {
                Console.WriteLine($"Method: {method.Name}");
                Console.WriteLine($"Author: {attribute.Author}");
                Console.WriteLine($"Version: {attribute.Version}");
                Console.WriteLine($"Description: {attribute.Description}");
            }
        }
        ExecuteByAuthor("AuthorTest");
    }
    public static void ExecuteByAuthor(string author)
    {
        Type type = typeof(Program);
        MethodInfo[] methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

        foreach (MethodInfo method in methods)
        {
            var attributes = method.GetCustomAttributes(typeof(DocumentationAttribute), false);
            foreach (DocumentationAttribute attribute in attributes)
            {
                if (attribute.Author == author)
                {
                    Console.WriteLine($"Executing Method: {method.Name}");
                    method.Invoke(Activator.CreateInstance(type), null);
                }
            }
        }
    }
}