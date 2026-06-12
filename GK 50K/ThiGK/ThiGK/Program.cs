using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Intrinsics.Arm;
using System.IO;

class PHUONGTIEN
{
    string bienso;
    string loaixe;
    string hangsx;
    int namsx;
    int gia;
    string tinhtrang;
    public string BienSo
    {
        get { return bienso; }
        set { bienso = value; }
    }
    public string LoaiXe
    {
        get { return loaixe; }
        set { loaixe = value; }
    }
    public string HangSX
    {
        get { return hangsx; }
        set { hangsx = value; }
    }
    public int NamSX
    {
        get { return namsx; }
        set { namsx = value; }
    }
    public int Gia
    {
        get { return gia; }
        set { gia = value; }
    }
    public string TinhTrang
    {
        get { return tinhtrang; }
        set { tinhtrang = value; }
    }
    public PHUONGTIEN()
    {

    }
    public PHUONGTIEN(string BienSo, string LoaiXe, string HangSX, int NamSX, int Gia, string TinhTrang)
    {
        this.BienSo = BienSo;
        this.LoaiXe = LoaiXe;
        this.HangSX = HangSX;
        this.NamSX = NamSX;
        this.Gia = Gia;
        this.TinhTrang = TinhTrang;
    }
    public void Xuat()
    {
        Console.WriteLine($"{BienSo};{LoaiXe};{HangSX};{NamSX};{Gia};{TinhTrang}");
    }
}
class QuanLyPhuongTien
{
    List<PHUONGTIEN> DsPhuongTien = new List<PHUONGTIEN>();
    public QuanLyPhuongTien(string fileName = "Phuongtien.txt")
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            string[] parts = line.Split(';');
            if (parts.Length == 6)
            {
                PHUONGTIEN pt = new PHUONGTIEN(parts[0].Trim(), parts[1].Trim(), parts[2].Trim(),
                                               int.Parse(parts[3].Trim()), int.Parse(parts[4].Trim()), parts[5].Trim());
                DsPhuongTien.Add(pt);
            }
        }
    }
    public void CapNhat()
    {
        bool kt = false;
        Console.Write("Nhap bien so muon cap nhat: ");
        string bso = Console.ReadLine();
        foreach (var pt in DsPhuongTien)
        {
            if (pt.BienSo == bso)
            {
                Console.Write("Nhap tinh trang moi: ");
                pt.TinhTrang = Console.ReadLine();
                kt = true;
                break;
            }
        }
        if (kt)
        {
            Console.WriteLine("Da cap nhat tinh trang!");
        }
        else
        {
            Console.WriteLine("Khong tim thay bien so muon cap nhat!");
        }
    }
    public void TimKiem()
    {
        bool kt = false;
        List<PHUONGTIEN> ds = new List<PHUONGTIEN>();
        Console.Write("Nhap hang xe muon tim kiem: ");
        string hang = Console.ReadLine();
        Console.WriteLine("Nhap khoang gia tim kiem: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        foreach (var pt in DsPhuongTien)
        {
            if (pt.HangSX == hang && pt.Gia >= a && pt.Gia <= b)
            {
                ds.Add(pt);
                kt = true;
            }
        }
        if (kt)
        {
            Console.WriteLine($"Danh sach hang xe {hang} trong khoang gia tu {a} den {b}");
            Console.WriteLine("BienSo;LoaiXe;HangSX;NamSX;Gia;TinhTrang");
            foreach (var pt in ds)
            {
                pt.Xuat();
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay phuong tien nao!");
        }
    }
    public void SapXep()
    {
        for (int i = 0; i < DsPhuongTien.Count - 1; i++)
        {
            for (int j = i + 1; j < DsPhuongTien.Count; j++)
            {
                if (DsPhuongTien[i].NamSX > DsPhuongTien[j].NamSX)
                {
                    PHUONGTIEN tam = DsPhuongTien[i];
                    DsPhuongTien[i] = DsPhuongTien[j];
                    DsPhuongTien[j] = tam;
                }
                else if (DsPhuongTien[i].NamSX == DsPhuongTien[j].NamSX)
                {
                    if (DsPhuongTien[i].Gia > DsPhuongTien[j].Gia)
                    {
                        PHUONGTIEN tam = DsPhuongTien[i];
                        DsPhuongTien[i] = DsPhuongTien[j];
                        DsPhuongTien[j] = tam;
                    }
                }
            }
        }
        Console.WriteLine("Da sap xep!");
    }
    public void Xuat()
    {
        foreach(var pt in DsPhuongTien)
        {
            pt.Xuat();
        }
    }
}
class Program
{
    static void Main()
    {
        QuanLyPhuongTien quanly = new QuanLyPhuongTien("Phuongtien.txt");
        while (true)
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("Bam 1: Cap nhat Tinh Trang theo Bien So");
            Console.WriteLine("Bam 2: Xuat danh sach xe theo hang xe va khoang gia tim kiem");
            Console.WriteLine("Bam 3: Sap xep tang dan theo Nam San Xuat");
            Console.WriteLine("Bam 0: Exit");
            Console.Write("Nhap lua chon cua ban: ");
            int chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    quanly.CapNhat();
                    quanly.Xuat();
                    break;
                case 2:
                    quanly.TimKiem();
                    break;
                case 3:
                    quanly.SapXep();
                    quanly.Xuat();
                    break;
                case 0:
                    Console.WriteLine("Thoat chuong trinh!");
                    break;
            }
            if (chon == 0)
                break;
        }
    }
}