using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Try___Catch___Finally
{
    internal class Program
    {
        public static long GiaiThua(int n)
        {
            if (n < 0)
            {
                // Tự tạo một ngoại lệ và quăng nó ra ngoài
                throw new ArgumentException("Số n không được là số âm!");
            }
            return n <= 1 ? 1 : n * GiaiThua(n - 1);
        }
        static void Main(string[] args)
        {
            // Try - Catch - Finally
            // try :doan ma nghi ngo loi
            try
            {
                int a = 10;
                int b = 4;
                int result = a / b;

            }
            catch(DivideByZeroException ex)
            {
                // Xử lý khi gặp lỗi chia cho 0
                Console.WriteLine("Lỗi: Không thể chia cho số không!");
            }
            catch(Exception ex)
            {
                Console.WriteLine($" loi kia thang gia kia {ex.Message}");
            }
            finally
            {
                // luon luon thuc hien du co loi hay khom
                // thuong thuong dong filr giai phong bo nho dong ket noi DB
                Console.WriteLine("eng game");
            }
            //
            try
            {
                // 2. Thử nhập dữ liệu
                Console.Write("Nhập một số để tính giai thừa: ");
                int input = int.Parse(Console.ReadLine());

                // 3. Gọi hàm
                long ketQua = GiaiThua(input);
                Console.WriteLine($"Kết quả: {ketQua}");
            }
            catch (ArgumentException ex)
            {
                // 4. Bắt lỗi do chính ta throw ở hàm GiaiThua
                Console.WriteLine($"Thông báo lỗi: {ex.Message}");
            }
            catch (FormatException)
            {
                // Bắt lỗi nếu người dùng nhập chữ thay vì nhập số
                Console.WriteLine("Lỗi: Bạn phải nhập vào một số nguyên!");
            }
            catch (Exception ex)
            {
                // Bắt các lỗi không mong muốn khác
                Console.WriteLine($"Có lỗi xảy ra: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Chương trình kết thúc.");
            }

        }
    }
}
