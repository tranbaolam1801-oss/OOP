using System;
using System.Collections.Generic;

namespace Bai28
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            List<int> ds = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                ds.Add(int.Parse(Console.ReadLine()));
            }
            int max2 = int.MinValue, min2 = int.MaxValue;
            int max = ds.Max(), min = ds.Min();
            foreach(int x in ds)
            {
                if (max2 < x && x < max)
                {
                    max2 = x;
                }
                if (min < x && x < min2)
                {
                    min2 = x;
                }
            }
            Console.WriteLine($"So lon thu 2: {max2}, vi tri index trong list la {ds.IndexOf(max2)}");
            Console.WriteLine($"So nho thu 2: {min2}, vi tri index trong list la {ds.IndexOf(min2)}");
            Console.ReadKey();
        }
    }
}