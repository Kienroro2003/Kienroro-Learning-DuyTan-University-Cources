using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ADOP1
{
    public partial class frm_SinhVien : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_SinhVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SINHVIEN values ('" + txt_MSSV.Text + "', N'" + txt_HoTen.Text + "', N'" + txt_DiaChi.Text + "',Convert(datetime,'"+dt_ngaysinh.Text+"',103),'"+cb_Khoa.SelectedValue+"')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm sinh viên thành công");
            else MessageBox.Show("Thêm sinh viên thất bại");
            LoadSV(); 
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {

            string sql = "Select COUNT (*) from SINHVIEN"; 
            int sosv = (int)lopchung.LayGT(sql);
            txt_SoSV.Text = sosv.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            string sql = "Delete SINHVIEN where MSSV = '" + txt_MSSV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xoá sinh viên thành công");
            else MessageBox.Show("Xoá sinh viên thất bại");
            LoadSV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            string sql = "Update SINHVIEN set HOTEN = N'" + txt_HoTen.Text + "',DIACHI = N'" + txt_DiaChi.Text + "',NGAYSINH = Convert(datetime,'" + dt_ngaysinh.Text + "',103),MAKHOA = '" + cb_Khoa.SelectedValue + "' where MSSV ='" + txt_MSSV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật sinh viên thành công");
            else MessageBox.Show("Cập nhật sinh viên thất bại");
            LoadSV();
        }
        public void LoadSV()
        {

            string sql = "Select * from SINHVIEN";
            //DataTable dt = lopchung.LoadDL(sql);
            dt_SinhVien.DataSource = lopchung.LoadDL(sql);
        }
        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            LoadSV();
            string sql = "Select * from KHOA";
            cb_Khoa.DataSource =  lopchung.LoadDL(sql);
            cb_Khoa.DisplayMember = "TENKHOA";
            cb_Khoa.ValueMember = "MAKHOA";
        }

        private void dt_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dt_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSSV.Text = dt_SinhVien.CurrentRow.Cells["MSSV"].Value.ToString();
            txt_HoTen.Text = dt_SinhVien.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_DiaChi.Text = dt_SinhVien.CurrentRow.Cells["DIACHI"].Value.ToString();
            dt_ngaysinh.Text = dt_SinhVien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            cb_Khoa.SelectedValue = dt_SinhVien.CurrentRow.Cells["MAKHOA"].Value.ToString();
        }
    }
}
