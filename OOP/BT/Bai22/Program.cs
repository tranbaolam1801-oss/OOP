using System;
using System.Collections.Generic;

namespace Bai22
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string a = @"
            tôi chăm học
            tôi chịu khó
            tôi đẹp zai";
            string[] dstu = a.Split();
            int dem = 0;
            foreach (string tu in dstu)
            {
                if ( tu == "tôi")
                {
                    dem++;
                }
            }
            Console.WriteLine($"Số từ tôi: {dem}");
        }
    }
}