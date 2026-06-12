using System;
using System.Collections.Generic;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> dsPhong = new List<Room>();
            List<Standard> dsPhongStandard = new List<Standard>();
            List<VIP> dsPhongVip = new List<VIP>();
            int chon;
            do 
            {
                Console.WriteLine("\n---MENU---");
                Console.WriteLine("Chon 0 de thoat chuong trinh");
                Console.WriteLine("chon 1 de nhap thong tin thue phong");
                Console.WriteLine("Chon 2 de xuat thong tin thue phong.");
                Console.WriteLine("Chon 3 de tinh so tien cho thue phong Standard va phong VIP");
                Console.WriteLine("Chon 4 de xuat thong tin thue phong Standard");
                Console.WriteLine("chon 5 de tinh tong so tien cho thue phong Luxury");
                Console.Write("\nNhap lua chon cua ban: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 0: 
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    case 1:
                        Console.Write("\nPhong muon thue: ");
                        string Kieuphong = Console.ReadLine();
                        if (Kieuphong == "Standard")
                        {
                            Standard phongTieuChuan = new Standard();
                            phongTieuChuan.Nhap();
                            dsPhong.Add(phongTieuChuan);
                            dsPhongStandard.Add(phongTieuChuan);
                        }
                        else if (Kieuphong == "VIP")
                        {
                            VIP phongVip = new VIP();
                            phongVip.Nhap();
                            dsPhong.Add(phongVip);
                            dsPhongVip.Add(phongVip);
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n---DANH SACH THONG TIN THUE PHONG---");
                        foreach (var phong in dsPhong)
                        {
                            phong.Xuat();
                        }
                        break;
                    case 3:
                        int TienThuePhongStandard = 0;
                        int TienThuePhongVip = 0;
                        foreach (var phong in dsPhongStandard)
                        {
                            TienThuePhongStandard += phong.TienThuePhong();
                        }
                        foreach (var phong in dsPhongVip)
                        {
                            TienThuePhongVip += phong.TienThuePhong();
                        }
                        Console.WriteLine("\n---TONG SO TIEN CHO THUE PHONG---");
                        Console.WriteLine($"Tong so tien cho thue phong Standard: {TienThuePhongStandard}$");
                        Console.WriteLine($"Tong so tien cho thue phong VIP: {TienThuePhongVip}$");
                        break;
                    case 4:
                        Console.WriteLine("\n---THONG TIN THUE PHONG STANDARD---");
                        foreach (var phong in dsPhongStandard)
                        {
                            phong.Xuat();
                        }
                        break;
                    case 5:
                        int TongLuxyry = 0;
                        foreach (var phong in dsPhongVip)
                        {
                            if (phong.LoaiPhong == "Luxury")
                                TongLuxyry += phong.TienThuePhong();
                        }
                        Console.WriteLine($"Tong so tien cho thue phong Luxury: {TongLuxyry}$");
                        break;
                    default :
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai!");
                        break;
                }
            } while (chon != 0);
        }
    }
}