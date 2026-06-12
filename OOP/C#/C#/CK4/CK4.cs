using System.ComponentModel;

namespace CK4;
abstract class NguoiLaoDong
{
    private string ma;
    public string Ma
    {
        get { return ma; }
        set { ma = value; }
    }
    private string hoVaTen;
    public string HoVaTen
    {
        get { return hoVaTen; }
        set { hoVaTen = value; }
    }
    private int namSinh;
    public int NamSinh
    {
        get { return namSinh; }
        set { namSinh = value; }
    }
    private string queQuan;
    public string QueQuan
    {
        get { return queQuan; }
        set { queQuan = value; }
    }
    public NguoiLaoDong(string ma, string hoVaTen, int namSinh, string queQuan)
    {
        Ma = ma;
        HoVaTen = hoVaTen;
        NamSinh = namSinh;
        QueQuan = queQuan;
    }
    public NguoiLaoDong() { }
    ~NguoiLaoDong() { }
    public abstract double TinhLuong();
    public virtual void Nhap()
    {
        Console.Write("Ma: "); Ma = Console.ReadLine();
        Console.Write("Ho va ten: "); HoVaTen = Console.ReadLine();
        Console.Write("Nam sinh: "); NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Que quan: "); QueQuan = Console.ReadLine();
    }
    public override string ToString()
    {
        return $" Ma: {Ma}, Ten: {HoVaTen}, NamSinh: {NamSinh} Que: {QueQuan}";
    }
}
class NhanVien : NguoiLaoDong
{
    private double luongCoBan;
    public double LuongCoBan
    {
        get { return luongCoBan; }
        set { luongCoBan = value; }
    }
    private double thuong;
    public double Thuong
    {
        get { return thuong; }
        set { thuong = value; }
    }

    public NhanVien(string ma, string hoVaTen, int namSinh, string queQuan, double luongCoBan, double thuong) : base(ma, hoVaTen, namSinh, queQuan)
    {
        LuongCoBan = luongCoBan;
        Thuong = thuong;
    }

    public NhanVien() : base() { }
    ~NhanVien() { }
    public override double TinhLuong()
    {
        return LuongCoBan + Thuong;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Luong co ban: ");
        LuongCoBan = double.Parse(Console.ReadLine());
        Console.Write("Thuong: ");
        Thuong = double.Parse(Console.ReadLine());
    }
    public override string ToString()
    {
        return base.ToString() + $", Luong co ban: {LuongCoBan}, Thuong: {Thuong}";
    }
}
class GiangVien : NguoiLaoDong
{
    private int soTiet;
    public int SoTiet
    {
        get { return soTiet; }
        set { soTiet = value; }
    }
    private double thuong;
    public double Thuong
    {
        get { return thuong; }
        set { thuong = value; }
    }
    public GiangVien(string ma, string hoVaTen, int namSinh, string queQuan, int soTiet, double thuong) : base(ma, hoVaTen, namSinh, queQuan)
    {
        SoTiet = soTiet;
        Thuong = thuong;
    }
    public GiangVien() { }
    ~GiangVien() { }
    public override double TinhLuong()
    {
        double DonGia = 0;
        if (SoTiet <= 200)
        {
            DonGia = 800000;
            return SoTiet * DonGia + Thuong;
        }
        else if (SoTiet > 200)
        {
            DonGia = 900000;
            return SoTiet * DonGia + Thuong;
        }
        else
        {
            return 0;
        }
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("So tiet: ");
        SoTiet = int.Parse(Console.ReadLine());
        Console.Write("Thuong: ");
        Thuong = double.Parse(Console.ReadLine());
    }
    public override string ToString()
    {
        return base.ToString() + $", So tiet: {SoTiet}, Thuong: {Thuong}";
    }

}
class DaiHoc
{
    private List<NguoiLaoDong> DSNguoiLaoDong = new List<NguoiLaoDong>();
    public void ThemNguoiLaoDong()
    {
        //Nhap nhan vien:
        while (true)
        {
            Console.WriteLine("Nhap Nhan Vien:");
            NhanVien nv = new NhanVien();
            nv.Nhap();
            DSNguoiLaoDong.Add(nv);
            Console.WriteLine("Ban co muon them Nhan Vien khac? (Y/N)");
            string choice = Console.ReadLine();
            if (choice == "N")
            {
                break;
            }
        }
        //Nhap giang vien:
        while (true)
        {
            Console.WriteLine("Nhap Giang Vien:");
            GiangVien gv = new GiangVien();
            gv.Nhap();
            DSNguoiLaoDong.Add(gv);
            Console.WriteLine("Ban co muon them giang vien khac? (Y/N)");
            string choice = Console.ReadLine();
            if (choice == "N")
            {
                break;
            }

        }
    }
    public void HienThiDanhSachNLD()
    {
        Console.WriteLine("Danh sach nguoi lao dong:");
        foreach (var nld in DSNguoiLaoDong)
        {
            Console.WriteLine(nld);
        }
    }
    public void TimKiemNLD()
    {
        Console.WriteLine("Nhap ma NLD: ");
        string ma = Console.ReadLine();
        bool isNLD = false;
        foreach (var nld in DSNguoiLaoDong)
        {
            if (nld.Ma == ma)
            {
                Console.WriteLine(nld);
                isNLD = true;
                break;
            }
        }
        if (isNLD == false)
        {
            Console.WriteLine("Khong tim thay nguoi lao dong co ma: " + ma);
        }
    }
    public void TinhTongLuongGiangVien()
    {
        double TongLuong = 0;
        foreach (var nld in DSNguoiLaoDong)
        {
            if (nld is GiangVien)
            {
                TongLuong += nld.TinhLuong();
            }
        }
        Console.WriteLine($"Tong luong cua cac giang vien: {TongLuong}");
    }
    public void DSNVCoLuongTren10000000()
    {
        bool is100000 = false;
        foreach (var nld in DSNguoiLaoDong)
        {
            if (nld is NhanVien && nld.TinhLuong() > 10000000)
            {
                Console.WriteLine(nld);
                is100000 = true;
                break;
            }
        }
        if (is100000 == false)
        {
            Console.WriteLine("Khong co nhan vien co luong tren 10000000");
        }
    }
    // Sắp xếp danh sách giảm dần theo họ và tên, nếu cùng họ và tên thì xếp giảm dần theo mã.
    public void SapXepDanhSachNLD()
    {
        DSNguoiLaoDong.Sort((x, y) =>
        {
            if (x.HoVaTen == y.HoVaTen)
            {
                return y.Ma.CompareTo(x.Ma);
            }
            else
            {
                return y.HoVaTen.CompareTo(x.HoVaTen);
            }
        });
        foreach (var nld in DSNguoiLaoDong)
        {
            Console.WriteLine(nld);
        }
    }
    public void InSoNLD()
    {
        Console.WriteLine("Tong so nguoi lao dong:");
        int sumNV = 0;
        int sumGV = 0;
        foreach (var nld in DSNguoiLaoDong)
        {
            if (nld is NhanVien)
            {
                sumNV++;
            }
            else if (nld is GiangVien)
            {
                sumGV++;
            }
        }
        Console.WriteLine("So GV: " + sumGV);
        Console.WriteLine("So NV: " + sumNV);
    }
}
class Program
{
    static void Main(string[] args)
    {
        DaiHoc dh = new DaiHoc();
        dh.ThemNguoiLaoDong();
        Console.WriteLine("\nDanh sach nguoi lao dong:");
        dh.HienThiDanhSachNLD();
        Console.WriteLine("\nTim kiem Nguoi Lao Dong:");
        dh.TimKiemNLD();
        Console.WriteLine("\nTinh tong luong cua giang vien:");
        dh.TinhTongLuongGiangVien();
        Console.WriteLine("\nDanh sach nhan vien co luong tren 10000000:");
        dh.DSNVCoLuongTren10000000();
        Console.WriteLine("\nSap xep danh sach nguoi lao dong:");
        dh.SapXepDanhSachNLD();
        Console.WriteLine("\nIn so nguoi lao dong theo loai:");
        dh.InSoNLD();
    }
}

