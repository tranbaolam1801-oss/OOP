using System;

namespace Bai1
{
    class Hinhtamgiac: Hinhhoc
    {
        public double a, b, c;
        public Hinhtamgiac()
        {
            this.a = this.b = this.c = 0;
        }
        ~Hinhtamgiac()
        {
            Console.WriteLine("Huy hinh tam giac.");
        }
        public override void Nhap()
        {
            Console.Write("Nhap canh a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            c = double.Parse(Console.ReadLine());
        }
        public override double TinhChuVi()
        {
            return a + b + c;
        }
        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override void Xuat()
        {
            Console.WriteLine("Hinh tam giac ");
            base.Xuat();
        }
    }
}