// 1. Xây dựng lớp Organization gồm: 
//  Thuộc tính: Name, Country, City, Address, Telephone là Tên Doanh nghiệp, Quốc 
// gia, Thành phố, Địa chỉ, Số điện thoại 
//  Phương thức: 
// o Hàm Khởi tạo, Hàm hủy 
// 5 
// o Hàm Nhập, Xuất – Để nhập và xuất thông tin 
// 2. Chương trình chính: 
// Nhập và xác nhận các thông tin đầu vào trong đó yêu cầu: 
//  Thông tin đầu vào các thuộc tính không được để trống 
//  Thông tin về Số điện thoại phải đảm bảo đủ 10 chữ số và không được để trống 
// Xuất ra màn hình thông tin của Doanh nghiệp nếu tất các thông tin nhập vào là hợp lệ.  
// Trường hợp thông tin không hợp lệ thì thông báo “Nhập thông tin lỗi” và dừng chương 
// trình. 
namespace BT5;

class Program
{
    static void Main(string[] args)
    {
        Organization Org = new Organization();
        Org.Nhap();
        if (Org.Name == "" || Org.Country == "" || Org.City == "" || Org.Address == ""  || Org.Telephone.Length != 10)
        {
            Console.Write("Vui long nhap lai");
        }
        else
        {
            Org.Xuat();
        }
    }
}
class Organization
{
    public string Name;
    public string Country;
    public string City;
    public string Address;
    public string Telephone;
    public Organization()
    {

    }
    public Organization(string Name, string Country, string City, string Address, string Telephone)
    {
        this.Name = Name;
        this.Country = Country;
        this.City = City;
        this.Address = Address;
        this.Telephone = Telephone;
    }
    ~Organization()
    {
        Console.Write("End");
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap ten doanh nghiep: ");
        Name=Console.ReadLine();
        Console.WriteLine("Nhap quoc gia: ");
        Country=Console.ReadLine();
        Console.WriteLine("Nhap thanh pho: ");
        City=Console.ReadLine();
        Console.WriteLine("Nhap dia chi: ");
        Address=Console.ReadLine();
        Console.WriteLine("Nhap sdt: ");
        Telephone=Console.ReadLine();
    }
    public void Xuat()
    {
        Console.WriteLine($"Ten: {Name}, Qgia: {Country}, Thanhpho: {City}, Diachi: {Address}, SDT: {Telephone}");
    }


}
