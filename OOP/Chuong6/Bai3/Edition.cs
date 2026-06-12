using System;

namespace Bai3
{
    abstract class Edition:IComparable<Edition>
    {
        public string title {get; set;}
        public string author {get; set;}
        public int year {get; set;}
        public Edition()
        {
            this.title = "";
            this.author = "";
            this.year = 0;
        }
        ~Edition()
        {
            Console.WriteLine("Huy Edition.");
        }
        public virtual void Nhap()
        {
            Console.WriteLine("\nNhap thong tin an pham: ");
            Console.Write("Nhap tieu de: ");
            title = Console.ReadLine();
            Console.Write("Nhap ten tac gia: ");
            author = Console.ReadLine();
            Console.Write("Nhap nam xuat ban: ");
            year = int.Parse(Console.ReadLine());
        }
        public int CompareTo(Edition other)
        {
            return this.author.CompareTo(other.author);
        }
        public abstract void Xuat();
    }
}