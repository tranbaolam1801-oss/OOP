using System;

namespace De3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();
            int n;
            do
            {
                Console.Write("Nhap so luong san pham: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Khong hop le, so luong phai lon hon 0!");
            } while (n <= 0);
            Console.WriteLine("\nNhap thong tin cho cac san pham: ");
            for (int i = 0; i < n; i++)
            {
                Product product = new Product();
                Console.WriteLine($"Nhap thong tin cho san pham thu {i + 1}: ");
                manager.AddProduct(product);
            }
            Console.WriteLine("\n-----DANH SACH SAN PHAM-----");
            manager.DisplayAllInfo();
            Console.WriteLine("\n-----TONG GIA TRI CUA SAN PHAM-----");
            manager.CalculateAndReturPrice();
            double minPrice, maxPrice;
            minPrice = double.Parse(Console.ReadLine());
            maxPrice = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nSAN PHAM CO GIA TRI TRONG KHOANG {minPrice} - {maxPrice}");
            manager.SearchByPriceRange(minPrice, maxPrice);
        }
    }
}