using System;

namespace Bai2
{
    class Lecture: People
    {
        public int Kinhnghiem {get; set;}
        public string Hocvi {get; set;}
        public string Chucvu {get; set;}
        public Lecture(): base()
        {
            this.Kinhnghiem = 0;
            this.Hocvi = "";
            this.Chucvu = "";
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so nam kinh nghiem: ");
            Kinhnghiem = int.Parse(Console.ReadLine());
            Console.Write("Nhap Hoc vi: ");
            Hocvi = Console.ReadLine();
            Console.Write("Nhap chuc vu: ");
            Chucvu = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Hoc vi: {Hocvi}");
            Console.WriteLine($"Chuc vu: {Chucvu}");
            Console.WriteLine($"Kinh nghiem: {Kinhnghiem }");
        }
        public static void SapXep(List<Lecture> ds)
        {
            ds.Sort((a, b) => b.Kinhnghiem.CompareTo(a.Kinhnghiem));
            foreach (var lec in ds)
            {
                lec.Xuat();
            }
        }
    }
}