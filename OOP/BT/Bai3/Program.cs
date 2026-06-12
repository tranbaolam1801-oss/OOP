static void TBP(int a, int b)
{
    Console.WriteLine($"Tong binh phuong la: {a * a + b * b}");
}
static void TBP1(int a, int b, out int kq)
{
    kq = a * a + b * b;
}
static int TBP2(int a, int b)
{
    return a * a + b * b;
}
int a, b, kq;
Console.Write("Nhap a: ");
a = int.Parse(Console.ReadLine());
Console.Write("Nhap b: ");
b = int.Parse(Console.ReadLine());
TBP(a, b);
TBP1(a, b, out kq);
Console.WriteLine($"Tong binh phuong la: {kq}");
Console.WriteLine($"Tong binh phuong la: {TBP2(a, b)}");
