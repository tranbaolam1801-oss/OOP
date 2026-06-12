static bool UCLN(int a, int b)
{
    while (b !=0 )
    {
        int c = a % b;
        a = b;
        b = c;
    }
    if (a == 1)
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
                dem ++;
        }
    }
    return dem;
}
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
string nhap = Console.ReadLine();
string[] chuoi = nhap.Split(' ');
int[] A = new int[n];
for (int i = 0; i < n; i++)
{
    A[i] = int.Parse(chuoi[i]);
}
Console.WriteLine(SNTCungNhau(A, n));