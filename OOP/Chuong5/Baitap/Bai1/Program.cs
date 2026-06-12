using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle hinhtron = new Circle(3);
            // Console.Write("Nhap ban kinh: ");
            // double bankinh = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nDien tich hinh tron la: {hinhtron.DienTich}");
            HinhCau hinhcau = new HinhCau(3);
            Console.WriteLine($"\nDien tich hinh cau la: {hinhcau.DienTich}");
            Console.WriteLine($"\nThe tich hinh cau la: {hinhcau.TheTich}");
            HinhTruTron hinhtru = new HinhTruTron(3, 5);
            // Console.Write("\nNhap chieu cao hinh tru: ");
            // double chieucao = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nChu vi mat day la: {hinhtru.ChuViDay}");
            Console.WriteLine($"\nDien tich mat day la: {hinhtru.DienTichDay}");
            Console.WriteLine($"\nDien tich xung quanh la: {hinhtru.DienTichXQ}");
            Console.WriteLine($"\nDien tich toan phan la: {hinhtru.DienTichTP}");
            Console.WriteLine($"\nThe tich la: {hinhtru.TheTich}");
        }
    }
}