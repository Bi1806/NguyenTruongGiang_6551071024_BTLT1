using System;

namespace XepLoaiHocSinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập điểm trung bình
            Console.Write("Nhập điểm trung bình: ");
            double diem = double.Parse(Console.ReadLine());

            // Xếp loại
            if (diem < 0 || diem > 10)
            {
                Console.WriteLine("Điểm không hợp lệ!");
            }
            else if (diem >= 9.0)
            {
                Console.WriteLine("Xếp loại: Xuất sắc");
            }
            else if (diem >= 8.0)
            {
                Console.WriteLine("Xếp loại: Giỏi");
            }
            else if (diem >= 6.5)
            {
                Console.WriteLine("Xếp loại: Khá");
            }
            else if (diem >= 5.0)
            {
                Console.WriteLine("Xếp loại: Trung bình");
            }
            else
            {
                Console.WriteLine("Xếp loại: Yếu");
            }
        }
    }
}