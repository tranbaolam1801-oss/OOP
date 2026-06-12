using System;

interface ISACH
{
    double TinhThanhTien();
}
abstract class SACH : ISACH
{
    string maSach;
    public string MaSach
    {
        get { return maSach; }
        set { maSach = value; }
    }
    string nxb;
    public string NXB
    {
        get { return nxb; }
        set { nxb = value; }
    }
    DateTime ngayNhap;
    public DateTime NgayNhap
    {
        get { return ngayNhap; }
        set { ngayNhap = value; }
    }
    double donGia;
    public double DonGia
    {
        get { return donGia; }
        set { donGia = value; }
    }
    int soLuong;
    public int SoLuong
    {
        get { return soLuong; }
        set { soLuong = value; }
    }
    public SACH() { }
    public SACH(string MaSach, string NXB, DateTime NgayNhap, double DonGia, int SoLuong)
    {
        this.MaSach = MaSach;
        this.NXB = NXB;
        this.NgayNhap = NgayNhap;
        this.DonGia = DonGia;
        this.SoLuong = SoLuong;
    }
    public virtual void Nhap()
    {
        Console.Write("Nhap ma sach: ");
        MaSach = Console.ReadLine();
        Console.Write("Nhap NXB: ");
        NXB = Console.ReadLine();
        Console.Write("Nhap ngay nhap: ");
        NgayNhap = DateTime.Parse(Console.ReadLine());
        Console.Write("Nhap don gia: ");
        DonGia = double.Parse(Console.ReadLine());
        Console.Write("Nhap so luong: ");
        SoLuong = int.Parse(Console.ReadLine());
    }
    public abstract double TinhTienGiam();
    public abstract double TinhThanhTien();
    public virtual void Xuat()
    {
        Console.Write($"Ma sach: {MaSach}, NXB: {NXB}, Ngay nhap: {NgayNhap}, Don gia: {DonGia}, So luong: {SoLuong}, ");
    }
}
class SACHGIAOKHOA : SACH
{
    string tinhTrang;
    public string TinhTrang
    {
        get { return tinhTrang; }
        set { tinhTrang = value; }
    }
    public SACHGIAOKHOA() : base() { }
    public SACHGIAOKHOA(string MaSach, string NXB, DateTime NgayNhap, double DonGia, int SoLuong, string TinhTrang) : base(MaSach, NXB, NgayNhap, DonGia, SoLuong)
    {
        this.TinhTrang = TinhTrang;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap tinh trang: ");
        TinhTrang = Console.ReadLine();
    }
    public override double TinhThanhTien()
    {
        return SoLuong * DonGia - TinhTienGiam();
    }
    public override double TinhTienGiam()
    {
        if (TinhTrang.Trim().ToLower() == "moi")
            return SoLuong * DonGia * 0.1;
        else
            return SoLuong * DonGia * 0.5;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Tinh trang: {TinhTrang}");
    }
}
class SACHTHAMKHAO : SACH
{
    double thue;
    public double Thue
    {
        get { return thue; }
        set { thue = value; }
    }
    public SACHTHAMKHAO() { }
    public SACHTHAMKHAO(string MaSach, string NXB, DateTime NgayNhap, double DonGia, int SoLuong, double Thue) : base(MaSach, NXB, NgayNhap, DonGia, SoLuong)
    {
        this.Thue = Thue;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap thue: ");
        Thue = double.Parse(Console.ReadLine());
    }
    public override double TinhThanhTien()
    {
        return SoLuong * DonGia + Thue - TinhTienGiam();
    }
    public override double TinhTienGiam()
    {
        return 0;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Thue: {Thue}");
    }
}
class DSSACH
{
    List<SACH> dsSach = new List<SACH>();
    public void HienThiDanhSach()
    {
        Console.WriteLine("\n===== DANH SACH SACH =====");
        foreach (var sach in dsSach)
        {
            sach.Xuat();
        }
    }
    public void ThemSach(SACH sach)
    {
        dsSach.Add(sach);
    }
    public void XoaSach()
    {
        bool kt = false;
        Console.Write("Nhap ma sach muon xoa: ");
        string ma = Console.ReadLine();
        for (int i = 0; i < dsSach.Count; i++)
        {
            if (dsSach[i].MaSach == ma)
            {
                dsSach.RemoveAt(i);
                Console.WriteLine("Da xoa sach!");
                kt = true;
                break;
            }
        }
        if (!kt)
        {
            Console.WriteLine("Khong tim thay sach muon xoa!");
        }
    }
    public void CapNhat()
    {
        Console.Write("Nhap ma sach muon cap nhat: ");
        string ma = Console.ReadLine();
        bool kt = false;
        foreach (var sach in dsSach)
        {
            if (sach.MaSach == ma)
            {
                sach.Nhap();
                kt = true;
                break;
            }
        }
        if (!kt)
            Console.WriteLine("Khong tim thay sach!");
    }
    public void TimKiem()
    {
        Console.Write("Nhap ma sach muon tim kiem: ");
        string ma = Console.ReadLine();
        bool kt = false;
        foreach (var sach in dsSach)
        {
            if (sach.MaSach == ma)
            {
                sach.Xuat();
                kt = true;
                break;
            }
        }
        if (!kt)
            Console.WriteLine("Khong tim thay sach!");
    }
    public void TongTien()
    {
        double tienthamkhao = 0;
        double tiengiaokhoa = 0;
        foreach (var sach in dsSach)
        {
            if (sach is SACHGIAOKHOA)
                tiengiaokhoa += sach.TinhThanhTien();
            else if (sach is SACHTHAMKHAO)
                tienthamkhao += sach.TinhThanhTien();
        }
        Console.WriteLine($"Tong tien sach tham khao: {tienthamkhao}");
        Console.WriteLine($"Tong tien sach giao khoa: {tiengiaokhoa}");
    }
}
class Program
{
    static void Main()
    {
        DSSACH ds = new DSSACH();
        while (true)
        {
            Console.WriteLine("\n-----MENU-----");
            Console.WriteLine("1. Them moi");
            Console.WriteLine("2. Cap nhat");
            Console.WriteLine("3. xoa");
            Console.WriteLine("4. Tim kiem");
            Console.WriteLine("5. Tinh tong tien tung loai");
            Console.WriteLine("0. Thoat chuong trinh");
            Console.Write("Nhap lua chon cua ban: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 0)
            {
                Console.WriteLine("Thoat chuong trinh!");
                break;
            }
            switch (chon)
            {
                case 1:
                    Console.WriteLine("1. Them sach giao khoa");
                    Console.WriteLine("2. Them sach tham khao");
                    Console.Write("Ban muon them sach nao: ");
                    int lc = int.Parse(Console.ReadLine());
                    if (lc == 1)
                    {
                        SACH sach = new SACHGIAOKHOA();
                        sach.Nhap();
                        ds.ThemSach(sach);
                    }
                    if (lc == 2)
                    {
                        SACH sach = new SACHTHAMKHAO();
                        sach.Nhap();
                        ds.ThemSach(sach);
                    }
                    break;
                case 2:
                    ds.CapNhat();
                    ds.HienThiDanhSach();
                    break;
                case 3:
                    ds.XoaSach();
                    ds.HienThiDanhSach();
                    break;
                case 4:
                    ds.TimKiem();
                    break;
                case 5:
                    ds.TongTien();
                    break;
            }
        }
    }
}