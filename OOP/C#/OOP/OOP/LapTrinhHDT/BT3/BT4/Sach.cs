// 1. Xây dựng lớp Sach gồm: 
//  Thuộc tính: Tensach, Tacgia, NamXB, Soluong 
//  Phương thức:  
// o Hàm Khởi tạo, Hàm hủy  
// o Hàm Nhập, Xuất 
// 2. Chương trình chính:  
//  Tạo đổi tượng Sach 
//  Nhập và xuất ra thông tin sách
namespace BT4;

class Program
{
    static void Main(string[] args)
    {
        Sach Qsach = new Sach();
        Qsach.Nhap();
        Qsach.Xuat();
    }
}

class Sach
{
    private string Tensach;
    private string Tacgia;
    private int NamXB;
    private int Soluong;
    public string tensach
    {
        get {return Tensach;}
        set {Tensach = value;}
    }
    public string tacgia
    {
        get {return Tacgia;}
        set {Tacgia = value;}
    }
    public int nxb
    {
        get {return NamXB;}
        set {NamXB = value;}
    }
    public int soluong
    {
        get {return Soluong;}
        set {Soluong = value;}
    }
    public Sach()
    {

    }
    public Sach(string Tensach, string Tacgia, int NamXB, int Soluong)
    {
        this.Tensach = Tensach;
        this.Tacgia = Tacgia;
        this.NamXB = NamXB;
        this.Soluong = Soluong;
    }
    ~Sach()
    {
        Console.WriteLine("End");
    }
    public void Nhap()
    {
        Console.Write("Nhap ten sach: ");
        Tensach=Console.ReadLine();
        Console.Write("Nhap tac gia: ");
        Tacgia=Console.ReadLine();
        Console.Write("Nhap nam xuat ban: ");
        NamXB=int.Parse(Console.ReadLine());
        Console.Write("Nhap so luong: ");
        Soluong=int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"Ten sach: {tensach}, Tac gia: {tacgia}, NXB: {nxb}, So luong: {soluong}");
    }

}