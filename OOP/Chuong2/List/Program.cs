using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo list
            List<int> ds1 = new List<int>(){12,3};
            List<float> ds2 = new List<float>();
            List<string> ds3 = new List<string>();
            List<int> ds4 = new List<int>(){1,2,3,4,5};
            Console.WriteLine(ds4[1]);
            //Add: them phan tu vao cuoi list
            ds4.Add(18);
            //Remove(object): Xóa phần tử xuất hiện đầu tiên
            //Count: Đếm số lượng phần tử
            //Clear(): Xóa toàn bộ phần tử
            //ds4.Clear();
            ds1.AddRange(ds4); // Thêm toàn bộ danh sách 4 vào cuối danh sách 1
            Console.WriteLine(ds1[5]);
            //bool <ds>.Contains(<Value>);
            bool kq = ds1.Contains(3);
            Console.WriteLine(kq);
            //GetRange(int index, int count): trả về 1 list con lấy từ vị trí index và lấy count kí tự của list nguồn
            List<int> ds5 = ds4.GetRange(1,2);
            Console.WriteLine()
            // int IndexOf(<Value>): Trả về vị trí index tìm thấy
            //Insert(int index, value);
            ds5.Insert(0,100);
            //InsertRange(index,<danh sách chèn thêm>): chèn danh sách chèn thêm vào vị trí index của list gốc
            List<int> ds15 = new List<int>() {1,2,3,4};
            List<int> ds16 = new List<int>() {3,5};
            ds15.InsertRange(2,ds16);
            Console.WriteLine(ds15);
            //RemoveRange(index, count): xóa từ index và xóa đi count phần tử
            // <ds>.Reverse(): Đảo ngược danh sách
            // Tìm kiếm nhị phân: int kq2 = ds20.BinarySearch(55);
            //int kq3 = ds20.Max();
        }
    }
}