using System;

class SoPhuc
{
    double PhanThuc;
    double PhanAo;
    public double thuc
    {
        get { return PhanThuc; }
        set { PhanThuc = value; }
    }
    public double ao
    {
        get { return PhanAo; }
        set { PhanAo = value; }
    }
    public SoPhuc()
    {
        PhanThuc = PhanAo = 0;
    }
    ~SoPhuc()
    {
        Console.WriteLine("Huy so phuc");
    }
    public void Nhap()
    {
        Console.Write("Nhap phan thuc: ");
        thuc = double.Parse(Console.ReadLine());
        Console.Write("Nhap phan ao: ");
        ao = double.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        if (ao > 0)
            Console.WriteLine($"{thuc} + {ao}i");
        else if (ao < 0)
            Console.WriteLine($"{thuc} - {ao}i");
        else
            Console.WriteLine($"{thuc}");
    }
    public SoPhuc Cong(SoPhuc z2)
    {
        SoPhuc z3 = new SoPhuc();
        z3.thuc = this.thuc + z2.thuc;
        z3.ao = this.ao + z2.ao;
        return z3;
    }
    public SoPhuc Tru(SoPhuc z2)
    {
        SoPhuc z3 = new SoPhuc();
        z3.thuc = this.thuc - z2.thuc;
        z3.ao = this.ao - z2.ao;
        return z3;
    }
    public SoPhuc Nhan(SoPhuc z2)
    {
        SoPhuc z3 = new SoPhuc();
        z3.thuc = this.thuc * z2.thuc - this.ao * z2.ao;
        z3.ao = this.thuc * z2.ao + this.ao * z2.thuc;
        return z3;
    }
    public SoPhuc Chia(SoPhuc z2)
    {
        SoPhuc z3 = new SoPhuc();
        double mau = z2.thuc * z2.thuc + z2.ao * z2.ao;
        z3.thuc = Math.Round((this.thuc * z2.thuc + this.ao * z2.ao) / mau, 2);
        z3.ao = Math.Round((z2.thuc * this.ao - this.thuc * z2.ao) / mau, 2);
        return z3;
    }
}
class Program
{
    static void Main()
    {
        SoPhuc z1 = new SoPhuc();
        Console.WriteLine("Nhap so phuc A:");
        z1.Nhap();
        SoPhuc z2 = new SoPhuc();
        Console.WriteLine("Nhap so phuc B:");
        z2.Nhap();
        Console.Write("So phuc A la: ");
        z1.Xuat();
        Console.Write("So phuc B la: ");
        z2.Xuat();
        SoPhuc cong = z1.Cong(z2);
        Console.Write("Tong 2 so phuc A va B la: ");
        cong.Xuat();
        SoPhuc tru = z1.Tru(z2);
        Console.Write("Hieu 2 so phuc A va B la: ");
        tru.Xuat();
        SoPhuc nhan = z1.Nhan(z2);
        Console.Write("Tich 2 so phuc A va B la: ");
        nhan.Xuat();
        SoPhuc chia = z1.Chia(z2);
        Console.Write("Thuong 2 so phuc A va B la: ");
        chia.Xuat();
    }
}