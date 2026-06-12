using System;

namespace Bai4
{
    class VIP: Room
    {
        public string LoaiPhong {get; set;}
        public VIP(): base()
        {
            LoaiPhong = "";
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap loai phong: ");
            LoaiPhong = Console.ReadLine();
        }
        public int Gia()
        {
            if (SoNgayThue <= 5)
            {
                if (LoaiPhong == "Luxury")
                    return 1100;
                else
                    return 1300;
            }
            else
                return 1000;
        }
        public int TienThuePhong()
        {
            return Gia() * SoNgayThue;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loai phong: {LoaiPhong}");
            Console.WriteLine($"Gia thue phong: {TienThuePhong()}$");
        }
    }
}