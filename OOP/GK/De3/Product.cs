using System;

namespace De3
{
    class Product
    {
        public string ProductID{get; set;}
        public string ProductName{get; set;}
        public string Category{get; set;}
        public double Price{get; set;}
        public int StockQuantity{get; set;}
        public void InputProductInfo() //Input product information
        {
            Console.Write("Nhap ma san pham: ");
            ProductID = Console.ReadLine();
            Console.Write("Nhap ten san pham: ");
            ProductName = Console.ReadLine();
            Console.Write("Nhap loai san pham: ");
            Category = Console.ReadLine();
            Console.Write("Nhap gia san pham: ");
            Price = double.Parse(Console.ReadLine());
            Console.Write("Nhap so luong san pham trong kho: ");
            StockQuantity = int.Parse(Console.ReadLine());
        }
        public double CalculateTotalValue() //Calculate and return the total product value
        {
            return Price * StockQuantity;
        }
        public void DisplayInfo() //Display product information
        {
            Console.WriteLine($"Ma san pham: {ProductID}");
            Console.WriteLine($"Ten san pham: {ProductName}");
            Console.WriteLine($"Loai san pham: {Category}");
            Console.WriteLine($"Gia san pham: {Price}");
            Console.WriteLine($"So luong trong kho: {StockQuantity}");
        }
    }
}