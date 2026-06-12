namespace MangHaiChieu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Nhập số nguyên n, m
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            // Nhập mảng 2 chiều có n dòng, m cột gồm các phần tử số nguyên
            int[,] A = new int[n, m];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"A[{i}, {j}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            // In mảng 2 chiều đã nhập
            Console.WriteLine("Mang hai chieu: ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // In tổng các dòng
            Console.WriteLine("Tong cac dong: ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int sumRow = 0; 
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    sumRow += A[i, j];
                }
                Console.WriteLine($"Tong cac so cua dong {i + 1} la: {sumRow}");
            }
            Console.WriteLine();

            // In tích các cột
            Console.WriteLine("Tich cac cot: ");
            for (int j = 0; j < A.GetLength(1); j++)
            {
                int productColumn = 1;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    productColumn *= A[i, j];
                }
                Console.WriteLine($"Tich cac so cua cot {j + 1} la: {productColumn}");
            }
            Console.WriteLine();

            // In và đếm các phần tử lẻ trong mảng
            int soPhanTuLe = 0;
            Console.Write("Cac phan tu le: ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 != 0)
                    {
                        Console.Write(A[i, j] + " ");
                        soPhanTuLe++;
                    }
                }
            }
            Console.WriteLine($"\nCo {soPhanTuLe} phan tu le trong mang\n");

            // In các đếm các phần tử chẵn trong mảng
            int soPhanTuChan = 0;
            Console.Write("Cac phan tu chan: ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        Console.Write(A[i, j] + " ");
                        soPhanTuChan++;
                    }
                }
            }
            Console.WriteLine($"\nCo {soPhanTuChan} phan tu chan trong mang\n");
        }
    }
}