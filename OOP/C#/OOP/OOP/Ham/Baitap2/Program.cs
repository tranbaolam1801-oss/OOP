// Hàm tổng bình phương:
// - Viết chương trình thực hiện các yêu cầu sau:
// •	Nhập vào từ bàn phím hai số nguyên a và b
// •	Tính tổng bình phương của a và b
// - Hàm TBP(a,b): kết quả được in lên màn hình
// - Hàm TBP(a,b,kq): tham số kq sẽ mang kết quả
// - Hàm TBP1(a,b): kết quả được trả về qua tên hàm
namespace Baitap2;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Nhap a: ");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap b: ");
        int b=int.Parse(Console.ReadLine());
        Console.WriteLine("cach 1:");
        TBP1(a, b); //gọi hàm thì k cần khai bao kiểu dl
        Console.WriteLine("cach 2:");
        TBP2(a, b, out int kq);
        Console.WriteLine("Tong binh phuong a,b la: {0} ",kq);
        Console.WriteLine("cach 3:");
        int TBP=TBP3(a, b);
        Console.WriteLine("Tong binh phuong a,b la: {0} ",TBP);

    }
    static void TBP1(int a, int b)
    {
        Console.WriteLine("Tong binh phuong a,b la: ");
        Console.WriteLine(Math.Pow((a+b),2));   
    }

    static void TBP2(int a, int b, out int kq)
    {
        kq=(int) Math.Pow((a+b),2); //thêm (int) vì Math.Pow sẽ trả về kiểu float or double mà "kq" lại có kiểu là int nên bị xung đột dữ liệu
    }

    static int TBP3(int a, int b)
    {
        return (int) Math.Pow((a+b),2);
    }
}
