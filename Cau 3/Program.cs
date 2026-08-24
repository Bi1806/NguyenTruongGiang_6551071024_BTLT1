using System;

namespace ChuyenDoiNhietDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập nhiệt độ Celsius
            Console.Write("Nhập nhiệt độ Celsius: ");
            decimal celsius = decimal.Parse(Console.ReadLine());

            // Chuyển đổi sang Fahrenheit và Kelvin
            decimal fahrenheit = celsius * 9 / 5 + 32;
            decimal kelvin = celsius + 273.15m;

            // In kết quả, làm tròn 2 chữ số thập phân
            Console.WriteLine();
            Console.WriteLine("Kết quả:");
            Console.WriteLine("Fahrenheit = {0:F2}", fahrenheit);
            Console.WriteLine("Kelvin = {0:F2}", kelvin);
        }
    }
}