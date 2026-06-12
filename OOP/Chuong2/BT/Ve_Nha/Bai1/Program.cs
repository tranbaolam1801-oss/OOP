static double danhgia(double diem) //Đổi thang 10 sang 4
{
//     if (diem < 4)
//         return 0.0;
//     else if (diem < 5.0)
//         return 1.0;
//     else if (diem < 5.5)
//         return 1.5;
//     else if (diem < 6.5)
//         return 2.0;
//     else if (diem < 7.0)
//         return 2.5;
//     else if (diem < 8.0)
//         return 3.0;
//     else if (diem < 8.5)
//         return 3.5;
//     else 
//         return 4.0;
    if (diem < 4)
        return 0;
    else if (diem < 5.5)
        return 1;
    else if (diem < 7.0)
        return 2;
    else if (diem < 8.5)
        return 3;
    else 
        return 4;
}
static double GPA(double QTH, double HTTTQL, double CSLT, double TRIET) //Tính GPA
{
    return (danhgia(QTH) * 3 + danhgia(HTTTQL) * 3 + danhgia(CSLT) * 3 + danhgia(TRIET) * 3) / 12;
}
static string XepLoai(double gpa) //Xếp loại học lực
{
    if (gpa < 2)
        return "Yeu";
    else if (gpa < 2.5)
        return "Trung binh";
    else if (gpa < 3.2)
        return "Kha";
    else if (gpa < 3.6)
        return "Gioi";
    else
        return "Xuat sac";
}
Console.Write("Ho va ten: ");
string Hoten = Console.ReadLine();
Console.Write("Lop: ");
string Lop = Console.ReadLine();
Console.Write("Diem_QTH: ");
double QTH = double.Parse(Console.ReadLine());
Console.Write("Diem_HTTTQL: ");
double HTTTQL = double.Parse(Console.ReadLine());
Console.Write("Diem_CSLT: ");
double CSLT = double.Parse(Console.ReadLine());
Console.Write("Diem_Triet: ");
double TRIET = double.Parse(Console.ReadLine());
double gpa = GPA(QTH, HTTTQL, CSLT, TRIET);
Console.WriteLine($"Sinh vien {Hoten}, Lop {Lop}, Dat GPA {gpa:F2}, Xep loai {XepLoai(gpa)}");