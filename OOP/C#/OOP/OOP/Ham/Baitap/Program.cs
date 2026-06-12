
/*1. Hàm mảng:
- Xây dựng các hàm: 
•	Nhập mảng 1 chiều
•	In mảng 1 chiều đã nhập 
•	In tổng, tích các phần tử trong mảng
•	In các phần tử chẵn
•	Tính tổng và tích các phần tử chẵn
•	In các phần tử lẻ
•	Tính tổng và tích các phần tử lẻ 
- Chương trình chính: 
•	Nhập số nguyên n
•	Gọi các hàm trên để thao tác với mảng có n phần tử nguyên
*/
namespace Baitap;
class Program
{
    static void Main(string[] args)
    {
        Nhap(out int n, out int[] A, out int i);
        InMang(A, n);
        TongTich(A, n,out int j, out int Tong, out int Tich);
        PTChan(A);
        TongTichChan(A, out int TongChan, out int TichChan);
        PTLe(A);
        TongTichLe(A, out int TongLe, out int TichLe);
    }

    //Nhập mảng 1 chiều
    static void Nhap(out int n, out int[] A, out int i)
    {
        // int n;
        // int[] A; //khai báo mảng nếu k dùng hàm còn nếu dùng thì bỏ ni đi 

        n=int.Parse(Console.ReadLine());
        A= new int[n]; //cấp phát động số phần tử
        for (i=0;i<n;i++)
        {
            Console.WriteLine("So thu {0}:", i+1);
            A[i]= int.Parse(Console.ReadLine());
        }

    }

    //In mảng 1 chiều đã nhập
    static void InMang(int[] A, int n)
    {
        //cách 1: dùng for:
        Console.WriteLine("Cach 1:");
        for (int So=0; So<n; So++)
        {
            Console.WriteLine(A[So]);
        }
        //cách 2: dùng foreach:
        Console.WriteLine("Cach 2:");
        foreach (int So1 in A)
        {
            Console.WriteLine(So1);
        }
    }
    //In tổng, tích các phần tử trong mảng
    static void TongTich(int[] A, int n, out int Tong, out int Tich, out int j )
    {
        Tong=0;
        for (j=0;j<n;j++)
        {
            Tong+=A[j];
        }
        Console.WriteLine("Tong cac phan tu trong mang la: {0}",Tong);

        Tich=1;
        for (j=0;j<n;j++)
        {
            Tich*=A[j];
        }
        Console.WriteLine("Tich cac phan tu trong mang la: {0}",Tich);
    }
    //In các phần tử chẵn
    static void PTChan(int[] A)
    {
        Console.WriteLine("Cac phan tu chan la: ");
        foreach (int So in A)
        {
            if (So%2==0)
            {
                Console.WriteLine(So);
            }
        }
    }
    //Tính tổng và tích các phần tử chẵn
    static void TongTichChan(int[] A, out int TongChan, out int TichChan)
    {
        TongChan=0;
        TichChan=1;
        foreach (int So in A)
        {
            if (So%2==0)
            {
                TongChan+=So;
                TichChan*=So;
            }
        }
        Console.WriteLine("Tong phan tu chan la: {0}", TongChan);
        Console.WriteLine("Tich phan tu chan la: {0}", TichChan);
    
    }

    //In các phần tử lẻ
    static void PTLe(int[] A)
    {
        Console.WriteLine("Cac phan tu le la: ");
        foreach (int So in A)
        {
            if (So%2!=0)
            {
                Console.WriteLine(So);
            }
        }
    }

    //Tính tổng và tích các phần tử lẻ 
     static void TongTichLe(int[] A, out int TongLe, out int TichLe)
    {
        TongLe=0;
        TichLe=1;
        foreach (int So in A)
        {
            if (So%2!=0)
            {
                TongLe+=So;
                TichLe*=So;
            }
        
        }
        Console.WriteLine("Tong phan tu le la: {0}", TongLe);
        Console.WriteLine("Tich phan tu le la: {0}", TichLe);
    }
}

