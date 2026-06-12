static double Tong(double[] A)
{
    double tong = 0;
    foreach (double x in A)
    {
        if (x < 0)
            tong += -x;
    }
    return tong;

}
static double Tich(double[] A) 
{
    int indexmax = Array.IndexOf(A, A.Max());
    int indexmin = Array.IndexOf(A, A.Min());
    double tich = 1;
    if (indexmin < indexmax)
    {
        for (int i = indexmin + 1; i < indexmax; i++)
        {
        tich *= A[i];
        }
    }
    else
        for (int i = indexmax + 1; i < indexmin; i++)
        {
            tich *= A[i];
        }
    return tich;
}
static void Sapxep(ref double[] A) 
{
    Array.Sort(A);
}
static void Biendoi(ref double[] A, ref double[] B)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = (int)A[i];
    }
    int dem = 0;
    foreach (double x in A)
    {
        if (x % 2 == 0)
        {
            B[dem] = x;
            dem ++;
        }
    }
    foreach (double x in A)
    {
        if (x % 2 != 0)
        {
            B[dem] = x;
            dem ++;
        }
    }
}
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
// double[] A = {2, -5, 7.6, -12, 6.5, -4.5, -9.1, -3.4, 15, 1};
// double[] A = {6, 17, -1, -2.5, -8, 8.5, -3.5, 5};
double[] A = new double[n];
for (int i = 0; i < n; i++)
{
    A[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine($"\nTong = {Tong(A)}");
Console.WriteLine($"Tich = {Tich(A)}");
Sapxep(ref A);
Console.Write("A_tang = ");
foreach (double x in A) 
{
    Console.Write(x + ", ");
}
Console.WriteLine();
double[] B = new double[A.Length];
Biendoi(ref A, ref B);
Console.Write("A_biendoi = ");
foreach (double y in B)
{
    Console.Write(y + ", ");
}