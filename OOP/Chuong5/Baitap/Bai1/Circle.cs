using System;

namespace Bai1
{
    class Circle
    {
        public double BanKinh{get; set;}
        public double DuongKinh
        {
            get {return 2 * BanKinh;}
        }
        public double DienTich
        {
            get {return Math.PI * BanKinh * BanKinh;}
        }
        public Circle(double bankinh)
        {
            BanKinh = bankinh;
        }
    }
}