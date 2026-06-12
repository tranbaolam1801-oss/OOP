using System;

namespace Bai3
{
    class Article: Edition
    {
        public string journal {get; set;}
        public Article(): base()
        {
            this.journal = "";
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ten tap chi: ");
            journal = Console.ReadLine();
        }
        public override void Xuat()
        {
            Console.WriteLine($"Bai bao: {title}, tac gia: {author}, tap chi: {journal}, nam xuat ban: {year}");
        }
    }
}