using XepLichNhanVien.DAO;
using XepLichNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XepLichNhanVien
{
    public partial class F_QLNhanVien : Form
    {
        public F_QLNhanVien()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            loadDS();
            loadCbChuyenMon();
        }
        private void loadCbChuyenMon()
        {
            cbChuyenMon.DataSource = ChuyenMonDAO.Instance.L;
            cbChuyenMon.DisplayMember = "TenCM";
            if (ChuyenMonDAO.Instance.L.Count > 0)
            {
                cbChuyenMon.Text = ChuyenMonDAO.Instance.L[0].TenCM;
            }
        }
        private void loadDS()
        {
            dgvNhanVien.Rows.Clear();
            int stt = 0;
            foreach (NhanVien i in NhanVienDAO.Instance.L)
            {
                DataGridViewRow row = (DataGridViewRow)dgvNhanVien.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                row.Cells[1].Value = i.MaNV;
                ChuyenMon chucNang = ChuyenMonDAO.Instance.getByMa(i.MaCM);
                row.Cells[2].Value = chucNang.TenCM;
                row.Cells[3].Value = i.HoTen;
                row.Cells[4].Value = i.ThuHai;
                row.Cells[5].Value = i.ThuBa;
                row.Cells[6].Value = i.ThuTu;
                row.Cells[7].Value = i.ThuNam;
                row.Cells[8].Value = i.ThuSau;
                row.Cells[9].Value = i.ThuBay;
                row.Cells[10].Value = i.ChuNhat;
                dgvNhanVien.Rows.Add(row);
            }
        }

        private void btXoaNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = NhanVienDAO.Instance.getByMa(tbMaNV.Text);
            if (nv == null)
            {
                MessageBox.Show("Hãy chọn nhân viên cần xóa trước !", "Nhắc nhở");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa nhân viên " + nv.HoTen + " ?\nMọi dữ liệu liên quan sẽ bị mất !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                NhanVienDAO.Instance.xoa(tbMaNV.Text);
                loadDS();
            }
        }

        private void btCapNhatNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaNV.Text))
            {
                MessageBox.Show("Hãy chọn nhân viên cần cập nhật thông tin trước !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống !", "Nhắc nhở");
                return;
            }
            ChuyenMon chucNang = ChuyenMonDAO.Instance.getByTen(cbChuyenMon.Text);
            NhanVienDAO.Instance.capNhat(tbMaNV.Text, chucNang.MaCM, tbHoTen.Text);
            loadDS();
        }

        private void btThemNhanVien_Click(object sender, EventArgs e)
        {
            ChuyenMon chucNang = ChuyenMonDAO.Instance.getByTen(cbChuyenMon.Text);
            if (chucNang == null)
            {
                MessageBox.Show("Hãy thêm chuyên môn trước !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống !", "Nhắc nhở");
                return;
            }
            NhanVienDAO.Instance.them(chucNang.MaCM, tbHoTen.Text.Replace('|', '_'));
            loadDS();
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhanVien.Rows[e.RowIndex];
                tbMaNV.Text = Convert.ToString(row.Cells[1].Value);
                if (string.IsNullOrEmpty(tbMaNV.Text))
                {
                    return;
                }
                cbChuyenMon.Text = Convert.ToString(row.Cells[2].Value);
                tbHoTen.Text = Convert.ToString(row.Cells[3].Value);
            }
            catch (Exception)
            { }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChuyenMon chucNang = ChuyenMonDAO.Instance.getByTen(cbChuyenMon.Text);
            if (chucNang == null)
            {
                MessageBox.Show("Hãy thêm chuyên môn trước !", "Nhắc nhở");
                return;
            }
            if (string.IsNullOrEmpty(tbHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống !", "Nhắc nhở");
                return;
            }
            if (MessageBox.Show("Xác nhận thêm nhân viên thêm hàng loạt !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string[] ten = tbHoTen.Text.Split(',');
                foreach (string t in ten)
                {
                    NhanVienDAO.Instance.them(chucNang.MaCM, t);
                }
                loadDS();
                MessageBox.Show("Thêm nhân viên hàng loạt thành công !", "Thông báo");
            }

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Tên các nhân viên cách nhau bằng dấu '|' \nVí dụ 'Thái,Hà,Quỳnh'");
            }
        }

        private void tbMaNV_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận reset tần suất đăng ký lịch theo thứ !", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                NhanVienDAO.Instance.resetThu();
                loadDS();
                MessageBox.Show("Reset thành công !", "Thông báo");
            }
        }

        private void dgvNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhanVien.Rows[e.RowIndex];
                tbMaNV.Text = Convert.ToString(row.Cells[1].Value);
                if (string.IsNullOrEmpty(tbMaNV.Text))
                {
                    return;
                }
                cbChuyenMon.Text = Convert.ToString(row.Cells[2].Value);
                tbHoTen.Text = Convert.ToString(row.Cells[3].Value);
            }
            catch (Exception)
            { }
        }
    }
}
