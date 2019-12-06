using System;
using System.Collections.Generic;
using System.Text;

namespace IComparableDel2
{
    class Person : IComparable
    {
        public string name;
        public int age;
        public string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public int CompareTo(object obj)
        {
            Person otherPerson = obj as Person;
            var v = this.name.CompareTo(otherPerson.name);
            if (v == 0)
            {
                v = this.age.CompareTo(otherPerson.age);
            }
            if (v == 0)
            {
                v = this.gender.CompareTo(otherPerson.gender); // Denne virker kun fordi F er før M i alfabetet

               /* if (this.gender == "Female" && otherPerson.gender == "Male")
                {
                    v -= 1;
                }
                else if (this.gender == "Male" && otherPerson.gender == "Female")
                {
                    v += 1;
                }*/
            }

            return v;
        }
        public void write()
        {
            Console.Write(name + "(" + age + "),(" + gender + ")\t");
        }
    }
}
