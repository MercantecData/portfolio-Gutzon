using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bibliotek
{
    class Book
    {
        public string id;
        public string title;
        public DateTime returnDate;


        public Boolean BorrowBook(DateTime returnDate)
        {
            if (this.returnDate.Year == 1)
            {
                this.returnDate = returnDate;
                Console.WriteLine("Bogen \"" + this.title + "\" er udlånt indtil: " + returnDate);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean ReturnBook()
        {
            this.returnDate = new DateTime(1, 1, 1);
            Console.WriteLine(this.returnDate);
            return true;
        }
        public Book(string title)
        {
            this.title = title;
        }

        public Book(string id, string title, DateTime returnDate)
        {
            this.id = id;
            this.title = title;
            this.returnDate = returnDate;
        }
    }



    class Library
    {
        string path = @"C:\Users\keg\Desktop\Github\portfolio-Gutzon\OOP Bibliotek\OOP Bibliotek\Data\";
        public string id;
        public string name;
        public List<Book> books = new List<Book>();

        public Boolean SaveBooksList()
        {
            return true;
        }

        public Library(string id, string name)
        {
            this.id = id;
            this.name = name;
            string[] array = System.IO.File.ReadAllLines(path + id + " Books.txt");
            foreach (String value in array)
            {
                String[] spearator = { "$-T$", "$-D$" };
                String[] strlist = value.Split(spearator, 3,
                StringSplitOptions.RemoveEmptyEntries);
                Book test2 = new Book(strlist[0], strlist[1], Convert.ToDateTime(strlist[2]));
                books.Add(test2);
            }
            
        }
    }
    /*class Inetialize
    {
        string path = @"C:\Users\keg\Desktop\Github\portfolio-Gutzon\OOP Bibliotek\OOP Bibliotek\Data\";
        private List<Library> libraries;

        public List<Library> LoadLibrary()
        {
            string[] array = System.IO.File.ReadAllLines(path + " Libraries.txt");
            foreach (string element in array)
            {

            }
        }
    }*/

}

