using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

abstract class CANBO
{
    int maCB;
    public int MaCB
    {
        get { return maCB; }
        set { maCB = value; }
    }
    string hoTen;
    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }
    double hesoLuong;
    public double HeSoLuong
    {
        get { return hesoLuong; }
        set { hesoLuong = value; }
    }
    public CANBO() { }
    public CANBO(int MaCB, string HoTen, double HeSoLuong)
    {
        this.MaCB = MaCB;
        this.HoTen = HoTen;
        this.HeSoLuong = HeSoLuong;
    }
    public abstract double TinhThuNhap();
}
class GVCoHuu : CANBO
{
    double phucapGiangDay;
    public double PhuCapGiangDay
    {
        get { return phucapGiangDay; }
        set { phucapGiangDay = value; }
    }
    double thuongNghienCuu;
    public double ThuongNghienCuu
    {
        get { return thuongNghienCuu; }
        set { thuongNghienCuu = value; }
    }
    public GVCoHuu() : base() { }
    public GVCoHuu(int MaCB, string HoTen, double HeSoLuong, double PhuCapGiangDay, double ThuongNghienCuu) : base(MaCB, HoTen, HeSoLuong)
    {
        this.PhuCapGiangDay = PhuCapGiangDay;
        this.ThuongNghienCuu = ThuongNghienCuu;
    }
    public override double TinhThuNhap()
    {
        return HeSoLuong * 2400000 + PhuCapGiangDay + ThuongNghienCuu;
    }
}
class GVThinhGiang : CANBO
{
    int soTietDay;
    public int SoTietDay
    {
        get { return soTietDay; }
        set { soTietDay = value; }
    }
    double donGiaTiet;
    public double DonGiaTiet
    {
        get { return donGiaTiet; }
        set { donGiaTiet = value; }
    }
    public GVThinhGiang() : base() { }
    public GVThinhGiang(int MaCB, string HoTen, double HeSoLuong, int SoTietDay, double DonGiaTiet) : base(MaCB, HoTen, HeSoLuong)
    {
        this.SoTietDay = SoTietDay;
        this.DonGiaTiet = DonGiaTiet;
    }
    public override double TinhThuNhap()
    {
        if (SoTietDay > 50)
        {
            return SoTietDay * DonGiaTiet + 500000;
        }
        else
            return SoTietDay * DonGiaTiet + 200000;
    }
}
interface INHANLUONG
{
    bool Thanhcong { get; set; }
    string Kenhnhan { get; set; }
    double Thucnhan { get; set; }
}
class CashPayment : INHANLUONG
{
    bool daKyNhan;
    public bool DaKyNhan
    {
        get { return daKyNhan; }
        set { daKyNhan = value; }
    }

    public bool Thanhcong { get; set; }
    public string Kenhnhan { get; set; }
    public double Thucnhan { get; set; }

    public CashPayment(bool ThanhCong, string Kenhnhan, double ThucNhan, bool DaKyNhan)
    {
        this.Thanhcong = ThanhCong;
        this.Kenhnhan = Kenhnhan;
        this.Thucnhan = ThucNhan;
        this.DaKyNhan = DaKyNhan;
    }

    public void ThanhToan()
    {
        if (Thucnhan > 0 && Thucnhan < 15000000 && DaKyNhan)
        {
            Console.WriteLine("Đã thanh toán lương thành công với số tiền " + Thucnhan + " qua hình thức nhận tiền mặt");
        }
        else
        {
            Console.WriteLine("Thanh toán lương thất bại");
        }
    }
}

class BankTransferPayment : INHANLUONG
{
    string soTaiKhoan;
    public string SoTaiKhoan
    {
        get { return soTaiKhoan; }
        set { soTaiKhoan = value; }
    }

    public bool Thanhcong { get; set; }
    public string Kenhnhan { get; set; }
    public double Thucnhan { get; set; }

    public BankTransferPayment(bool ThanhCong, string Kenhnhan, double ThucNhan, string SoTaiKhoan)
    {
        this.Thanhcong = ThanhCong;
        this.Kenhnhan = Kenhnhan;
        this.Thucnhan = ThucNhan;
        this.SoTaiKhoan = SoTaiKhoan;
    }

    public void ThanhToan()
    {
        if (Thucnhan > 0 && SoTaiKhoan.Length >= 10 && SoTaiKhoan.Length <= 14)
        {
            Console.WriteLine("Đã thanh toán lương thành công với số tiền " + Thucnhan + " qua hình thức nhận chuyển khoản");
        }
        else
        {
            Console.WriteLine("Thanh toán lương thất bại");
        }
    }
}
class Program
{
    static void Main()
    {
        List<CANBO> danhSachCanBo = new List<CANBO>()
        {
            new GVCoHuu(1, "Nguyễn Văn A", 5.0, 500000, 2000000),
            new GVCoHuu(2, "Trần Văn B", 6.0, 1000000, 3000000),
            new GVThinhGiang(3, "Lê Thị C", 0, 80, 150000)
        };

        Console.WriteLine("DANH SÁCH CÁN BỘ");

        foreach (CANBO cb in danhSachCanBo)
        {
            if (cb is GVCoHuu)
                Console.WriteLine($"{cb.MaCB} - {cb.HoTen}, Giảng viên, Thu nhập: {cb.TinhThuNhap():N0} VND");
            else if (cb is GVThinhGiang)
                Console.WriteLine($"{cb.MaCB} - {cb.HoTen}, Giảng viên thỉnh giảng, Thu nhập: {cb.TinhThuNhap():N0} VND");
        }
        Console.WriteLine("\nKÊNH NHẬN LƯƠNG");
        CashPayment paymentA = new CashPayment(true, "Tiền mặt", 12200000, true);
        Console.WriteLine("Nguyễn Văn A");
        Console.Write("Chọn kênh (1=Tiền mặt, 2=Chuyển khoản): ");
        int kenh1 = int.Parse(Console.ReadLine());
        if (kenh1 == 1)
            paymentA.Kenhnhan = "Tiền mặt";
        else if (kenh1 == 2)
            paymentA.Kenhnhan = "Chuyển khoản";
        Console.Write("Đã kí nhận? (y/n): ");
        string kn1 = Console.ReadLine();
        if (kn1 == "n")
            paymentA.DaKyNhan = false;
        paymentA.ThanhToan();
        BankTransferPayment paymentB = new BankTransferPayment(true, "Chuyển khoản", 21700000, "1234567890");
        Console.WriteLine("\nTrần Văn B");
        Console.Write("Chọn kênh (1=Tiền mặt, 2=Chuyển khoản): ");
        int kenh2 = int.Parse(Console.ReadLine());
        if (kenh2 == 1)
            paymentA.Kenhnhan = "Tiền mặt";
        else if (kenh2 == 2)
            paymentB.Kenhnhan = "Chuyển khoản";
        Console.Write("Nhập sô tài khoản (10-14 số): ");
        string stk = Console.ReadLine();
        paymentB.SoTaiKhoan = stk;
        paymentB.ThanhToan();
        Console.WriteLine("\nLê Thị C");
        CashPayment paymentC = new CashPayment(true, "Tiền mặt", 17200000, true);
        Console.Write("Chọn kênh (1=Tiền mặt, 2=Chuyển khoản): ");
        int kenh3 = int.Parse(Console.ReadLine());
        if (kenh3 == 1)
            paymentC.Kenhnhan = "Tiền mặt";
        else if (kenh3 == 2)
            paymentC.Kenhnhan = "Chuyển khoản";
        Console.Write("Đã kí nhận? (y/n): ");
        string kn = Console.ReadLine();
        if (kn == "n")
            paymentC.DaKyNhan = false;
        paymentC.ThanhToan();
    }
}