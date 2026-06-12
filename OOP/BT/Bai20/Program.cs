using System;
using System.Collections.Generic;

namespace Bai20
{
    class Program
    {
        static void Main()
        {
            int so = 0, kt = 0;
            bool Check = true;
            Console.Write("Moi ban nhap mat khau: ");
            string mk = Console.ReadLine();
            while (Check == true)
            {
                foreach (char c in mk)
                {
                    if (char.IsDigit(c))
                    {
                        so++;

                    }
                    else if (char.IsLetter(c))
                    {
                        kt++;
                    }
                }
                if ((so * kt != 0) && (mk.Length >= 6))
                {
                    Check = false;
                }
                else
                {
                    Console.Write("Vui long nhap lai mat khau cua ban: ");
                    mk = Console.ReadLine();
                }
            }
            Console.WriteLine($"Ban da nhap mat khau thanh cong, mat khau cua ban la: {mk}");
            int Count = 0;
            Console.Write("Nhap mat khau de login: ");
            string login = Console.ReadLine();
            while (true)
            {
                if (mk.Equals(login))
                {
                    Console.WriteLine("Dang nhap thanh cong.");
                    break;
                }
                else
                {
                    Count++;
                    if (Count < 5)
                    {
                        Console.WriteLine($"Moi ban nhap lai mat khau, ban da nhap sai {Count} lan");
                        login = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Ban da nhap sai 5 lan.");
                        break;
                    }
                }
            }
        }
    }
}
