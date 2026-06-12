namespace Bai2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập n số tài khoản: ");
        int n=int.Parse(Console.ReadLine());
        List<BankAccount> Bank = new List<BankAccount>();
        if (n>0)
        {
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("Nhập thông tin cho tài khoản thứ {0}",i+1);
                Console.Write("Nhập số tài khoản: ");
                string accountNumber = Console.ReadLine();
                Console.Write("Nhập tên tài khoản: ");
                string accountHolderName = Console.ReadLine();
                Console.Write("Nhập số dư cho tk: ");
                double balance =double.Parse(Console.ReadLine());
                Console.Write("Nhập loại tài khoản: ");
                string accountType = Console.ReadLine();
                // Bank.Add(new BankAccount(accountNumber, balance, accountHolderName, accountType));
                Bank.Add(new BankAccount());
                Console.WriteLine("------------------------------------");
                
            }
        }
        else
        {
            Console.WriteLine("Không hợp lệ");
        }
        Console.Write("Tạo giao dịch với tài khoản thứ :");
        int m = int.Parse(Console.ReadLine());
        if (m>=0 & m<=n)
            {
                Console.Write("Số tiền nạp: ");
                double Nap = double.Parse(Console.ReadLine());
                Bank[m-1].Deposit(Nap);
                Console.WriteLine("Số dư hiện tại: {0}",Bank[m-1].GetBalance()); // Kiểm tra số dư   
                Console.Write("Rút tiền khỏi tài khoản: ");
                double Rut =double.Parse(Console.ReadLine());
                Bank[m-1].Withdraw(Rut);
                Console.WriteLine("Số dư hiện tại: {0}",Bank[m-1].GetBalance());

            }
        else
        {
            Console.WriteLine("không hợp lệ");
        }        
        

    }
}
class BankAccount
{
    private string accountNumber;
    private double balance;
    private string accountHolderName;
    private string accountType;
    //property
    public string AccountNumber
    {
        get { return accountNumber;}
        set { accountNumber = value;}
    }
    public double Balance
    {
        get { return balance;}
        set { balance = value;}
    }
    public string AccountHolderName
    {
        get { return accountHolderName;}
        set { accountHolderName = value;}
    }
    public string AccountType
    {
        get { return accountType;}
        set { accountType = value;}
    }
    //hàm khởi tạo
    public BankAccount(string accountNumber, double balance, string accountHolderName, string accountType)
    {
        this.accountNumber=accountNumber;
        this.balance=balance;
        this.accountHolderName=accountHolderName;
        this.accountType=accountType;
    }
    
    public BankAccount()
    {
        accountNumber="";
        balance=0.0;
        accountHolderName="";
        accountType="";
    }
    ~BankAccount()
    {

    }
    //nạp tiền vào tài khoản
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance +=amount;
            Console.WriteLine($"Đã nạp {amount} vào tài khoản {AccountNumber}. Số dư hiện tại: {Balance}");
        }
        else
        {
            Console.WriteLine("Số tiền nạp phải lớn hơn 0.");   
        }
    }
        // Hàm rút tiền từ tài khoản
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Đã rút {amount} từ tài khoản {AccountNumber}, có tên tài khoản {AccountHolderName}, có loại tài khoản {AccountType}. Số dư còn lại: {Balance}");
        }
        else
        {
            Console.WriteLine("Số tiền rút không hợp lệ hoặc không đủ số dư.");
        }
    }

    // Hàm kiểm tra số dư
    public double GetBalance()
    {
        return Balance;
    }
}


