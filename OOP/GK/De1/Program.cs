using System;
using System.Collections.Generic;

namespace De1
{
    class Student
    {
        public string StudentID{get; set;}
        public string StudentName{get; set;}
        public string DateOfBirth{get; set;}
        public string Address{get; set;}
        public double GPA{get; set;}
        public int CompletedCredits{get; set;}
        public void InputStudentInfo()
        {
            Console.Write("Nhap ma sinh vien: ");
            StudentID = Console.ReadLine();
            Console.Write("Nhap ten sinh vien: ");
            StudentName = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            DateOfBirth = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            Address = Console.ReadLine();
            Console.Write("Nhap GPA: ");
            GPA = double.Parse(Console.ReadLine());
            Console.Write("Nhap so tin chi da hoan thanh: ");
            CompletedCredits = int.Parse(Console.ReadLine());
        }
        public int CalculateRemainingCredits(int totalCredits)
        {
            return totalCredits - CompletedCredits;
        }
        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Ma sinh vien: {StudentID}");
            Console.WriteLine($"Ten sinh vien: {StudentName}");
            Console.WriteLine($"Ngay sinh: {DateOfBirth}");
            Console.WriteLine($"Dia chi: {Address}");
            Console.WriteLine($"Diem trung binh: {GPA}");
            Console.WriteLine($"So tin chi da hoan thanh: {CompletedCredits}");
        }
    }
    class StudentManager
    {
        List<Student> AllStudent = new List<Student>();
        public void AddStudent()
        {
            Student student = new Student();
            Console.WriteLine("\nNhap thong tin cua sinh vien: ");
            student.InputStudentInfo();
            AllStudent.Add(student);
        }
        public void DisplayAllStudent()
        {
            foreach (var student in AllStudent)
            {
                student.DisplayInfo();
            }
        }
        public void RemainingCredits(int totalCredits)
        {
            foreach (var student in AllStudent)
            {
                Console.WriteLine($"\nSinh vien {student.StudentName} con {student.CalculateRemainingCredits(totalCredits)} tin chi.");
            }
        }
        public void SearchGPA(double minGPA)
        {
            Console.WriteLine("\n---DANH SACH SINH VIEN CO DIEM TRUNG BINH LON HON MIN GPA---");
            foreach(var student in AllStudent)
            {
                if (student.GPA >= minGPA)
                    student.DisplayInfo();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            do
            {
                Console.Write("Nhap so luong sinh vien: ");
                m = int.Parse(Console.ReadLine());
                if (m <= 0)
                    Console.WriteLine("Khong hop le, so luong phai lon hon 0!");
            } while (m <= 0);
            StudentManager DanhsachSV = new StudentManager();
            Console.WriteLine($"Nhap thong tin cho {m} sinh vien:");
            for (int i = 0; i < m; i++)
            {
                DanhsachSV.AddStudent();
            }
            Console.WriteLine("\n---DANH SACH SINH VIEN DA NHAP---");
            DanhsachSV.DisplayAllStudent();
            Console.Write("\nTong so tin chi can hoan thanh de tot nghiep: ");
            int totalCredits = int.Parse(Console.ReadLine());
            Console.WriteLine("So tin chi con lai cua cac sinh vien: ");
            DanhsachSV.RemainingCredits(totalCredits);
            Console.Write("\nDiem trung binh toi thieu: ");
            double minGPA = double.Parse(Console.ReadLine());
            DanhsachSV.SearchGPA(minGPA);
        }
    }
}