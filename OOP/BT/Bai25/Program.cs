using System;
using System.Collections.Generic;

namespace Bai22
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            List<int> ds = new List<int>();
            for ( int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                ds.Add(int.Parse(Console.ReadLine()));
            }
            List<double> bp = new List<double>();
            int dem = 0;
            foreach (int i in ds)
            {
                double x = Math.Pow(i, 2);
                bp.Add(x);
                if (x > 50)
                    dem++;
            }
            Console.Write("Danh sach binh phuong: ");
            foreach (double j in bp)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine($"\nCo {dem} phan tu lon hon 50");

        }
    }
}