static bool UCLN(int x, int y)
{
    while (y != 0)
    {
        int c = x % y;
        x = y;
        y = c;
    }
    if (x == 1)
        return true;
    else
        return false;
}
static int SNTCungNhau(int[] A, int n)
{
    int dem = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (UCLN(A[i], A[j]))
                dem += 1;
        }
    }
    return dem;
}
Console.Write("Nhap so luong phan tu: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Nhap day so: ");
string nhap = Console.ReadLine();
string[] day_so = nhap.Split(' ');
int[] Day_So = new int[n];
for (int i = 0; i < n; i++)
{
    Day_So[i] = int.Parse(day_so[i]);
}
Console.WriteLine($"So cap so nguyen to cung nhau la: {SNTCungNhau(Day_So, n)}");