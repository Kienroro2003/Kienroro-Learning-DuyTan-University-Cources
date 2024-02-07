using System;

namespace QLSinhVien
{
    public class QLSinhVien
    {
        private SinhVien[] sinhViens;

        public QLSinhVien()
        {
        }
        
        protected int NhapSo()
        {
            bool loop = true;
            int n = 0;
            while (loop)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out n) && n > 0)
                {
                    loop = false;
                }
                else Console.WriteLine("Invalid!!! Enter a integer: ");
            }

            return n;
        }

        public void Nhap()
        {
            string c;
            while (true)
            {
                Console.WriteLine("Nhập vào (D) sinh viên điện tử, (C) sinh viên công nghệ thông tin");
                c = Console.ReadLine();
                if (!(c.Equals("D") || c.Equals("C")))
                {
                    Console.WriteLine("Không hợp lệ. Chỉ nhập 1 trong 2 giá trị (D) và (C)");
                    continue;
                };
                Console.WriteLine("Nhập số lượng sinh viên: ");
                int n = NhapSo();
                this.sinhViens = new SinhVien[n];
                if (c.Equals("D"))
                {
                    for (int i = 0; i < n; i++)
                    {
                        this.sinhViens[i] = new SinhVienDienTu();
                        this.sinhViens[i].Nhap();
                    }
                }

                if (c.Equals("C"))
                {
                    for (int i = 0; i < n; i++)
                    {
                        this.sinhViens[i] = new SinhVienKCNTT();
                        this.sinhViens[i].Nhap();
                    }
                }
                for (int i = 0; i < this.sinhViens.Length; i++)
                {
                    this.sinhViens[i].Xuat();
                }
            }
        }
    }
}