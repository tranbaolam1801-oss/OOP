using System;
using System.ComponentModel;

class Tamgiac
{
    double canhA;
    double canhB;
    double canhC;
    public double a
    {
        get { return canhA; }
        set { canhA = value; }
    }
    public double b
    {
        get { return canhB; }
        set { canhB = value; }
    }
    public double c
    {
        get { return canhC; }
        set { canhC = value; }
    }
    public Tamgiac()
    {
        canhA = canhB = canhC = 0;
    }
    ~Tamgiac()
    {
        Console.WriteLine($"Huy tam giac");
    }
    public void Nhap()
    {
        Console.Write("Nhap canh a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Nhap canh b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Nhap canh c: ");
        c = double.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"Tam giac co canh a = {a}, b = {b}, c = {c}");
    }
    bool laTamgiac(double a, double b, double c)
    {
        if (a > 0 && b > 0 && c > 0 && (a + b) > c && (b + c) > a && (a + c) > b)
            return true;
        return false;
    }
    bool vuong(double a, double b, double c)
    {
        if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            return true;
        return false;
    }
    bool can(double a, double b, double c)
    {
        if (a == b || a == c || b == c)
            return true;
        return false;
    }
    bool deu(double a, double b, double c)
    {
        if (a == b && b == c)
            return true;
        return false;
    }
    public void Kiemtra()
    {
        if (laTamgiac(a, b, c))
            if (vuong(a, b, c) && can(a, b, c))
                Console.WriteLine("Tam giac vuon can");
            else if (vuong(a, b, c))
                Console.WriteLine("Tam giac vuong");
            else if (deu(a, b, c))
                Console.WriteLine("Tam giac deu");
            else if (can(a, b, c))
                Console.WriteLine("Tam giac can");
            else
                Console.WriteLine("Tam giac thuong");
        else
            Console.WriteLine("Ba canh khong the tao thanh tam giac");
    }
}
class Program
{
    static void Main()
    {
        Tamgiac tg1 = new Tamgiac();
        tg1.Nhap();
        tg1.Xuat();
        tg1.Kiemtra();
    }
}