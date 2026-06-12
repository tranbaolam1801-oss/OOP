// Xây dựng chương trình quản lý xe, đóng gói bằng phương thức
// -	Tạo lớp Car 
// o	Thuộc tính (private):
// •	Make (Hãng xe): Kiểu chuỗi (string), cho phép thiết lập và lấy giá trị (ví dụ: "Toyota", "Honda").
// •	Model (Mẫu xe): Kiểu chuỗi (string), cho phép thiết lập và lấy giá trị (ví dụ: "Corolla", "Civic").
// •	Year (Năm sản xuất): Kiểu số nguyên (int), cho phép thiết lập và lấy giá trị. Năm sản xuất phải lớn hơn 1885 (năm chiếc xe đầu tiên ra đời) và không được vượt quá năm hiện tại.
// o	Phương thức (public):
// •	SetMake(string make): Phương thức để thiết lập hãng xe.
// •	SetModel(string model): Phương thức để thiết lập mẫu xe.
// •	SetYear(int year): Phương thức để thiết lập năm sản xuất, với điều kiện năm phải hợp lệ (lớn hơn 1885 và không vượt quá năm hiện tại).
// •	GetMake(), GetModel(), GetYear(): Các phương thức để lấy thông tin hãng xe, mẫu xe, và năm sản xuất.
// -	Chương trình chính (Main) phải:
// o	Tạo một đối tượng Car và thiết lập thông tin (hãng xe, mẫu xe, năm sản xuất).
// o	Sử dụng các phương thức trong lớp Car để truy cập và in ra các thông tin về chiếc xe.
// o	Kiểm tra năm sản xuất được thiết lập hợp lệ và không vi phạm điều kiện.

namespace Car2;

class Program
{
    static void Main(string[] args)
    {
        Car2 C2 = new Car2();
        C2.Thongtinxe();
        C2.CheckNSX();
        C2.Xuatthongtin();
    }
}
class Car2
{
    public string Make;
    public string Model;
    public int Year;
    //ham khoi tao ham co tham so
    public Car2(string Make, string Model, int Year)
    {
       this.Make = Make;
       this.Model = Model;
       this.Year = Year; 
    }
    public Car2()
    {
        Make = "";
        Model = "";
        Year = 0;
    }
    ~Car2()
    {

    }
    public void Thongtinxe()
    {
        Console.WriteLine("Thiet lap hang xe: ");
        Make = Console.ReadLine();
        Console.WriteLine("Thiet lap mau xe: ");
        Model = Console.ReadLine();
        Console.WriteLine("Nhap nam san xuat xe: ");
        Year =int.Parse(Console.ReadLine());
    }
    public void CheckNSX()
    {
        while (Year <= 1885 || Year > DateTime.Now.Year)
        {
            Console.WriteLine("Nhap lai NSX:");
            Year = int.Parse(Console.ReadLine());
        }
        this.Year = Year;
    }
    public void Xuatthongtin()
    {
        Console.WriteLine($"Hang xe: {Make}, mau xe: {Model}, nam san xuat: {Year}");
    }
}
