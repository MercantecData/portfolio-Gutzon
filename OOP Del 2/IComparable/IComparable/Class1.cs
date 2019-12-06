using System;
using System.Collections.Generic;
using System.Text;

namespace IComparableOpg
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
            return this.age.CompareTo(otherPerson.age);
        }
    }
}
