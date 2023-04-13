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
    public partial class F_QLPhong : Form
    {
        public F_QLPhong()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            loadDS();
        }  
        private void loadDS()
        {
            dgvPhong.Rows.Clear();
            int stt = 0;
            List<Phong> l = PhongDAO.Instance.L;
            foreach (Phong i in l)
            {
                DataGridViewRow row = (DataGridViewRow)dgvPhong.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                row.Cells[1].Value = i.MaPhong;
                row.Cells[2].Value = i.TenPhong;
                row.Cells[3].Value = i.GhiChu;
                dgvPhong.Rows.Add(row);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Tên phòng không được để trống !", "Nhắc nhở");
                return;
            }
            if (PhongDAO.Instance.getByTen(tbTen.Text) != null)
            {
                MessageBox.Show("Phòng '" + tbTen.Text + "' đã tồn tại !", "Nhắc nhở");
                return;
            }
            PhongDAO.Instance.them(tbTen.Text,tbGhiChu.Text);
            loadDS();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMa.Text))
            {
                MessageBox.Show("Hãy chọn phòng cần xóa trước !", "Nhắc nhở");
                return;
            }
            Phong p = PhongDAO.Instance.getByMa(tbMa.Text);
            if (MessageBox.Show("Xác nhận xóa phòng '"+p.TenPhong+"' ?\nMọi dữ liệu liên quan sẽ bị mất !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                PhongDAO.Instance.xoa(tbMa.Text);
                tbMa.Text = "";
                loadDS();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMa.Text))
            {
                MessageBox.Show("Hãy chọn phòng cần cập nhật trước !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Tên phòng không được để trống !", "Nhắc nhở");
                return;
            }
            Phong p = PhongDAO.Instance.getByTen(tbTen.Text);
            if (p != null&&p.MaPhong!=tbMa.Text)
            {
                MessageBox.Show("Phòng '" + tbTen.Text + "' đã tồn tại !", "Nhắc nhở");
                return;
            }
            PhongDAO.Instance.capNhat(tbMa.Text,tbTen.Text,tbGhiChu.Text);
            loadDS();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvPhong.Rows[e.RowIndex];
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Tên phòng không được để trống !", "Nhắc nhở");
                return;
            }
            if (MessageBox.Show("Xác nhận thêm phòng thêm hàng loạt !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string[] ten = tbTen.Text.Split(',');
                foreach (string t in ten)
                {
                    if(PhongDAO.Instance.getByTen(t)==null)
                        PhongDAO.Instance.them(t,"");
                }
                loadDS();
                MessageBox.Show("Thêm phòng hàng loạt thành công !", "Nhắc nhở");
            }
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Tên các phòng cách nhau bằng dấu ',' \nVí dụ 'Phòng 1,DV. 2,Chụp X.Quang'");
            }
        }
    }
}
