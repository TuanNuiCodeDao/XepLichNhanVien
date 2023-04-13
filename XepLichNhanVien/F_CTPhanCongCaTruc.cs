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
    public partial class F_CTPhanCongCaTruc : Form
    {
        private CaTruc ca;
        public F_CTPhanCongCaTruc(string maCa)
        {
            InitializeComponent();
            ca = CaTrucDAO.Instance.getByMa(maCa);
            load();
        }
        private void load()
        {
            label1.Text = label1.Text + ": '" + ca.Ten + "'";
            loadDS();
            loadCbChuyenMon();
            loadCbPhong();
        }
        private void loadCbPhong()
        {
            cbTenPhong.DataSource = PhongDAO.Instance.L;
            cbTenPhong.DisplayMember = "TenPhong";
            if (PhongDAO.Instance.L.Count > 0)
            {
                cbTenPhong.Text = PhongDAO.Instance.L[0].TenPhong;
            }
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
            dgvPhong.Rows.Clear();
            int stt = 0;
            List<Phong> l = PhongDAO.Instance.L;
            foreach (Phong i in l)
            {
                if (PhanCongDAO.Instance.getDSByMaPhongAndMaCa(i.MaPhong, ca.Ma).Count == 0)
                    continue;
                DataGridViewRow row = (DataGridViewRow)dgvPhong.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                row.Cells[1].Value = i.MaPhong;
                row.Cells[2].Value = i.TenPhong;
                row.Cells[3].Value = i.GhiChu;
                dgvPhong.Rows.Add(row);
            }
        }
        private void loadPhanCong()
        {
            Phong p = PhongDAO.Instance.getByTen(cbTenPhong.Text);
            dgvPhanCong.Rows.Clear();
            if (p == null)
                return;
            int stt = 0;
            List<PhanCong> l = PhanCongDAO.Instance.getDSByMaPhongAndMaCa(p.MaPhong, ca.Ma);
            foreach (PhanCong i in l)
            {
                DataGridViewRow row = (DataGridViewRow)dgvPhanCong.Rows[0].Clone();
                stt++;
                row.Cells[0].Value = stt + "";
                ChuyenMon c = ChuyenMonDAO.Instance.getByMa(i.MaCM);
                row.Cells[1].Value = c.TenCM;
                row.Cells[2].Value = i.SoLuong;
                dgvPhanCong.Rows.Add(row);
            }
        }
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row = dgvPhong.Rows[e.RowIndex];
                string ma = Convert.ToString(row.Cells[1].Value);
                if (string.IsNullOrEmpty(ma))
                {
                    return;
                }
                cbTenPhong.Text = Convert.ToString(row.Cells[2].Value);
                loadPhanCong();
            }
            catch (Exception)
            { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChuyenMon c = ChuyenMonDAO.Instance.getByTen(cbChuyenMon.Text);
            if (c == null)
            {
                MessageBox.Show("Hãy thêm chuyên môn trước !", "Nhắc nhở");
                return;
            }
            Phong p = PhongDAO.Instance.getByTen(cbTenPhong.Text);
            if (p==null)
            {
                MessageBox.Show("Hãy chọn phòng cần phân công trước !", "Nhắc nhở");
                return;
            }
            PhanCongDAO.Instance.themPhanCong(p.MaPhong, ca.Ma, c.MaCM, (int)nudSoLuong.Value);
            loadPhanCong();
            loadDS();
        }

        private void F_CTPhanCongCaTruc_Load(object sender, EventArgs e)
        {

        }

        private void cbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPhanCong();
        }
    }
}
