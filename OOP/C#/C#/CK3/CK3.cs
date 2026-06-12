//Phong Thuc Hanh
using System.Text;
namespace CK3;
abstract class PhongHoc
{
    private string maPhongHoc;
    public string MaPhongHoc
    {
        get { return maPhongHoc; }
        set { maPhongHoc = value; }
    }
    private string dayNha;
    public string DayNha
    {
        get { return dayNha; }
        set { dayNha = value; }
    }
    private double dienTich;
    public double DienTich
    {
        get { return dienTich; }
        set { dienTich = value; }
    }
    private int soBongDen;
    public int SoBongDen
    {
        get { return soBongDen; }
        set { soBongDen = value; }
    }
    public abstract string DanhGia();
    public PhongHoc(string maPhongHoc, string dayNha, double dienTich, int soBongDen)
    {
        MaPhongHoc = maPhongHoc;
        DayNha = dayNha;
        DienTich = dienTich;
        SoBongDen = soBongDen;
    }
    public PhongHoc() { }
    ~PhongHoc() { }
    public virtual void Nhap()
    {
        Console.WriteLine("Ma phong:");
        MaPhongHoc = Console.ReadLine();
        Console.WriteLine("Day nha:");
        DayNha = Console.ReadLine();
        Console.WriteLine("Dien Tich:");
        DienTich = double.Parse(Console.ReadLine());
        Console.WriteLine("So bong den:");
        SoBongDen = int.Parse(Console.ReadLine());
    }
    public override string ToString()
    {
        return $"Ma phong: {MaPhongHoc}, Day Nha: {DayNha}, Dien Tich: {DienTich}, So bong den: {SoBongDen}";
    }

}
class PhongLyThuyet : PhongHoc
{
    private int mayChieu;
    public int MayChieu
    {
        get { return mayChieu; }
        set { mayChieu = value; }
    }
    // private double anhSang;
    // public double AnhSang
    // {
    //     get { return anhSang; }
    //     set { anhSang = value; }
    // } 
    public PhongLyThuyet(string maPhongHoc, string dayNha, double dienTich, int soBongDen, int mayChieu) : base(maPhongHoc, dayNha, dienTich, soBongDen)
    {
        MayChieu = mayChieu;
        // AnhSang = anhSang;
    }
    public PhongLyThuyet() : base() { }
    public override string ToString()
    {
        return base.ToString() + $"May chieu: {MayChieu}";
    }
    public override string DanhGia()
    {
        if (DienTich / SoBongDen <= 10 && MayChieu > 0)
        {
            return "Dat Chuan";
        }
        else
        {
            return "Khong Dat Chuan";
        }
    }
    public override void Nhap()
    {
        base.Nhap();
        int MayChieu = int.Parse(Console.ReadLine());
    }
}
class PhongThucHanh : PhongHoc
{
    private int soLuongMay;
    public int SoLuongMay
    {
        get { return soLuongMay; }
        set { soLuongMay = value; }
    }
    public override string DanhGia()
    {
        if (DienTich / SoLuongMay >= 1.5)
        {
            return "Dat Chuan";
        }
        else
        {
            return "Khong Dat Chuan";
        }
    }
    public PhongThucHanh(string maPhongHoc, string dayNha, double dienTich, int soBongDen, int soLuongMay) : base(maPhongHoc, dayNha, dienTich, soBongDen)
    {
        SoLuongMay = soLuongMay;
    }
    public PhongThucHanh() : base() { }
    ~PhongThucHanh() { }
    public override string ToString()
    {
        return base.ToString() + $"So LuongMay: {SoLuongMay}";
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("So Luong May:");
        SoLuongMay = int.Parse(Console.ReadLine());
    }
}

class DaiHoc
{
    private List<PhongHoc> DSPhongHoc = new List<PhongHoc>();
    public void ThemPhongHoc()
    {
        // DSPhongHoc.Add(new PhongLyThuyet("phong 1", "tam", 5, 7, 8));
        // DSPhongHoc.Add(new PhongLyThuyet("phong 33", "am", 4, 9, 7));
        // //them phong thuc hanh
        // DSPhongHoc.Add(new PhongThucHanh("phong 1", "tam", 5, 7, 8));
        // DSPhongHoc.Add(new PhongThucHanh("phong 5", "ter", 8, 9, 9));
        //them doi tuong phong li thuyet bang while true:
        while (true)
        {
            Console.WriteLine("Them phong li thuyet:");
            PhongLyThuyet phongLyThuyet = new PhongLyThuyet();
            phongLyThuyet.Nhap();
            DSPhongHoc.Add(phongLyThuyet);
            Console.WriteLine("Ban co muon them phong khac? (Y/N)");
            string choice = Console.ReadLine();
            if (choice == "N")
            {
                break;
            }
        }
        //them doi tuong phong thuc hanh bang while true:
        while (true)
        {
            Console.WriteLine("them phong thuc hanh: ");
            PhongThucHanh phongThucHanh = new PhongThucHanh();
            phongThucHanh.Nhap();
            DSPhongHoc.Add(phongThucHanh);
            Console.WriteLine("Ban co muon them phong khac? (Y/N)");
            string choice = Console.ReadLine();
            if (choice == "N")
            {
                break;
            }
        }


    }
    public void XuatThongTinPhongHoc()
    {
        foreach (var Phong in DSPhongHoc)
        {
            Console.WriteLine(Phong);
            Console.WriteLine($"Danh gia: {Phong.DanhGia()}");
        }
    }
    public void TimKiemPHTheoMa(string maPhongHoc)
    {
        bool isPhong = false;
        foreach (var PH in DSPhongHoc)
        {
            if (PH.MaPhongHoc == maPhongHoc)
            {
                Console.WriteLine(PH);
                isPhong = true;
                break;
            }
        }
        if (isPhong == false)
        {
            Console.WriteLine("Khong tim thay phong");
        }

    }
    //Tinh tong so phong hoc:
    public int TinhTongSoPhongHoc()
    {
        return DSPhongHoc.Count;
    }
    //tinh tong dien tich cac phong thuc hanh:
    public double TinhTongDienTichPhongThucHanh()
    {
        double tongDienTich = 0;
        foreach (var phong in DSPhongHoc)
        {
            if (phong is PhongThucHanh)
            {
                tongDienTich += phong.DienTich;
            }
        }
        return tongDienTich;
    }
    //in danh sach phong hoc dat chuan:
    public void InDanhSachPhongHocDatChuan()
    {
        foreach (var phong in DSPhongHoc)
        {
            if (phong.DanhGia() == "Dat Chuan")
            {
                Console.WriteLine(phong);
            }
        }
    }
    //in danh sach phong thuc hanh co so may tren 40:
    public void InDanhSachPhongThucHanhCoSoMayTren40()
    {
        foreach (var phong in DSPhongHoc)
        {
            if (phong is PhongThucHanh && (phong as PhongThucHanh).SoLuongMay > 40)
            {
                Console.WriteLine(phong);
            }
        }
    }
    //sap xep danh sach tang dan theo dien tich, neu dung dien tich thì xếp giảm dần theo số bóng đèn:
    public void SapXepPhongHocTangDanTheoDienTich()
    {
        DSPhongHoc.Sort((x, y) => y.DienTich.CompareTo(x.DienTich));
    }

}

class Program
{
    static void Main(string[] args)
    {
        DaiHoc dh = new DaiHoc();
        Console.WriteLine("1: Thêm phòng học và danh sách phòng học.");
        Console.WriteLine("2: Hiển thị tất cả thông tin trong danh sách phòng học.");
        Console.WriteLine("3: Tìm kiếm phòng học theo mã phòng học.");
        Console.WriteLine("4: Tính tổng số phòng học.");
        Console.WriteLine("5: Tính tổng diện tích phòng thực hành.");
        Console.WriteLine("6. In ra các phòng thực hành đạt chuẩn.");
        Console.WriteLine("7: In danh sách phòng thực hành có số máy trên 40.");
        Console.WriteLine("8: Sắp xếp tăng dần theo diện tích.");
        Console.WriteLine("----------------------------------------------");

        while (true)
        {
            Console.Write("Nhap so ban muon: ");
            int chon = Convert.ToInt32(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    dh.ThemPhongHoc();
                    Console.WriteLine("---------------------");
                    break;
                case 2:
                    dh.XuatThongTinPhongHoc();
                    Console.WriteLine("---------------------");
                    break;
                case 3:
                    Console.Write("Nhap ma phong hoc ban muon tim: ");
                    string maPhongHoc = Console.ReadLine();
                    dh.TimKiemPHTheoMa(maPhongHoc);
                    Console.WriteLine("---------------------");
                    break;
                case 4:
                    dh.TinhTongSoPhongHoc();
                    Console.WriteLine("---------------------");
                    break;
                case 5:
                    dh.TinhTongDienTichPhongThucHanh();
                    Console.WriteLine("-----------------------------");
                    break;
                case 6:
                    dh.InDanhSachPhongHocDatChuan(); ;
                    Console.WriteLine("---------------------");
                    break;
                case 7:
                    dh.InDanhSachPhongThucHanhCoSoMayTren40();
                    Console.WriteLine("-------------------------------");
                    break;
                case 8:
                    dh.SapXepPhongHocTangDanTheoDienTich();
                    Console.WriteLine("-------------------------------");
                    break;
                default:
                    Console.WriteLine("Chua thuc hien duoc, moi nhap lai");
                    break;

            }

            Console.Write("Tiep tuc ('Co'/'Khong'): ");
            string tt = Console.ReadLine();
            if (tt == "Co")
            {
                continue;
            }
            else
            {
                break;
            }


        }


    }
}