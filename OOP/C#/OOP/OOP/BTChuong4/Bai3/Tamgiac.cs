namespace Bai3;

class Program
{
    static void Main(string[] args)
    {
        Tamgiac tg = new Tamgiac();
        tg.Nhap();
        tg.Xuat();
    }
}
class Tamgiac
{
    private double a;
    private double b;
    private double c;
    public double A
    {
        get { return a;}
        set { a = value;}
    }
    public double B
    {
        get { return b;}
        set { b = value;}
    }
    public double C
    {
        get { return c;}
        set { c = value;}
    }
    //khoi tao
    // public Tamgiac(double a, double b, double c)
    // {
    //     this.a=a;
    //     this.b=b;
    //     this.c=c;
    // }
    public Tamgiac()
    {
        A=0;
        B=0;
        C=0;
    }
    ~Tamgiac()
    {

    }
    public void Nhap()
    {
        Console.Write("Nhap canh a: ");
        A = double.Parse(Console.ReadLine());
        Console.Write("Nhap canh b: ");
        B = double.Parse(Console.ReadLine());
        Console.Write("Nhap canh c: ");
        C = double.Parse(Console.ReadLine());
    }
    public string KiemTra()
    {
        if ((A + B > C) && (A + C > B) && (B + C > A) && (A > 0) && (B > 0) && (C > 0))
        {
            if ((A == B) && (B == C) && (A == C))
            {
                return "Tam giac deu";
            }
            else if (((A * A + B * B == Math.Round(C * C)) && (A == B)) || ((A * A + C * C == Math.Round(B * B)) && (A == C)) || ((B * B + C * C == Math.Round(A * A)) && (B == C)))
            {
                return "Tam giac vuong can";
            }
            else if ((A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == A * A + B * B))
            {
                return "Tam giac vuong";
            }
            else if ((A == B) || (A == C) || (B == C))
            {
                return "Tam giac can";
            }
            else
            {
                return "Tam giac thuong";
            }
        }
        else
        {
            return "Khong phai la tam giac";
        }
    }
    public void Xuat()
    {
        Console.WriteLine($"\n--> {KiemTra()}");
    }


}