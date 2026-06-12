static string XOR(string A, string B)
{
    string chuoi = "";
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] == '0' && B[i] == '0')
            chuoi += "0";
        else if ((A[i] == '0' && B[i] == '1') || (A[i] == '1' && B[i] == '0'))
            chuoi += "1";
        else if (A[i] == '1' && B[i] == '1')
            chuoi += "0";        
    }
    return chuoi;
}
Console.Write("Nhap chuoi A: ");
string A = Console.ReadLine();
Console.Write("Nhap chuoi B: ");
string B = Console.ReadLine();
Console.WriteLine($"Chuoi nhi phan sau khi XOR: {XOR(A, B)}");