namespace DiemSo
{
    class program
    {
        static void Main()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n;
            n=Convert.ToInt32(Console.ReadLine());
            TTSV[] sv = new TTSV[n];
            Diemtp[] point = new Diemtp[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin sinh vien {i+1}:");
                sv[i] = new TTSV();
                sv[i].Nhaptt();
                point[i] = new Diemtp();
                point[i].Nhapdiem();
            }
            Console.WriteLine($"Thong tin cua {n} sinh vien. ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"- Thong tin sinh vien thu {i+1}:");
                sv[i].Xuat();
                point[i].Xuat();
                Console.WriteLine("");
            }
            
        }
    }
    class TTSV
    {
        private string id;
        private string hoten;
        private string group;
        public string ID
        { 
            get{return id; }
            set {id = value; }
        }
        public string Hoten
        {  
            get {return hoten;}
            set {hoten = value;}
        }
        public string Group
        { 
            get {return group;}
            set {group = value;}
        }
        public void Nhaptt()
        {
            Console.Write("Nhap ID: ");
            ID=Console.ReadLine();
            Console.Write("Nhap Ho ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap Lop sinh hoat: ");
            Group = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine($"ID: {ID}\nHo ten: {Hoten}\nLop sinh hoat: {Group}");
        }

    }
    class Diemtp
    {
        private double tp1;
        private double tp2;
        private double tp3;
        public double TP1
        {  get => tp1;
        set => tp1 = value;}
        public double TP2
        { get => tp2;
        set => tp2 = value;}
        public double TP3
        { get => tp3;
        set => tp3 = value;}
        public void Nhapdiem()
        {
            Console.Write("Nhap diem TP1: ");
            TP1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem TP2: ");
            TP2=Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem TP3: ");
            TP3 = Convert.ToDouble(Console.ReadLine());
        }
        public static  double DTB(double TP1, double TP2, double TP3)
        {
            return TP1*0.1+TP2*0.3+TP3*0.6;
        }
        public void Xuat()
        {
            double dtb = DTB(TP1, TP2, TP3);
            Console.WriteLine($"Diem TB: {dtb}");
        }
    }
}
