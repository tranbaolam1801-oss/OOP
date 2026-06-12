using System;

namespace Bai1
{
    abstract class Hinhhoc
    {
        public abstract double TinhChuVi();
        public abstract double TinhDienTich();
        public abstract void Nhap();
        public virtual void Xuat()
        {
            Console.WriteLine($"Co chu vi la: {TinhChuVi():F2}, dien tich la: {TinhDienTich():F2}");
        }
    }
}