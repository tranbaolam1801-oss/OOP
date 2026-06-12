static int SDG(int n)
{
    while (n > 9)
    {
        int tong = 0;
        while (n > 0)
        {
            tong += n % 10;
            n /= 10;
        }
        n = tong;
    }
    return n;
}
Console.Write("Nhap N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"So don gian la: {SDG(N)}");
