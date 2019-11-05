using System;

namespace OOP_Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("0001", "OOP Bibliotek");
            int input = 10;
            while (input < 1 || input > 3)
            {
                WriteOptions();
                while (Int32.TryParse(Console.ReadLine(), out input) != true)
                {
                    WriteOptions();
                }
                switch (input)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    default:

                        break;
                }
            }
            


        }
        static void WriteOptions()
        {
            Console.Clear();
            Console.WriteLine("1 - Lån en bog");
            Console.WriteLine("2 - Aflevere en bog");
            Console.WriteLine("3 - Forlæng udlånings tiden");
        }
    }
}
