namespace XepLichNhanVien
{
    partial class F_QLNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.btCapNhatNhanVien = new System.Windows.Forms.Button();
            this.btXoaNhanVien = new System.Windows.Forms.Button();
            this.btThemNhanVien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbChuyenMon = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Thông tin Nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1521, 60);
            this.panel1.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(126, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 24);
            this.label13.TabIndex = 38;
            this.label13.Text = "Mã";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNV.Location = new System.Drawing.Point(217, 82);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.ReadOnly = true;
            this.tbMaNV.Size = new System.Drawing.Size(392, 30);
            this.tbMaNV.TabIndex = 37;
            this.tbMaNV.TextChanged += new System.EventHandler(this.tbMaNV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Họ tên";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTen.Location = new System.Drawing.Point(217, 127);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(1124, 30);
            this.tbHoTen.TabIndex = 30;
            // 
            // btCapNhatNhanVien
            // 
            this.btCapNhatNhanVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatNhanVien.Location = new System.Drawing.Point(721, 190);
            this.btCapNhatNhanVien.Name = "btCapNhatNhanVien";
            this.btCapNhatNhanVien.Size = new System.Drawing.Size(127, 35);
            this.btCapNhatNhanVien.TabIndex = 28;
            this.btCapNhatNhanVien.Text = "Cập nhật";
            this.btCapNhatNhanVien.UseVisualStyleBackColor = true;
            this.btCapNhatNhanVien.Click += new System.EventHandler(this.btCapNhatNhanVien_Click);
            // 
            // btXoaNhanVien
            // 
            this.btXoaNhanVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaNhanVien.Location = new System.Drawing.Point(476, 190);
            this.btXoaNhanVien.Name = "btXoaNhanVien";
            this.btXoaNhanVien.Size = new System.Drawing.Size(100, 35);
            this.btXoaNhanVien.TabIndex = 27;
            this.btXoaNhanVien.Text = "Xóa";
            this.btXoaNhanVien.UseVisualStyleBackColor = true;
            this.btXoaNhanVien.Click += new System.EventHandler(this.btXoaNhanVien_Click);
            // 
            // btThemNhanVien
            // 
            this.btThemNhanVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNhanVien.Location = new System.Drawing.Point(217, 190);
            this.btThemNhanVien.Name = "btThemNhanVien";
            this.btThemNhanVien.Size = new System.Drawing.Size(114, 35);
            this.btThemNhanVien.TabIndex = 26;
            this.btThemNhanVien.Text = "Thêm";
            this.btThemNhanVien.UseVisualStyleBackColor = true;
            this.btThemNhanVien.Click += new System.EventHandler(this.btThemNhanVien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(770, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Chuyên môn";
            // 
            // cbChuyenMon
            // 
            this.cbChuyenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuyenMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenMon.FormattingEnabled = true;
            this.cbChuyenMon.Location = new System.Drawing.Point(963, 82);
            this.cbChuyenMon.Name = "cbChuyenMon";
            this.cbChuyenMon.Size = new System.Drawing.Size(378, 32);
            this.cbChuyenMon.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(985, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
            this.button1.TabIndex = 47;
            this.button1.Text = "Thêm hàng loạt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 246);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1499, 435);
            this.dgvNhanVien.TabIndex = 48;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Chuyên môn";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Họ tên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thứ hai";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thứ ba";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Thứ tư";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Thứ năm";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 90;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Thứ sáu";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 90;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Thứ bảy";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 90;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Chủ nhật";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 90;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1243, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 35);
            this.button2.TabIndex = 49;
            this.button2.Text = "Reset tần suất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // F_QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1523, 693);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbChuyenMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.btCapNhatNhanVien);
            this.Controls.Add(this.btXoaNhanVien);
            this.Controls.Add(this.btThemNhanVien);
            this.Controls.Add(this.panel1);
            this.Name = "F_QLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_QLNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Button btCapNhatNhanVien;
        private System.Windows.Forms.Button btXoaNhanVien;
        private System.Windows.Forms.Button btThemNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbChuyenMon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button button2;
    }
}