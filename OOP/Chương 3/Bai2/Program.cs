using System;
using System.Collections.Generic;

class Meo
{
    public string Ten;
    public string Giong;
    public string Gioitinh;
    public int Tuoi;
    static int SoluongMeo = 0;
    public Meo()
    {
        Ten = "";
        Giong = "";
        Gioitinh = "";
        Tuoi = 0;
        SoluongMeo++;
    }
    public Meo(string ten, string giong, string gioitinh, int tuoi)
    {
        Ten = ten;
        Giong = giong;
        Gioitinh = gioitinh;
        Tuoi = tuoi;
        SoluongMeo++;
    }
    ~Meo()
    {
        Console.WriteLine($"Huy meo {Ten}");
    }
    public void Nhap()
    {
        Console.Write("Nhap ten meo: ");
        Ten = Console.ReadLine();
        Console.Write("Nhap giong meo: ");
        Giong = Console.ReadLine();
        Console.Write("Nhap gioi tinh: ");
        Gioitinh = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        Tuoi = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"\nTen: {Ten}");
        Console.WriteLine($"Giong: {Giong}");
        Console.WriteLine($"Gioi tinh: {Gioitinh}");
        Console.WriteLine($"Tuoi: {Tuoi}");
    }
    public static int Dem()
    {
        return SoluongMeo;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Meo m1 = new Meo();
        m1.Nhap();
        Console.WriteLine();
        Meo m2 = new Meo("ki", "Tam the", "Cai", 3);
        Console.WriteLine();
        Meo m3 = new Meo();
        m3.Nhap();
        Console.WriteLine("\n---DANH SACH MEO---");
        m1.Xuat();
        m2.Xuat();
        m3.Xuat();
        Console.WriteLine($"\nSo luong meo co trong danh sach la: {Meo.Dem()}");
    }
}
