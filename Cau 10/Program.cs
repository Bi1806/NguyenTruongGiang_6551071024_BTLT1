using System;

class Program
{
    static void Main(string[] args)
    {
        int n;

        try
        {
            Console.Write("Nhap so nguyen duong n (n <= 1000): ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0 || n > 1000)
            {
                Console.WriteLine("Loi! Vui long nhap n trong khoang 1 den 1000.");
                return;
            }

            int dem = 0;

            Console.WriteLine($"\nCac so nguyen to tu 2 den {n}:");

            // Vòng lặp ngoài: xét từng số
            for (int i = 2; i <= n; i++)
            {
                bool laSoNguyenTo = true;

                // Vòng lặp trong: kiểm tra i có phải số nguyên tố không
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }

                if (laSoNguyenTo)
                {
                    Console.Write(i + " ");
                    dem++;
                }
            }

            Console.WriteLine($"\n\nTong so luong so nguyen to: {dem}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Loi! Ban phai nhap mot so nguyen.");
        }
    }
}