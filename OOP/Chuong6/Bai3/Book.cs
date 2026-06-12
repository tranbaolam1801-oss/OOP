using System;

namespace Bai3
{
    class Book: Edition
    {
        public string publisher {get; set;}
        public Book(): base()
        {
            this.publisher = "";
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap nha xuat ban: ");
            publisher = Console.ReadLine();
        }
        public override void Xuat()
        {
            Console.WriteLine($"Sach: {title}, tac gia: {author}, nam xuat ban: {year}, nha xuat ban: {publisher}");
        }

    }
}