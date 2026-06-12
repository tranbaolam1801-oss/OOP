using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---HINH CHU NHAT---");
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.Nhap();
            hcn.Xuat();
            Console.WriteLine("\n---HINH TRON---");
            Hinhtron ht = new Hinhtron();
            ht.Nhap();
            ht.Xuat();
            Console.WriteLine("\n---HINH TAM GIAC---");
            Hinhtamgiac tg = new Hinhtamgiac();
            tg.Nhap();
            tg.Xuat();
            Console.WriteLine("\n---HINH VUONG---");
            Hinhvuong hv = new Hinhvuong();
            hv.Nhap();
            hv.Xuat();
        }
    }
}