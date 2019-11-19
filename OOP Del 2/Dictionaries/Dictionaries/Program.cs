using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string space = "──────────────────────────────────────────────────────────";
            StringKey();
            Console.WriteLine(space);
            FloatKey();

        }
        static void StringKey()
        {
            Dictionary<string, int> stringKey = new Dictionary<string, int>() { { "Holstebro", 7500 }, { "Aarhus", 8100 }, { "Viborg", 8800 }, { "Lemvig", 7620 }, { "Struer", 7600 }, { "One", 1 }, { "Satan",666 }, { "Two", 2 }, {"God", 777 }, { "Three", 3 } };
            string[] stringKeyArray = { "One", "Two", "Three", "God", "Satan", "Holstebro", "Viborg", "Lemvig", "Struer", "Aarhus" };
            Console.WriteLine("Dictionary med en string Key og en Int Value");
            foreach (string value in stringKeyArray)
            {
                Console.WriteLine("Key: {0}\tValue: {1}", value, stringKey[value]);
            }
        }
        static void FloatKey()
        {

        }
    }
}
