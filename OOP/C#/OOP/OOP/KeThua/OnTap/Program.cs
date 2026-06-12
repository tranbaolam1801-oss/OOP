namespace CSharp
{
    public class BankAccount
    {
        private string accountnumber;
        public string AccountNumber
        {
            get { return accountnumber; }
            set{ accountnumber = value; }
        }

        private string owner;
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        protected double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BankAccount() { }
        public BankAccount(string accountNumber, string owner, double balance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= Balance) Balance -= amount;
            else Console.WriteLine("So du khong du");
        }
        public void CheckBalance() => Console.WriteLine($"So du hien tai: {Balance}");

        ~BankAccount() { }
    }

    public class SavingsAccount : BankAccount
    {
        private double interestrate;
        public double InterestRate
        {
            get { return interestrate; }
            set { interestrate = value; }
        }

        public SavingsAccount() : base() { }
        public SavingsAccount(string accountNumber, string owner, double balance, double interestRate) : base(accountNumber, owner, balance) 
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            Balance += Balance * InterestRate;
        }
        public void WithdrawInterest()
        {
            Balance -= Balance * InterestRate;
        }
        public void ApplyCumulativeInterest(int months)
        {
            for (int i = 0; i < months; i++)
            {
                Balance += Balance * InterestRate;
            }
        }

        ~SavingsAccount() { }
    }

    public class CheckingAccount : BankAccount
    {
        private double transactionlimit;
        public double TransactionLimit
        {
            get { return transactionlimit; }
            set { transactionlimit = value; }
        }

        private double maintenancefee;
        public double MaintenanceFee
        {
            get { return maintenancefee; }
            set { maintenancefee = value; }
        }

        private double minimumbalance;
        public double MinimumBalance 
        { 
            get { return minimumbalance; }
            set { minimumbalance = value; }
        }

        public CheckingAccount() : base() { }
        public CheckingAccount(string accountNumber, string owner, double balance, double transactionLimit, double maintenanceFee, double minimumBalance) : base(accountNumber, owner, balance)
        {
            TransactionLimit = transactionLimit;
            MaintenanceFee = maintenanceFee;
            MinimumBalance = minimumBalance;
        }

        public new void Withdraw(double amount)
        {
            if (amount > TransactionLimit) Console.WriteLine("So tien rut vuot qua gioi han");
            else if (Balance - amount < MinimumBalance) Console.WriteLine("So du sau khi rut se duoi muc toi thieu");
            else base.Withdraw(amount);
        }
        public void ApplyMaintenanceFee()
        {
            if (Balance < MinimumBalance) Balance -= MaintenanceFee;
        }
        public void Transfer(BankAccount targetAccount, double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                targetAccount.Balance += amount;
            }
        }

        ~CheckingAccount() { }
    }

    public class InvestmentAccount : BankAccount
    {
        private double risklevel;
        public double RiskLevel
        {
            get { return risklevel; }
            set { risklevel = value; }
        }
        private double investmentamount;
        public double InvestmentAmount
        {
            get { return investmentamount; }
            set { investmentamount = value; }
        }

        public InvestmentAccount() : base() { }
        public InvestmentAccount(string accountNumber, string owner, double balance, double riskLevel, double investmentAmount) : base(accountNumber, owner, balance)
        {
            RiskLevel = riskLevel;
            InvestmentAmount = investmentAmount;
        }

        public void Invest(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                InvestmentAmount += amount;
            }
        }
        public void CollectInvestmentReturn(double profitPercentage)
        {
            Balance += InvestmentAmount * profitPercentage;
        }

        ~InvestmentAccount() { }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount("34543234543", "Toan", 344600000, 0.8);
            Console.Write("\nTai khoan tiet kiem: "); savingsAccount.CheckBalance();
            savingsAccount.Withdraw(39000000);
            savingsAccount.ApplyInterest();
            savingsAccount.CheckBalance();

            CheckingAccount checkingAccount = new CheckingAccount("34543234542", "Song", 36460000, 6000000, 200000, 6000000);
            Console.Write("\nTai khoan thanh toan: "); checkingAccount.CheckBalance();
            checkingAccount.Withdraw(6700000);
            checkingAccount.Withdraw(1900000);
            BankAccount targetAccount = new BankAccount("345432345253", "Ha", 600000);
            checkingAccount.Transfer(targetAccount, 670000);
            checkingAccount.CheckBalance();

            InvestmentAccount investmentAccount = new InvestmentAccount("345432345224", "An", 2034000000, 2, 0);
            Console.Write("\nTai khoan dau tu: "); investmentAccount.CheckBalance();
            investmentAccount.Withdraw(560000000);
            investmentAccount.Invest(780000000);
            investmentAccount.CollectInvestmentReturn(40);
            investmentAccount.CheckBalance();
        }
    }
}
