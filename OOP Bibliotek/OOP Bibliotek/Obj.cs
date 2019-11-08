using System;
using System.Collections.Generic;

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
        public Boolean ReturnBookById(string id)
        {
            int i = 0;
            Boolean succes = false;
            while (i < books.Count)
            {
                if (books[i].id == id )
                {
                    books[i].ReturnBook();
                    i = books.Count;
                    succes = true;
                }
            }
            return succes;
        }
        public string ReturnBookByTitle(string title)
        {
            int i = 0;
            string returnMessage = "";
            while (i < books.Count)
            {
                if (books[i].title == title)
                {
                    books[i].ReturnBook();
                    i = books.Count;
                    returnMessage = "Bogen: "+title+" Blev afleveret";
                }
                else
                {
                    returnMessage = "Kunne ikke finde en bog med navnet: "+title;
                }
                i += 1;
            }
            return returnMessage;
        }
        public string CheckStatusOnBookByTitle(string name)
        {
            int i = 0;
            string returnMessage = "";
            while (i < books.Count)
            {
                if (books[i].title == name)
                {
                    if (books[i].returnDate.Year == 1)
                    {
                        books[i].ReturnBook();
                        returnMessage = "Bogen: " + name + " Er Hjemme";
                    }
                    else
                    {
                        returnMessage = "Bogen: " + name + " Er udlånt indtil: " + books[i].returnDate.Day +"/"+ books[i].returnDate.Month +"-"+ books[i].returnDate.Year;
                    }
                    i = books.Count;
                }
                else
                {
                    returnMessage = "Kunne ikke finde en bog med navnet: " + name;
                }
                i += 1;
            }
            return returnMessage;
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

