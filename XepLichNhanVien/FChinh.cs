using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XepLichNhanVien
{
    public partial class FChinh : Form
    {
        private Form formCon;
        public FChinh()
        {
            InitializeComponent();
            OpenChildForm(new F_XepLich());
        }

        private void OpenChildForm(Form childForm)
        {
            if (formCon != null)
            {
                formCon.Close();
            }
            formCon = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void FChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình ?", "Xác nhận", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QLNhanVien());
        }

        private void qLyChucNangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QLChuyenMon());
        }

        private void qLThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qLyPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QLPhong());
        }

        private void TrangChuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_XepLich());
        }

        private void quảnLýCaTrựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_QLCaTruc());
        }

        private void đăngKýCaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thayĐổiĐườngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DuongDan f = new F_DuongDan();
            f.ShowDialog();
            OpenChildForm(new F_XepLich());
        }
    }
}
