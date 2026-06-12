namespace Phanso
{
    class Program
    {
        static void Main()
        {
            double cong, tru, nhan, chia;
            Phanso A = new Phanso();
            Phanso B = new Phanso();
            Console.WriteLine("Nhap phan so A: ");
            A.Nhap();
            Console.WriteLine("Nhap phan so B: ");
            B.Nhap();
            if (Phanso.KT(A.mauso, B.mauso))
            {
                cong = Phanso.Cong(A.tuso, A.mauso, B.tuso, B.mauso);
                tru = Phanso.Tru(A.tuso, A.mauso, B.tuso, B.mauso);
                nhan = Phanso.Tich(A.tuso, A.mauso, B.tuso, B.mauso);
                chia = Phanso.Chia(A.tuso, A.mauso, B.tuso, B.mauso);
                A.Xuat(cong,tru, nhan,chia);
            }
            else Console.WriteLine("Loi !!!");
        }

    }
    class Phanso
    {
        public int tuso;
        public int mauso;
     
        public Phanso() 
        {

        }
        ~Phanso() 
        {
            
        }
        public void Nhap()
        {
            Console.Write("Nhap Tu so: ");
            tuso=Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Mau so: ");
            mauso = Convert.ToInt32(Console.ReadLine());
        }
        public static bool KT(int b, int d)
        {
            return (b != 0 && d!=0);
        }
        public static double Cong(int a, int b,int c, int d)
        {
            return (double)((a * d) + (c * b)) / (b * d);
        }
        public static double Tru(int a, int b, int c, int d)
        {
            return (double)((a*d)-(c*b)) / (b * d);
        }
        public static double Tich(int a, int b, int c, int d)
        {
            return (double) (a * c) / (b * d);
        }
        public static double Chia(int a, int b, int c, int d)
        {
            return (double)(a * d) / (b * c);
        }
        public void Xuat(double a, double b, double c, double d)
        {
            Console.WriteLine($"Ket qua: \nCong= {a}\nTru= {b}\nNhan= {c}\nChia= {d}");
        }

    }
}
