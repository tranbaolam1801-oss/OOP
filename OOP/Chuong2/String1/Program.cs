namespace String;

class Program
{
    static void Main(string[] args)
    {
        string chuoi = "Lam is numberone";
        Console.WriteLine("Chuoi la: " + chuoi);
        string chuoi2 = @"D:\galailaptrinh"; //Noi dung giu nguyen
        Console.WriteLine("Chuoi 2 la: " + chuoi2);
        // Chuyen sang string
        int i = 1234;
        string chuoi3 = i.ToString(); //Cach1
        string chuoi4 = Convert.ToString(i); //Cach2
        string chuoi5 = i + ""; //Cach3
        Console.WriteLine($"Chuoi 3: {chuoi3}");
        Console.WriteLine($"Chuoi 4: {chuoi4}");
        Console.WriteLine($"Chuoi 5: {chuoi5}");
        //Tach chuoi thanh mang
        string chuoi6 = "Xinchao";
        char[] lst = chuoi6.ToCharArray();
        Console.WriteLine(lst);
        int j = chuoi6.Length;
        Console.WriteLine(j);
        //Check chuoi con
        string s1 = "abc";
        string s2 = "abcde";
        bool l = s2.Contains(s1); //Check s2 contains s1?
        Console.WriteLine(l);
        //Copy to
        string s3 = "123456";
        char[] lst2 = new char[6];
        lst2[0] = 'a';
        lst2[1] = 'b';
        s3.CopyTo(1, lst2, 2, 4); // coppy từ index1 của s3 lấy 4 kt dán vào từ index2 của lst2
        //Kiểm tra kết thúc bằng, bắt đầu bằng
        /* 
        string c1 = "yeuaido.com";
        bool kt = chuoi.EndsWith(".com");
        */
        // Gán chuỗi theo string.Format
        int n = 14;
        string c2 = string.Format($"n = {n} va can bac hai cua n la {Math.Sqrt(n)}");
        Console.WriteLine(c2);
        //bool equals
        string c3 = "haha";
        string c4 = "hihi";
        bool kt2 = c3.Equals(c4);
        Console.WriteLine(kt2);
        //chèn thêm chuỗi
        string c5 = "lam";
        string c6 = "an";
        c5 = c5.Insert(3, c6);
        Console.WriteLine(c5);
        // Kiểm tra vị trí xuất hiện đầu tiên trong chuỗi
        string c7 = "adbsfdjf";
        int kq4 = c7.IndexOf('a');
        Console.WriteLine(kq4);
        // LastIndex: vị trí xuất hiện cuối cùng
        // Remove(index, count)
        string c10 = "1234567";
        Console.WriteLine(c10);
        c10 = c10.Remove(1,2);
        Console.WriteLine(c10);
        //Replace
        string c11 = "12344455";
        c11 = c11.Replace("4", "Lam");
        Console.WriteLine(c11);
        //Substring(index, count);
        string c12 = "123456";
        string c13 = c12.Substring(2, 4);
        Console.WriteLine(c13);
        //ToLower();    ToUpper();
        c11 = c11.ToLower();
        Console.WriteLine(c11);
        //Trim(): Xóa toàn bộ khoảng trắng đầu cuối
        //TrimEnd(),TrimStart();
        //Split(): Tách chuỗi thành mảng
        string st1 = "mot, hai, ba";
        string[] lst5 = st1.Split(',');
        Console.WriteLine(lst5[0]);
        // string.Join(' ', list)
        string[] lst6 = new string[3];
        lst6[0] = "lam";
        lst6[1] = "an";
        lst6[2] = "duyen";
        string st2 = string.Join(',', lst6);
        Console.WriteLine(st2);
        

    }
}
