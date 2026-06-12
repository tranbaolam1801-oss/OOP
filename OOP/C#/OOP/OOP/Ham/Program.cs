namespace Ham;
{
        class Program
        {
            static void Nhap(out int a, out int b)
            {
                a=Convert.ToInt32(Console.ReadLine());
                b=Convert.ToInt32(Console.ReadLine());
            }

            static void Cach1(int a, int b)
            {
                int Tong = a+b;
                int Hieu=a-b;
                int Tich=a*b;
                int Thuong= a/b;
                Console.WriteLine("Tong: {0}, Hieu: {1}, Tich: {2}, Thuong: {3}",Tong, Hieu, Tich, Thuong);
            }
            static void Cach2(int a, int b, out int Tong, out int Hieu, out int Tich, out int Thuong)
            {
                Tong = a+b;
                Hieu=a-b;
                Tich=a*b;
                Thuong= a/b;
            
            }
            static int Tong(int a, int b)
            {
                return a+b;            
            }
            static int Hieu(int a, int b)
            {
                return a-b;
            }
            static int Tich(int a, int b)
            {  
                return a*b;
            }
            static int Thuong(int a, int b)
            {
                return a/b;
            }
            static void Main(string[] args)
            {
                Nhap(out int a, out int b); 
                Cach1(a,b);
                Cach2(a, b, out int Tong, out int Hieu, out int Tich, out int Thuong);//Gọi hàm
                Console.WriteLine("Tong: {0}, Hieu: {1}, Tich: {2}, Thuong: {3}",Tong, Hieu, Tich, Thuong);//In kết quả
                //Gọi hàm nếu dùng cách 3
                Console.WriteLine("*Ham co kieu tra ve ket qua:");
                int Tong1=Tong(a,b);//Khai báo biến để nhận kết quả trả về
                int Hieu1=Hieu(a, b);//Khai báo biến để nhận kết quả trả về
                int Tich1=Tich(a, b);//Khai báo biến để nhận kết quả trả về
                int Thuong1=Thuong(a,b);//Khai báo biến để nhận kết quả trả về
                Console.WriteLine("Tong: {0}, Hieu: {1}, Tich: {2}, Thuong: {3}",Tong1, Hieu1, Tich1, Thuong1);//In kết quả
            }
        }
}



