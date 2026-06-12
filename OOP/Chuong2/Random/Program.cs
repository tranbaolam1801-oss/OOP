using System;

namespace Bai2
{
    class Program
    {
        static void Main()
        {   //Random
            Random rd = new Random();
            int k1 = rd.Next(1,11);
            double k2 = rd.NextDouble();
            double k3 = k1 + k2;
            Console.WriteLine($"So ngau nhien duoc tao: {k3}");
            //Date time
            DateTime birthday = new DateTime(2006,01,18);
            Console.WriteLine("Ngay sinh cua ban la: " + birthday.ToString("dd/MM/yyyy"));
            string s = Console.ReadLine(); //Month/Day/Year
            DateTime birthday2 = DateTime.Parse(s);
            Console.WriteLine("Ngay sinh cua ban la: " + birthday2);
            Console.ReadKey();

        }
    }
}