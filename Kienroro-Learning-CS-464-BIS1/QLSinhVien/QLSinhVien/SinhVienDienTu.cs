using System;

namespace QLSinhVien
{
    public class SinhVienDienTu : SinhVien
    {
        // EE200,EE201,EE205
        private double diemEE200;
        private double diemEE201;
        private double diemEE205;

        public override double DiemTb { get => (this.diemEE200 + this.diemEE201 + this.diemEE205) / 3d; }

        public SinhVienDienTu()
        {
        }

        public SinhVienDienTu(int mssv, string hoTen, string diaChi, DateTime ngaySinh, double diemEe200, double diemEe201, double diemEe205) : base(mssv, hoTen, diaChi, ngaySinh)
        {
            diemEE200 = diemEe200;
            diemEE201 = diemEe201;
            diemEE205 = diemEe205;
        }

        public double DiemEe200
        {
            get => diemEE200;
            set => diemEE200 = value;
        }

        public double DiemEe201
        {
            get => diemEE201;
            set => diemEE201 = value;
        }

        public double DiemEe205
        {
            get => diemEE205;
            set => diemEE205 = value;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập điểm EE200: ");
            this.diemEE200 = NhapSoDouble();
            Console.WriteLine("Nhập điểm EE201: ");
            this.diemEE201 = NhapSoDouble();
            Console.WriteLine("Nhập điểm EE205: ");
            this.diemEE205 = NhapSoDouble();
        }
    }
}