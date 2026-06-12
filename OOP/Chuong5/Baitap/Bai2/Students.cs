using System;

namespace Bai2
{
    class Students: People
    {
        public string Term {get; set;}
        public double TP1 {get; set;}
        public double TP2 {get; set;}
        public double TP3 {get; set;}
        public Students(): base()
        {
            this.Term = "";
            this.TP1 = this.TP2 = this.TP3 = 0;
        }
        public override void Nhap()
        {
            base.Nhap(); // Gọi hàm Nhap() từ lớp cha
            Console.Write("Nhap mon hoc: ");
            Term = Console.ReadLine();
            Console.WriteLine("Nhap diem TP1: ");
            TP1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem TP2: ");
            TP2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem TP3: ");
            TP3 = double.Parse(Console.ReadLine());
        }
        public string GPA()
        {
            double gpa = TP1 * 0.2 + TP2 * 0.2 + TP3 * 0.6;
            if (gpa <= 10 && gpa >= 8.5)
                return "Gioi";
            else if (gpa >= 7.0)
                return "Kha";
            else if (gpa >= 5.5)
                return "Trung binh";
            else if (gpa >= 4.0)
                return "Trung binh yeu";
            else
                return "Yeu";
        }
        public override void Xuat()
        {
            base.Xuat(); //Xuất thông tin của lớp cha
            Console.WriteLine($"Ten hoc phan: {Term}");
            Console.WriteLine($"TP1: {TP1}, TP2: {TP2}, TP3: {TP3}");
            Console.WriteLine($"Diem trung binh mon: {(TP1 * 0.2 + TP2 * 0.2 + TP3 * 0.6) :2F}, xep loai: {GPA()}");
        }
    }
}