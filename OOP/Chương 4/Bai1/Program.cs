using System;

class Phanso
{
    int Tuso;
    int Mauso;
    public int tuso
    {
        get { return Tuso; }
        set { Tuso = value; }
    }
    public int mauso
    {
        get { return Mauso; }
        set
        {
            if (value != 0)
                Mauso = value;
        }
    }
    public Phanso()
    {
        Tuso = 0;
        Mauso = 1;
    }
    ~Phanso()
    {
        Console.WriteLine($"Huy phan so {Tuso}/{Mauso}");
    }
    public void Nhap()
    {
        Console.Write("Nhap tu so: ");
        tuso = int.Parse(Console.ReadLine());
        while (true)
        {
            Console.Write("Nhap mau so: ");
            mauso = int.Parse(Console.ReadLine());
            if (mauso == 0)
            {
                Console.WriteLine("Mau so khong hop le!\nVui long nhap lai!");
            }
            else
                break;
        }
    }
    int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int c = a % b;
            a = b;
            b = c;
        }
        return a;
    }
    void Rutgon()
    {
        int ucln = UCLN(Math.Abs(Tuso), Math.Abs(Mauso));
        Tuso /= ucln;
        Mauso /= ucln;
        if (Mauso < 0)
        {
            Tuso = -Tuso;
            Mauso = -Mauso;
        }
    }
    public void Xuat()
    {
        Rutgon();
        if (Mauso == 0)
            Console.WriteLine($"{Tuso}");
        else
            Console.WriteLine($"{Tuso}/{Mauso}");
    }
    public Phanso(int Tu, int Mau)
    {
        tuso = Tu;
        mauso = Mau;
        Rutgon();
    }
    public Phanso Cong(Phanso B)
    {
        int tu = this.tuso * B.mauso + this.mauso * B.tuso;
        int mau = this.mauso * B.mauso;
        return new Phanso(tu, mau);
    }
    public Phanso Tru(Phanso B)
    {
        int tu = this.tuso * B.mauso - this.mauso * B.tuso;
        int mau = this.mauso * B.mauso;
        return new Phanso(tu, mau);
    }
    public Phanso Nhan(Phanso B)
    {
        int tu = this.tuso * B.tuso;
        int mau = this.mauso * B.mauso;
        return new Phanso(tu, mau);
    }
    public Phanso Chia(Phanso B)
    {
        int tu = this.tuso * B.mauso;
        int mau = this.mauso * B.tuso;
        return new Phanso(tu, mau);
    }
}
class Program
{
    static void Main()
    {
        Phanso A = new Phanso();
        A.Nhap();
        Phanso B = new Phanso();
        B.Nhap();
        Console.Write("\nPhan so A la: ");
        A.Xuat();
        Console.Write("Phan so B la: ");
        B.Xuat();
        Console.Write("Tong cua 2 phan so A va B la: ");
        Phanso C = A.Cong(B);
        C.Xuat();
        Console.Write("Hieu cua 2 phan so A va B la: ");
        Phanso D = A.Tru(B);
        D.Xuat();
        Console.Write("Tich cua 2 phan so A va B la: ");
        Phanso E = A.Nhan(B);
        E.Xuat();
        if (B.tuso == 0)
        {
            Console.WriteLine("Khong the thuc hien duoc phep chia!");
        }
        else
        {
            Console.Write("Thuong cua 2 phan so A va B la: ");
            Phanso F = A.Chia(B);
            F.Xuat();
        }
    }
}