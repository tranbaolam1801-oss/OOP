using System;
using System.Collections.Generic;
using System.Linq; //Dùng để gọi hàm Sum

namespace Bai30
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>()
            {
                {"A", 1}, {"B", 2}, {"C", 3}, {"D", 2}, {"E", 1}, {"F", 4}, {"G", 2},
                {"H", 4}, {"I", 1}, {"J", 8}, {"K", 5}, {"L", 1}, {"M", 3}, {"N", 1}, 
                {"O", 1}, {"P", 3}, {"Q", 10}, {"R", 1}, {"S", 1}, {"T", 1}, {"U", 1},
                {"V", 4}, {"W", 4}, {"X", 8}, {"Y", 4}, {"Z", 10}
            };
            List<string> dsKT = dic.Keys.ToList();
            Console.Write("Chuoi ki tu sau tach la: ");
            foreach (string kt in dsKT)
            {
                Console.Write(kt + " ");
            }
            List<int> dsSo = dic.Values.ToList();
            Console.Write("\nChuoi ki tu sau tach la: ");
            foreach (int i in dsSo)
            {
                Console.Write(i + " ");
            }
            int Tong = dsSo.Sum();
            Console.WriteLine($"\nTong cac so la: {Tong}");
            string chuoi = "University of Technology and Education";
            chuoi = chuoi.ToUpper();
            Console.WriteLine(chuoi);
            string chuoi1 = "";
            foreach (char kt in chuoi)
            {
                if (dic.ContainsKey(kt.ToString()))
                {
                    chuoi1 += dic[kt.ToString()];
                }
                else
                {
                    chuoi1 += kt;
                }
            }
            Console.WriteLine(chuoi1);
        }
    }
}