
namespace XepLichNhanVien
{
    partial class F_XepLich
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btXepLich = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDuoi = new System.Windows.Forms.DateTimePicker();
            this.dateTren = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btChon = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbCaTruc = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1521, 60);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Xếp lịch Nhân viên";
            // 
            // btXepLich
            // 
            this.btXepLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btXepLich.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXepLich.Location = new System.Drawing.Point(593, 186);
            this.btXepLich.Name = "btXepLich";
            this.btXepLich.Size = new System.Drawing.Size(175, 41);
            this.btXepLich.TabIndex = 24;
            this.btXepLich.Text = "Xếp lịch";
            this.btXepLich.UseVisualStyleBackColor = false;
            this.btXepLich.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(941, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 42);
            this.label3.TabIndex = 82;
            this.label3.Text = "Danh sách Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 89;
            this.label4.Text = "Từ ngày";
            // 
            // dateDuoi
            // 
            this.dateDuoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDuoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDuoi.Location = new System.Drawing.Point(810, 77);
            this.dateDuoi.Name = "dateDuoi";
            this.dateDuoi.Size = new System.Drawing.Size(200, 30);
            this.dateDuoi.TabIndex = 90;
            // 
            // dateTren
            // 
            this.dateTren.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTren.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTren.Location = new System.Drawing.Point(1244, 76);
            this.dateTren.Name = "dateTren";
            this.dateTren.Size = new System.Drawing.Size(200, 30);
            this.dateTren.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1109, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 91;
            this.label5.Text = "Đến ngày";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9});
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 246);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1498, 435);
            this.dgvNhanVien.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 96;
            this.label6.Text = "Nơi lưu";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUrl.Location = new System.Drawing.Point(221, 135);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.ReadOnly = true;
            this.tbUrl.Size = new System.Drawing.Size(915, 30);
            this.tbUrl.TabIndex = 97;
            // 
            // btChon
            // 
            this.btChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btChon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChon.Location = new System.Drawing.Point(1169, 130);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(137, 41);
            this.btChon.TabIndex = 98;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = false;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbCaTruc
            // 
            this.cbCaTruc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaTruc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaTruc.FormattingEnabled = true;
            this.cbCaTruc.Location = new System.Drawing.Point(221, 82);
            this.cbCaTruc.Name = "cbCaTruc";
            this.cbCaTruc.Size = new System.Drawing.Size(422, 32);
            this.cbCaTruc.TabIndex = 100;
            this.cbCaTruc.SelectedIndexChanged += new System.EventHandler(this.cbCaTruc_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(56, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 24);
            this.label20.TabIndex = 99;
            this.label20.Text = "Ca trực";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã nhân viên";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Chuyên môn";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Họ tên";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Chọn";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // F_XepLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1522, 693);
            this.Controls.Add(this.cbCaTruc);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.dateTren);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateDuoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btXepLich);
            this.Controls.Add(this.panel1);
            this.Name = "F_XepLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.F_XepLich_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXepLich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDuoi;
        private System.Windows.Forms.DateTimePicker dateTren;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.ComboBox cbCaTruc;
        private System.Windows.Forms.Label label20;
    }
}