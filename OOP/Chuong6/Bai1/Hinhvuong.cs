using System;

namespace Bai1
{
    class Hinhvuong: Hinhhoc
    {
        public double canh;
        public Hinhvuong()
        {
            this.canh = 0;
        }
        ~Hinhvuong()
        {
            Console.Write("Huy hinh vuong.");
        }
        public override void Nhap()
        {
            Console.Write("Nhap canh hinh vuong: ");
            canh = double.Parse(Console.ReadLine());
        }
        public override double TinhChuVi()
        {
            return canh * 4;
        }
        public override double TinhDienTich()
        {
            return canh * canh;
        }
        public override void Xuat()
        {
            Console.WriteLine("Hinh vuong ");
            base.Xuat();
        }
    }
}