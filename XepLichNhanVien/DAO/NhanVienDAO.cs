using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XepLichNhanVien.DTO;

namespace XepLichNhanVien.DAO
{
    public class NhanVienDAO
    {
        private static List<NhanVien> l;
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        public NhanVienDAO()
        {
            l = new List<NhanVien>();
            docFile();
        }

        public List<NhanVien> L { get => l; set => l = value; }

        public void docFile()
        {
            l = new List<NhanVien>();
            using (StreamReader sr = new StreamReader(FilePath_.Instance.Path + "NhanVien.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split('|');
                    if (s.Length == 11)
                    {
                        NhanVien i = new NhanVien(s[0], s[1], s[2], int.Parse(s[3]), int.Parse(s[4]), int.Parse(s[5])
                            , int.Parse(s[6]), int.Parse(s[7]), int.Parse(s[8]), int.Parse(s[9]), int.Parse(s[10]));
                        l.Add(i);
                    }
                }
            }
        }
        private void luuFile()
        {
            using (StreamWriter sw = new StreamWriter(FilePath_.Instance.Path + "NhanVien.txt"))
            {
                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i].getDinhDangLuuFile());
                }
            }
        }
        public NhanVien getByMa(string ma)
        {
            foreach (NhanVien i in l)
                if (i.MaNV == ma)
                    return i;
            return null;
        }
        private string getMa()
        {
            if (l.Count == 0) return "NV0001";
            string ma = l[l.Count - 1].MaNV;
            string tam = "";
            for (int i = 2; i < ma.Length; i++)
                tam += ma[i];
            int so = int.Parse(tam);
            so++;
            string s = so + "";
            ma = "NV";
            for (int i = 0; i < 4 - s.Length; i++)
                ma += "0";
            ma += s;
            return ma;

        }
        public void them(string maCN, string hoTen)
        {
            l.Add(new NhanVien(getMa(), maCN, hoTen, 0, 0, 0, 0, 0, 0, 0, 0));
            luuFile();
        }
        public void xoa(string ma)
        {
            List<DangKyCa> l1 = DangKyCaDAO.Instance.loadByMaNV(ma);
            foreach (DangKyCa j in l1)
            {
                DangKyCaDAO.Instance.xoa(j.MaNV, j.MaCa);
            }
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].MaNV == ma)
                    break;
            if (i < l.Count)
                l.RemoveAt(i);
            luuFile();
        }
        public void xoaByMaCM(string maCM)
        {
            int i = 0;
            while (i < l.Count)
            {
                if (l[i].MaCM == maCM)
                    l.RemoveAt(i);
                else i++;
            }
            luuFile();
        }
        public List<NhanVien> loadDSChuaDangkyCa(string maCa)
        {
            List<NhanVien> l1 = new List<NhanVien>();
            foreach (NhanVien nv in l)
            {
                if (DangKyCaDAO.Instance.getByMaNV_MaCa(nv.MaNV, maCa) == null)
                    l1.Add(nv);
            }
            return l1;
        }
        public List<NhanVien> loadDSDaDangkyCa(string maCa)
        {
            List<NhanVien> l1 = new List<NhanVien>();
            foreach (NhanVien nv in l)
            {
                if (DangKyCaDAO.Instance.getByMaNV_MaCa(nv.MaNV, maCa) != null)
                    l1.Add(nv);
            }
            return l1;
        }
        public void capNhat(string maNV, string maCN, string hoTen)
        {
            NhanVien n = getByMa(maNV);
            NhanVien nv = new NhanVien(maNV, maCN, hoTen, n.Check, n.ThuHai, n.ThuBa, n.ThuTu, n.ThuNam, n.ThuSau, n.ThuBay, n.ChuNhat);
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].MaNV == maNV)
                    l[i] = nv;
            luuFile();
        }
        public int getMin(NhanVien n)
        {
            int min = n.ThuHai;
            if (min > n.ThuBa)
                min = n.ThuBa;
            if (min > n.ThuTu)
                min = n.ThuTu;
            if (min > n.ThuNam)
                min = n.ThuNam;
            if (min > n.ThuSau)
                min = n.ThuSau;
            if (min > n.ThuBay)
                min = n.ThuBay;
            if (min > n.ChuNhat)
                min = n.ChuNhat;
            return min;
        }
        public void resetThu()
        {
            foreach (NhanVien i in l)
            {
                int min = getMin(i);
                i.ThuHai -= min;
                i.ThuBa -= min;
                i.ThuTu -= min;
                i.ThuNam -= min;
                i.ThuSau -= min;
                i.ThuBay -= min;
                i.ChuNhat -= min;
            }
            luuFile();
        }
        public void dangKyLichDone(string maNV, string tenThu)
        {
            NhanVien nv = getByMa(maNV);
            if (tenThu == "Mon")
                nv.ThuHai++;
            if (tenThu == "Tue")
                nv.ThuBa++;
            if (tenThu == "Wed")
                nv.ThuTu++;
            if (tenThu == "Thu")
                nv.ThuNam++;
            if (tenThu == "Fri")
                nv.ThuSau++;
            if (tenThu == "Sat")
                nv.ThuBay++;
            if (tenThu == "Sun")
                nv.ChuNhat++;
            nv.Check = 1;
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].MaNV == maNV)
                    l[i] = nv;
            luuFile();
        }
        public void unCheckByMaCM(string maCM)
        {
            foreach (NhanVien i in l)
                if (i.MaCM == maCM)
                    i.Check = 0;
            luuFile();
        }
    }
}
