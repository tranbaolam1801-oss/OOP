static void DiemLN(int[,] A, int n)
{
    int[] dsDiem = new int[n];
    for (int i = 0; i < n; i++)
    {
        int diem = 0;
        for (int j = 0; j < n; j++)
        {
            diem += A[i, j];
        }
        dsDiem[i] = diem;
    }
    int diemmax = dsDiem.Max();
    Console.Write("Doi bong co diem cao nhat: ");
    for (int i = 0; i < dsDiem.Length; i++)
    {
        if (dsDiem[i] == diemmax)
        {
            Console.Write((i+1) + " ");
        }
    }
    Console.WriteLine();
}
static void Thang(int[,] A, int n)
{
    int[] SoTranThang = new int[n];
    for (int i = 0; i < n; i++)
    {
        int dem = 0;
        for (int j = 0; j < n; j++)
        {
            if (i == j)
                continue;
            if (A[i, j] == 3)
                dem += 1;
            else if (A[i, j] == 0)
                dem -= 1;
        }
        SoTranThang[i] = dem;
    }
    Console.Write("Doi bong co so tran thang nhieu hon: ");
    for (int i = 0; i < n; i++)
    {
        if (SoTranThang[i] > 0                                                          )
        {
            Console.Write((i + 1) + " ");
        }
    }
    Console.WriteLine();
}
static void KhongThua(int[,] A, int n) 
{
    bool[] dsKT = new bool[n];
    for (int i = 0; i < n; i++)
    {
        bool kt = true;
        for (int j = 0; j < n; j++)
        {
            if (i == j)
                continue;
            if (A[i, j] == 0)
                kt = false;
        }
        dsKT[i] = kt;
    }
    Console.Write("Doi bong khong thua tran nao: ");
    for (int i = 0; i < n; i++)
    {
        if (dsKT[i])
            Console.Write((i + 1) + " ");
    }
    Console.WriteLine();
}
Console.Write("Nhap so luong doi bong: ");
int n = int.Parse(Console.ReadLine());
int[,] A = new int[n, n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Nhap diem cua doi thu {i + 1}:");
    for (int j = 0; j < n; j++)
    {
        A[i, j] = int.Parse(Console.ReadLine());
    }
}
DiemLN(A, n);
Thang(A, n);
KhongThua(A, n);