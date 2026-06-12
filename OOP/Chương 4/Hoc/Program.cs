// using System;

// class HCN
// {
//     double Dai;
//     double Rong;
//     public HCN(double dai, double rong)
//     {
//         Dai = dai;
//         Rong = rong;
//     }
//     public double dai
//     {
//         get { return Dai; }
//         set { Dai = dai; }
//     }
//     public double rong
//     {
//         get { return Rong; }
//         set { Rong = rong; }
//     }

//     // public double getDai()
//     // {
//     //     return Dai;
//     // }
//     // public void setDai(double D)
//     // {
//     //     Dai = D;
//     // }
//     // public double getRong()
//     // {
//     //     return Rong;
//     // }
//     // public void setRong(double R)
//     // {
//     //     Rong = R;
//     // }
//     // double Tinh()
//     // {
//     //     return Dai * Rong;
//     // }
//     public void Xuat()
//     {
//         Console.WriteLine("Dien tich hinh chu nhat la: " + Dai * Rong);
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         HCN h = new HCN(10, 7);
//         h.dai = 15;
//         h.rong = 3;

//         // h.Xuat();
//         Console.WriteLine($"Dien tich hinh chu nhat la: {h.Tinh()}");
//     }
// }

// Nap tien (sotien) vao tk
//Rut tien (ruttien) tien ra tk
//Hien thi thong tin tk nh theo thoi gian thuc
// using System;
// class NGANHANG
// {
//     private string STK;
//     private double Sodu;
//     public NGANHANG()
//     { }
//     public string stk
//     {
//         get { return STK; }
//         set { STK = value; }
//     }
//     public double soDu
//     {
//         get { return Sodu; }
//         set { Sodu = value; }
//     }
//     public NGANHANG(string stk, double sodu)
//     {
//         STK = stk;
//         Sodu = sodu;
//     }
//     public void Naptien()
//     {
//         Console.Write("Nhap so tien can nap: ");
//         double naptien = double.Parse(Console.ReadLine());
//         Sodu += naptien;
//     }
//     public void Ruttien()
//     {
//         Console.Write("Nhap so tien can nap: ");
//         double ruttien = double.Parse(Console.ReadLine());
//         Sodu -= ruttien;
//     }
//     public double sodu
//     {
//         get { return Sodu; }
//         set { sodu = Sodu; }
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         // NGANHANG n1 = new NGANHANG("1234567", 0);
//         NGANHANG n1 = new NGANHANG();
//         Console.Write("Nhap STK cua ban: ");
//         n1.stk = Console.ReadLine();
//         Console.Write("Nhap so du hien tai: ");
//         n1.soDu = double.Parse(Console.ReadLine());
//         n1.Naptien();
//         n1.Ruttien();
//         Console.WriteLine($"So tai khoan hien tai la: {n1.stk}");
//         Console.WriteLine($"So du hien tai la: {n1.sodu}");
//     }
// }
//Viet chuong trinh dung lop VPP
/* Thuoc tinh: tensp, soluong, giaban 1 don vi
Phuong thuc: hoa don ban hang (tinh tong hoa don khi mua cac san pham khac nhau)*/
// class Banhang
// {
//     string Tensp;
//     int Soluong;
//     double Giaban;
//     public string tensp
//     {
//         set { Tensp = value; }
//         get { return Tensp; }
//     }
//     public int soluong
//     {
//         set { Soluong = value; }
//         get { return Soluong; }
//     }
//     public double giaban
//     {
//         set { Giaban = value; }
//         get { return Giaban; }
//     }
//     public Banhang()
//     { }
//     public double TinhGiaSP()
//     {
//         return Soluong * Giaban;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Banhang but = new Banhang();
//         but.tensp = "but bi thien long";
//         but.soluong = 10;
//         but.giaban = 1500;
//         Banhang vo = new Banhang();
//         vo.tensp = "vo hong ha";
//         vo.soluong = 5;
//         vo.giaban = 7000;
//         double Tongtien = but.TinhGiaSP() + vo.TinhGiaSP();
//         Console.WriteLine($"Hoa don mua gom {but.soluong} {but.tensp} co gia {but.TinhGiaSP()}, {vo.soluong} {vo.tensp} co gia {vo.TinhGiaSP()}, co tong hoa don la {Tongtien}");
//     }
// }


using System;
using System.Collections.Generic;

class NhaphocTKTH
{
    public string Hoten;
    public string Gioitinh;
    public string Chuyennganh;
    public NhaphocTKTH()
    {
        Hoten = "";
        Gioitinh = "";
        Chuyennganh = "";
    }
    public NhaphocTKTH(string Hoten, string Gioitinh, string Chuyennganh)
    {
        this.Hoten = Hoten;
        this.Gioitinh = Gioitinh;
        this.Chuyennganh = Chuyennganh;
    }
    public void Nhap()
    {
        Console.Write("Nhap ho ten sinh vien: ");
        Hoten = Console.ReadLine();
        Console.Write("Nhap gioi tinh: ");
        Gioitinh = Console.ReadLine();
        Console.Write("Nhap chuyen nganh: ");
        Chuyennganh = Console.ReadLine();
    }
    public void Xuat()
    {
        Console.WriteLine($"Sinh vien: {Hoten}");
        Console.WriteLine($"Gioi tinh: {Gioitinh}");
        Console.WriteLine($"Chuyen nganh: {Chuyennganh}");
    }
}
class Khoa
{
    List<NhaphocTKTH> dsSinhVien = new List<NhaphocTKTH>();
    List<NhaphocTKTH> K05 = new List<NhaphocTKTH>();
    List<NhaphocTKTH> K14 = new List<NhaphocTKTH>();
    List<NhaphocTKTH> K21 = new List<NhaphocTKTH>();
    List<NhaphocTKTH> K36 = new List<NhaphocTKTH>();
    public Khoa()
    {
        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());
        for (int j = 0; j < n; j++)
        {
            NhaphocTKTH sv = new NhaphocTKTH();
            sv.Nhap();
            dsSinhVien.Add(sv);
        }
    //     NhaphocTKTH sv1 = new("Nguyen Dang An", "Nam", "K14");
    }
    public void LocSV()
    {
        foreach (var x in dsSinhVien)
        {
            if (x.Chuyennganh == "K05")
            {
                K05.Add(x);
            }
            if (x.Chuyennganh == "K36")
            {
                K36.Add(x);
            }
            if (x.Chuyennganh == "K21")
            {
                K21.Add(x);
            }
            if (x.Chuyennganh == "K14")
            {
                K14.Add(x);
            }
        }
        Console.WriteLine("Danh sach sinh vien K05: ");
        foreach (var x in K05)
        {
            x.Xuat();
        }
        Console.WriteLine($"So luong: {K05.Count}");
        Console.WriteLine("Danh sach sinh vien K14:");
        foreach (var x in K14)
        {
            x.Xuat();
        }
        Console.WriteLine($"So luong: {K14.Count}");
        Console.WriteLine("Danh sach sinh vien K21:");
        foreach (var x in K21)
        {
            x.Xuat();
        }
        Console.WriteLine($"So luong: {K21.Count}");
        Console.WriteLine("Danh sach sinh vien K36: ");
        foreach (var x in K36)
        {
            x.Xuat();
        }
        Console.WriteLine($"So luong: {K36.Count}");
    }
    public void ThongKe()
    {
        int nam05 = 0;
        int nu05 = 0;
        foreach (var x in K05)
        {
            if (x.Gioitinh == "Nam")
                nam05++;
            else
                nu05++;
        }
        Console.WriteLine($"K05 co {nam05} nam, {nu05} nu");
        int nu14 = 0;
        int nam14 = 0;
        foreach (var y in K14)
        {
            if (y.Gioitinh == "Nam")
                nam14++;
            else
                nu14++;
        }
        Console.WriteLine($"K14 co {nam14} nam, {nu14} nu");
        int nam21 = 0;
        int nu21 = 0;
        foreach (var z in K21)
        {
            if (z.Gioitinh == "Nam")
                nam21++;
            else
                nu21++;
        }
        Console.WriteLine($"K21 co {nam21} nam, {nu21} nu");
        int nam36 = 0;
        int nu36 = 0;
        foreach (var t in K14)
        {
            if (t.Gioitinh == "Nam")
                nam36++;
            else
                nu36++;
        }
        Console.WriteLine($"K36 co {nam36} nam, {nu36} nu");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Khoa tkth = new Khoa();
        tkth.LocSV();
        tkth.ThongKe();
    }
}