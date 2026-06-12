//He Thong dich vu
using CK2;

namespace CK2;
//lớp trừu tượngtượng
public abstract class TelecomService
{
    private string customerName;
    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }
    private string phoneNumber;
    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }
    private string email;
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    //Doanh thu tổng: static 
    private static double totalRevenue;
    public static double TotalRevenue
    {
        get { return totalRevenue; }
        private set { totalRevenue = value; }//set pravite để chỉ có thể cập nhật từ trong classclass
    }
    //phương thức ảo:
    public abstract double MonthlyCost();
    //Cập nhật doanh thu toàn hệ thống: static 
    public static void AddTotalRevenue(double anount)
    {
        TotalRevenue += anount;
    }
    //phương thức khởi tạo:
    public TelecomService(string customerName, string phoneNumber, string email)
    {
        CustomerName = customerName;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    public TelecomService() { }
    ~TelecomService() { }
    public override string ToString()
    {
        return $"Name: {CustomerName}, Email: {Email}, PhoneNumber: {PhoneNumber}";
    }

}
//lớp kế thừa:
class InternetService : TelecomService
{
    private double internetSpeed;
    public double InternetSpeed
    {
        get { return internetSpeed; }
        set { internetSpeed = value; }
    }
    private double monthlyUsage;
    public double MonthlyUsage
    {
        get { return monthlyUsage; }
        set { monthlyUsage = value; }
    }
    // phương thức khởi tạo:
    public InternetService(string customerName, string phoneNumber, string email, double internetSpeed, double monthlyUsage) : base(customerName, phoneNumber, email)//gọi phương thức lớp cha
    {
        InternetSpeed = internetSpeed;
        MonthlyUsage = monthlyUsage;
    }
    public InternetService() : base() { }
    ~InternetService() { }

    //ghi đè phương thức tính chi phí cho dịch vụ Internet:
    public override double MonthlyCost()
    {
        double cost = (MonthlyUsage * InternetSpeed * 0.1);
        cost += 0.1 * cost;
        AddTotalRevenue(cost);
        return cost;
    }
    public override string ToString()
    {
        return base.ToString() + $", InternetSpeed: {InternetSpeed}, MonthlyUsage: {MonthlyUsage}, MonthlyCost: {MonthlyCost()}";
    }
}
//lớp MobileSevice kế thừa:
class MobileService : TelecomService
{
    private double callMinutes;
    public double CallMinutes
    {
        get { return callMinutes; }
        set { callMinutes = value; }
    }
    //dung lượng di động:
    private double dataUsage;
    public double DataUsage
    {
        get { return dataUsage; }
        set { dataUsage = value; }
    }
    //phương thức khởi tạo:
    public MobileService(string customerName, string phoneNumber, string email, double callMinutes, double dataUsage) : base(customerName, phoneNumber, email)
    {
        CallMinutes = callMinutes;
        DataUsage = dataUsage;
    }
    public MobileService() : base() { }
    ~MobileService() { }
    //ghi đè phương thức tính chi phí cho dịch vụ Mobile:
    public override double MonthlyCost()
    {
        double cost = (CallMinutes * 0.05) + (DataUsage * 0.02);
        cost += cost * 0.08;
        AddTotalRevenue(cost);
        return cost;
    }
    public override string ToString()
    {
        return base.ToString() + $", CallMinutes: {CallMinutes}, DataUsage: {DataUsage}, MonthlyCost: {MonthlyCost()}";
    }
}
class TVService : TelecomService
{
    private int channels;
    public int Channels
    {
        get { return channels; }
        set { channels = value; }
    }
    private string packageName;
    public string PackageName
    {
        get { return packageName; }
        set { packageName = value; }
    }
    //phương thức khởi tạo:
    public TVService(string customerName, string phoneNumber, string email, int channels, string packageName) : base(customerName, phoneNumber, email)
    {
        Channels = channels;
        PackageName = packageName;
    }
    public TVService() : base() { }
    ~TVService() { }
    public override double MonthlyCost()
    {
        double CostPerChannel;
        if (PackageName == "Basic")
        {
            CostPerChannel = 1;
        }
        else if (PackageName == "Advanced")
        {
            CostPerChannel = 2;
        }
        else if (PackageName == "Premium")
        {
            CostPerChannel = 3;
        }
        else
        {
            CostPerChannel = 0;
        }
        // tisnh cost
        double cost = (CostPerChannel * Channels);
        cost += cost * 0.05;
        //goi them vao totalrevenue:
        AddTotalRevenue(cost);
        return cost;
    }
    public override string ToString()
    {
        return base.ToString() + $", Channels: {Channels}, PackageName: {PackageName}, MonthlyCost: {MonthlyCost()}";
    }
}
class ServiceManagement
{
    //tao list: 
    private List<TelecomService> services = new List<TelecomService>();
    //them khach hang vao he thong:
    public void InputCustomer()
    {
        //them khach hang vao dich vu internet
        services.Add(new InternetService("An", "0942482364", "a@gmail.com", 50, 100));
        services.Add(new InternetService("TOan", "0942482357", "T@gmail.com", 57, 180));
        services.Add(new InternetService("Ha", "0942482464", "h@gmail.com", 30, 140));
        //them khach hang vao dich vu mobie
        services.Add(new MobileService("Ane", "09424242364", "6@gmail.com", 50, 5));
        services.Add(new MobileService("TOn", "0944682357", "5@gmail.com", 57, 7));
        services.Add(new MobileService("Hai", "0942483464", "t@gmail.com", 30, 2));
        //them khach hang dich vu TV:
        services.Add(new TVService("Hii", "0542483464", "7@gmail.com", 100, "Premium"));
        services.Add(new TVService("Hiu", "0542673464", "8@gmail.com", 100, "Premium"));
    }
    public void SearchCustomerByPhoneNumber(string phoneNumber)
    {
        bool isCustomer = false;
        foreach (var sv in services)
        {
            if (sv.PhoneNumber == phoneNumber)
            {
                Console.WriteLine(sv);
                isCustomer = true;
                break;
            }
        }
        if (isCustomer == false)
        {
            Console.WriteLine("Customer not found");
        }
    }
    public void SearchCustomerByEmail(string email)
    {
        bool isCustomer = false;
        foreach (var sv in services)
        {
            if (sv.Email == email)
            {
                Console.WriteLine(sv);
                isCustomer = true;
                break;
            }
        }
        if (isCustomer == false)
        {
            Console.WriteLine("Customer not found");
        }
    }
    public void DisplayMonthly()
    {
        foreach (var Cs in services)
        {
            Console.WriteLine($"{Cs.CustomerName} : {Cs.MonthlyCost()}");
        }
    }
    public void DisplayTotalRrvenue()
    {
        foreach (var Cs in services)
        {
            TelecomService.AddTotalRevenue(Cs.MonthlyCost());
        }
        Console.WriteLine($"Total Revenue: {TelecomService.TotalRevenue}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        //tao doi tuong:
        ServiceManagement SM = new ServiceManagement();
        //theo hs vao he thong:
        SM.InputCustomer();
        //nhap sdt:
        string phoneNumber = Console.ReadLine();
        //tim kiem theo so dien thoai:
        SM.SearchCustomerByPhoneNumber(phoneNumber);
        //nhap email:
        string email = Console.ReadLine();
        //tim kiem theo so dien thoai:
        SM.SearchCustomerByEmail(email);
        //hiejn thi thong tin theo thang:
        SM.DisplayMonthly();
        //hien thi tong doanh thu:
        SM.DisplayTotalRrvenue();

    }
}
