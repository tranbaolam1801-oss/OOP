static int TongTien(int[] A, int n)
{
    Array.Sort(A);
    Array.Reverse(A);
    int tong = 0;
    int giamgia = n / 3;
    int conlai = n % 3;
    if (conlai == 0)
    {
        for (int i = 0; i < (n - giamgia); i++)
        {
            tong += A[i];
        }
    }
    else
    {
        for (int i = 0; i < n - (giamgia + conlai); i++)
        {
            tong += A[i];
        }
        for (int j = n - conlai; j < n; j++)
        {
            tong += A[j];
        }
    }
    return tong;
}
Console.Write("n=");
int n = int.Parse(Console.ReadLine());
Console.Write("Gia tri lan luot cac mat hang la: ");
string nhap = Console.ReadLine();
string[] chuoi = nhap.Split(' ');
int[] A = new int[n];
for (int i = 0; i < n; i++)
{
    A[i] = int.Parse(chuoi[i]);
}
Console.WriteLine($"Tong so tien phai tra la: {TongTien(A, n)}");