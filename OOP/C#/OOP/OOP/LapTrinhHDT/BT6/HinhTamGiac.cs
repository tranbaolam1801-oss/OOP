// 1. Xây dựng lớp HinhTamGiac gồm: 
//  Thuộc tính: a, b, c (kiểu int) là 3 cạnh của một tam giác 
//  Phương thức: 
// o Hàm Khởi tạo, Hàm hủy 
// o Hàm Nhập, Xuất – Để nhập và xuất thông tin 
// o Hàm Tính để tính chu vi và diện tích hình tam giác 
// 2. Chương trình chính: 
// Tạo một Menu để thực hiện lặp lại các chức năng cho đến khi thoát: 
// o Bấm 1: Nhập các cạnh a, b, c của tam giác 
// o Bấm 2: Tính chu vi và diện tích hình tam giác 
// o Bấm 3: Xuất ra các giá trị a, b, c.  
// o Bấm 0: Thoát khỏi chương trình 
// Trường hợp các cạnh tạo được một tam giác thì Xuất ra giá trị Chu vi và Diện tích của tam 
// giác. Trường hợp không tạo được tam giác thì xuất ra màn hình “Không hợp lệ”.

namespace BT6;

class HinhTamGiac
{
    // Thuộc tính
    public int a, b, c;

    // Hàm khởi tạo mặc định
    public HinhTamGiac()
    {
        a = 0;
        b = 0;
        c = 0;
    }

    // Hàm khởi tạo có tham số
    public HinhTamGiac(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    // Hàm hủy
    ~HinhTamGiac()
    {
        Console.WriteLine("Hủy đối tượng tam giác.");
    }

    // Hàm nhập thông tin các cạnh
    public void Nhap()
    {
        Console.Write("Nhập cạnh a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh b: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh c: ");
        c = int.Parse(Console.ReadLine());
    }

    // Hàm xuất thông tin các cạnh
    public void Xuat()
    {
        Console.WriteLine($"Cạnh a: {a}, Cạnh b: {b}, Cạnh c: {c}");
    }

    // Hàm kiểm tra xem ba cạnh có tạo thành tam giác hay không
    public bool LaTamGiac()
    {
        return (a + b > c && a + c > b && b + c > a);
    }

    // Hàm tính chu vi tam giác
    public int TinhChuVi()
    {
        return a + b + c;
    }

    // Hàm tính diện tích tam giác theo công thức Heron
    public double TinhDienTich()
    {
        double p = TinhChuVi() / 2.0; // Nửa chu vi
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}

class Program
{
    static void Main(string[] args)
    {
        HinhTamGiac tamGiac = new HinhTamGiac();
        bool tiepTuc = true;

        while (tiepTuc)
        {
            Console.WriteLine("\n===== Menu =====");
            Console.WriteLine("1. Nhập các cạnh a, b, c của tam giác");
            Console.WriteLine("2. Tính chu vi và diện tích hình tam giác");
            Console.WriteLine("3. Xuất các giá trị a, b, c");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Mời bạn chọn: ");

            int luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    tamGiac.Nhap();
                    break;
                case 2:
                    if (tamGiac.LaTamGiac())
                    {
                        Console.WriteLine($"Chu vi tam giác: {tamGiac.TinhChuVi()}");
                        Console.WriteLine($"Diện tích tam giác: {tamGiac.TinhDienTich()}");
                    }
                    else
                    {
                        Console.WriteLine("Không hợp lệ. Đây không phải là tam giác.");
                    }
                    break;
                case 3:
                    tamGiac.Xuat();
                    break;
                case 0:
                    tiepTuc = false;
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }
}