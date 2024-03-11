using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTCHUONG4
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void BaiTap1_Click(object sender, EventArgs e)
        {
            frm_BaiTap1 frm_BaiTap1 = new frm_BaiTap1();
            frm_BaiTap1.ShowDialog();
        }

        private void BaiTap2_Click(object sender, EventArgs e)
        {
            frm_BaiTap2 frm_BaiTap2 = new frm_BaiTap2();
            frm_BaiTap2.ShowDialog();
        }

        private void BaiTap3_Click(object sender, EventArgs e)
        {
            frm_BaiTap3 frm_BaiTap3 = new frm_BaiTap3();
            frm_BaiTap3.ShowDialog();
        }
    }
}
