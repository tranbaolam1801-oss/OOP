namespace People
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Students
            Students sv = new Students();
            Console.Write("Nhap thong tin sinh vien: ");
            sv.Nhap();
            sv.Xuat();

            //Lecture
            List<Lecture> lectures = new List<Lecture>();
            string check;
            do
            {
                Lecture lecture = new Lecture();
                Console.Write("Nhap thong tin giang vien: ");
                lecture.Nhap();
                lectures.Add(lecture);
                Console.Write("Neu muon nhap tiep hay bam 'y': ");
                check = Console.ReadLine().ToLower();
            }
            while (check == "y");

            Console.WriteLine("\n--- Thong tin giang vien truoc khi sap xep ---");
            foreach (var l in lectures) l.Xuat();

            Console.WriteLine("\n--- Thong tin giang vien sau khi sap xep ---");
            List<Lecture> sortLectures = Lecture.SapXep(lectures);
            foreach (var l in sortLectures) l.Xuat();
        }
    }

    public class People
    {
        public string ID { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }

        public People() { }
        public People(string id, string hoTen, int tuoi, string diaChi)
        {
            ID = id;
            HoTen = hoTen;
            Tuoi = tuoi;
            DiaChi = diaChi;
        }

        public void Nhap()
        {
            Console.Write("\nNhap ID: ");
            ID = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine($"\n[ID: {ID}] - Ho ten: {HoTen} - {Tuoi} tuoi - Dia chi: {DiaChi}");
        }

        ~People() { }
    }

    public class Students : People
    {
        public string Term { get; set; }
        public double TP1 { get; set; }
        public double TP2 { get; set; }
        public double TP3 { get; set; }

        public Students() : base() { }
        public Students(string id, string hoTen, int tuoi, string diaChi, string term, double tp1, double tp2, double tp3) : base(id, hoTen, tuoi, diaChi)
        {
            Term = term;
            TP1 = tp1;
            TP2 = tp2;
            TP3 = tp3;
        }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ten hoc phan: ");
            Term = Console.ReadLine();
            Console.Write("\tNhap diem thanh phan 1: ");
            TP1 = double.Parse(Console.ReadLine());
            Console.Write("\tNhap diem thanh phan 2: ");
            TP2 = double.Parse(Console.ReadLine());
            Console.Write("\tNhap diem thanh phan 3: ");
            TP3 = double.Parse(Console.ReadLine());
        }
        public (double GPA, string XepLoai) KetQuaHocTap()
        {
            double GPA = Math.Round((TP1 + TP2 + TP3) / 3, 1);
            string xepLoai;
            if (GPA >= 8.5) xepLoai = "Xuat sac";
            else if (GPA >= 7.0) xepLoai = "Gioi";
            else if (GPA >= 5.5) xepLoai = "Kha";
            else if (GPA >= 4.0) xepLoai = "Trung binh";
            else xepLoai = "Yeu";
            return (GPA, xepLoai);
        }
        public new void Xuat()
        {
            base.Xuat();
            var (GPA, xepLoai) = KetQuaHocTap();
            Console.WriteLine($"\tDiem hoc phan: {Term}\n\tTP1\tTP2\tTP3");
            Console.WriteLine($"\t{TP1}\t{TP2}\t{TP3}");
            Console.WriteLine($"\t--> GPA: {GPA} | Xep loai: {xepLoai}");
        }

        ~Students() { }
    }

    public class Lecture : People
    {
        public int KinhNghiem { get; set; }
        public string HocVi { get; set; }
        public string ChucVu { get; set; }

        public Lecture() : base() { }
        public Lecture(string id, string hoTen, int tuoi, string diaChi, int kinhNghiem, string hocVi, string chucVu) : base(id, hoTen, tuoi, diaChi)
        {
            KinhNghiem = kinhNghiem;
            HocVi = hocVi;
            ChucVu = chucVu;
        }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap kinh nghiem: ");
            KinhNghiem = int.Parse(Console.ReadLine());
            Console.Write("Nhap chuc vu (ThS/TS/...): ");
            HocVi = Console.ReadLine();
            Console.Write("Nhap chuc vu (Truong BM/Truong khoa/...): ");
            ChucVu = Console.ReadLine();
        }
        public static List<Lecture> SapXep(List<Lecture> lectures)
        {
            return new (lectures.OrderBy(l => l.KinhNghiem));
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Kinh nghiem: {KinhNghiem} | Hoc vi: {HocVi} | Chuc vu: {ChucVu}");
        }

        ~Lecture() { }
    }
}