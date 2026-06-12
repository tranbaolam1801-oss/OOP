using System;
using System.Collections.Generic;

namespace De3
{
    class ProductManager
    {
        List<Product> listProduct = new List<Product>();
        public void AddProduct(Product product) //Add product to the list product
        {
            product.InputProductInfo();
            listProduct.Add(product);
        }
        public void SearchByPriceRange(double minPrice, double maxPrice) //Search product in Range(min, max)
        {
            foreach (var product in listProduct)
            {
                if (product.Price >= minPrice && product.Price <= maxPrice)
                    product.DisplayInfo();
            }
        }
        public void DisplayAllInfo() //Display all product information
        {
            foreach (var product in listProduct)
            {
                product.DisplayInfo();
            }
        }
        public void CalculateAndReturPrice()
        {
            foreach (var product in listProduct)
            {
                Console.WriteLine($"Gia tri cua san pham {product.ProductName}: {product.CalculateTotalValue()}");
            }
        }
    }
}