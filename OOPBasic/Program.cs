using System;
using System.Collections.Generic;
using System.IO;

namespace OOPBasic
{
    class Program
    {
        static void Main(string[] args)
        {

            List<AptechBook> aptechBooks = new List<AptechBook>();
            int choice;

            do
            {
                ShowMenu();
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Input(aptechBooks);
                        break;
                    case 2:
                        Display(aptechBooks);
                        break;
                    case 3:
                        Sort(aptechBooks);
                        break;
                    case 4:
                        FindByBookName(aptechBooks);
                        break;
                    case 5:
                        FindByBookAuthor(aptechBooks);
                        break;
                    case 6:
                        SaveToFile(aptechBooks);
                        break;
                    case 7:
                        break;
                    case 8:
                        Console.WriteLine("------ Thoat -----");
                        break;
                    default:
                        Console.WriteLine("Nhap sai yeu cau");
                        break;
                }
            } while (choice !=8);
        }

        static void ShowMenu()
        {
            Console.WriteLine("1.Nhap thong tin n cuon sach cua Aptech : ");
            Console.WriteLine("2.Hien thi thong tin vua nhap");
            Console.WriteLine("3.Sap xep thong tin giam dan theo nam xuat ban va hien thi");
            Console.WriteLine("4.Tim kiem theo ten sach: ");
            Console.WriteLine("5.Tim kiem theo ten tac gia : ");
            Console.WriteLine("6.Luu thong tin sach da nhap vao file");
            Console.WriteLine("7.Doc noi dung tu file va luu vao mang quan ly sach");
            Console.WriteLine("8.Thoat chuong trinh");
            Console.WriteLine("--Lua chon cua ban: ");
        }

        static void Input(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("Nhap so luong sach can them: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                AptechBook books = new AptechBook();
                books.Input();
                aptechBooks.Add(books);
            }
        }

        static void Display(List<AptechBook> aptechBooks)
        {
            for (int i = 0; i < aptechBooks.Count; i++)
            {
                aptechBooks[i].Display();
            }
        }

        static void Sort(List<AptechBook> aptechBooks)
        {
            if (aptechBooks.Count == 0)
            {
                Console.WriteLine("Khong co du lieu");
            }
            aptechBooks.Sort((x, y) => x.Year.CompareTo(y.Year));
            Display(aptechBooks);
        }
        static void FindByBookName(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("Nhap ten sach can tim: ");
            string search = Console.ReadLine();

            for (int i = 0; i < aptechBooks.Count; i++)
            {
                if (aptechBooks[i].BookName.Equals(search))
                {
                    aptechBooks[i].Display();
                } 
                else
                {
                    Console.WriteLine("khong co du lieu");
                }
            }
        }
        static void FindByBookAuthor(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("Nhap ten sach can tim: ");
            string search = Console.ReadLine();

            for (int i = 0; i < aptechBooks.Count; i++)
            {
                if (aptechBooks[i].BookAuthor.Equals(search))
                {
                    aptechBooks[i].Display();
                }
                else
                {
                    Console.WriteLine("khong co du lieu");
                }
            }
        }
        
        static void SaveToFile(List<AptechBook> aptechBooks)
        {
            //using (Stream filepath = File.Open(@"Book.dat", FileMode.Create))
            //{
            //    var format1 = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            //    format1.Serialize(filepath, aptechBooks);
            //}
            //Console.WriteLine("Thanh cong !!!");
        }
    }
}
