using System;

namespace Bai1
{
    class Hinhtron: Hinhhoc
    {
        public double Bankinh;
        public Hinhtron()
        {
            this.Bankinh = 0;
        }
        ~Hinhtron()
        {
            Console.WriteLine("Huy hinh tron.");
        }
        public override void Nhap()
        {
            Console.Write("Nhap ban kinh: ");
            Bankinh = double.Parse(Console.ReadLine());
        }
        public override double TinhChuVi()
        {
            return 2 * Bankinh * Math.PI;
        }
        public override double TinhDienTich()
        {
            return Math.PI * Bankinh * Bankinh;
        }
        public override void Xuat()
        {
            Console.WriteLine("\nHinh tron ");
            base.Xuat();
        }
    }
}