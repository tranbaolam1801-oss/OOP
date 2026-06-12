// int[] A = new int[100];
// Console.Write("Nhap so luong sinh vien: ");
// int n = int.Parse(Console.ReadLine());
// int[] SV = new int[n];
// for (int i = 0; i < n; i++)
// {
//     Console.Write("SV{0}: ", i + 1);
//     SV[i] = int.Parse(Console.ReadLine());
// }
// // for (int i = 0; i < n; i++)
// // {
// //     Console.WriteLine($"SV {i + 1} co diem la {SV[i]}");
// // }
// int i1 = 0;
// while (i1 < n)
// {
//     Console.WriteLine($"SV {i1+1} co diem la {SV[i1]}");
//     i1++;
// }
int[,] A = new int[2,3];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write($"Nhap A[{i},{j}] = ");
        A[i,j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(A[i,j]+" ");
    }
    Console.WriteLine();
}
