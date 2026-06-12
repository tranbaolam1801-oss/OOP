// namespace Ham;

// class Program
// {
//     // Bai toan hoan vi
//     static void HoanVi(ref int x, ref int y)
//     {
//         int z;
//         z = x;
//         x = y;
//         y = z;
//     }
//     static void Main(string[] args)
//     {
//         int x = 5, y = 10;
//         HoanVi(ref x, ref y);
//         Console.WriteLine($"x = {x}, y = {y}");
//     }
// }
// static bool SNT(int x)
// {
//     if (x < 2)
//         return false;
//     for (int i = 2; i < x; i++)
//     {
//         if (x % i == 0)
//             return false;
//     }
//     return true;
// }
// int dem = 0;
// int a,b;
// a = int.Parse(Console.ReadLine());
// b = int.Parse(Console.ReadLine());
// for (int i = a; i <= b; i++)
// {
//     if (SNT(i))
//         tong += 1;
// }
// Console.WriteLine($"Tong cac so nguyen to trong doan [a, b]: {dem}");
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