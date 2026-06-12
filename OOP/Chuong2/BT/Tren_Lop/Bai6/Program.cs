static int Gia(int[] dsGia, int n)
{
    int tong = 0;
    for (int i = 0; i < n; i++)
    {
        if ((i + 1) % 3 == 0)
            continue;
        tong += dsGia[i];
    }
    return tong;

}
Console.Write("Nhap so luong mat hang: ");
int n = int.Parse(Console.ReadLine());
int[] dsGia = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Nhap gia cua mat hang thu {i + 1}: ");
    dsGia[i] = int.Parse(Console.ReadLine());
}
Array.Sort(dsGia);
Array.Reverse(dsGia);
Console.WriteLine($"Tong so tien phai tra la: {Gia(dsGia, n)}");