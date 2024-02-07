using System;

namespace QLSinhVien
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Nhập số lượng sinh viên: ");
            // int n = int.Parse(Console.ReadLine());
            // SinhVien[] sinhViens = new SinhVien[n];
            // for (int i = 0; i < n; i++)
            // {
            //     sinhViens[i] = new SinhVienKCNTT();
            //     sinhViens[i].Nhap();
            //     sinhViens[i].Xuat();
            // }
            QLSinhVien qlSinhVien = new QLSinhVien();
            qlSinhVien.Nhap();
        }
    }
}