// Bài tập 3: Mèo 
// 1. Xây dựng lớp Meo gồm: 
// - Thuộc tính: Ten, Giong, Gioitinh, Tuoi 
// - Phương thức: 
// o Hàm Khởi tạo, Hàm hủy 
// o Hàm Nhập, Xuất, Đếm 
// 2. Chương trình chính 
// - Lặp lại quá trình: Hòi người dùng có muốn nhập thông tin thêm mèo hay không, 
// nếu người dùng nhập y hoặc Y thì cho phép nhập thêm và đưa vào danh sách (dùng 
// kiểu List) 
// -  Xuất ra danh sách thông tin mèo đã nhập ra màn hình 
// - Đếm số lượng mèo có trong danh sách 

using System;
using System.Collections.Generic;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Meo> Danhsachmeo = new List<Meo>(); // Khởi tạo danh sách các đối tượng Meo
            bool Tieptuc = true;

            while (Tieptuc)
            {
                Meo Conmeo = new Meo();
                Conmeo.Nhap();
                Danhsachmeo.Add(Conmeo); // Thêm đối tượng Conmeo vào danh sách

                Console.WriteLine("Bạn có muốn nhập thêm thông tin mèo? (y/Y)");
                string Nhapthem = Console.ReadLine(); // Nhập tiếp nếu người dùng muốn thêm

                // Kiểm tra xem có tiếp tục nhập thông tin không
                if (Nhapthem != "y")
                {
                    Tieptuc = false;
                }
            }

            // Xuất thông tin của tất cả các mèo
            foreach (Meo Conmeo in Danhsachmeo)
            {
                Conmeo.Xuat();
            }

            // Đếm và xuất số lượng mèo
            Meo.Dem(Danhsachmeo);
        }
    }

    class Meo
    {
        public string Ten;
        public string Giong;
        public string Gioitinh;
        public int Tuoi;

        // Hàm khởi tạo mặc định
        public Meo()
        {
            Ten = "";
            Giong = "";
            Gioitinh = "";
            Tuoi = 0;
        }

        // Hàm khởi tạo có tham số
        public Meo(string Ten, string Giong, string Gioitinh, int Tuoi)
        {
            this.Ten = Ten;
            this.Giong = Giong;
            this.Gioitinh = Gioitinh;
            this.Tuoi = Tuoi;
        }

        // Hàm hủy
        ~Meo()
        {
            Console.WriteLine("END");
        }

        // Hàm nhập thông tin mèo
        public void Nhap()
        {
            Console.Write("Nhập tên mèo: ");
            Ten = Console.ReadLine();
            Console.Write("Nhập giống mèo: ");
            Giong = Console.ReadLine();
            Console.Write("Nhập giới tính mèo: ");
            Gioitinh = Console.ReadLine();
            Console.Write("Nhập tuổi mèo: ");
            Tuoi = int.Parse(Console.ReadLine());
        }

        // Hàm xuất thông tin mèo
        public void Xuat()
        {
            Console.WriteLine($"Tên: {Ten}, Giống: {Giong}, Giới tính: {Gioitinh}, Tuổi: {Tuoi}");
        }

        // Hàm đếm số lượng mèo
        public static void Dem(List<Meo> Danhsachmeo)
        {
            Console.WriteLine("Số lượng mèo: {0}", Danhsachmeo.Count);
        }
    }
}
