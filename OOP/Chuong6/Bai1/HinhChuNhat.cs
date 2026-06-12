using System;

namespace Bai1
{
    class HinhChuNhat: Hinhhoc
    {
        public double Dai, Rong;
        public HinhChuNhat()
        {
            this.Dai = this.Rong = 0;
        }
        ~HinhChuNhat()
        {
            Console.WriteLine("Huy hinh chu nhat.");
        }
        public override void Nhap()
        {
            Console.Write("Nhap chieu dai: ");
            Dai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            Rong = double.Parse(Console.ReadLine());
        }
        public override double TinhChuVi()
        {
            return (Dai + Rong) *2;
        }
        public override double TinhDienTich()
        {
            return Dai * Rong;
        }
        public override void Xuat()
        {
            Console.Write("\nHinh chu nhat ");
            base.Xuat();
        }
    }
}