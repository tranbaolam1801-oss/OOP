public class Product
{
    private string productCode;
    private string name;
    private decimal price;
    private int quantity;

    public string ProductCode
    {
        get { return productCode; }
        set { productCode = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public Product(string productCode, string name, decimal price, int quantity)
    {
        ProductCode = productCode;
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Code: {ProductCode}, Name: {Name}, Price: {Price}, Quantity: {Quantity}");
    }
}
public class Electronics : Product
{
    private int warrantyPeriod;

    public int WarrantyPeriod
    {
        get { return warrantyPeriod; }
        set { warrantyPeriod = value; }
    }

    public Electronics(string productCode, string name, decimal price, int quantity, int warrantyPeriod)
        : base(productCode, name, price, quantity)
    {
        WarrantyPeriod = warrantyPeriod;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Warranty Period: {WarrantyPeriod} months");
    }
}
public class Clothing : Product
{
    private string size;
    private string material;

    public string Size
    {
        get { return size; }
        set { size = value; }
    }

    public string Material
    {
        get { return material; }
        set { material = value; }
    }

    public Clothing(string productCode, string name, decimal price, int quantity, string size, string material)
        : base(productCode, name, price, quantity)
    {
        Size = size;
        Material = material;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Size: {Size}, Material: {Material}");
    }
}
public class Food : Product
{
    private DateTime expirationDate;

    public DateTime ExpirationDate
    {
        get { return expirationDate; }
        set { expirationDate = value; }
    }

    public Food(string productCode, string name, decimal price, int quantity, DateTime expirationDate)
        : base(productCode, name, price, quantity)
    {
        ExpirationDate = expirationDate;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Expiration Date: {ExpirationDate.ToShortDateString()}");
    }
}
public class Store
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayAllProducts()
    {
        foreach (var product in products)
        {
            product.DisplayInfo();
            Console.WriteLine("--------------------");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Store store = new Store();

        // Tạo các sản phẩm
        Electronics electronicProduct = new Electronics("E001", "Laptop", 1500m, 5, 24);
        Clothing clothingProduct = new Clothing("C001", "T-shirt", 20m, 50, "M", "Cotton");
        Food foodProduct = new Food("F001", "Milk", 2.5m, 100, new DateTime(2024, 12, 31));

        // Thêm sản phẩm vào cửa hàng
        store.AddProduct(electronicProduct);
        store.AddProduct(clothingProduct);
        store.AddProduct(foodProduct);

        // In thông tin của tất cả các sản phẩm trong cửa hàng
        store.DisplayAllProducts();
    }
}
