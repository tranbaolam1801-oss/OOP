namespace LapTrinhHDT;

class Program
{
    static void Main(string[] args)
    {
        HocSinh hs = new HocSinh();
        hs.Nhap();
        hs.Xuat();
    }
}
// ví dụ
class HocSinh
{
    public float ChieuCao;
    public float CanNang;
    public HocSinh()
    {
        ChieuCao=0;
        CanNang=0;
    }
    public HocSinh(float ChieuCao, float CanNang)
    {
        this.ChieuCao=ChieuCao;
        this.CanNang=CanNang;
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap chieu cao: ");
        ChieuCao=float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap can nang: ");
        CanNang=float.Parse(Console.ReadLine());    
    }
    public void TinhBMI(float ChieuCao, float CanNang, out float BMI1)
    {
        BMI1=(float) CanNang/(ChieuCao*ChieuCao);
    }
    public string XepLoaiSucKhoe() //void thì k thể trả về lệnh return vì thế phải đổi lại float
    {
        // float bmi=TinhBMI(ChieuCao, CanNang, out float BMI1);
        TinhBMI(ChieuCao, CanNang, out float BMI1);
        if (BMI1<18.5)
            return "Gay";
        else if (BMI1 >= 18.5 && BMI1 <24.9)
            return "BinhThuong";
        else if (BMI1 >= 25 && BMI1 < 29.9)
            return "ThuaCan";
        else
            return "BeoPhi";
    }
    ~HocSinh()
    {
        Console.WriteLine("END");
    }
    public void Xuat()
    {
        TinhBMI(ChieuCao, CanNang, out float BMI1);
        Console.WriteLine("Chiều cao: {0} và Cân nặng: {1}", ChieuCao, CanNang);
        Console.WriteLine("BMI: {0}", BMI1);
        Console.WriteLine("Xếp loại sức khỏe: {0}", XepLoaiSucKhoe());
    }
}
