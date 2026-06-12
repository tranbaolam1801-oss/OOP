using System;

namespace Bai4
{
    class Room
    {
        public string Ten_KH {get; set;}
        public string CMND {get; set;}
        public int SoNgayThue {get; set;}
        public Room()
        {
            Ten_KH = "";
            CMND = "";
            SoNgayThue = 0;
        }
        ~Room()
        {
            Console.WriteLine("Huy phong!");
        }
        public virtual void Nhap()
        {
            Console.WriteLine("\nNhap thong tin khach hang:");
            Console.Write("Nhap ten khach hang: ");
            Ten_KH = Console.ReadLine();
            Console.Write("Nhap so CMND: ");
            CMND = Console.ReadLine();
            Console.Write("Nhap so ngay thue: ");
            SoNgayThue = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"\nTen khach hang: {Ten_KH}");
            Console.WriteLine($"So CMND: {CMND}");
            Console.WriteLine($"So ngay thue: {SoNgayThue}");
        }
    }
}