static double Tong(int n)
{
    double tong = 0;
    for (int i = 1; i <= 2*n - 1 ; i+=2)
    {
        tong += 1.0/i;
    }
    return tong;
}
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Tong nghich dao cac so le: {Tong(n)}");


static string XOR(string A, string B)
{
    string chuoi = "";
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] == '0' && B[i] == '0')
            chuoi += "0";
        else if ((A[i] == '0' && B[i] == '1') || (A[i] == '1' && B[i] == '0'))
            chuoi += "1";
        else if (A[i] == '1' && B[i] == '1')
            chuoi += "0";        
    }
    return chuoi;
}
Console.Write("Nhap chuoi A: ");
string A = Console.ReadLine();
Console.Write("Nhap chuoi B: ");
string B = Console.ReadLine();
Console.WriteLine($"Chuoi nhi phan sau khi XOR: {XOR(A, B)}");

// static bool SoNguyenTo(int x)
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
// Console.Write("Nhap a = ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Nhap b = ");
// int b = int.Parse(Console.ReadLine());
// for (int i = a; i <= b; i++)
// {
//     if (SoNguyenTo(i))
//         dem += 1;
// }
// Console.WriteLine($"Tong cac so nguyen to trong doan [a, b]: {dem}");
