using System;
using System.Collections.Generic;

namespace Bai26
{
    class Program
    {
        static void Main()
        {
            List<string> quest = new List<string>() {"2 + 5 + 7 =", "5 + 10 =", " sqrt(16) =", "12 % 2 =", "5 // 2 ="};
            List<int> answer = new List<int>(){14, 15, 4, 0, 2};
            for (int i = 0; i < quest.Count; i++)
            {
                Console.WriteLine("Nhap cau tra loi: ");
                Console.Write(quest[i] + " ");
                int kq = int.Parse(Console.ReadLine());
                if (kq == answer[i])
                {
                    Console.WriteLine("You did it right");
                }
                else
                {
                    Console.WriteLine("Wrong, the answer is " + answer[i]);
                }
            }
            Console.ReadKey();
        }
    }
}