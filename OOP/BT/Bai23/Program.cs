using System;

namespace Bai23
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap chuoi cua ban: ");
            string chuoi = Console.ReadLine();
            string so = "", chu = "";
            foreach (char kt in chuoi)
            {
                if (char.IsDigit(kt))
                    so += kt + "";
                else if (char.IsLetter(kt))
                {
                    chu += kt + "";
                }
            }
            Console.WriteLine($"Chuoi so la: {so}");
            Console.WriteLine($"Chuoi chu la: {chu}");
        }
    }
}