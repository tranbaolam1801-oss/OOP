using System;

class Triangle
{
    public int a;
    public int b;
    public int c;
    public Triangle()
    {
        a = b = c = 0;
    }
    public Triangle(int x, int y, int z)
    {
        a = x;
        b = y;
        c = z;
    }
    ~Triangle()
    {
        Console.WriteLine($"Huy tam giac");
    }
    public void Nhap()
    {
        Console.Write("Nhap canh a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Nhap canh b: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Nhap canh c: ");
        c = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"Canh a: {a}");
        Console.WriteLine($"Canh b: {b}");
        Console.WriteLine($"Canh c: {c}");
    }
    public void Chuvi()
    {
        Console.WriteLine($"Chu vi tam giac la: {a + b + c}");
    }
    public void Dientich()
    {
        double p = (a + b + c) / 2;
        Console.WriteLine($"Dien tich tam giac la: {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
    }
}
class Program
{
    static bool Latamgiac(int a, int b, int c)
    {
        if (a > 0 && b > 0 && c > 0 &&(a + b > c) && (b + c > a) && (c + a > b))
        {
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        Triangle tg = new Triangle();
        while (true)
        {
            Console.WriteLine("\n-----MENU-----");
            Console.WriteLine("Bam 0: Thoat khoi chuong trinh");
            Console.WriteLine("Bam 1: Nhap cac canh a,b,c cua tam giac");
            Console.WriteLine("Bam 2: Tinh chu vi va dien tich hinh tam giac");
            Console.WriteLine("Bam 3: Xuat ra cac gia tri a, b, c");
            Console.Write("\nBam lua chon cua ban: ");
            int chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 0:
                    Console.WriteLine("Thoat chuong trinh!"); break;
                case 1:
                    tg.Nhap();
                    break;
                case 2:
                    if (Latamgiac(tg.a, tg.b, tg.c))
                    {
                        tg.Chuvi();
                        tg.Dientich();
                    }
                    else
                        Console.WriteLine("Khong hop le!");
                    break;
                case 3:
                    tg.Xuat(); break;
                default:
                    Console.WriteLine("Lua chon cua ban khong hop le!");
                    break;
            }
            if (chon == 0)
                break;
        }
    }
}