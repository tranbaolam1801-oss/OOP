using System;
using System.Collections.Generic;

namespace De2
{
    class Product
    {
        public string ProductID{get; set;}
        public string ProductName{get; set;}
        public double Price{get; set;}
        public string Category{get; set;}
        public double DiscountRate{get; set;}
        public int Stock{get; set;}
        public void InputProductInfo() //Enter info product
        {
            Console.Write("\nNhap ma san pham: ");
            ProductID = Console.ReadLine();
            Console.Write("Nhap ten san pham: ");
            ProductName = Console.ReadLine();
            Console.Write("Nhap gia san pham: ");
            Price = double.Parse(Console.ReadLine());
            Console.Write("Nhap danh muc san pham: ");
            Category = Console.ReadLine();
            Console.Write("Nhap ti le gia: ");
            DiscountRate = double.Parse(Console.ReadLine());
            Console.Write("Nhap so luong ton kho: ");
            Stock = int.Parse(Console.ReadLine());
        }
        public double CalculateDiscountedPrice() //Calculte and return the product price
        {
            return Price * (1 - DiscountRate);
        }
        public void UpdateStock(int amount) //Update number stock
        {
            if (amount > 0)
                Stock += amount;
            else
            {
                if (Math.Abs(amount) <= Stock)
                    Stock += amount;
                else
                    Console.WriteLine("Khong du hang trong kho de xuat");
            }
        }
        public void DisplayInfo() //Display product infomation
        {
            Console.WriteLine($"Ma san pham: {ProductID}");
            Console.WriteLine($"Ten san pham: {ProductName}");
            Console.WriteLine($"Gia truoc giam gia: {Price}");
            Console.WriteLine($"Gia sau giam gia: {CalculateDiscountedPrice()}");
            Console.WriteLine($"So luong ton kho: {Stock}");
            Console.WriteLine($"Danh muc san pham: {Category}");
        }
    }
    class InventoryManager
    {
        List<Product> listProduct = new List<Product>();
        public void AddProduct(Product product) //Add a product to the product list
        {
            product.InputProductInfo();
            listProduct.Add(product);
        }
        public void DisplayAllInfo() //Display all product information
        {
            foreach (var product in listProduct)
            {
                product.DisplayInfo();
            }
        }
        public void SearchByCategory(string category) //Display all product in the category
        {
            foreach(var product in listProduct)
            {
                if (product.Category == category)
                    product.DisplayInfo();
            }
        }
        public void UpdateAllStock()
        {
            foreach (var product in listProduct)
            {
                Console.Write($"Nhap so luong nhap/xuat kho cua san pham {product.ProductName}: ");
                int amount = int.Parse(Console.ReadLine());
                product.UpdateStock(amount);
            }
        }
        public void DisplayStockAfterUpdate()
        {
            foreach (var product in listProduct)
            {
                Console.WriteLine($"\nSan pham {product.ProductName} con ton kho: {product.Stock}");
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();
            int n; //Enter number original n
            do
            {
                Console.Write("\nNhap so luong san pham: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("khong hop le, So luong san pham phai lon hon 0!");
            } while (n <= 0);
            Console.WriteLine("Nhap thong tin cac san pham:"); //Creat for n product
            for (int i = 0; i < n; i++)
            {
                Product product = new Product();
                manager.AddProduct(product);
            }
            Console.WriteLine("\n------DANH SACH SAN PHAM------");
            manager.DisplayAllInfo(); //Display all product information
            Console.WriteLine("\n---CAP NHAT TON KHO");
            manager.UpdateAllStock(); //Print product information of after updating
            Console.WriteLine("\n---TON KHO SAU CAP NHAT---"); 
            manager.DisplayStockAfterUpdate();
            Console.Write("\nNhap danh muc can tim: ");
            string category = Console.ReadLine();
            manager.SearchByCategory(category);
        }
    }
}