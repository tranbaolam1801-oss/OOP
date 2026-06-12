using System;

abstract class Plant
{
    string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    double area;
    public double Area
    {
        get { return area; }
        set { area = value; }
    }
    public Plant(string Name, double Area)
    {
        this.Name = Name;
        this.Area = Area;
    }
    public Plant() { }
    public abstract double BaseYield();
    public virtual double WeatherFactor(string weather)
    {
        if (weather == "Mua")
            return 0.9;
        else if (weather == "Han han")
            return 0.7;
        else
            return 1.0;
    }
    public virtual double RealYield(string weather)
    {
        return BaseYield() * WeatherFactor(weather);
    }
    public virtual void Thongtin(string weather)
    {
        Console.WriteLine($"{Name}({Area} m2): Nang suat ly thuyet: {BaseYield()}; Nang suat thuc te: {RealYield(weather)}");
    }
}
class Rice : Plant
{
    public Rice(string Name, double Area) : base(Name, Area) { }
    public override double BaseYield()
    {
        return Area * 0.8;
    }
    public override double WeatherFactor(string weather)
    {
        if (weather == "Mua")
            return 0.95;
        else if (weather == "Han han")
            return 0.6;
        else
            return 1.0;
    }
}
class Corn : Plant
{
    public Corn(string Name, double Area) : base(Name, Area) { }
    public override double BaseYield()
    {
        return Area * 1.2;
    }
}
class Potato : Plant
{
    public Potato(string Name, double Area) : base(Name, Area) { }
    public override double BaseYield()
    {
        return Area * 1.0;
    }
    public override double WeatherFactor(string weather)
    {
        if (weather == "Mua")
            return 0.8;
        else if (weather == "Han han")
            return 0.75;
        else
            return 1.0;
    }
}
class Program
{
    static void Main()
    {
        Rice lua = new Rice("Lua", 1000);
        Corn ngo = new Corn("Ngo", 800);
        Potato khoaitay = new Potato("Khoai tay", 600);
        Console.Write("Thoi tiet: ");
        string weather = Console.ReadLine();
        // lua.RealYield(weather);
        // ngo.RealYield(weather);
        // khoaitay.RealYield(weather);
        lua.Thongtin(weather);
        ngo.Thongtin(weather);
        khoaitay.Thongtin(weather);
    }
}