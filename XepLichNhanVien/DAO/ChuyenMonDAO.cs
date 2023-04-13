using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XepLichNhanVien.DTO;

namespace XepLichNhanVien.DAO
{
    public class ChuyenMonDAO
    {
        private static List<ChuyenMon> l;
        private static ChuyenMonDAO instance;
        public static ChuyenMonDAO Instance
        {
            get { if (instance == null) instance = new ChuyenMonDAO(); return instance; }
            private set { instance = value; }
        }
        public ChuyenMonDAO()
        {
            l = new List<ChuyenMon>();
            docFile();
        }

        public List<ChuyenMon> L { get => l; set => l = value; }

        public void docFile()
        {
            l = new List<ChuyenMon>();
            using (StreamReader sr = new StreamReader(FilePath_.Instance.Path + "ChuyenMon.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split('|');
                    if (s.Length == 3)
                    {
                        ChuyenMon i = new ChuyenMon(s[0], s[1], s[2]);
                        l.Add(i);
                    }
                }
            }
        }
        private void luuFile()
        {
            using (StreamWriter sw = new StreamWriter(FilePath_.Instance.Path + "ChuyenMon.txt"))
            {
                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i].getDinhDangLuuFile());
                }
            }
        }
        public ChuyenMon getByMa(string ma)
        {
            foreach (ChuyenMon i in l)
                if (i.MaCM == ma)
                    return i;
            return null;
        }
        public ChuyenMon getByTen(string ten)
        {
            foreach (ChuyenMon i in l)
                if (i.TenCM == ten)
                    return i;
            return null;
        }
        private string getMa()
        {
            if (l.Count == 0) return "CM0001";
            string ma = l[l.Count - 1].MaCM;
            string tam = "";
            for (int i = 2; i < ma.Length; i++)
                tam += ma[i];
            int so = int.Parse(tam);
            so++;
            string s = so + "";
            ma = "CM";
            for (int i = 0; i < 4 - s.Length; i++)
                ma += "0";
            ma += s;
            return ma;

        }
        public void them(string tenCM,string ghiChu)
        {
            l.Add(new ChuyenMon(getMa(), tenCM,ghiChu));
            luuFile();
        }
        public void xoa(string ma)
        {
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].MaCM == ma)
                    break;
            if (i < l.Count)
            {
                NhanVienDAO.Instance.xoaByMaCM(ma);
                PhanCongDAO.Instance.xoaByMaCM(ma);
                l.RemoveAt(i);
            }
            luuFile();
        }
        public List<ChuyenMon> getDSByMaPhongAndMaCa(string maPhong,string maCa)
        {
            List<ChuyenMon> lC = new List<ChuyenMon>();
            foreach (ChuyenMon i in l)
                if (PhanCongDAO.Instance.getByMaPhongAndMaCMAndMaCa(maPhong, maCa,i.MaCM)!=null)
                    lC.Add(i);
            return lC;
        }
        public void capNhat(string ma, string tenCM, string ghiChu)
        {
            ChuyenMon cm = new ChuyenMon(ma, tenCM, ghiChu);
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].MaCM == ma)
                    l[i] = cm;
            luuFile();
        }
    }
}
