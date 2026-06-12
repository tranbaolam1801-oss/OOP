using System;

namespace Bai4
{
    class Standard: Room
    {
        public Standard(): base() {}
        public override void Nhap()
        {
            base.Nhap();
        }
        public int Gia()
        {
            if (SoNgayThue <= 5)
                return 500;
            else
                return 400;
        }
        public int TienThuePhong()
        {
            return Gia() * SoNgayThue;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Gia thue phong: {TienThuePhong()}$");
        }
    }
}