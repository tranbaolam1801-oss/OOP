namespace Bai19;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "English = 78 Science = 83 Math = 68 History = 65";
        string[] ds = str1.Split(' ');
        string So = "";
        foreach (string kt in ds)
        {
            foreach (char c in kt)
            {
                if (char.IsDigit(c))
                {
                    So += kt + " ";
                    break;
                }
            }
        }
        So = So.Trim();
        List<int> dsSo = So.Split().Select(int.Parse).ToList();
        int Tong = 0;
        foreach (int so in dsSo)
        {
            Tong += so;
        }
        Console.WriteLine($"Tong cac so can tim la: {Tong}");    
    }
}
