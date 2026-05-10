using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapArray1
{
    internal class Program
    {
        static int[] MangDaoNguoc(int[] SoLuongPhanTu)
        {
            
            int[] mang1 = SoLuongPhanTu;
            for(int i=0;i<mang1.Length;i++)
            {
                for(int j=0;j<mang1.Length;j++)
                {
                    if (mang1[i] < mang1[j])
                    {

                        int swat = mang1[i];
                        mang1[i] = mang1[j];
                        mang1[j] = swat;


                    }
                }
            }
            return mang1;

        }
        static void Main(string[] args)
        {
            int[] MangChuaDuocDaoNguoc = {23,34,12,54,0,454,23,9,23,4,1,34,2,0 };

            int[] MangDaDuocDaoNguoc = MangDaoNguoc(MangChuaDuocDaoNguoc);

            foreach (int i in MangDaDuocDaoNguoc) Console.Write(i+" ");
            

        }
    }
}
