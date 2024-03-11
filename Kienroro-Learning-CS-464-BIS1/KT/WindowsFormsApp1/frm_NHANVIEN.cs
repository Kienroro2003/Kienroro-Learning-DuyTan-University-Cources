using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_NHANVIEN : Form
    {
        public frm_NHANVIEN()
        {
            InitializeComponent();
        }

        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NHANVIEN values ('" + txt_MSNV.Text + "', N'" + txt_HoTen.Text + "', N'" + txt_DiaChi.Text + "',Convert(datetime,'" + dt_ngaysinh.Text + "',103),'" + txt_ChucVu.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm sinh viên thành công");
            else MessageBox.Show("Thêm sinh viên thất bại");
            LoadNV();
        }

        private void resetTextBox()
        {
            txt_ChucVu.Text = "";
            txt_HoTen.Text = "";
            txt_MSNV.Text = "";
            txt_DiaChi.Text = "";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            string sql = "Delete NHANVIEN where MSNV = '" + txt_MSNV.Text + "'";
            var confirm = MessageBox.Show("Muốn xóa với id nhân viên " + txt_MSNV.Text, "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int kq = lopchung.ThemXoaSua(sql);
                resetTextBox();
                if (kq >= 1) MessageBox.Show("Xoá sinh viên thành công");
                else MessageBox.Show("Xoá sinh viên thất bại");
            }
               
            LoadNV();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            string sql = "Update NHANVIEN set HOTEN = N'" + txt_HoTen.Text + "',DIACHI = N'" + txt_DiaChi.Text + "',NGAYSINH = Convert(datetime,'" + dt_ngaysinh.Text + "',103),CHUCVU = '" + txt_ChucVu.Text + "' where MSNV ='" + txt_MSNV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật sinh viên thành công");
            else MessageBox.Show("Cập nhật sinh viên thất bại");
            LoadNV();
        }
        public void LoadNV()
        {

            string sql = "Select * from NHANVIEN";
            //DataTable dt = lopchung.LoadDL(sql);
            dt_NhanVien.DataSource = lopchung.LoadDL(sql);
        }

        private void dt_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dt_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSNV.Text = dt_NhanVien.CurrentRow.Cells["MSNV"].Value.ToString();
            txt_HoTen.Text = dt_NhanVien.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_DiaChi.Text = dt_NhanVien.CurrentRow.Cells["DIACHI"].Value.ToString();
            dt_ngaysinh.Text = dt_NhanVien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_ChucVu.Text = dt_NhanVien.CurrentRow.Cells["CHUCVU"].Value.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            
        }
    }
}
