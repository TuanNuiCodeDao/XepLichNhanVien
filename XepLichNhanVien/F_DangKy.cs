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
    public partial class F_DangKy : Form
    {
        private CaTruc ca;
        public F_DangKy(string maCa)
        {
            InitializeComponent();
            ca = CaTrucDAO.Instance.getByMa(maCa);
            label1.Text = label1.Text + ": '" + ca.Ten + "'";
            load();
        }
        private void load()
        {
            
            loadDSDaDangKy();
            loadDSChuaDangKy();
        }
        private void loadDSDaDangKy()
        {
            dgvDa.Rows.Clear();
            int stt = 0;
            List<NhanVien> l = NhanVienDAO.Instance.loadDSDaDangkyCa(ca.Ma);
            foreach (NhanVien i in l)
            {
                stt++;
                ChuyenMon chucNang = ChuyenMonDAO.Instance.getByMa(i.MaCM);
                dgvDa.Rows.Add(stt, i.MaNV, chucNang.TenCM, i.HoTen, true);
            }
        }
        private void loadDSChuaDangKy()
        {
            dgvChua.Rows.Clear();
            int stt = 0;
            List<NhanVien> l = NhanVienDAO.Instance.loadDSChuaDangkyCa(ca.Ma);
            foreach (NhanVien i in l)
            {
                stt++;
                ChuyenMon chucNang = ChuyenMonDAO.Instance.getByMa(i.MaCM);
                dgvChua.Rows.Add(stt, i.MaNV, chucNang.TenCM, i.HoTen, false);
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgvDa.Rows)
            {
                try
                {
                    if (string.IsNullOrEmpty(r.Cells[0].Value.ToString()))
                        continue;
                    if ((Boolean)r.Cells[4].Value == false)
                    {
                        DangKyCaDAO.Instance.xoa(r.Cells[1].Value.ToString(), ca.Ma);
                    }
                }catch(Exception ex) { }
            }
            foreach (DataGridViewRow r in dgvChua.Rows)
            {
                try
                {
                    if (string.IsNullOrEmpty(r.Cells[0].Value.ToString()))
                    continue;
                if ((Boolean)r.Cells[4].Value == true)
                {
                    DangKyCaDAO.Instance.them(r.Cells[1].Value.ToString(), ca.Ma);
                }
                }
                catch (Exception ex) { }
            }
            load();
        }
    }
}
