namespace ToanDX;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("so nguyen n:");
        int n =int.Parse(Console.ReadLine());
        if (n >0)
        {
            ProductManager manager = new ProductManager();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin cho sp thu {i+1}");
                Product product1 = new Product();
                product1.InputProductInfo();
                product1.DisplayInfo();
                product1.CalculateTotalValue();
                manager.AddProduct(product1);

            }
            // Console.WriteLine("Tong gia tri san pham:");
            // double sum = 0;
            // for (int i = 0; i < n; i++)
            // {
                
            // }

            Console.WriteLine("nhap gia min:");
            double minPrice =double.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia max:");
            double maxPrice =double.Parse(Console.ReadLine());
            manager.SearchByPriceRange(minPrice, maxPrice);

        }
        else
            Console.WriteLine("Nhap lai");



    }
}
class Product
{
    private string ProductID, ProductName, Category;
    private double Price;
    private int StockQuantity;
    public string productID
    {
        get {return ProductID; }
        set { ProductID = value;}
    }
    public string productName
    {
        get {return ProductName; }
        set { ProductName = value;}
    }
    public string category
    {
        get {return Category; }
        set { Category = value;}
    }
    public double price
    {
        get {return Price; }
        set { Price = value;}
    }
    public int stockQuantity
    {
        get {return StockQuantity; }
        set { StockQuantity = value;}
    }
    public Product()
    {
        productID = "";
        productName = "";
        category = "";
        price = 0;
        stockQuantity = 0;
    }
    public void InputProductInfo()
    {
        Console.WriteLine("Nhap ma san pham: ");
        productID = Console.ReadLine();
        Console.WriteLine("Nhap ten san pham: ");
        productName = Console.ReadLine();
        Console.WriteLine("Nhap loai san pham: ");
        category = Console.ReadLine();
        Console.WriteLine("Nhap gia san pham: ");
        price =double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so luong trong kho: ");
        stockQuantity =int.Parse(Console.ReadLine());
    }

    public double CalculateTotalValue()
    {
        return price * stockQuantity;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Ma sp: {productID}, ten sp: {productName}, loai sp: {category}, gia sp: {price}, soluong: {stockQuantity}");
    }
}
class ProductManager
{
    private List<Product> Products = new List<Product>();
    public List<Product> products
    {
        get { return Products;}
        set {Products = value;}
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public void SearchByPriceRange(double minPrice, double maxPrice)
    {
        Console.WriteLine($"Cac sp gia tu {minPrice} den {maxPrice}");
        foreach (var product in products)
        {
            if (product.price >= minPrice && product.price <= maxPrice)
            {
                product.DisplayInfo();
                Console.WriteLine("--------------------------");
            }
        }
    }
}