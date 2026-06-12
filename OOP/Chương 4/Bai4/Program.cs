using System;

class Info
{
    string ID;
    string Hoten;
    string Group;
    public string MSV
    {
        get { return ID; }
        set { ID = value; }
    }
    public string ten
    {
        get { return Hoten; }
        set { Hoten = value; }
    }
    public string lop
    {
        get { return Group; }
        set { Group = value; }
    }
    public Info()
    {
        ID = "";
        Hoten = "";
        Group = "";
    }
    public void Nhap()
    {
        Console.Write("Nhap ma sinh vien: ");
        ID = Console.ReadLine();
        Console.Write("Nhap ho ten sinh vien: ");
        ten = Console.ReadLine();
        Console.Write("Nhap lop sinh hoat: ");
        lop = Console.ReadLine();
    }
}
class DiemTP
{
    double TP1;
    double TP2;
    double TP3;
    public double tp1
    {
        get { return TP1; }
        set { TP1 = value; }
    }
    public double tp2
    {
        get { return TP2; }
        set { TP2 = value; }
    }
    public double tp3
    {
        get { return TP3; }
        set { TP3 = value; }
    }
    public DiemTP()
    {
        TP1 = TP2 = TP3 = 0;
    }
    public void Nhap()
    {
        Console.Write("Nhap diem thanh phan 1: ");
        tp1 = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem thanh phan 2: ");
        tp2 = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem thanh phan 3: ");
        tp3 = double.Parse(Console.ReadLine());
    }
    public double DiemTB()
    {
        return tp1 * 0.1 + tp2 * 0.3 + tp3 * 0.6;
    }
}
class Sinhvien
{
    public Info Thongtin;
    public DiemTP Diem;
    static int SoluongSV = 0;
    public Sinhvien()
    {
        Thongtin = new Info();
        Diem = new DiemTP();
        SoluongSV++;
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap thong tin sinh vien: ");
        Thongtin.Nhap();
        Console.WriteLine("Nhap diem thanh phan cua sinh vien: ");
        Diem.Nhap();
    }
    public void Xuat()
    {
        Console.WriteLine($"Sinh vien: {Thongtin.ten}");
        Console.WriteLine($"Ma sinh vien: {Thongtin.MSV}");
        Console.WriteLine($"Lop sinh hoat: {Thongtin.lop}");
        Console.WriteLine($"Diem trung binh mon OOP: {Diem.DiemTB()}");
    }
    public static int dem()
    {
        return SoluongSV;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Sinhvien sv1 = new Sinhvien();
        sv1.Nhap();
        Sinhvien sv2 = new Sinhvien();
        sv2.Nhap();
        Sinhvien sv3 = new Sinhvien();
        sv3.Nhap();
        Console.WriteLine($"So luong sinh vien la: {Sinhvien.dem()}");
        Console.WriteLine("---THONG TIN SINH VIEN---");
        sv1.Xuat();
        Console.WriteLine();
        sv2.Xuat();
        Console.WriteLine();
        sv3.Xuat();
    }
}