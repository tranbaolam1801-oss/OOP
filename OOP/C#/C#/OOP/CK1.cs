using System.Diagnostics.Contracts;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace OOP;
abstract class Course
{
    // Properites
    // private string nameStudent;
    // public string NameStudent{
    //     get {return nameStudent;}
    //     set {nameStudent = value;}
    // }

    // Get set
    public string NameStudent { get; set; }
    public string Email { get; set; }
    public string Numberphone { get; set; }
    private static double totalRevenue;
    public static double TotalRevenue
    {
        get { return totalRevenue; }
        set { totalRevenue = value; }
    }
    //Phuong thuc ao tinh chi phi hang thang:
    public abstract double MonthlyCost();
    //phuong thuc cap nhat tong doanh thu: static 
    public static void AddTotalRevenue(double amount)
    {
        TotalRevenue += amount;
    }
    //phuong thuc khoi tao:
    public Course(string nameStudent, string email, string numberphone)
    {
        NameStudent = nameStudent;
        Email = email;
        Numberphone = numberphone;
    }
    public Course() { }
    ~Course() { }
    public override string ToString()
    {
        return $"Name: {NameStudent}, Email: {Email}, Numberphone: {Numberphone}";
    }
}
class ProgrammingCourse : Course
{
    public int Hours { get; set; }
    public int Assignments { get; set; }
    public override double MonthlyCost()
    {
        double cost = Hours * 200000 + Assignments * 50000;
        cost += cost * 0.1; // VAT 10%
        return cost;
    }
    public ProgrammingCourse(string nameStudent, string email, string numberphone, int hours, int assignments) : base(nameStudent, email, numberphone)
    {
        Hours = hours;
        Assignments = assignments;
    }
    public ProgrammingCourse() : base() { }
    public override string ToString()
    {
        return base.ToString() + $", Hours: {Hours}, Assignments: {Assignments}, MonthlyCost: {MonthlyCost()}";
    }
    ~ProgrammingCourse() { }
}
class DesignCourse : Course
{
    public int Hours { get; set; }
    public int Projects { get; set; }
    public override double MonthlyCost()
    {
        double cost = Hours * 180000 + Projects * 70000;
        cost += cost * 0.08; // VAT 8%
        return cost;
    }
    public DesignCourse(string nameStudent, string email, string numberphone, int hours, int projects) : base(nameStudent, email, numberphone)
    {
        Hours = hours;
        Projects = projects;
    }
    public DesignCourse() : base() { }
    public override string ToString()
    {
        return base.ToString() + $", Hours: {Hours}, Projects: {Projects}, MonthlyCost: {MonthlyCost()}";
    }
    ~DesignCourse() { }
}
class EnglishCourse : Course
{
    public int Level { get; set; }
    public int Hours { get; set; }
    public override double MonthlyCost()
    {
        double cost = Level * Hours * 150000;
        cost += cost * 0.05; // VAT 5%
        return cost;
    }
    public override string ToString()
    {
        return base.ToString() + $", Hours: {Hours}, Level: {Level}, MonthlyCost: {MonthlyCost()}";
    }
    public EnglishCourse(string nameStudent, string email, string numberphone, int level, int hours) : base(nameStudent, email, numberphone)
    {
        Level = level;
        Hours = hours;
    }
    public EnglishCourse() : base() { }
    ~EnglishCourse() { }
}
class CourseManagement
{
    //tao list
    private List<Course> courses = new List<Course>();
    //them hoc sinh vao he thonf

    public void InputStudent()
    {
        //tu nhap du lieu
        // Console.WriteLine("Enter student's information:");
        // Console.Write("Name: ");
        // string name = Console.ReadLine();
        // Console.Write("Email: ");
        // string email = Console.ReadLine();
        // Console.Write("Numberphone: ");
        // string numberphone = Console.ReadLine();
        // Console.WriteLine($"Student information: {name}, {email}, {numberphone}");
        // Console.WriteLine();
        // Console.Write("Course type (Programming/Design/English): ");
        // string courseType = Console.ReadLine();
        // if (courseType == "Programming")
        // {
        //     courses.Add(new ProgrammingCourse("toan", "h@example.com", "0923456789", 50 , 100));
        // }
        // else if (courseType == "Design")
        // {
        //     Console.Write("Hours: ");
        //     int hours = int.Parse(Console.ReadLine());
        //     Console.Write("Number of projects: ");
        //     int projects = int.Parse(Console.ReadLine());
        //     courses.Add(new DesignCourse(name, email, numberphone, hours, projects));
        // }
        // else if (courseType == "English")
        // {
        //     Console.Write("Level (1-3): ");
        //     int level = int.Parse(Console.ReadLine());
        //     Console.Write("Hours: ");
        //     int hours = int.Parse(Console.ReadLine());
        //     courses.Add(new EnglishCourse(name, email, numberphone, level, hours));
        // }

        //them hoc sinh vao khoa hoc program co dinh:
        courses.Add(new ProgrammingCourse("toan", "h@example.com", "0923456789", 50, 100));
        courses.Add(new ProgrammingCourse("song", "a@example.com", "0923456745", 100, 200));
        courses.Add(new ProgrammingCourse("duong", "b@example.com", "0923456765", 80, 150));
        //them hoc sinh vao khoa hoc design co dinh:
        courses.Add(new DesignCourse("trang", "c@example.com", "0923456754", 120, 250));
        courses.Add(new DesignCourse("tien", "d@example.com", "0923456732", 150, 300));
        //them hoc sinh vao khoa hoc english co dinh:
        courses.Add(new EnglishCourse("minh", "e@example.com", "0923456712", 2, 20));
        courses.Add(new EnglishCourse("phong", "f@example.com", "0923456790", 3, 30));

    }
    public void SearchStudentByPhoneNumber(string phoneNumber)
    {
        bool isStudent = false;
        foreach (var course in courses)
        {
            if (course.Numberphone == phoneNumber)
            {
                System.Console.WriteLine(course);
                isStudent = true;
                break;
            }
        }
        if (isStudent == false)
        {
            System.Console.WriteLine("Student not found.");
        }
    }
    public void SearchStudentEmail(string email)
    {
        bool isStudent = false;
        foreach (var course in courses)
        {
            if (course.Email == email)
            {
                Console.WriteLine(course);
                isStudent = true;
                break;
            }
        }
        if (isStudent == false)
        {
            Console.WriteLine("Student not found.");
        }
    }
    public void DisplayMonthly()
    {
        foreach (var St in courses)
        {
            Console.WriteLine($"{St.NameStudent}: {St.MonthlyCost()}");
        }
    }

    public void DisplayTotalRrvenue()
    {
        foreach (var St in courses)
        {
            Course.AddTotalRevenue(St.MonthlyCost());
        }
        Console.WriteLine($"Course.TotalRevenue: {Course.TotalRevenue}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Tao doi tuong:
        CourseManagement courseManagement = new CourseManagement();
        //them hoc sinh vao he thong:
        courseManagement.InputStudent();
        //Nhap sdt hoc sinh:
        string phoneNumber = Console.ReadLine();
        //tim kiem hoc sinh theo sdt:
        courseManagement.SearchStudentByPhoneNumber(phoneNumber);
        //Nhap email hoc sinh:
        string email = Console.ReadLine();
        //tim kiem hoc sinh theo email:
        courseManagement.SearchStudentEmail(email);
        //hien thi tong doanh thu:
        courseManagement.DisplayTotalRrvenue();
        //hien thi thong tin cac hoc sinh theo thang:
        courseManagement.DisplayMonthly();
    }
}

