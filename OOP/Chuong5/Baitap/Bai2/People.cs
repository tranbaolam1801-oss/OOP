using System;

namespace Bai2
{
    class People
    {
        public string ID {get; set;}
        public string Hoten {get; set;}
        public int Tuoi {get; set;}
        public string Diachi {get; set;}
        public People()
        {
            this.ID = "";
            this.Hoten = "";
            this.Tuoi = 0;
            this.Diachi = "";
        }
        ~People()
        {
            Console.WriteLine($"Ham huy people da duoc goi.");
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma so: ");
            ID = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            Diachi = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"\nMa so: {ID}");
            Console.WriteLine($"Ho ten: {Hoten}");
            Console.WriteLine($"Tuoi: {Tuoi}");
            Console.WriteLine($"Dia chi: {Diachi}");
        }
    }
}