using System;
using System.Collections.Generic;
using System.Data;

class Organization
{
    public string Name;
    public string Country;
    public string City;
    public string Address;
    public string Telephone;
    public Organization()
    {
        Name = "";
        Country = "";
        City = "";
        Address = "";
        Telephone = "";
    }
    public Organization(string name, string country, string city, string address, string telephone)
    {
        Name = name;
        Country = country;
        City = city;
        Address = address;
        Telephone = telephone;
    }
    ~Organization()
    {
        Console.WriteLine($"Huy {Name}");
    }
    public void Nhap()
    {
        Console.Write("\nNhap ten doanh nghiep: ");
        Name = Console.ReadLine();
        Console.Write("Nhap quoc gia: ");
        Country = Console.ReadLine();
        Console.Write("Nhap thanh pho: ");
        City = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        Address = Console.ReadLine();
        Console.Write("Nhap so dien thoai: ");
        Telephone = Console.ReadLine();
    }
    public void Xuat()
    {
        Console.WriteLine("/N---THONG TIN DOANH NGHIEP---");
        Console.WriteLine($"Doanh nghiep : {Name}");
        Console.WriteLine($"Quoc gia: {Country}");
        Console.WriteLine($"Thanh pho: {City}");
        Console.WriteLine($"Dia chi: {Address}");
        Console.WriteLine($"So dien thoai: {Telephone}");
    }
    public bool KT()
    {
        if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Country) || string.IsNullOrWhiteSpace(City) || string.IsNullOrWhiteSpace(Address))
            return false;
        if (Telephone.Length != 10 || string.IsNullOrWhiteSpace(Telephone))
            return false;
        foreach (char i in Telephone)
        {
            if (!char.IsDigit(i))
                return false;
        }
        return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Organization dn = new Organization();
        while (true)
        {
            dn.Nhap();
            if (dn.KT() == false)
            {
                Console.WriteLine($"Thong tin loi!");
                break;
            }
            dn.Xuat();
        }
    }
}
