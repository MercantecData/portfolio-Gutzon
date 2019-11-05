using System;

namespace OOP_Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Book book = new Book("test");
            book.ReturnBook();
            Inetialize index = new Inetialize();
            Library library = new Library("0001","OOP Bibliotek");
            


        }
    }
}
