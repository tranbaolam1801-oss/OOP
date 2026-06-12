namespace Luyencode;

class Program
{
    static void Main(string[] args)
    {
        int Tuoi; string Ten;
        Console.Write("Nhap ten: ");
        Ten = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        Tuoi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ten: {Ten}, Tuoi: {Tuoi}");   
    }
}