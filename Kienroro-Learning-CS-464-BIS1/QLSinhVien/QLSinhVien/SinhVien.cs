using System;
using System.Globalization;

namespace QLSinhVien
{
    public abstract class SinhVien
    {
        // MSSV, HoTen, DiaChi, NgaySinh,
        private int MSSV;
        private string hoTen;
        private string diaChi;
        private DateTime ngaySinh;
        
        public SinhVien()
        {
        }

        public SinhVien(int mssv, string hoTen, string diaChi, DateTime ngaySinh)
        {
            MSSV = mssv;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
        }

        public int Mssv
        {
            get => MSSV;
            set => MSSV = value;
        }

        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }

        public DateTime NgaySinh
        {
            get => ngaySinh;
            set => ngaySinh = value;
        }

        public abstract double DiemTb { get; }
        
        protected int NhapSo()
        {
            bool loop = true;
            int n = 0;
            while (loop)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out n))
                {
                    loop = false;
                }
                else Console.WriteLine("Invalid!!! Enter a integer: ");
            }

            return n;
        }
        
        protected double NhapSoDouble()
        {
            bool loop = true;
            double n = 0;
            while (loop)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out n))
                {
                    loop = false;
                }
                else Console.WriteLine("Invalid!!! Enter a double: ");
            }

            return n;
        }

        protected DateTime NhapNgaySinh()
        {
            DateTime res;
            while (!DateTime.TryParseExact(Console.ReadLine(),
                       "dd/MM/yyyy",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out res))
            {
                Console.WriteLine("incorrect time dd/MM/yyyy");
            }

            return res;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhập mã số sinh viên: ");
            this.MSSV = NhapSo();
            Console.WriteLine("Nhập họ tên: ");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ: ");
            this.DiaChi = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh: ");
            this.ngaySinh = NhapNgaySinh();
        }

        public string TinhXepLoai()
        {
            if (this.DiemTb >= 8) return "Giỏi";
            if (this.DiemTb >= 6.5) return "Khá";
            if (this.DiemTb >= 5) return "Trung bình";
            return "Trượt";
        }

        public void Xuat()
        {
            Console.WriteLine("Mã số sinh viên: " + this.MSSV);
            Console.WriteLine("Họ tên: " + this.hoTen);
            Console.WriteLine("Địa chỉ: " + this.diaChi);
            Console.WriteLine("Ngày sinh: "  + this.ngaySinh);
            Console.WriteLine("Điểm trung bình: {0}, xếp loại: {1}", this.DiemTb, TinhXepLoai());
        }
    }
}