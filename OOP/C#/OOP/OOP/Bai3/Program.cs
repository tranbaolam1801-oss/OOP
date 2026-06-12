using System.Globalization;

namespace Bai3;

class Program
{
    static void Main(string[] args)
    {
        int n,m;
        n=Convert.ToInt32(Console.ReadLine());
        m=Convert.ToInt32(Console.ReadLine());
        int[,] A= new int [n,m];
        {
            for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = int.Parse(Console.ReadLine());
        }
        }
            for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                 Console.Write(A[i, j] + " ");
            }
                Console.WriteLine();
}
        }
    }
    
}
