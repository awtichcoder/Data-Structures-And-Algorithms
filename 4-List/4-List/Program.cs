using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 khoi tao List
            List<int> ds1 = new List<int>();
            List<float> ds2 = new List<float>();
            // 2 gan phan tu
            List<int> ds3 = new List<int>() { 1,2,31,32,232,453,2,3,4};
            // 3 in ra phan tu
            foreach( int i in ds3)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            // Add
            List<int> ds4 = new List<int>();
            ds4.Add(100);
            ds4.Add(0);
            ds4.Add(102);
            ds4.ForEach(i => Console.Write(i+" "));
            
            // Remove xoa phan tu dau tieen xuat hien trong mang
            Console.WriteLine();
            ds4.Remove(0);
            ds4.ForEach(i => {
                // cac yeu cau khac
                Console.Write(i + " ");
            });
            Console.WriteLine();
            //Count
            Console.WriteLine(" so phan tu trong mang ds4 la: " +ds4.Count);
            //Clear
            
            ds4.Clear();
            Console.WriteLine(" ds4 da bi clear()");
            ds4.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            //AddRange()
            Console.WriteLine(" ds5 sao khi them cao ds6");
            List<int> ds5 = new List<int>() {1,42,23 };
            List<int> ds6 = new List<int>() { 43,232,3};
            ds5.AddRange(ds6);
            ds5.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            // Contains : gia tri co ton tai hay khom
            bool kq = ds5.Contains(3);
            Console.WriteLine(kq);
            // Insert(index, value)
            List<int> ds7 = new List<int>() { 1, 42, 23 };
            ds7.Insert(1, 34);
            ds7.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();

            //RemoveAt( int index) xoa phan tu vi tri index chi dinh
            ds7.RemoveAt(1);
            ds7.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            //Reverse()
            ds7.Reverse();
            ds7.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            // BinarySearch()
            Console.WriteLine();
            List<int> ds8 = new List<int>() { 1, 42, 23 };
            int kq2 = ds8.BinarySearch(4234);
            Console.WriteLine("ket qua + "+kq2);






        }
    }
}
