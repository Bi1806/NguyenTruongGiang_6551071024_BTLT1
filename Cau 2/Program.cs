using System;

namespace MayTinhDonGian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập hai số thực
            Console.Write("Nhập số a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            double b = double.Parse(Console.ReadLine());

            // Các phép toán
            double cong = a + b;
            double tru = a - b;
            double nhan = a * b;
            double chia = a / b;

            // Ép kiểu về int để chia lấy phần nguyên và phần dư
            int phanNguyen = (int)a / (int)b;
            int phanDu = (int)a % (int)b;

            // Lũy thừa
            double luyThua = Math.Pow(a, b);

            // In kết quả
            Console.WriteLine();
            Console.WriteLine("Kết quả:");
            Console.WriteLine("Cộng: " + cong);
            Console.WriteLine("Trừ: " + tru);
            Console.WriteLine("Nhân: " + nhan);
            Console.WriteLine("Chia: " + chia);
            Console.WriteLine("Chia lấy phần nguyên: " + phanNguyen);
            Console.WriteLine("Chia lấy phần dư: " + phanDu);
            Console.WriteLine("Lũy thừa a^b: " + luyThua);
        }
    }
}