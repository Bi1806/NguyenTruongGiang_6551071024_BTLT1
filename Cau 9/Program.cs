using System;

class Program
{
    static void Main(string[] args)
    {
        // Nhập họ tên
        Console.Write("Nhap ho ten day du: ");
        string hoTen = Console.ReadLine();

        // Độ dài chuỗi
        Console.WriteLine($"\nDo dai chuoi: {hoTen.Length}");

        // Chữ HOA và chữ thường
        Console.WriteLine($"Chuoi chu HOA: {hoTen.ToUpper()}");
        Console.WriteLine($"Chuoi chu thuong: {hoTen.ToLower()}");

        // Xóa khoảng trắng hai đầu
        string chuoiTrim = hoTen.Trim();
        Console.WriteLine($"Sau khi Trim: {chuoiTrim}");

        // Kiểm tra có chứa từ "Nguyễn"
        bool coNguyen = chuoiTrim.Contains("Nguyễn");

        if (coNguyen)
        {
            Console.WriteLine("Chuoi co chua tu \"Nguyen\".");
        }
        else
        {
            Console.WriteLine("Chuoi khong chua tu \"Nguyen\".");
        }

        // Tách chuỗi thành từng từ
        string[] cacTu = chuoiTrim.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("\n===== CAC TU TRONG HO TEN =====");

        foreach (string tu in cacTu)
        {
            Console.WriteLine(tu);
        }

        // Ghép lại bằng dấu "-"
        string chuoiGhep = String.Join("-", cacTu);

        Console.WriteLine($"\nChuoi sau khi ghep: {chuoiGhep}");
    }
}