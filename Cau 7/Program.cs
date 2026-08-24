using System;

class Program
{
    static void Main(string[] args)
    {
        int n;

        // Nhập n là số nguyên dương
        do
        {
            Console.Write("Nhap so nguyen duong n: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Loi! Vui long nhap n > 0.");
            }

        } while (n <= 0);

        // Khai báo kiểu long
        long tong = 0;
        long tongChan = 0;
        long tongLe = 0;

        // Dùng vòng lặp for tính các tổng
        for (int i = 1; i <= n; i++)
        {
            // Tổng 1 + 2 + ... + n
            tong += i;

            // Tổng các số chẵn
            if (i % 2 == 0)
            {
                tongChan += i;
            }

            // Tổng các số lẻ
            else
            {
                tongLe += i;
            }
        }

        // Dùng vòng lặp while tính giai thừa
        long giaiThua = 1;
        int j = 1;

        while (j <= n)
        {
            giaiThua *= j;
            j++;
        }

        // In kết quả
        Console.WriteLine("\n===== KET QUA =====");
        Console.WriteLine($"Tong 1 + 2 + ... + {n} = {tong}");
        Console.WriteLine($"Tong cac so chan tu 1 den {n} = {tongChan}");
        Console.WriteLine($"Tong cac so le tu 1 den {n} = {tongLe}");
        Console.WriteLine($"Giai thua {n}! = {giaiThua}");
    }
}