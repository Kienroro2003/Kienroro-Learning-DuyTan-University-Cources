using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai2
{
    public partial class NhapHSCB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Khởi_Tạo_Các_Controls();
        }

        protected void Khởi_Tạo_Các_Controls()
        {
            int i; ListItem L;
            for (i = 1; i <= 31; i++)
            {
                L = new ListItem(i.ToString(), i.ToString());
                cboNgaySinh.Items.Add(L);
            }
            for (i = 1; i <= 12; i++)
            {
                L = new ListItem(i.ToString(), i.ToString());
                cboThangSinh.Items.Add(L);
            }
            for (i = 1950; i <= 1990; i++)
            {
                L = new ListItem(i.ToString(), i.ToString());
                cboNamSinh.Items.Add(L);
            }


        }
        public void KiemTra()
        {
            if (HoVaTen.Text.Trim().ToString() == "")
            {
                Console.WriteLine("Go Go!!!");
                lblTrangThai.Visible = true;
                lblTrangThai.Text = "Họ tên không được rỗng !";
            }
            else
            {
                lblTrangThai.Visible = false;
            }
        }
        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            KiemTra();
        }

    }
}