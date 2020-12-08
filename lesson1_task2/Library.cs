using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lesson1_task2
{
    class Library
    {
        Book book = null;
        void InitializeBook()
        {
            this.book = new Book();
        }

        public Library()
        {
            InitializeBook();
            book.Author = "noAuthor";
            book.BookName = "noName";
        }

        public Library(string author, string bookName) 
        {
            InitializeBook();
            book.Author = author;
            book.BookName = bookName;
        }

        public void ExistingBook()
        {
            Console.WriteLine("Book is created. Author is {0} and its name is {1}", book.Author, book.BookName);
        }
    }
}
