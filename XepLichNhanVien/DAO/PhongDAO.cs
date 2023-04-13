using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XepLichNhanVien.DTO;

namespace XepLichNhanVien.DAO
{
    public class PhongDAO
    {
        private static List<Phong> l;
        private static PhongDAO instance;
        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            private set { instance = value; }
        }
        public PhongDAO()
        {
            l = new List<Phong>();
            docFile();
        }

        public List<Phong> L { get => l; set => l = value; }

        public void docFile()
        {
            l = new List<Phong>();
            using (StreamReader sr = new StreamReader(FilePath_.Instance.Path + "Phong.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split('|');
                    if (s.Length == 3)
                    {
                        Phong i = new Phong(s[0], s[1], s[2]);
                        l.Add(i);
                    }
                }
            }
        }
        public List<Phong> getDSByMaCa(string maCa)
        {
            List<Phong> lP = new List<Phong>();
            foreach (Phong p in l)
                if (PhanCongDAO.Instance.getDSByMaPhongAndMaCa(p.MaPhong, maCa).Count > 0)
                    lP.Add(p);
            return lP;
        }
        private void luuFile()
        {
            using (StreamWriter sw = new StreamWriter(FilePath_.Instance.Path + "Phong.txt"))
            {
                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i].getDinhDangLuuFile());
                }
            }
        }
        public Phong getByMa(string ma)
        {
            foreach (Phong i in l)
                if (i.MaPhong == ma)
                    return i;
            return null;
        }
        public Phong getByTen(string ten)
        {
            foreach (Phong i in l)
                if (i.TenPhong== ten)
                    return i;
            return null;
        }
        private string getMa()
        {
            if (l.Count == 0) return "P0001";
            string ma = l[l.Count - 1].MaPhong;
            string tam = "";
            for (int i = 2; i < ma.Length; i++)
                tam += ma[i];
            int so = int.Parse(tam);
            so++;
            string s = so + "";
            ma = "P";
            for (int i = 0; i < 4 - s.Length; i++)
                ma += "0";
            ma += s;
            return ma;

        }
        public void them(string tenPhong, string ghiChu)
        {
            l.Add(new Phong(getMa(),tenPhong, ghiChu));
            luuFile();
        }
        public void xoa(string ma)
        {
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].MaPhong == ma)
                    break;
            if (i < l.Count)
                l.RemoveAt(i);
            luuFile();
        }
        public void capNhat(string ma, string tenPhong, string ghiChu)
        {
            Phong p = new Phong(ma,tenPhong, ghiChu);
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].MaPhong == ma)
                    l[i] = p;
            luuFile();
        }
    }
}
