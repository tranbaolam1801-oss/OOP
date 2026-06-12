namespace Bai3;

class Program
{
    static void Main(string[] args)
    {
        char ch1 = 'a'; // declare (khai báo) kí tự a
        char ch2 = (char) 65;
        Console.WriteLine("Ki tu 1: " + ch1);
        Console.WriteLine("Ki tu 2: " + ch2);
        string s = Console.ReadLine();
        char ch3 = char.Parse(s); //ép kiểu
        Console.WriteLine("Ki tu 3: " + ch3);
        Console.WriteLine(ch3.GetType().ToString());// Check data type
        char ch4 = Convert.ToChar("c");// Chuyển đổi (convert) type data
        Console.WriteLine("Ki tu 4: " + ch4);
        Console.WriteLine(ch1.CompareTo(ch2)); //So sánh (compare) 2 kí tự
        Consolo.WriteLine(ch1.Equals(ch2)); //So sánh có bằng (equal) trả về true or false
        Console.WriteLine(Char.IsDigit(ch1)); //Check if it is a number
        Console.WriteLine(Char.IsLetter(ch1)); //Check if it is a letter
        Console.WriteLine(Char.IsWhiteSpace(ch2)); //Check if it is a space
        Console.WriteLine(Char.IsLower(ch2)); //Check if it is a lowercase
        Console.WriteLine(Char.IsUpper(ch)); //Check if it is a uppercase
        Console.WriteLine(Char.ToLower(ch2)); // Convert kt sang Lowercase
        Console.WriteLine(Char.ToUpper(ch1)); // Convert kt sang Uppercase
    }
}