using System;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            //Khai báo Dictionary
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Dictionary<int, string> dic1 = new Dictionary<int, string>() {{1,"Lam"}, {2,"An"}};
            //Thêm phần tử vào dic
            dic.Add(1,"Duyen");
            dic.Add(2,"Thuy");
            //Duyệt dic
            foreach (KeyValuePair<int,string> kvp in dic)
            {
                Console.WriteLine($"key: {kvp.Key}, Value: {kvp.Value}");
            }
            //Kiểm tra 1 Key có tồn tại trong Dic hay không
            bool kq = dic.ContainsKey(2);
            //Kiểm tra 1 VAlue có tồn tại trong Dic hay không
            bool kq2 = dic.ContainsValue("Lam");
            Console.WriteLine(kq2);
            //Lấy Value từ Key
            string name = dic[1];
            Console.WriteLine(name);
            //Xóa phần tử theo key
            dic1.Remove(1);
            //Xóa toàn bộ phần tử
            dic1.Clear();
            //Chuyển Value thành List
            List<string> ds = new List<string>();
            ds = dic.Values.ToList();
            foreach (string kt in ds)
            {
                Console.WriteLine(kt);
            }
            //Chuyển Key thành list
            List<int> dsso = new List<int>();
            dsso = dic.Keys.ToList();
            foreach (int i in dsso)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}