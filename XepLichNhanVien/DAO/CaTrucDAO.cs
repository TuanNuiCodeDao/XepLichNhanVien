using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XepLichNhanVien.DTO;

namespace XepLichNhanVien.DAO
{
    public class CaTrucDAO
    {
        private static List<CaTruc> l;
        private static CaTrucDAO instance;
        public static CaTrucDAO Instance
        {
            get { if (instance == null) instance = new CaTrucDAO(); return instance; }
            private set { instance = value; }
        }
        public CaTrucDAO()
        {
            l = new List<CaTruc>();
            docFile();
        }

        public List<CaTruc> L { get => l; set => l = value; }

        public void docFile()
        {
            l = new List<CaTruc>();
            using (StreamReader sr = new StreamReader(FilePath_.Instance.Path+"CaTruc.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split('|');
                    if (s.Length == 3)
                    {
                        CaTruc i = new CaTruc(s[0], s[1], s[2]);
                        l.Add(i);
                    }
                }
            }
        }
        private void luuFile()
        {
            using (StreamWriter sw = new StreamWriter(FilePath_.Instance.Path + "CaTruc.txt"))
            {
                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i].getDinhDangLuuFile());
                }
            }
        }
        public CaTruc getByMa(string ma)
        {
            foreach (CaTruc i in l)
                if (i.Ma == ma)
                    return i;
            return null;
        }
        public CaTruc getByTen(string ten)
        {
            foreach (CaTruc i in l)
                if (i.Ten == ten)
                    return i;
            return null;
        }
        private string getMa()
        {
            if (l.Count == 0) return "CA0001";
            string ma = l[l.Count - 1].Ma;
            string tam = "";
            for (int i = 2; i < ma.Length; i++)
                tam += ma[i];
            int so = int.Parse(tam);
            so++;
            string s = so + "";
            ma = "CA";
            for (int i = 0; i < 4 - s.Length; i++)
                ma += "0";
            ma += s;
            return ma;

        }
        public void them(string tenCaTruc, string ghiChu)
        {
            l.Add(new CaTruc(getMa(), tenCaTruc, ghiChu));
            luuFile();
        }
        public void xoa(string ma)
        {
            List<DangKyCa> l1 = DangKyCaDAO.Instance.loadByMaCa(ma);
            foreach (DangKyCa j in l1)
            {
                DangKyCaDAO.Instance.xoa(j.MaNV, j.MaCa);
            }
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].Ma == ma)
                    break;
            if (i < l.Count)
            {
                l.RemoveAt(i);
                PhanCongDAO.Instance.xoaByMaCa(ma);
            }
            luuFile();
        }
        public void capNhat(string ma, string tenCaTruc, string ghiChu)
        {
            CaTruc p = new CaTruc(ma, tenCaTruc, ghiChu);
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].Ma == ma)
                    l[i] = p;
            luuFile();
        }
    }
}

