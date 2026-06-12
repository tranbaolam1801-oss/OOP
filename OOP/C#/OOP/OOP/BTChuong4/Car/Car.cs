namespace QuanLyXe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Nhap();
            Console.WriteLine(car);
        }
    }

    public class Car
    {
        private string make;
        private string model;
        private int year;

        public string GetMake() => make;
        public void SetMake(string make) => this.make = make;

        public string GetModel() => model;
        public void SetModel(string model) => this.model = model;

        public int GetYear() => year;
        public void SetYear(int year)
        {
            while (year <= 1885 || year > DateTime.Now.Year)
            {
                Console.Write($"Nhap lai nam: ");
                year = int.Parse(Console.ReadLine());
            }
            this.year = year;
        }
        public void Nhap()
        {
            Console.Write($"Nhap hang xe: ");
            SetMake(Console.ReadLine());
            Console.Write($"Nhap mau xe: ");
            SetModel(Console.ReadLine());
            Console.Write($"Nhap nam san xuat: ");
            SetYear(int.Parse(Console.ReadLine()));
        }
        public override string ToString() => $"Hang xe: {GetMake()}, mau xe: {GetModel()}, nam san xuat: {GetYear()}";
    }
}

















