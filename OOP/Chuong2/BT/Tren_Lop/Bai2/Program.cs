static double Tong(int n)
{
    double tong = 0;
    for (int i = 2; i <= 2*n; i+=2)
    {
        tong += (1.0/(i -1));
    }
    return tong;
}
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Tong nghich dao cac so le: {Tong(n)}");