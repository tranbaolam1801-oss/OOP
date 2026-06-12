using System;
using System.Collections.Generic;
class Sach
{
    public string Tensach;
    public string Tacgia;
    public int NamXB;
    public int Soluong;
    public Sach()
    {
        Tensach = "";
        Tacgia = "";
        NamXB = 0;
        Soluong = 0;
    }
    public Sach(string tensach, string tacgia, int namxb, int soluong)
    {
        Tensach = tensach;
        Tacgia = tacgia;
        NamXB = namxb;
        Soluong = soluong;
    }
    ~Sach()
    {
        Console.WriteLine($"Huy sach {Tensach}");
    }
    public void Nhap()
    {
        Console.Write("Nhap ten sach: ");
        Tensach = Console.ReadLine();
        Console.Write("Nhap ten tac gia: ");
        Tacgia = Console.ReadLine();
        Console.Write("Nhap nam xuat ban: ");
        NamXB = int.Parse(Console.ReadLine());
        Console.Write("Nhap so luong sach: ");
        Soluong = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"\nTen sach: {Tensach}");
        Console.WriteLine($"Tac gia: {Tacgia}");
        Console.WriteLine($"Nam xuat ban: {NamXB}");
        Console.WriteLine($"So luong: {Soluong}");
    }
}
class Program
{
    static void Main()
    {
        Sach s1 = new Sach("Toan", "Kim Dong", 2006, 50);
        Sach s2 = new Sach();
        s2.Nhap();
        Console.WriteLine("---SACH DA NHAP---");
        s1.Xuat();
        s2.Xuat();
    }
}







// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Sach> dsSach = new List<Sach>();
//         while (true)
//         {
//             Console.WriteLine("\n-----MENU-----");
//             Console.WriteLine("Nhap 0 de thoat chuong trinh");
//             Console.WriteLine("Nhap 1 de them sach");
//             Console.WriteLine("Nhap 2 de xem thong tin sach");
//             Console.WriteLine("Nhap 3 de xoa sach");
//             Console.Write("\nNhap lua chon cua ban: ");
//             int chon = int.Parse(Console.ReadLine());
//             if (chon == 0)
//                 break;
//             switch (chon)
//             {
//                 case 1:
//                     Sach sach = new Sach();
//                     sach.Nhap();
//                     dsSach.Add(sach);
//                     break;
//                 case 2:
//                     if (dsSach.Count == 0)
//                         Console.WriteLine("Chua co sach nao");
//                     else
//                     {
//                         Console.WriteLine("-----THONG TIN SACH-----");
//                         foreach (var s in dsSach)
//                         {
//                             Console.WriteLine();
//                             s.Xuat();
//                         }
//                     }
//                     break;
//                 case 3:
//                     Console.Write("\nNhap ten sach can xoa: ");
//                     string xoa = Console.ReadLine();
//                     foreach (var s in dsSach)
//                     {
//                         if (s.Tensach == xoa)
//                         {
//                             dsSach.Remove(s);
//                             break;
//                         }
//                     }
//                     break;
//                 default:
//                     Console.WriteLine("Lua chon khong hop le!");
//                     break;
//             }
//         }
//     }
// }
