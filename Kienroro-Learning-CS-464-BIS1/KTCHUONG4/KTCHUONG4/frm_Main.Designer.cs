namespace KTCHUONG4
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcBàiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaiTap1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BaiTap2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BaiTap3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcBàiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // danhMụcBàiToolStripMenuItem
            // 
            this.danhMụcBàiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaiTap1,
            this.BaiTap2,
            this.BaiTap3});
            this.danhMụcBàiToolStripMenuItem.Name = "danhMụcBàiToolStripMenuItem";
            this.danhMụcBàiToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.danhMụcBàiToolStripMenuItem.Text = "Danh mục bài tập";
            // 
            // BaiTap1
            // 
            this.BaiTap1.Name = "BaiTap1";
            this.BaiTap1.Size = new System.Drawing.Size(296, 22);
            this.BaiTap1.Text = "Bài tập 1 - Bài Tập Giải Phương Trình Bậc 2";
            this.BaiTap1.Click += new System.EventHandler(this.BaiTap1_Click);
            // 
            // BaiTap2
            // 
            this.BaiTap2.Name = "BaiTap2";
            this.BaiTap2.Size = new System.Drawing.Size(296, 22);
            this.BaiTap2.Text = "Bài tập 2 - Bài Tập ListBox";
            this.BaiTap2.Click += new System.EventHandler(this.BaiTap2_Click);
            // 
            // BaiTap3
            // 
            this.BaiTap3.Name = "BaiTap3";
            this.BaiTap3.Size = new System.Drawing.Size(296, 22);
            this.BaiTap3.Text = "Bài tập 3 - Chọn Môn Học";
            this.BaiTap3.Click += new System.EventHandler(this.BaiTap3_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "from_Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcBàiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaiTap1;
        private System.Windows.Forms.ToolStripMenuItem BaiTap2;
        private System.Windows.Forms.ToolStripMenuItem BaiTap3;
    }
}