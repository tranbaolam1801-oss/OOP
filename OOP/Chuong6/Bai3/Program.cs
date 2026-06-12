using System;
using System.Collections.Generic;

namespace Bai3
{
    class Program
    {
        static void Search(List<Edition> danhSach, string AuThor)
        {

        }
        static void Main(string[] args)
        {
            List<Edition> danhSach = new List<Edition>();
            Console.Write("Nhap so luong an pham: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nChon an pham ban muon them:");
                Console.WriteLine("Nhap 1 de them sach.");
                Console.WriteLine("Nhap 2 de them bao.");
                Console.WriteLine("Nhap 3 de them tai nguyen online.");
                int m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        Book sach = new Book();
                        sach.Nhap();
                        danhSach.Add(sach);
                        break;
                    case 2:
                        Article bao = new Article();
                        bao.Nhap();
                        danhSach.Add(bao);
                        break;
                    case 3:
                        OnlineResoure duongdan = new OnlineResoure();
                        duongdan.Nhap();
                        danhSach.Add(duongdan);
                        break;
                    default:
                        Console.WriteLine("Khong hop le!");
                        continue;
                }
            }
            danhSach.Sort();
            Console.WriteLine("\n---DANH SACH AN PHAM---");
            foreach (var tacpham in danhSach)
            {
                Console.ReadLine();
                tacpham.Xuat();
            }
            Console.Write("\nNhap ten tac gia can tim: ");
            string AuThor = Console.ReadLine();
            foreach (var tacpham in danhSach)
            {
                if (tacpham.author.ToLower() == AuThor.ToLower())
                    tacpham.Xuat();
            }
        }
    }
}