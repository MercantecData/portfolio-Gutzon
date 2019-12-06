using System;
using Access_Modifiers_DLL;

namespace Access_Modifiers_Test
{
    class Program
    {
        internal static Reg reg = new Reg();
        static void Main(string[] args)
        {
            AddPeople();
            AddBikes();
            SetOwners();
            Console.WriteLine(reg.GetPersonList());
            reg.SetOwner(2, 1);
            Console.WriteLine(reg.GetBikeList());
            reg.RemovePerson(1);
            Console.WriteLine(reg.GetBikeList());
            Console.WriteLine(reg.GetPersonList());
            Console.WriteLine(reg.GetBikeListOwnedBy(0));
        }
        static void AddPeople()
        {
            reg.AddPerson("Kim", 18);
            reg.AddPerson("Robin", 27);
            reg.AddPerson("Adolf", 45);
            reg.AddPerson("Anna", 23);
            reg.AddPerson("Erik", 20);

        }
        static void AddBikes()
        {
            reg.AddBike("Mustang", "1");
            reg.AddBike("Puch", "12");
            reg.AddBike("Puch", "3");
            reg.AddBike("Mustang", "14");
            reg.AddBike("Mount", "5");
            reg.AddBike("Puch", "16");
            reg.AddBike("Mount", "7");
            reg.AddBike("Mustang", "18");
            reg.AddBike("Mount", "9");
            reg.AddBike("Mount", "10");
            reg.AddBike("Puch", "2");

        }
        static void SetOwners()
        {
            reg.SetOwner(0, 0);
            reg.SetOwner(2, 2);
            reg.SetOwner(3, 2);
            reg.SetOwner(4, 4);
            reg.SetOwner(6, 2);
            reg.SetOwner(7, 4);
            reg.SetOwner(8, 0);
            reg.SetOwner(9, 4);

        }

    }
}
