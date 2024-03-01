using System.Windows.Forms;

namespace KTCHUONG4
{
    partial class frm_BaiTap3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Heading = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_Hour = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Hour = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Next = new System.Windows.Forms.Button();
            this.NextNext = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.PreviousPrevious = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ThongTin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.Color.Crimson;
            this.Heading.Location = new System.Drawing.Point(252, 9);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(253, 39);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Chọn môn học";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(110, 70);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(39, 13);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Họ tên";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Location = new System.Drawing.Point(110, 112);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(32, 13);
            this.lb_Date.TabIndex = 2;
            this.lb_Date.Text = "Ngày";
            // 
            // lb_Hour
            // 
            this.lb_Hour.AutoSize = true;
            this.lb_Hour.Location = new System.Drawing.Point(503, 112);
            this.lb_Hour.Name = "lb_Hour";
            this.lb_Hour.Size = new System.Drawing.Size(23, 13);
            this.lb_Hour.TabIndex = 3;
            this.lb_Hour.Text = "Giờ";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(183, 67);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(252, 20);
            this.Name.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.CustomFormat = "dd/MM/yyyy";
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(183, 106);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(252, 20);
            this.Date.TabIndex = 5;
            // 
            // Hour
            // 
            this.Hour.CustomFormat = "hh:mm";
            this.Hour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hour.Location = new System.Drawing.Point(556, 105);
            this.Hour.Name = "Hour";
            this.Hour.ShowUpDown = true;
            this.Hour.Size = new System.Drawing.Size(200, 20);
            this.Hour.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách học bổng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách đã chọn";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Lập Trình Net",
            "Java",
            "Web",
            "Hướng đối tượng"});
            this.listBox1.Location = new System.Drawing.Point(113, 227);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(202, 160);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(506, 227);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(202, 160);
            this.listBox2.TabIndex = 10;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(379, 227);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 11;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // NextNext
            // 
            this.NextNext.Location = new System.Drawing.Point(379, 267);
            this.NextNext.Name = "NextNext";
            this.NextNext.Size = new System.Drawing.Size(75, 23);
            this.NextNext.TabIndex = 12;
            this.NextNext.Text = ">>";
            this.NextNext.UseVisualStyleBackColor = true;
            this.NextNext.Click += new System.EventHandler(this.NextNext_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(379, 308);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 13;
            this.Previous.Text = "<";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // PreviousPrevious
            // 
            this.PreviousPrevious.Location = new System.Drawing.Point(379, 348);
            this.PreviousPrevious.Name = "PreviousPrevious";
            this.PreviousPrevious.Size = new System.Drawing.Size(75, 23);
            this.PreviousPrevious.TabIndex = 14;
            this.PreviousPrevious.Text = "<<";
            this.PreviousPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PreviousPrevious.UseVisualStyleBackColor = true;
            this.PreviousPrevious.Click += new System.EventHandler(this.PreviousPrevious_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thông tin";
            // 
            // ThongTin
            // 
            this.ThongTin.Location = new System.Drawing.Point(113, 437);
            this.ThongTin.Multiline = true;
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Size = new System.Drawing.Size(452, 166);
            this.ThongTin.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Làm trống";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 580);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frm_BaiTap3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThongTin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PreviousPrevious);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.NextNext);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.lb_Hour);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.Date);
            //this.Name = "frm_BaiTap3";
            this.Text = "frm_BaiTap3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_Hour;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.DateTimePicker Hour;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button Next;
        private Button NextNext;
        private Button Previous;
        private Button PreviousPrevious;
        private Label label3;
        private TextBox ThongTin;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}