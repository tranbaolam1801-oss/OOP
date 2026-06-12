using System;

namespace Bai29
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> account = new Dictionary<string, string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nhap username: ");
                string name = Console.ReadLine();
                Console.Write("Nhap password: ");
                string pass = Console.ReadLine();
                account.Add(name, pass);
            }
            //Login
            Console.Write("Vui long nhap username: ");
            string username = Console.ReadLine();
            Console.Write("Vui long nhap password: ");
            string password = Console.ReadLine();
            if (account.ContainsKey(username) == false)
            {
                Console.WriteLine("Username khong ton tai");
            }
            else
            {
                if (account[username] == password)
                {
                    Console.WriteLine("Ban da login thanh cong");
                }
                else
                {
                    Console.WriteLine("PASSWORD SAI");
                }
            }
        }
    }
}