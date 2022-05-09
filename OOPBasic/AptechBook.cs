using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasic
{
    public class AptechBook : Book
    {
        private string _language;
        private int _year;

        public string Language { get => _language; set => _language = value; }
        public int Year { get => _year; set => _year = value; }

        public AptechBook(string bookName, string bookAuthor, double price, string language, int year) : base(bookName, bookAuthor, price)
        {
            _language = language;
            _year = year;
        }

        public AptechBook(): base()
        {

        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Language: ");
            _language = Console.ReadLine();
            Console.WriteLine("Nhap Year: ");
            _year = Convert.ToInt32(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Language: {0}", _language);
            Console.WriteLine("Year: {0}", _year);
        }
    }
}
