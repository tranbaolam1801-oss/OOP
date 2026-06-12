using System;

namespace Bai1
{
    class HinhCau: Circle
    {
        public HinhCau(double bankinh): base(bankinh) {}
        public new double DienTich
        {
            get {return 4 * Math.PI * BanKinh * BanKinh;}
        }
        public double TheTich
        {
            get {return (4 / 3) * Math.PI * Math.Pow(BanKinh, 3);}
        }
    }
}