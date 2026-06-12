namespace Bai4;

class Program
{
    static void Main(string[] args)
    {
        int n,i,tong,tich,tongchan,tongle,tichchan,tichle;
        int[]A;
        Console.Write("so phan tu cua mang A la: ");
        n=int.Parse(Console.ReadLine());
        A=new int [n];
        Console.WriteLine("Nhap cac phan tu vao mang A: ", n);
        for (i=0;i<n;i++)
        {
            Console.Write("Phan tu thu {0}: ",i+1);
            A[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Cac phan tu trong mang A la: ");
        for (i=0;i<n;i++)
        {
            Console.WriteLine(A[i]);
        }
        tong=0;
        for (i=0;i<n;i++)
        {
            tong+=A[i];
        }
        Console.WriteLine("Tong cac phan tu trong mang la: {0} ",tong);
        
        tich=1;
        for (i=0;i<n;i++)
        {
            tich*=A[i];
        }
        Console.WriteLine("Tich cac phan tu trong mang la: {0} ",tich);
        {
            tong=0;
            tongchan=0;
            tichchan=1;
            foreach( int So in A)
                if (So % 2 == 0)
                {
                    tong+=1;
                    tongchan+=So;
                    tichchan*=So;
                }   
            Console.WriteLine();
            Console.WriteLine("Cac phan tu chan trong mang: {0}", tong);
            Console.WriteLine("Tong cac phan tu chan trong mang: {0}",tongchan);
            Console.WriteLine("Tich cac phan tu chan trong mang: {0}",tichchan);
        }
        {
            tong=0;
            tongle=0;
            tichle=1;
            foreach( int So in A)
                if (So % 2 != 0)
                {
                    tong+=1;
                    tongle+=So;
                    tichle*=So;
                } 
            Console.WriteLine();
            Console.WriteLine("Cac phan tu le trong mang: {0}", tong);
            Console.WriteLine("Tong cac phan tu le trong mang: {0}",tongle);
            Console.WriteLine("Tich cac phan tu le trong mang: {0}",tichle);
            
        }
    }
}
