namespace Bai1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap n:");
        int n=int.Parse(Console.ReadLine());
        Employee[] E = new Employee[n];
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("Nhap thong tin cho nhan vien {0}",i+1);
            E[i] = new Employee();
            E[i].Nhap();
        } 
        foreach (Employee So in E)
        {
            Console.WriteLine("-------------------------");
            So.Xuat();
            System.Console.WriteLine("Thue la: {0}", So.TinhThue());
        }
    }
}
class Employee
{
    private int Id;
    private string Name;
    private double Salary;
    public int id
    {
        get {return Id;}
        set {Id=value;}
    }
    public string name
    {
        get {return Name;}
        set {Name=value;}
    }
    public double salary
    {
        get {return Salary;}
        set {Salary=value;}
    }
    public Employee()
    {
        Id = 0;
        Name = "";
        Salary = 0.0;
    }
    public Employee(int Id, string Name, double Salary)
    {
        this.Id = Id;
        this.Name = Name;
        this.Salary = Salary;
    }
    ~Employee()
    {
        Console.Write("End");
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap ID: ");
        Id=int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap Name: ");
        Name=Console.ReadLine();
        Console.WriteLine("Nhap Salary: ");
        Salary=double.Parse(Console.ReadLine());
    }
    public double TinhThue()
    {
        return 0.1*Salary;
    }
    public void Xuat()
    {
        Console.WriteLine($"Mã nhân viên: {Id}");
        Console.WriteLine($"Tên nhân viên: {Name}");
        Console.WriteLine($"Lương nhân viên: {Salary}");
    }
}
