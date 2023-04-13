using XepLichNhanVien.DAO;
using XepLichNhanVien.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClosedXML.Excel;
using GemBox.Spreadsheet;

namespace XepLichNhanVien
{
    public partial class F_XepLich : Form
    {
        public F_XepLich()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            btXepLich.Enabled = false;
            loadCbCa();
            loadDSNhanVien();
        }
        private void loadCbCa()
        {
            cbCaTruc.Items.Clear();
            cbCaTruc.DataSource = CaTrucDAO.Instance.L;
            cbCaTruc.DisplayMember = "Ten";
            if (CaTrucDAO.Instance.L.Count > 0)
            {
                cbCaTruc.Text = CaTrucDAO.Instance.L[0].Ten;
            }
        }
        private void loadDSNhanVien()
        {
            dgvNhanVien.Rows.Clear();
            int stt = 0;
            CaTruc ct = CaTrucDAO.Instance.getByTen(cbCaTruc.Text);
            if (ct == null)
                return;
            List<NhanVien> l = NhanVienDAO.Instance.loadDSDaDangkyCa(ct.Ma);
            foreach (NhanVien i in l)
            {
                stt++;
                ChuyenMon chucNang = ChuyenMonDAO.Instance.getByMa(i.MaCM);
                dgvNhanVien.Rows.Add(stt, i.MaNV, chucNang.TenCM, i.HoTen, true);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void F_XepLich_Load(object sender, EventArgs e)
        {

        }
        private int getSoLuongTheoMaCM(List<NhanVien> l1, string maCM)
        {
            int soLuong = 0;
            foreach (NhanVien i in l1)
                if (i.MaCM == maCM)
                {
                    soLuong++;
                }
            return soLuong;
        }
        private int getInDexTheoMaCM_Min_ThuHai(List<NhanVien> l1, string maCM)
        {
            int id = -1;
            for (int i = 0; i < l1.Count; i++)
                if (l1[i].MaCM == maCM && l1[i].Check == 0 && (id == -1 || l1[i].ThuHai < l1[id].ThuHai))
                {
                    id = i;
                }
            return id;
        }
        private int getInDexTheoMaCM_Min_ThuBa(List<NhanVien> l1, string maCM)
        {
            int id = -1;
            for (int i = 0; i < l1.Count; i++)
                if (l1[i].MaCM == maCM && l1[i].Check == 0 && (id == -1 || l1[i].ThuBa < l1[id].ThuBa))
                {
                    id = i;
                }
            return id;
        }
        private int getInDexTheoMaCM_Min_ThuTu(List<NhanVien> l1, string maCM)
        {
            int id = -1;
            for (int i = 0; i < l1.Count; i++)
                if (l1[i].MaCM == maCM && l1[i].Check == 0 && (id == -1 || l1[i].ThuTu < l1[id].ThuTu))
                {
                    id = i;
                }
            return id;
        }
        private int getInDexTheoMaCM_Min_ThuNam(List<NhanVien> l1, string maCM)
        {
            int id = -1;
            for (int i = 0; i < l1.Count; i++)
                if (l1[i].MaCM == maCM && l1[i].Check == 0 && (id == -1 || l1[i].ThuNam < l1[id].ThuNam))
                {
                    id = i;
                }
            return id;
        }
        private int getInDexTheoMaCM_Min_ThuSau(List<NhanVien> l1, string maCM)
        {
            int id = -1;
            for (int i = 0; i < l1.Count; i++)
                if (l1[i].MaCM == maCM && l1[i].Check == 0 && (id == -1 || l1[i].ThuSau < l1[id].ThuSau))
                {
                    id = i;
                }
            return id;
        }
        private int getInDexTheoMaCM_Min_ThuBay(List<NhanVien> l1, string maCM)
        {
            int id = -1;
            for (int i = 0; i < l1.Count; i++)
                if (l1[i].MaCM == maCM && l1[i].Check == 0 && (id == -1 || l1[i].ThuBay < l1[id].ThuBay))
                {
                    id = i;
                }
            return id;
        }
        private int getInDexTheoMaCM_Min_ChuNhat(List<NhanVien> l1, string maCM)
        {
            int id = -1;
            for (int i = 0; i < l1.Count; i++)
                if (l1[i].MaCM == maCM && l1[i].Check == 0 && (id == -1 || l1[i].ChuNhat < l1[id].ChuNhat))
                {
                    id = i;
                }
            return id;
        }
        private int getIDByMaCM_Thu(List<NhanVien> lNV, string maCM, string tenThu)
        {
            int id = getInDexTheoMaCM_Min_ThuHai(lNV, maCM);
            if (tenThu == "Tue")
                id = getInDexTheoMaCM_Min_ThuBa(lNV, maCM);
            if (tenThu == "Wed")
                id = getInDexTheoMaCM_Min_ThuTu(lNV, maCM);
            if (tenThu == "Thu")
                id = getInDexTheoMaCM_Min_ThuNam(lNV, maCM);
            if (tenThu == "Fri")
                id = getInDexTheoMaCM_Min_ThuSau(lNV, maCM);
            if (tenThu == "Sat")
                id = getInDexTheoMaCM_Min_ThuBay(lNV, maCM);
            if (tenThu == "Sun")
                id = getInDexTheoMaCM_Min_ChuNhat(lNV, maCM);
            return id;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUrl.Text))
            {
                MessageBox.Show("Hãy chọn nơi lưu !", "Nhắc nhở");
                return;
            }
            DateTime date1 = (DateTime)dateDuoi.Value;
            DateTime date2 = (DateTime)dateTren.Value;
            btXepLich.Enabled = false;
            btChon.Enabled = false;
            List<Lich> l = new List<Lich>();
            if (date1 > date2.AddDays(1))
            {
                MessageBox.Show("Khoảng thời gian phải từ 1 ngày trở lên !", "Nhắc nhở");
                return;
            }
            CaTruc ca = CaTrucDAO.Instance.getByTen(cbCaTruc.Text);
            if (ca == null)
                return;
            List<NhanVien> lNV = new List<NhanVien>();
            foreach (DataGridViewRow r in dgvNhanVien.Rows)
            {
                try
                {
                    if (string.IsNullOrEmpty(r.Cells[0].Value.ToString()))
                        continue;
                    if ((Boolean)r.Cells[4].Value == true)
                    {
                        lNV.Add(NhanVienDAO.Instance.getByMa(r.Cells[1].Value.ToString()));
                    }
                }
                catch (Exception ex) { }
            }
            if (lNV.Count == 0)
            {
                MessageBox.Show("Không có nhân viên nào được chọn !", "Nhắc nhở");
                return;
            }
            int soNgay = 1;
            while (date1.AddDays(soNgay - 1).ToShortDateString() != date2.ToShortDateString())
            {
                soNgay++;
            }
            for (int ngay = 0; ngay < soNgay; ngay++)
            {
                string tenThu = DataProvider.Instance.layTenThu(date1.AddDays(ngay));
                foreach (Phong p in PhongDAO.Instance.L)
                {
                    List<PhanCong> lPc = PhanCongDAO.Instance.getDSByMaPhongAndMaCa(p.MaPhong, ca.Ma);
                    foreach (PhanCong pc in lPc)
                    {
                        if (getSoLuongTheoMaCM(lNV, pc.MaCM) == 0)
                        {
                            continue;
                        }
                        for (int g = 0; g < pc.SoLuong; g++)
                        {
                            int id = getIDByMaCM_Thu(lNV, pc.MaCM, tenThu);
                            if (id == -1)
                            {
                                NhanVienDAO.Instance.unCheckByMaCM(pc.MaCM);
                                for (int iTemp = 0; iTemp < lNV.Count; iTemp++)
                                {
                                    lNV[iTemp] = NhanVienDAO.Instance.getByMa(lNV[iTemp].MaNV);
                                }
                                id = getIDByMaCM_Thu(lNV, pc.MaCM, tenThu);
                            }
                            NhanVienDAO.Instance.dangKyLichDone(lNV[id].MaNV, tenThu);
                            l.Add(new Lich(ca.Ma, pc.MaPhong, lNV[id].MaNV, lNV[id].MaCM, ngay));
                        }
                    }
                }
            }
            if (l.Count == 0)
            {
                btXepLich.Enabled = true;
                btChon.Enabled = true;
                return;
            }

            DateTime dt = DateTime.Now;
            string s = dt.ToString(), duongDan = "";
            int j = 0;
            while (j < s.Length)
            {
                if (s[j] == '/' || s[j] == ' ' || s[j] == ':')
                    duongDan += '_';
                else duongDan += s[j];
                j++;
            }

            string filepath = tbUrl.Text + "\\XepLichNhanVien" + duongDan + ".xlsx";
            XLWorkbook wbook = new XLWorkbook();
            var ws = wbook.Worksheets.Add(ca.Ten);
            ws.Cell(1, 1).Value = "Lịch trực " + ca.Ten + " từ " + date1.ToShortDateString() + " đến " + date2.ToShortDateString();
            List<Phong> lP = PhongDAO.Instance.getDSByMaCa(ca.Ma);
            int h = 3;
            ws.Cell(2, 1).Value = "Phòng";
            ws.Cell(2, 2).Value = "Chuyên môn";
            for (int i = 0; i < soNgay; i++)
            {
                ws.Cell(2, i + 3).Value = date1.AddDays(i).ToShortDateString();
            }
            foreach (Phong p in lP)
            {
                ws.Cell(h, 1).Value = p.TenPhong;
                List<ChuyenMon> lCM = ChuyenMonDAO.Instance.getDSByMaPhongAndMaCa(p.MaPhong, ca.Ma);
                foreach (ChuyenMon chuyenMon in lCM)
                {
                    PhanCong pc = PhanCongDAO.Instance.getByMaPhongAndMaCMAndMaCa(p.MaPhong, ca.Ma, chuyenMon.MaCM);

                    ws.Cell(h, 2).Value = chuyenMon.TenCM;
                    for (int i = 0; i < soNgay; i++)
                    {
                        int vt = h;
                        List<Lich> lLich = getByMaCa_Phong_ChuyenMon_Ngay(l, ca.Ma, p.MaPhong, chuyenMon.MaCM, i);
                        foreach (Lich lich in lLich)
                        {
                            NhanVien nv = NhanVienDAO.Instance.getByMa(lich.MaNV);
                            ws.Cell(vt, i + 3).Value = nv.HoTen;
                            vt++;
                        }
                    }
                    h += pc.SoLuong;
                }
            }
            try
            {
                wbook.SaveAs(filepath);
                SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                var workbook = ExcelFile.Load(filepath);
                var worksheet = workbook.Worksheets[0];
                int columnCount = worksheet.CalculateMaxUsedColumns();
                for (int i = 0; i < columnCount; i++)
                    worksheet.Columns[i].AutoFit(1, worksheet.Rows[1], worksheet.Rows[worksheet.Rows.Count - 1]);
                workbook.Save(filepath);
                MessageBox.Show("Xuất file Excel thành công\nĐường dẫn : " + filepath, "Thông báo");
            }
            catch
            {
                MessageBox.Show("Xuất file Excel thất bại !", "Thông báo");
            }
            btXepLich.Enabled = true;
            btChon.Enabled = true;
        }
        public List<Lich> getByMaCa_Phong_ChuyenMon_Ngay(List<Lich> l, string maC, string maP, string maCM, int ngay)
        {
            List<Lich> l1 = new List<Lich>();
            foreach (Lich i in l)
                if (i.MaPhong == maP && i.MaCa == maC && i.MaCM == maCM && i.Ngay == ngay)
                    l1.Add(i);
            return l1;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btChon_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                tbUrl.Text = f.SelectedPath;
                btXepLich.Enabled = true;
            }
            else
            {
                tbUrl.Text = "";
                btXepLich.Enabled = false;
            }
        }

        private void cbCaTruc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDSNhanVien();
        }
    }

}
