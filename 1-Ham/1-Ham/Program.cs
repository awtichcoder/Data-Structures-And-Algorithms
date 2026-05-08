using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ham
{
    internal class Program
    {
        static int tong (int a, int b)
        {
            return a + b;
        }
         public static int  cong(int a, int b) => a + b;
        ///  tinh giai thua
        public static long giaiThua(int giaithua)
        {
            int Bien = 1;
            for(int i =1; i<=giaithua;i++)
            {
                Bien = Bien * i;
            }
            return Bien;
        }
        //Điều kiện ? Giá trị nếu Đúng : Giá trị nếu Sai;
        public static int  giaithua2(int n) => (n<= 1) ? 1:  n * giaithua2(n - 1);
        // void
        static void XinChao(string message)
        {
            Console.WriteLine($"xin chao {message}");

        }
        // tham tri
        static void ThamTri(int  a)
        {
            a += 1;
            Console.WriteLine("trong khi goi tham tri: "+a);
        }
        // tham chieu ref
        static void ThamChieuref( ref int a)
        {
            a += 1;
            Console.WriteLine("trong khi goi tham tri: " + a);
        }
        // tham chieu out 
        static void ThamChieuout( out int a)
        {
            a = 1;
            
            Console.WriteLine("trong khi goi tham tri: " + a);
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int GiaiThua = 4;
            string mess = "Awtichcoder";
            Console.WriteLine("ham tinh tong la: {0}",tong(a,b));
            Console.WriteLine($"ham tinh cong la:{cong(a,b)}");
            Console.WriteLine($"Giai thua cua {GiaiThua}!={giaiThua(GiaiThua)}");
            Console.WriteLine($"Giai thua2 cua {GiaiThua}!={giaithua2(GiaiThua)}");
            XinChao(mess);
            Console.WriteLine("------------------------------------------");
            // tham tri khom lam thay doi ket qua cua bien
            Console.WriteLine("Tham tri");
            Console.WriteLine("a truoc khi goi tham tri: "+a);
            ThamTri(a);
            Console.WriteLine("a sau khi goi tham tri: " + a);
            Console.WriteLine("------------------------------------------");
            // tham chieu no se thay doi ket qua khi roi khoi ham
            // ref thi phai dat truoc luc goi ham
            Console.WriteLine("Tham chieu ref");
            Console.WriteLine("a truoc khi goi tham tri: " + a);
            ThamChieuref( ref a);
            Console.WriteLine("a sau khi goi tham tri: " + a);
            // out minh phai khoi tao gia tri ben trong ham
            
            Console.WriteLine("Tham chieu out");
            Console.WriteLine("a truoc khi goi tham tri: " + a);
            ThamChieuout( out a);
            Console.WriteLine("a sau khi goi tham tri: " + a);



        }
    }
}
