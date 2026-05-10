using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khoi tao mang
            int[] MangSoNguyen = new int[6];// so phan tu la 7
            char[] MangKiTu = new char[3];

            // lenght
            Console.WriteLine($"lenght cua mang so nguyen {MangSoNguyen.Length}");
            // nhap du lieu
            for (int i = 0; i < MangSoNguyen.Length; i++)
            {
                if (i == MangSoNguyen.Length - 1)
                {
                    Console.WriteLine(" day la phan tu cuoi cung");
                }
                Console.Write($"Nhap phan tu thu {i}: ");
                MangSoNguyen[i] = int.Parse(Console.ReadLine());

            }

            // in ra du lieu
            // for
            for (int i = 0; i < MangSoNguyen.Length; i++)
            {
                Console.WriteLine(MangSoNguyen[i] + " " + i);
            }
            // foreach
            foreach (int i in MangSoNguyen)
            {
                Console.WriteLine(i);

            }
            // khoi tao mang ngau nhien
            Random random = new Random();
            int[] mang3 = new int[3] { random.Next(12), random.Next(34), random.Next(233) };
            foreach (int i in mang3)
            {
                Console.WriteLine(i);
            }


            int[] mang4 = new int[5];
            for (int i = 0; i < mang4.Length; i++)
            {
                mang4[i] = random.Next(123);

            }
            foreach (int i in mang4)
            {
                Console.WriteLine(i);
            }

            tham chieu
            int[] mang5 = { 12, 23, 42, 43, 234, 2324, 2324, 42 };
            int[] mang6 = mang5;
            Console.WriteLine("mang 5 ");
            foreach (int i in mang5) Console.WriteLine(i);
            Console.WriteLine("mang 6 ");
            foreach (int i in mang6) Console.WriteLine(i);
            Console.WriteLine(" sau khi thay doi tai index 0 va 1");
            mang5[0] = 100;
            mang6[1] = 100;
            Console.WriteLine("mang 5 ");
            foreach (int i in mang5) Console.WriteLine(i);
            Console.WriteLine("mang 6 ");
            foreach (int i in mang6) Console.WriteLine(i);
            // no se lien thong voi nhau

            // sap xep (Ham)

            int[] mang7 = { 12, 23, 42, 43, 234, 2324, 2324, 42 };
            Array.Sort(mang7);
            foreach (int i in mang7) Console.WriteLine(i);

            Console.WriteLine();
            // dao nguoc (Ham)
            int[] mang8 = { 12, 23, 42, 43, 234, 2324, 2324, 42 };
            Array.Reverse(mang7);
            foreach (int i in mang7) Console.WriteLine(i);
        }
    }
}
