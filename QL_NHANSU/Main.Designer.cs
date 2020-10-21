namespace QL_NHANSU
{
    partial class Main
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
            this.btnDangky = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.FormQl = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DuAn = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.FormQl});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1762, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDangky,
            this.btnDangxuat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(224, 26);
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(224, 26);
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // FormQl
            // 
            this.FormQl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NhanVienToolStripMenuItem,
            this.phòngBanToolStripMenuItem,
            this.DuAn});
            this.FormQl.Name = "FormQl";
            this.FormQl.Size = new System.Drawing.Size(73, 24);
            this.FormQl.Text = "Quản lý";
            // 
            // NhanVienToolStripMenuItem
            // 
            this.NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem";
            this.NhanVienToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.NhanVienToolStripMenuItem.Text = "Nhân viên";
            this.NhanVienToolStripMenuItem.Click += new System.EventHandler(this.NhanVienToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // DuAn
            // 
            this.DuAn.Name = "DuAn";
            this.DuAn.Size = new System.Drawing.Size(163, 26);
            this.DuAn.Text = "Dự án";
            this.DuAn.Click += new System.EventHandler(this.DuAn_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::QL_NHANSU.Properties.Resources.ns;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 28);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1762, 712);
            this.panelMain.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1762, 740);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDangky;
        private System.Windows.Forms.ToolStripMenuItem FormQl;
        private System.Windows.Forms.ToolStripMenuItem NhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem dựÁnToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem btnDangxuat;
        private System.Windows.Forms.ToolStripMenuItem DuAn;
    }
}