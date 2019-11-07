using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("OOP Cykel Forhandler");
            Owner owner = new Owner(shop);
            Console.WriteLine(owner.CountAmountBikesBasedOnColor("Rød"));
            foreach (string value in shop.GetAllManifactorNames())
            {
                Console.WriteLine(value + ", ");
            }
        }
    }
}
