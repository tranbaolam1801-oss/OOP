using System;
using System.Collections.Generic;

namespace Bai2
{
    interface IThietBi
    {
        void ON();
        void OFF();
        bool IsON {get;}
        string Ten {get;}
    }
    class MayQuat: IThietBi
    {
        private bool trangthai = false;
        public string Ten
        {
            get {return "May quat";}
        }
        public void ON()
        {
            trangthai = true;
        }
        public void OFF()
        { 
            trangthai = false;
        }
        public bool IsON
        {
            get {return trangthai;}
        }
    }
    class DieuHoa: IThietBi
    {
        private bool trangthai = false;
        public string Ten
        {
            get {return "Dieu Hoa";}
        }
        public void ON()
        {
            trangthai = true;
        }
        public void OFF()
        {
            trangthai = false;
        }
        public bool IsON
        {
            get {return trangthai;}
        }
    }
    class TiVi: IThietBi
    {
        private bool trangthai = false;
        public string Ten
        {
            get {return "Ti vi";}
        }
        public void ON()
        {
            trangthai = true;
        }
        public void OFF()
        {
            trangthai = false;
        }
        public bool IsON
        {
            get {return trangthai;}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IThietBi> ds = new List<IThietBi>();
            ds.Add(new MayQuat());
            ds.Add(new DieuHoa());
            ds.Add(new TiVi());
            ds[0].ON();
            ds[1].OFF();
            ds[2].ON();
            Console.WriteLine("--- TRANG THAI CAC THIET BI---");
            foreach (var tb in ds)
            {
                Console.Write($"Thiet bi {tb.Ten} dang ");
                if (tb.IsON)
                    Console.WriteLine("MO");
                else
                    Console.WriteLine("TAT");
            }
        }
    }
}