using System;

namespace QLSinhVien
{
    public class SinhVienKCNTT : SinhVien
    {
        // DiemCS414, DiemIS311, DiemCS311 
        private double diemCS414;
        private double diemIS311;
        private double diemCS311;
        public SinhVienKCNTT()
        {
        }

        public SinhVienKCNTT(int mssv, string hoTen, string diaChi, DateTime ngaySinh, double diemCs414, double diemIs311, double diemCs311) : base(mssv, hoTen, diaChi, ngaySinh)
        {
            diemCS414 = diemCs414;
            diemIS311 = diemIs311;
            diemCS311 = diemCs311;
        }

        public double DiemCs414
        {
            get => diemCS414;
            set => diemCS414 = value;
        }

        public double DiemIs311
        {
            get => diemIS311;
            set => diemIS311 = value;
        }

        public double DiemCs311
        {
            get => diemCS311;
            set => diemCS311 = value;
        }

        public override double DiemTb { get => (this.diemCS311 + this.diemIS311 + this.diemCS414) / 3d; }
        
        /**
         * public override double DiemTb
        {
            get => (this.diemCS311 + this.diemIS311 + this.diemCS414) / 3d;
        }
         */

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập điểm CS 414: ");
            this.diemCS414 = base.NhapSoDouble();
            Console.WriteLine("Nhập điểm IS 311: ");
            this.diemIS311 = base.NhapSoDouble();
            Console.WriteLine("Nhập điểm CS 311: ");
            this.diemCS311 = base.NhapSoDouble();
        }
    }
}