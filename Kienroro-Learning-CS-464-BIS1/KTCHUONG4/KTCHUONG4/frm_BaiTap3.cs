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
    public partial class frm_BaiTap3 : Form
    {
        public frm_BaiTap3()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            //for (int i = 0; i < Lib_A.SelectedItems.Count; i++)  //(*)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
                //(*)  //i--; // sẽ dừng vòng for sau khi Lib_A được xóa hêt
            }
            listBox1.Sorted = true;  //// sort cả A và B vì trong quá trình làm sẽ chuyển dữ liệu qua lại giữa 2 ListBox
            listBox2.Sorted = true;
        }

        private void NextNext_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
            listBox1.Items.Clear();
            listBox2.Sorted = true;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
            }
            listBox1.Sorted = true;
            //Lib_B.Sorted = true;
        }

        private void PreviousPrevious_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i]);
            }
            listBox2.Items.Clear();
            listBox1.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listHocBong = "Môn đã chọn: ";
            for (int i = 0;i < listBox2.Items.Count;i++)
            {
                listHocBong += listBox2.Items[i].ToString();
                if (i < listBox2.Items.Count - 1) listHocBong += ", ";
            }
            ThongTin.AppendText(Name.Text.ToString() + Environment.NewLine + Date.Text + Environment.NewLine + Hour.Text + Environment.NewLine + listHocBong); 
        }
    }
}
