namespace XepLichNhanVien
{
    partial class FChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChinh));
            this.pnTong = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TrangChuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyChucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCaTrựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiĐườngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnTong.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTong
            // 
            this.pnTong.Controls.Add(this.pnBody);
            this.pnTong.Controls.Add(this.menuStrip1);
            this.pnTong.Location = new System.Drawing.Point(0, 0);
            this.pnTong.Name = "pnTong";
            this.pnTong.Size = new System.Drawing.Size(1561, 790);
            this.pnTong.TabIndex = 0;
            // 
            // pnBody
            // 
            this.pnBody.Location = new System.Drawing.Point(3, 35);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1550, 755);
            this.pnBody.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrangChuToolStripMenuItem1,
            this.thoátToolStripMenuItem,
            this.qLThongTinToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1561, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TrangChuToolStripMenuItem1
            // 
            this.TrangChuToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.TrangChuToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrangChuToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangChuToolStripMenuItem1.Image = global::XepLichNhanVien.Properties.Resources.home;
            this.TrangChuToolStripMenuItem1.Name = "TrangChuToolStripMenuItem1";
            this.TrangChuToolStripMenuItem1.Size = new System.Drawing.Size(119, 28);
            this.TrangChuToolStripMenuItem1.Text = "Xếp lịch";
            this.TrangChuToolStripMenuItem1.Click += new System.EventHandler(this.TrangChuToolStripMenuItem1_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.thoátToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(14, 28);
            // 
            // qLThongTinToolStripMenuItem
            // 
            this.qLThongTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLyNhanVienToolStripMenuItem,
            this.qLyChucNangToolStripMenuItem,
            this.qLyPhongToolStripMenuItem,
            this.quảnLýCaTrựcToolStripMenuItem,
            this.thayĐổiĐườngDẫnToolStripMenuItem});
            this.qLThongTinToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qLThongTinToolStripMenuItem.Image = global::XepLichNhanVien.Properties.Resources.quanLy;
            this.qLThongTinToolStripMenuItem.Name = "qLThongTinToolStripMenuItem";
            this.qLThongTinToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.qLThongTinToolStripMenuItem.Text = "Quản lý Thông tin";
            this.qLThongTinToolStripMenuItem.Click += new System.EventHandler(this.qLThongTinToolStripMenuItem_Click);
            // 
            // qLyNhanVienToolStripMenuItem
            // 
            this.qLyNhanVienToolStripMenuItem.Image = global::XepLichNhanVien.Properties.Resources.employ;
            this.qLyNhanVienToolStripMenuItem.Name = "qLyNhanVienToolStripMenuItem";
            this.qLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            this.qLyNhanVienToolStripMenuItem.Text = "Quản lý Nhân viên";
            this.qLyNhanVienToolStripMenuItem.Click += new System.EventHandler(this.qLyNhanVienToolStripMenuItem_Click);
            // 
            // qLyChucNangToolStripMenuItem
            // 
            this.qLyChucNangToolStripMenuItem.Image = global::XepLichNhanVien.Properties.Resources.phân_công;
            this.qLyChucNangToolStripMenuItem.Name = "qLyChucNangToolStripMenuItem";
            this.qLyChucNangToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            this.qLyChucNangToolStripMenuItem.Text = "Quản lý Chuyên môn";
            this.qLyChucNangToolStripMenuItem.Click += new System.EventHandler(this.qLyChucNangToolStripMenuItem_Click);
            // 
            // qLyPhongToolStripMenuItem
            // 
            this.qLyPhongToolStripMenuItem.Image = global::XepLichNhanVien.Properties.Resources.Phong;
            this.qLyPhongToolStripMenuItem.Name = "qLyPhongToolStripMenuItem";
            this.qLyPhongToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            this.qLyPhongToolStripMenuItem.Text = "Quản lý Phòng";
            this.qLyPhongToolStripMenuItem.Click += new System.EventHandler(this.qLyPhongToolStripMenuItem_Click);
            // 
            // quảnLýCaTrựcToolStripMenuItem
            // 
            this.quảnLýCaTrựcToolStripMenuItem.Image = global::XepLichNhanVien.Properties.Resources.client;
            this.quảnLýCaTrựcToolStripMenuItem.Name = "quảnLýCaTrựcToolStripMenuItem";
            this.quảnLýCaTrựcToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            this.quảnLýCaTrựcToolStripMenuItem.Text = "Quản lý Ca trực";
            this.quảnLýCaTrựcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCaTrựcToolStripMenuItem_Click);
            // 
            // thayĐổiĐườngDẫnToolStripMenuItem
            // 
            this.thayĐổiĐườngDẫnToolStripMenuItem.Image = global::XepLichNhanVien.Properties.Resources.changeSever1;
            this.thayĐổiĐườngDẫnToolStripMenuItem.Name = "thayĐổiĐườngDẫnToolStripMenuItem";
            this.thayĐổiĐườngDẫnToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            this.thayĐổiĐườngDẫnToolStripMenuItem.Text = "Thay đổi đường dẫn";
            this.thayĐổiĐườngDẫnToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiĐườngDẫnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.thoátToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.thoátToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.thoátToolStripMenuItem1.Image = global::XepLichNhanVien.Properties.Resources.thoát;
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(99, 28);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // FChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 791);
            this.Controls.Add(this.pnTong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý Xếp lịch Nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FChinh_FormClosing);
            this.pnTong.ResumeLayout(false);
            this.pnTong.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrangChuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem qLThongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyChucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyPhongToolStripMenuItem;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCaTrựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiĐườngDẫnToolStripMenuItem;
    }
}

