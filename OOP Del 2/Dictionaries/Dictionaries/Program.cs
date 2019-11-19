using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string space = "─────────────────────────────────────────────────────────────";
            StringKey();
            Console.WriteLine(space);
            FloatKey();
            Console.WriteLine(space);
            ClassKey();

            Console.ReadLine();
        }
        static void StringKey()
        {
            Dictionary<string, int> stringKey = new Dictionary<string, int>() { { "Holstebro", 7500 }, { "Aarhus", 8100 }, { "Viborg", 8800 }, { "Lemvig", 7620 }, { "Struer", 7600 }, { "One", 1 }, { "Satan",666 }, { "Two", 2 }, {"God", 777 }, { "Three", 3 } };
            string[] stringKeyArray = { "One", "Two", "Three", "God", "Satan", "Holstebro", "Viborg", "Lemvig", "Struer", "Aarhus" };
            Console.WriteLine("Dictionary med en string Key og en int Value");
            foreach (string value in stringKeyArray)
            {
                Console.WriteLine("Key: {0}\tValue: {1}", value, stringKey[value]);
            }
        }
        static void FloatKey()
        {
            Dictionary<float, Boolean> floatKey = new Dictionary<float, Boolean>();
            floatKey.Add(16, true);
            floatKey.Add(17, true);
            floatKey.Add(18, false);
            floatKey.Add(19, true);
            floatKey.Add(20, true);
            floatKey.Add(11, true);
            floatKey.Add(12, true);
            floatKey.Add(13, false);
            floatKey.Add(14, true);
            floatKey.Add(15, false);
            float[] floatKeyArray = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Dictionary med en float Key og en Boolean Value");
            foreach (float value in floatKeyArray)
            {
                Console.WriteLine("Key: {0}\tValue: {1}", value, floatKey[value]);
            }
        }
        static void ClassKey()
        {
            Dictionary<Person, string> classKey = new Dictionary<Person, string>();
            Person[] personArray =
            {
                new Person("John", 35),
                new Person("Steven", 13),
                new Person("Anne", 19),
                new Person("Jens", 56),
                new Person("Merete", 51)
            };
            classKey[personArray[0]] = "Evil";
            classKey[personArray[1]] = "Young";
            classKey[personArray[2]] = "Woman";
            classKey[personArray[3]] = "Dad";
            classKey[personArray[4]] = "Mom";

            Console.WriteLine("Dictionary med en Person Key og en string Value");
            int i = 0;
            foreach (Person value in personArray)
            {
                Console.WriteLine("Key: Person({0}) Name: {1} \t Age: {2} \t Value: {3}", i, value.name, value.age, classKey[value]);
                i += 1;
            }
        }
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
