using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XepLichNhanVien.DAO;
using XepLichNhanVien.DTO;

namespace XepLichNhanVien
{
    public partial class F_QLCaTruc : Form
    {
        public F_QLCaTruc()
        {
            InitializeComponent();
            loadDS();
        }
        private void loadDS()
        {
            dgvCa.Rows.Clear();
            int stt = 0;
            List<CaTruc> l = CaTrucDAO.Instance.L;
            foreach (CaTruc i in l)
            {
                DataGridViewRow row = (DataGridViewRow)dgvCa.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                row.Cells[1].Value = i.Ma;
                row.Cells[2].Value = i.Ten;
                row.Cells[3].Value = i.GhiChu;
                dgvCa.Rows.Add(row);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Tên ca trực không được để trống !", "Nhắc nhở");
                return;
            }
            if (CaTrucDAO.Instance.getByTen(tbTen.Text) != null)
            {
                MessageBox.Show("Ca trực '" + tbTen.Text + "' đã tồn tại !", "Nhắc nhở");
                return;
            }
            CaTrucDAO.Instance.them(tbTen.Text, tbGhiChu.Text);
            loadDS();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMa.Text))
            {
                MessageBox.Show("Hãy chọn ca trực cần xóa trước !", "Nhắc nhở");
                return;
            }
            CaTruc ca = CaTrucDAO.Instance.getByMa(tbMa.Text);
            if (MessageBox.Show("Xác nhận xóa ca trực '" + ca.Ten + "' ?\nMọi dữ liệu liên quan sẽ bị mất !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                CaTrucDAO.Instance.xoa(tbMa.Text);
                tbMa.Text = "";
                loadDS();
            }
        }

        private void dgvCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvCa.Rows[e.RowIndex];
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMa.Text))
            {
                MessageBox.Show("Hãy chọn ca trực cần cập nhật trước !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Tên ca trực không được để trống !", "Nhắc nhở");
                return;
            }
            CaTruc ca = CaTrucDAO.Instance.getByTen(tbTen.Text);
            if (ca != null && ca.Ma != tbMa.Text)
            {
                MessageBox.Show("Ca trực '" + tbTen.Text + "' đã tồn tại !", "Nhắc nhở");
                return;
            }
            CaTrucDAO.Instance.capNhat(tbMa.Text, tbTen.Text, tbGhiChu.Text);
            loadDS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaTruc ca=CaTrucDAO.Instance.getByMa(tbMa.Text);
            if (ca==null)
            {
                MessageBox.Show("Hãy chọn ca trực cần cập nhật trước !", "Nhắc nhở");
                return;
            }
            F_CTPhanCongCaTruc f = new F_CTPhanCongCaTruc(ca.Ma);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CaTruc ca = CaTrucDAO.Instance.getByMa(tbMa.Text);
            if (ca == null)
            {
                MessageBox.Show("Hãy chọn ca trực trước !", "Nhắc nhở");
                return;
            }
            F_DangKy f = new F_DangKy(ca.Ma);
            f.ShowDialog();
        }
    }
}
