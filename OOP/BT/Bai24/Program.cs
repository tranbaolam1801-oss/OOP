using System;
using System.Collections.Generic;

namespace Bai24
{
    class Program
    {
        static void Main()
        {
            Console.Write("Moi ban nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            List<int> ds = new List<int>();
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                ds.Add(rd.Next(1, 101));
            }
            Console.Write("Danh sach vua tao ra la: ");
            foreach (int j in ds)
            {
                Console.Write(j + " ");
            }
        }
    }
}