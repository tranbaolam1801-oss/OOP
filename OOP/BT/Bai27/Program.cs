using System;
using System.Collections.Generic;

namespace Bai27
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            List<int> ds = new List<int>();
            for (int i = 0; i < n; i ++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                ds.Add(int.Parse(Console.ReadLine()));
            }
            int dem = 0;
            List<int> index = new List<int>();

            for (int j = 0; j < n; j++)
            {
                if (ds[j] < 5)
                {
                    dem++;
                    index.Add(j);
                }
            }
            Console.WriteLine($"Co {dem} so nho hon 5");
            Console.Write("Index cac so nho hon 5: ");
            foreach (int k in index)
            {
                Console.Write(k + ", ");
            }
            Console.ReadKey();
        }
    }
}