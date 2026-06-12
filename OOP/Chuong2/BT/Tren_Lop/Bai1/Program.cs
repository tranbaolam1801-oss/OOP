static bool SNT(int x)
{
    if (x < 2)
        return false;
    for (int i = 2; i < x; i++)
    {
        if (x % i == 0)
            return false;
    }
    return true;
}
int dem = 0;
int a,b;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
for (int i = a; i <= b; i++)
{
    if (SNT(i))
        tong += 1;
}
Console.WriteLine($"Tong cac so nguyen to trong doan [a, b]: {dem}");