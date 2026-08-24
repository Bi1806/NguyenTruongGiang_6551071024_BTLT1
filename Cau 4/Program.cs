using System;

namespace KiemTraSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập số nguyên
            Console.Write("Nhập một số nguyên: ");
            int n = int.Parse(Console.ReadLine());

            // Kiểm tra dương, âm hoặc bằng 0
            if (n > 0)
                Console.WriteLine("Số đó là số dương");
            else if (n < 0)
                Console.WriteLine("Số đó là số âm");
            else
                Console.WriteLine("Số đó bằng 0");

            // Kiểm tra chẵn hoặc lẻ
            if (n % 2 == 0)
                Console.WriteLine("Số đó là số chẵn");
            else
                Console.WriteLine("Số đó là số lẻ");

            // Kiểm tra chia hết cho 3
            if (n % 3 == 0)
                Console.WriteLine("Số đó chia hết cho 3");
            else
                Console.WriteLine("Số đó không chia hết cho 3");

            // Kiểm tra chia hết cho cả 2 và 3
            if (n % 2 == 0 && n % 3 == 0)
                Console.WriteLine("Số đó chia hết cho cả 2 và 3");
            else
                Console.WriteLine("Số đó không chia hết cho cả 2 và 3");
        }
    }
}