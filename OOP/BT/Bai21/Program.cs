using System;
using System.Collections.Generic;

namespace Bai21
{
    class Program
    {
        static void Main()
        {
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "zxcvbnmasdfghjklqwertyuiop";
            Console.Write("Moi ban nhap mat khau: ");
            string mk = Console.ReadLine();
            string mkmoi = "";
            foreach (char kt in mk)
            {
                int vitri = a.IndexOf(kt);
                mkmoi += b[vitri] + "";
            }
            Console.Write($"mat khau da ma hoa: {mkmoi}");
        }
    }
}
