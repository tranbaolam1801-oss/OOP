static void Nhap(out double a, out double b, out char toantu) 
{
    Console.Write("a=");
    a = double.Parse(Console.ReadLine());
    Console.Write("b=");
    b = double.Parse(Console.ReadLine());
    Console.Write("Toan tu: ");
    toantu = Convert.ToChar(Console.ReadLine());
}
static double Thuchien(double a, double b, char toantu) 
{
    switch (toantu)
    {
        case '+':
            return a + b;
        case '-':
            return a - b;
        case '*':
            return a * b;
        case '/':
            if (b == 0)
                return 0;
            else
                return a / b;
        default:
            return 0;
    }
}
static void InKQ(double a, double b, double kq, char toantu)
{
    if (b == 0 && toantu == '/')
        Console.WriteLine("Khong thuc hien duoc phep tinh!");
    else
        Console.WriteLine($"{a} {toantu} {b} = {kq}");
}
while (true)
{
    double a, b;
    char toantu;
    Nhap(out a, out b, out toantu);
    double kq = Thuchien(a, b, toantu);
    InKQ(a, b, kq, toantu);
    Console.Write("Tiep tuc: ");
    char chon = Convert.ToChar(Console.ReadLine());
    if (chon == 'T' || chon == 't')
        break;
}