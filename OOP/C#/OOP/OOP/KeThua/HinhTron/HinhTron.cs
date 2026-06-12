namespace HinhTron;

public class HinhTron
{
    public double bankinh { get; set; }
    public double duongkinh { get{return bankinh*2;}}
    public double dientich { get{return Math.PI*bankinh*bankinh;}}

    public HinhTron(double r)
    {
        this.bankinh = r;
    }
}
public class HinhCau : HinhTron
{
    public new double dientich{ get{return 4*Math.PI*bankinh*bankinh;}}
    public double Thetich{ get{return 4/3*Math.PI*bankinh*bankinh*bankinh;}}
    public HinhCau(double r):base(r) {}
}
public class HinhTruTron : HinhTron
{   
    public double chieucao   {get;set;}
    public double chuvi{ get{return Math.PI*duongkinh;}}
    public  double dientichday { get{return Math.PI*bankinh*bankinh;}}
    public double dientichxungquanh{ get{return Math.PI*duongkinh*chieucao;}}
    public double dientichtoanphan{ get{return dientichxungquanh+ 2*dientichday; }}
    public double Thetich  {get{return dientichday*chieucao;}}
    public HinhTruTron(double r,double h):base(r)
     {
        chieucao = h;
     }
}
class Program
{
    static void Main(string[] args)
    {
        HinhTron hinhtron= new HinhTron(5);
        Console.WriteLine($"Dien tich hinh tron : {Math.Round(hinhtron.dientich,2)}");
        Console.WriteLine($"Duong kinh hinh tron : {Math.Round(hinhtron.duongkinh,2)}");
        HinhCau hinhcau= new HinhCau(10);
        Console.WriteLine($"Dien tich hinh cau : {Math.Round(hinhcau.dientich,2)}");
        Console.WriteLine($"The tich hinh cau : {Math.Round(hinhcau.Thetich,2)}");
        HinhTruTron hinhtrutron= new HinhTruTron(7,10);
        Console.WriteLine($"Dien tich mat day hinh tru tron : {Math.Round(hinhtrutron.dientichday,2)}");
        Console.WriteLine($"Dien tich xung quanh hinh tru tron : {Math.Round(hinhtrutron.dientichxungquanh,2)}");
        Console.WriteLine($"Dien tich toan phan hinh tru tron : {Math.Round(hinhtrutron.dientichtoanphan,2)}");
        Console.WriteLine($"The tich hinh tru tron : {Math.Round(hinhtrutron.Thetich,2)}"); 
    }
}
