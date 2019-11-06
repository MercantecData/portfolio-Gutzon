using System;

namespace OOP_Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Library library = new Library("0001", "OOP Bibliotek");
            int input = 0;
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
                        Console.WriteLine(library.books[0].returnDate);
                        BorrowBook();
                        break;
                    case 2:
                        Console.Clear();

                        library.books[library.books.FindIndex()].ReturnBook();
                        break;
                    case 3:
                        ExtendTime();
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
        static void BorrowBook()
        {
            
        }
        static void ReturnBook()
        {

        }
        static void ExtendTime()
        {

        }
    }
}
