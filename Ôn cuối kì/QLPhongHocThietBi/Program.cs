using System;

interface IRentable
{
    double CalculateFree(int hours);
}
abstract class Room
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
    public Room(string Name, double Area)
    {
        this.Name = Name;
        this.Area = Area;
    }
    public abstract double BaseRate();
    public virtual double AdjustedRate()
    {
        Console.WriteLine("....");
    }
    public virtual void ShowInfo()
    {
        Console.Write($"Phong {Name} ({Area} m2)");
    }
}
class Classroom : Room
{
    public override double BaseRate(int hours)
    {
        return 5000;
    }
    public override double AdjustedRateRate()
    {
        return BaseRate() * (1 + Area / 100);
    }
}
class Lab : Room
{
    public override double BaseRate(int hours)
    {
        return 10000;
    }
    public override double AdjustedRateRate()
    {
        return BaseRate() * (1 + Area / 50);
    }
}
class Hall : Room
{
    public override double BaseRate(int hours)
    {
        return 20000;
    }
    public override double AdjustedRateRate()
    {
        return BaseRate() * (1 + Area / 200);
    }
}
class Laptop : IRentable
{
    Room room;
    public Laptop(Room room)
    {
        this.room = room;
    }
    public double CalculateFree(int hours)
    {
        return room.AdjustedRate * hours;
    }
    public void ShowInfo(int hours)
    {
        room.ShowInfo();
        Console.WriteLine("Thiet bi Laptop");
        Console.WriteLine($"Thue {hours} gio: {CalculateFree(hours)}");
    }
}
class Projector : IRentable
{
    private Room room;

    public Projector(Room room)
    {
        this.room = room;
    }

    public double CalculateFee(int hours)
    {
        return room.AdjustedRate() * hours * 1.2;
    }

    public void ShowInfo(int hours)
    {
        room.ShowInfo();
        Console.WriteLine("Thiết bị: Projector");
        Console.WriteLine($"Thuê {hours} giờ: {CalculateFee(hours)}");
    }
}

// 4c. Speaker
class Speaker : IRentable
{
    private Room room;

    public Speaker(Room room)
    {
        this.room = room;
    }

    public double CalculateFee(int hours)
    {
        return room.AdjustedRate() * hours * 0.8;
    }

    public void ShowInfo(int hours)
    {
        room.ShowInfo();
        Console.WriteLine("Thiết bị: Speaker");
        Console.WriteLine($"Thuê {hours} giờ: {CalculateFee(hours)}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Tạo phòng
        Room classroom1 = new Classroom("Classroom1", 30);
        Room lab1 = new Lab("Lab1", 50);
        Room hall1 = new Hall("Hall1", 100);

        // Tạo thiết bị và gán phòng
        Laptop laptop = new Laptop(classroom1);
        Projector projector = new Projector(lab1);
        Speaker speaker = new Speaker(hall1);

        // Tính và in thông tin thuê
        Console.WriteLine("=== Laptop thuê ở Classroom1, 2 giờ ===");
        laptop.ShowInfo(2);
        Console.WriteLine();

        Console.WriteLine("=== Projector thuê ở Lab1, 3 giờ ===");
        projector.ShowInfo(3);
        Console.WriteLine();

        Console.WriteLine("=== Speaker thuê ở Hall1, 1 giờ ===");
        speaker.ShowInfo(1);
        Console.WriteLine();
    }
}
