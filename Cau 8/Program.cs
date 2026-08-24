using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[10];

        // Nhập mảng
        Console.WriteLine("Nhap 10 phan tu cua mang:");

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        // In toàn bộ mảng - dùng foreach
        Console.WriteLine("\n===== TOAN BO MANG =====");
        foreach (int x in a)
        {
            Console.Write(x + " ");
        }

        // Tính tổng - dùng foreach
        long tong = 0;

        foreach (int x in a)
        {
            tong += x;
        }

        double trungBinh = (double)tong / a.Length;

        // Tìm lớn nhất, nhỏ nhất và vị trí
        int max = a[0];
        int min = a[0];
        int viTriMax = 0;
        int viTriMin = 0;

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                viTriMax = i;
            }

            if (a[i] < min)
            {
                min = a[i];
                viTriMin = i;
            }
        }

        // Đếm số chẵn và lẻ - dùng foreach
        int soChan = 0;
        int soLe = 0;

        foreach (int x in a)
        {
            if (x % 2 == 0)
                soChan++;
            else
                soLe++;
        }

        // Đảo ngược mảng - dùng for
        for (int i = 0; i < a.Length / 2; i++)
        {
            int temp = a[i];
            a[i] = a[a.Length - 1 - i];
            a[a.Length - 1 - i] = temp;
        }

        // In kết quả
        Console.WriteLine("\n\n===== KET QUA =====");
        Console.WriteLine($"Tong cac phan tu = {tong}");
        Console.WriteLine($"Trung binh = {trungBinh:F2}");
        Console.WriteLine($"Gia tri lon nhat = {max}, vi tri = {viTriMax}");
        Console.WriteLine($"Gia tri nho nhat = {min}, vi tri = {viTriMin}");
        Console.WriteLine($"So luong phan tu chan = {soChan}");
        Console.WriteLine($"So luong phan tu le = {soLe}");

        Console.WriteLine("\nMang sau khi dao nguoc:");
        foreach (int x in a)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }
}