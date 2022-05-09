using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasic
{
    public class Book
    {
        private String _bookName;
        private String _bookAuthor;
        private double _price;

        public string BookName { get => _bookName; set => _bookName = value; }
        public string BookAuthor { get => _bookAuthor; set => _bookAuthor = value; }
        public double Price { get => _price; set => _price = value; }

        public Book()
        {
        }


        public Book(string bookName, string bookAuthor, double price)
        {
            BookName = bookName;
            BookAuthor = bookAuthor;
            Price = price;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap Book Name: ");
            _bookName = Console.ReadLine();
            Console.WriteLine("Nhap Book Author: ");
            _bookAuthor = Console.ReadLine();
            Console.WriteLine("Nhap Price: ");
            _price = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.Write("================== DANH SACH BOOK ================== ");
            Console.Write("\n");
            Console.WriteLine("Book Name: {0}",_bookName);
            Console.WriteLine("Book Author: {0}", _bookAuthor);
            Console.WriteLine("Price: {0}", _price);
        }
    }
}
