using System;
using System.Collections.Generic;

class Doanhnghiep
{
    string TenDN;
    string MST;
    string Diachi;
    public string tendn
    {
        get { return TenDN; }
        set { TenDN = value; }
    }
    public string masothue
    {
        get { return MST; }
        set { MST = value; }
    }
    public string diachi
    {
        get { return Diachi; }
        set { Diachi = value; }
    }
    public Doanhnghiep()
    {
        TenDN = "";
        MST = "";
        Diachi = "";
    }
    ~Doanhnghiep()
    {
        Console.WriteLine($"Huy doanh nghiep {TenDN}");
    }
    public void Nhap()
    {
        Console.Write("Nhap ten doanh nghiep: ");
        tendn = Console.ReadLine();
        Console.Write("Nhap ma so thue: ");
        masothue = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        diachi = Console.ReadLine();
    }
}