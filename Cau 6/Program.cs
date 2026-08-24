using System;

class Program
{
    static void Main(string[] args)
    {
        int n;

        // Nhập lại nếu n không nằm trong khoảng 1-9
        do
        {
            Console.Write("Nhap so nguyen n (1 <= n <= 9): ");
            n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 9)
            {
                Console.WriteLine("Loi! Vui long nhap lai n trong khoang 1-9.");
            }

        } while (n < 1 || n > 9);

        // In bảng cửu chương
        Console.WriteLine($"\nBang cuu chuong {n}:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} × {i} = {n * i}");
        }
    }
}