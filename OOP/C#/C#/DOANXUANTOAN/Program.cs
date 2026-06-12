namespace DOANXUANTOAN;
public abstract class NhanVien
{
    private string maNV;
    public string MaNV
    {
        get { return maNV; }
        set { maNV = value; }
    }
    private string hoTen;
    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }
    private double luongCoBan;
    public double LuongCoBan
    {
        get { return luongCoBan; }
        set { luongCoBan = value; }
    }
    public NhanVien(string maNV, string hoTen, double luongCoBan)
    {
        MaNV = maNV;
        HoTen = hoTen;
        LuongCoBan = luongCoBan;
    }
    public NhanVien() { }
    ~NhanVien() { }
    //phuong thuc truu tuong TinhLuong:
    public abstract double TinhLuong();
    public virtual void Nhap()
    {
        Console.WriteLine("Nhap ma nhan vien: ");
        MaNV = Console.ReadLine();
        Console.WriteLine("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.WriteLine("Nhap luong co ban: ");
        LuongCoBan = double.Parse(Console.ReadLine());
    }
    public virtual void Xuat()
    {
        Console.WriteLine($"Ma nhan vien:{MaNV}");
        Console.WriteLine($"Ho ten: {HoTen}");
        Console.WriteLine($"Luong co ban: {LuongCoBan}");
    }
}
public class NhanVienVanPhong : NhanVien
{
    private int soNgayLamViec;
    public int SoNgayLamViec
    {
        get { return soNgayLamViec; }
        set { soNgayLamViec = value; }
    }
    public NhanVienVanPhong(string maNV, string hoTen, double luongCoBan, int soNgayLamViec) : base(maNV, hoTen, luongCoBan)
    {
        SoNgayLamViec = soNgayLamViec;
    }
    public NhanVienVanPhong() { }
    ~NhanVienVanPhong() { }
    public override double TinhLuong()
    {
        return LuongCoBan + SoNgayLamViec * 100;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("Nhap so ngay lam viec: ");
        SoNgayLamViec = int.Parse(Console.ReadLine());
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"So ngay lam viec: {SoNgayLamViec},Luong: {TinhLuong()}");
    }
}
public class NhanVienSanXuat : NhanVien
{
    private int soSanPham;
    public int SoSanPham
    {
        get { return soSanPham; }
        set { soSanPham = value; }
    }
    public NhanVienSanXuat(string maNV, string hoTen, double luongCoBan, int soSanPham) : base(maNV, hoTen, luongCoBan)
    {
        SoSanPham = soSanPham;
    }
    public NhanVienSanXuat() { }
    ~NhanVienSanXuat() { }
    public override double TinhLuong()
    {
        return LuongCoBan + SoSanPham * 50;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("Nhap so san pham: ");
        SoSanPham = int.Parse(Console.ReadLine());
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"So san pham: {SoSanPham} Luong: {TinhLuong()}");
    }
}
public class CongTy
{
    private List<NhanVien> DSNhanVien = new List<NhanVien>();
    public void ThemNhanVien(NhanVien nv)
    {
        DSNhanVien.Add(nv);
    }
    public void XuatDanhSachNhanVien()
    {
        foreach (var nv in DSNhanVien)
        {
            nv.Xuat();
        }
    }
    public void TimKiemNhanVienTheoMa()
    {
        Console.WriteLine("Nhap ma nhan vien can tim: ");
        string maNV = Console.ReadLine();
        bool isNV = false;
        foreach (var nv in DSNhanVien)
        {
            if (nv.MaNV == maNV)
            {
                nv.Xuat();
                isNV = true;
                break;
            }
        }
        if (isNV == false)
        {
            Console.WriteLine($"Khong tim thay nhan vien");
        }
    }
    public void TinhTongLuongNhanVien()
    {
        double tongLuong = 0;
        foreach (var nv in DSNhanVien)
        {
            tongLuong += nv.TinhLuong();
        }
        Console.WriteLine($"Tong luong nhan vien: {tongLuong}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        CongTy congTy = new CongTy();
        // //Them 2 nhan vien van phong:
        congTy.ThemNhanVien(new NhanVienVanPhong("NV01", "Nguyen Van A", 3000000, 20));
        congTy.ThemNhanVien(new NhanVienVanPhong("NV03", "Nguyen Van C", 3500000, 18));
        // //Them 2 nhan vien san xuat:
        congTy.ThemNhanVien(new NhanVienSanXuat("NV02", "Nguyen Van B", 2500000, 15));
        congTy.ThemNhanVien(new NhanVienSanXuat("NV04", "Nguyen Van D", 2800000, 12));
        Console.WriteLine("-----------------------------------");
        //Xuat danh sach nhan vien:
        congTy.XuatDanhSachNhanVien();
        Console.WriteLine("-----------------------------------");
        //Tim kiem nhan vien theo ma:
        congTy.TimKiemNhanVienTheoMa();
        Console.WriteLine("-----------------------------------");
        //Tinh tong luong nhan vien:
        congTy.TinhTongLuongNhanVien();
    }
}




