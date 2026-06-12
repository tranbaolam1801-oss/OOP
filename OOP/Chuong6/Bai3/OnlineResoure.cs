using System;

namespace Bai3
{
    class OnlineResoure: Edition
    {
        public string link {get; set;}
        public string Abstract {get; set;}
        public OnlineResoure(): base()
        {
            this.link = this.Abstract = "";
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap duong dan (URL) den tai nguyen: ");
            link = Console.ReadLine();
            Console.Write("Nhap noi dung tom tat: ");
            Abstract = Console.ReadLine();
        }
        public override void Xuat()
        {
            Console.WriteLine($"Tac pham: {title}, tac gia: {author}, duong dan: {link}, noi dung: {Abstract}, nam xuat ban: {year}");
        }
    }
}