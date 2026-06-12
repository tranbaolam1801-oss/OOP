/*using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = Convert.ToInt32(Console.ReadLine()); 
      int b = Convert.ToInt32(Console.ReadLine()); 
      char c = Convert.ToChar(Console.ReadLine());
      if (c=='+')
      {
        Console.WriteLine("a+b={0}", a+b );

      }
      else if (c=='-')
      {
        Console.WriteLine("a-b={0}", a-b );

      }
      else if (c=='*')
      {
        Console.WriteLine("a*b={0}", a*b );

      }
      else if (c=='/')
      {
        if (b==0)
        Console.WriteLine("nhap lai~");
        else
        Console.WriteLine("a/b={0}", a/b );

      }

  }
}
}*/


/*using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      
      double a,b,c;
      a = Convert.ToDouble(Console.ReadLine());
      b = Convert.ToDouble(Console.ReadLine()); 
      c = Convert.ToDouble(Console.ReadLine()); 
      
      if(((a>=6.5) && (b>=5.5) && (c>=5.0)) && ((a+b+c>=18.0) || (a+b>=14)))
        Console.WriteLine("dau");
      else
        Console.WriteLine("rot");
    }
  }
}*/



/*namespace thungay

{
  class Program
  {
    static void Main(string[] args)
    {
      int a;
      a = Convert.ToInt32(Console.ReadLine());
      switch(a)
      {
        case 1:
          Console.WriteLine("Sunday"); break;
        case 2:
          Console.WriteLine("Monday"); break;
        case 3:
          Console.WriteLine("Tuesday"); break;
        case 4:
          Console.WriteLine("Wednesday"); break;
        case 5:
          Console.WriteLine("Thursday"); break;
        case 6:
          Console.WriteLine("Friday"); break;
        case 7:
          Console.WriteLine("Sunday"); break;
        default:
          Console.WriteLine("Nhap lai cho tao"); break;
      }
    }
  }
}
*/

/*namespace NamNhuan
{
  class Program
  {
    static void Main(string[] args)
    {
      int a;
      a = Convert.ToInt32(Console.ReadLine());
      if ((a%4==0 & a%100!=0) || (a%400==0))
      {
        Console.WriteLine("Day la nam nhuan");
      }
      else
      {
        Console.WriteLine("Day khong phai la nam nhuan");
      }
      }
    }
  }
*/

/*namespace ThangTrongQuy
{
  class Program
  {
    static void Main(string[] args)
    {
      int Thang;
      Thang = Convert.ToInt32(Console.ReadLine());
      if ((Thang==1) || (Thang==2) || (Thang==3))
      {
        Console.WriteLine("Thang thuoc quy 1 va mua Xuan");
      }
      else if ((Thang==4) || (Thang==5) || (Thang==6))
      {
        Console.WriteLine("Thang thuoc quy 2 va mua Ha");
      }
      else if ((Thang==7) || (Thang==8) || (Thang==9))
      {
        Console.WriteLine("Thang thuoc quy 3 va mua Thu");
      }
      else if ((Thang==10) || (Thang==11) || (Thang==12))
      {
        Console.WriteLine("Thang thuoc quy 4 va mua Dong");
      }
      else
      {
        Console.WriteLine("Nhap lai");
      }
      }
    }
  }*/

/*namespace ViDu

{
  class Program
  {
    static void Main(string[] args)
    {
      double k,n,i,j,sum,sum1,sum3; 
      n=Convert.ToDouble(Console.ReadLine());
      sum=0;
      for (i=1;i<=n;i++)
        sum+=1/i;
      Console.WriteLine(Math.Round(sum,3));

      k=1;
      sum1=0;

      while (k<=n)
      {
        sum1+=1/k;
        k++;
      }
      Console.WriteLine(Math.Round(sum1,3));
      
      j=1;
      sum3=0;
      do
      {
        sum3+=1/j;
        j++;
       } while (j<=n);
      Console.WriteLine(Math.Round(sum3,3));



      }
    }
  }*/

 
  class HocSinh
{
    
    public float ChieuCao;
    public float CanNang;

   
    public HocSinh()
    {
        ChieuCao = 0;
        CanNang = 0;
    }

    public HocSinh(float ChieuCao, float canNang)
    {
        this.ChieuCao = ChieuCao;
        this.CanNang = CanNang;
    }

    
    public void Nhap()
    {
        Console.Write("Nhap chieu cao: ");
        ChieuCao = float.Parse(Console.ReadLine());
        Console.Write("Nhap can nang: ");
        CanNang = float.Parse(Console.ReadLine());
    }

    
    public float TinhBMI()
    {
        return CanNang / (ChieuCao * ChieuCao);
    }

    
    public string XepLoaiSucKhoe()
    {
        float bmi = TinhBMI();
        if (bmi < 18.5)
        {
            return "GAY";
        }
        else if (bmi < 25)
        {
            return "BINH THUONG";
        }
        else if (bmi < 30)
        {
            return "THUA CAN";
        }
        else
        {
            return "BEO PHI";
        }
    }

    
    public void Xuat()
    {
        Console.WriteLine("Chieu cao: {0} m", ChieuCao);
        Console.WriteLine("Can nang: {0} kg", CanNang);
        Console.WriteLine("Chi so BMI: {0:F2}", TinhBMI());
        Console.WriteLine("Xep loai suc khoe: {0}", XepLoaiSucKhoe());
    }
}
class Program
{
    static void Main(string[] args)
    {
        HocSinh hs = new HocSinh();
        hs.Nhap();
        hs.Xuat();
    }
}