static int SDG(int n)
{
    while (n > 9)
    {
        int tong = 0;
        while (n > 0)
        {
            tong += n % 10;
            n = n / 10;
        }
        n = tong;
    }
    return n;
}
Console.Write("n=");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SDG(n));
