using System;

abstract class PhongHoc
{
    string maPhong;
    public string MaPhong
    {
        get { return maPhong; }
        set { maPhong = value; }
    }
    string dayNha;
    public string DayNha
    {
        get { return dayNha; }
        set { dayNha = value; }
    }
    double dienTich;
    public double DienTich
    {
        get { return dienTich; }
        set { dienTich = value; }
    }
    int soluongDen;
    public int SoluongDen
    {
        get { return soluongDen; }
        set { soluongDen = value; }
    }
    public PhongHoc() { }
    public PhongHoc(string MaPhong, string DayNha, double DienTich, int SoluongDen)
    {
        this.MaPhong = MaPhong;
        this.DayNha = DayNha;
        this.DienTich = DienTich;
        this.SoluongDen = SoluongDen;
    }
    public abstract string DanhGia();
    public virtual void Nhap()
    {
        Console.Write("Nhap ma phong hoc: ");
        MaPhong = Console.ReadLine();
        Console.Write("Nhap day nha: ");
        DayNha = Console.ReadLine();
        Console.Write("Nhap dien tich: ");
        DienTich = double.Parse(Console.ReadLine());
        Console.Write("Nhap so luong bong den: ");
        SoluongDen = int.Parse(Console.ReadLine());
    }
    public virtual void ToString()
    {
        Console.WriteLine($"Ma phong: {MaPhong}, Day nha: {DayNha}, Dien tich: {DienTich}, So luong bong den: {SoluongDen}");
    }
}
class PhongLyThuyet : PhongHoc
{
    int mayChieu;
    public int MayChieu
    {
        get { return mayChieu; }
        set { mayChieu = value; }
    }
    public PhongLyThuyet() : base() { }
    public PhongLyThuyet(string MaPhong, string DayNha, double DienTich, int SoluongDen, int MayChieu) : base(MaPhong, DayNha, DienTich, SoluongDen)
    {
        this.MayChieu = MayChieu;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so luong may chieu: ");
        MayChieu = int.Parse(Console.ReadLine());
    }
    public override string DanhGia()
    {
        if ((DienTich / SoluongDen) <= 10 && MayChieu > 0)
            return "Dat chuan";
        else
            return "Khong dat chuan";
    }
    public override void ToString()
    {
        base.ToString();
        Console.WriteLine($"So luong may chieu: {MayChieu}");
        Console.WriteLine($"Danh gia: {DanhGia()}");
    }
}
class PhongThucHanh : PhongHoc
{
    int mayTinh;
    public int MayTinh
    {
        get { return mayTinh; }
        set { mayTinh = value; }
    }
    public PhongThucHanh() : base() { }
    public PhongThucHanh(string MaPhong, string DayNha, double DienTich, int SoluongDen, int MayTinh) : base(MaPhong, DayNha, DienTich, SoluongDen)
    {
        this.MayTinh = MayTinh;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so luong may tinh: ");
        MayTinh = int.Parse(Console.ReadLine());
    }
    public override string DanhGia()
    {
        if (MayTinh > 0 && (DienTich / MayTinh) >= 1.5)
            return "Dat chuan";
        else
            return "Khong dat chuan";
    }
    public override void ToString()
    {
        base.ToString();
        Console.WriteLine($"So luong may tinh: {MayTinh}");
        Console.WriteLine($"Danh gia: {DanhGia()}");
    }
}
class DaiHoc
{
    List<PhongHoc> dsPhonghoc = new List<PhongHoc>();
    public void ThemPhongHoc(PhongHoc phonghoc)
    {
        dsPhonghoc.Add(phonghoc);
    }
    public void DanhSachPH()
    {
        foreach (var phong in dsPhonghoc)
        {
            phong.ToString();
        }
    }
    public void TimKiem()
    {
        Console.Write("Nhap ma phong muon tim: ");
        string ma = Console.ReadLine();
        bool kt = false;
        foreach (var phong in dsPhonghoc)
        {
            if (phong.MaPhong == ma)
            {
                phong.ToString();
                kt = true;
                break;
            }
        }
        if (!kt)
            Console.WriteLine("Khong tim thay phong!");
    }
    public void TongsoPhong()
    {
        int tong = dsPhonghoc.Count;
        Console.WriteLine($"Tong so phong hoc la: {tong}");
    }
    public void DientichphongTH()
    {
        double tong = 0;
        foreach (var phong in dsPhonghoc)
        {
            if (phong is PhongThucHanh)
            {
                tong += phong.DienTich;
            }
        }
        Console.WriteLine($"Tong dien tich cac phong thuc hanh la: {tong}");
    }
    public void dsDatChuan()
    {
        foreach (var phong in dsPhonghoc)
        {
            if (phong.DanhGia() == "Dat chuan")
            {
                phong.ToString();
            }
        }
    }
    public void dsMaytren40()
    {
        foreach (var phong in dsPhonghoc)
        {
            if (phong is PhongThucHanh)
            {
                PhongThucHanh pth = (PhongThucHanh)phong;
                if (pth.MayTinh > 40)
                {
                    pth.ToString();
                }
            }
        }
    }
    public void SapXep()
    {
        for (int i = 0; i < dsPhonghoc.Count - 1; i++)
        {
            for (int j = i + 1; j < dsPhonghoc.Count; j++)
            {
                if (dsPhonghoc[i].DienTich > dsPhonghoc[j].DienTich)
                {
                    PhongHoc tam = dsPhonghoc[i];
                    dsPhonghoc[i] = dsPhonghoc[j];
                    dsPhonghoc[j] = tam;
                }
                if (dsPhonghoc[i].DienTich == dsPhonghoc[j].DienTich)
                {
                    if (dsPhonghoc[i].SoluongDen < dsPhonghoc[j].SoluongDen)
                    {
                        PhongHoc tam = dsPhonghoc[i];
                        dsPhonghoc[i] = dsPhonghoc[j];
                        dsPhonghoc[j] = tam;
                    }
                }
            }
        }
        Console.WriteLine("Danh sach phong hoc sau khi sap xep: ");
        foreach (var phong in dsPhonghoc)
        {
            phong.ToString();
        }
    }
}
class Program
{
    static void Main()
    {
        DaiHoc Kinhte = new DaiHoc();
        while (true)
        {
            Console.WriteLine("-----MENU-----");
            Console.WriteLine("1. Them phong hoc");
            Console.WriteLine("2. Hien thi thong tin trong danh sach");
            Console.WriteLine("3. Tim kiem phong hoc theo ma phong duoc chi dinh");
            Console.WriteLine("4. Tinh tong so phong hoc");
            Console.WriteLine("5. Tinh tong dien tch cac phong thuc hanh");
            Console.WriteLine("6. In danh sach cac phong dat chuan");
            Console.WriteLine("7. In danh sach phong thuc hanh co so may tren 40");
            Console.WriteLine("8. Sap xep tang dan theo dien tich, neu cung dien tich thi sap xep giam dan");
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
                    Console.WriteLine("1. Them phong thuc hanh");
                    Console.WriteLine("2. Them phong ly thuyet");
                    Console.Write("Chon phong ban muon them: ");
                    int lc = int.Parse(Console.ReadLine());
                    switch (lc)
                    {
                        case 1:
                            PhongHoc phongth = new PhongThucHanh();
                            Console.WriteLine("Nhap thong tin phong hoc muon them: ");
                            phongth.Nhap();
                            Kinhte.ThemPhongHoc(phongth);
                            break;
                        case 2:
                            PhongHoc phonglt = new PhongLyThuyet();
                            Console.WriteLine("Nhap thong tin phong hoc muon them: ");
                            phonglt.Nhap();
                            Kinhte.ThemPhongHoc(phonglt);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("-----DANH SACH PHONG HOC-----");
                    Kinhte.DanhSachPH();
                    break;
                case 3:
                    Kinhte.TimKiem();
                    break;
                case 4:
                    Kinhte.TongsoPhong();
                    break;
                case 5:
                    Kinhte.DientichphongTH();
                    break;
                case 6:
                    Console.WriteLine("-----DANH SACH PHONG DAT CHUAN-----");
                    Kinhte.dsDatChuan();
                    break;
                case 7:
                    Console.WriteLine("-----DANH SACH PHONG THUC HANH CO SO MAY TREN 40-----");
                    Kinhte.dsMaytren40();
                    break;
                case 8:
                    Kinhte.SapXep();
                    break;
            }
        }
    }
}
