using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyNgoaiLe
{
    class Program
    {
        static void NgoaiLe()
        {
            try
            {
                Console.WriteLine("Moi nhao vao ngay thang nam sinh: ");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("Ngay sinh cua ban la: " + birthday.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cam on ban da su dung chuong trinh");//Vẫn chạy khi dù có lỗi hay không
            }
        }
        static void Main()
        {
            NgoaiLe();
        }
    }
}