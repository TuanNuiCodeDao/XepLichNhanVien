using XepLichNhanVien.DAO;
using XepLichNhanVien.DTO;
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
    public partial class F_QLChuyenMon : Form
    {
        public F_QLChuyenMon()
        {
            InitializeComponent();
            loadDS();
        }
        private void loadDS()
        {
            dgvChucNang.Rows.Clear();
            int stt = 0;
            foreach (ChuyenMon i in ChuyenMonDAO.Instance.L)
            {
                DataGridViewRow row = (DataGridViewRow)dgvChucNang.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                row.Cells[1].Value = i.MaCM;
                row.Cells[2].Value = i.TenCM;
                row.Cells[3].Value = i.GhiChu;
                dgvChucNang.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Tên chuyên môn không được để trống !", "Nhắc nhở");
                return;
            }
            if (ChuyenMonDAO.Instance.getByTen(tbTen.Text) != null)
            {
                MessageBox.Show("Chuyên môn '" + tbTen.Text + "' đã tồn tại !", "Nhắc nhở");
                return;
            }
            ChuyenMonDAO.Instance.them(tbTen.Text, tbGhiChu.Text);
            loadDS();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMa.Text))
            {
                MessageBox.Show("Hãy chọn chuyên môn cần xóa trước !", "Nhắc nhở");
                return;
            }
            ChuyenMon cn = ChuyenMonDAO.Instance.getByMa(tbMa.Text);
            if (MessageBox.Show("Xác nhận xóa chuyên môn '" + cn.TenCM+"' ?\nMọi dữ liệu liên quan sẽ bị mất !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                ChuyenMonDAO.Instance.xoa(tbMa.Text);
                tbMa.Text = "";
                loadDS();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMa.Text))
            {
                MessageBox.Show("Hãy chọn chuyên môn cần cập nhật trước !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Tên chuyên môn không được để trống !", "Nhắc nhở");
                return;
            }
            ChuyenMon cn = ChuyenMonDAO.Instance.getByTen(tbTen.Text);
            if (cn != null&&cn.MaCM!=tbMa.Text)
            {
                MessageBox.Show("Chuyên môn '" + tbTen.Text + "' đã tồn tại !", "Nhắc nhở");
                return;
            }
            ChuyenMonDAO.Instance.capNhat(tbMa.Text,tbTen.Text,tbGhiChu.Text);
            loadDS();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvChucNang.Rows[e.RowIndex];
                tbMa.Text = Convert.ToString(row.Cells[1].Value);
                if (string.IsNullOrEmpty(tbMa.Text))
                {
                    return;
                }
                tbTen.Text = Convert.ToString(row.Cells[2].Value);
                tbGhiChu.Text = Convert.ToString(row.Cells[3].Value);
            }
            catch (Exception)
            { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
