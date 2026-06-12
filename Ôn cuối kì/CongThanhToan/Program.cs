using System;

interface IPaymentGateway
{
    bool Pay(decimal amount, string currenct);
}
class VisaGateway : IPaymentGateway
{
    public bool Pay(decimal amount, string currenct)
    {
        if (amount > 50000000)
        {
            Console.WriteLine("Thanh toan that bai, so tien vuot qua so tien cho phep!");
            return false;
        }
        if (currenct != "USD" && currenct != "VND")
        {
            Console.WriteLine("Tu choi thanh toan, Visa chi ho tro thanh toan VND hoac USD!");
            return false;
        }
        Console.WriteLine($"Thanh toan {amount} {currenct} thanh cong!");
        return true;
    }
}
class MomoGateway : IPaymentGateway
{
    public bool Pay(decimal amount, string currenct)
    {
        if (amount > 20000000)
        {
            Console.WriteLine("Thanh toan that bai, vuot gioi han giao dich 20 trieu");
            return false;
        }
        if (currenct != "VND")
        {
            Console.WriteLine("Thanh toan that bai, Momo chi ho tro thanh toan VND!");
            return false;
        }
        Console.WriteLine($"Thanh toan {amount} {currenct} thanh cong!");
        return true;
    }
}
class BankTransferGateway : IPaymentGateway
{
    public bool Pay(decimal amount, string currenct)
    {
        Console.WriteLine($"Thanh toan {amount} {currenct} thanh cong!");
        return true;
    }
}
class CheckoutService
{
    IPaymentGateway gateway;
    public CheckoutService(IPaymentGateway gateway)
    {
        this.gateway = gateway;
    }
    public void Checkout(decimal amount, string currenct)
    {
        if (gateway.Pay(amount, currenct))
            Console.WriteLine("Thanh toan hoan tat, cam on quy khach!");
        else
            Console.WriteLine("Thanh toan that bai, vui long thu lai!");
    }
}
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Visa");
            Console.WriteLine("2. Momo");
            Console.WriteLine("3. Bank Transfer");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("Nhap lua chon cua ban: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 0)
            {
                Console.WriteLine("Thoat chuong trinh!");
                break;
            }
            Console.WriteLine("Nhap so tien muon thanh toan: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nhap loai tien te: ");
            string currenct = Console.ReadLine();
            IPaymentGateway gateway;
            switch (chon)
            {
                case 1:
                    gateway = new VisaGateway();
                    break;
                case 2:
                    gateway = new MomoGateway();
                    break;
                case 3:
                    gateway = new BankTransferGateway();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le, vui long chon lai!");
                    continue;
            }
            CheckoutService check = new CheckoutService(gateway);
            check.Checkout(amount, currenct);
        }
    }
}