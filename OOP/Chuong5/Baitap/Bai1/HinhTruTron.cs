using System;

namespace Bai1
{
    class HinhTruTron: Circle
    {
        public double Chieucao {get; set;}
        public HinhTruTron(double bankinh, double chieucao): base(bankinh)
        {
            Chieucao = chieucao;
        }
        public double ChuViDay
        {
            get {return DuongKinh * Math.PI;}
        }
        public double DienTichDay
        {
            get {return base.DienTich;}
        }
        public double DienTichXQ
        {
            get {return 2 * Math.PI * BanKinh * Chieucao;}
        }
        public double DienTichTP
        {
            get {return 2 * DienTichDay + DienTichXQ;}
        }
        public double TheTich
        {
            get {return DienTichDay * Chieucao;}
        }
    }
}