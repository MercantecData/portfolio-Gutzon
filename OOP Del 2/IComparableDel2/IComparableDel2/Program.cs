using System;
using System.Collections.Generic;

namespace IComparableDel2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Kim", 18, "Male"));
            people.Add(new Person("Robin", 27, "Male"));
            people.Add(new Person("Robin", 25, "Female"));
            people.Add(new Person("Adolf", 45, "Male"));
            people.Add(new Person("Kim", 18, "Female"));
            people.Add(new Person("Anna", 18, "Female"));
            people.Add(new Person("Drax", 26, "Male"));
            people.Add(new Person("Erica", 25, "Female"));
            people.Add(new Person("Erik", 27, "Male"));
            people.Add(new Person("Anne", 45, "Female"));

            foreach (Person per in people)
            {
                per.write();
            }
            Console.WriteLine();
            people.Sort();
            foreach (Person per in people)
            {
                per.write();
            }
        }
    }
}
