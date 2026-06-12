using System;
using System.Collections.Generic;
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Students> DsStudent = new List<Students>();
            // Console.Write("Nhap so luong sinh vien: ");
            // int n = int.Parse(Console.ReadLine());
            // for (int i = 0; i < n; i++)
            // {
            //     Console.WriteLine($"\nNhap thong tin cua sinh vien thu {i + 1}: ");
            //     Students student = new Students();
            //     student.Nhap();
            //     DsStudent.Add(student);
            // }
            // Console.WriteLine("\n-----DANH SACH SINH VIEN-----");
            // foreach (var student in DsStudent)
            // {
            //     student.Xuat();
            // }
            List<Lecture> dsLecture = new List<Lecture>();
            Console.Write("Nhap so luong giang vien: ");
            int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine($"Nhap thong tin cua giang vien thu {j + 1}");
                Lecture giangvien = new Lecture();
                giangvien.Nhap();
                dsLecture.Add(giangvien);
            }
            Console.WriteLine("-----DANH SACH GIANG VIEN-----");
            Lecture.SapXep(dsLecture);
        }
    }
}