using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XepLichNhanVien.DTO;

namespace XepLichNhanVien.DAO
{
    public class DangKyCaDAO
    {
        private static List<DangKyCa> l;
        private static DangKyCaDAO instance;
        public static DangKyCaDAO Instance
        {
            get { if (instance == null) instance = new DangKyCaDAO(); return instance; }
            private set { instance = value; }
        }
        public DangKyCaDAO()
        {
            l = new List<DangKyCa>();
            docFile();
        }

        public List<DangKyCa> L { get => l; set => l = value; }

        public void docFile()
        {
            l = new List<DangKyCa>();
            using (StreamReader sr = new StreamReader(FilePath_.Instance.Path + "DangKyCa.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split('|');
                    if (s.Length == 2)
                    {
                        DangKyCa i = new DangKyCa(s[0], s[1]);
                        l.Add(i);
                    }
                }
            }
        }
        private void luuFile()
        {
            using (StreamWriter sw = new StreamWriter(FilePath_.Instance.Path + "DangKyCa.txt"))
            {
                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i].getDinhDangLuuFile());
                }
            }
        }
        public DangKyCa getByMaNV_MaCa(string maNV,string maCa)
        {
            foreach (DangKyCa i in l)
                if (i.MaNV == maNV&&i.MaCa==maCa)
                    return i;
            return null;
        }
        public List<DangKyCa> loadByMaCa(string maCa)
        {
            List<DangKyCa> l1=new List<DangKyCa> ();
            foreach (DangKyCa i in l)
                if (i.MaCa == maCa)
                    l1.Add(i);
            return l1;
        }
        public List<DangKyCa> loadByMaNV(string maNV)
        {
            List<DangKyCa> l1 = new List<DangKyCa>();
            foreach (DangKyCa i in l)
                if (i.MaNV == maNV)
                    l1.Add(i);
            return l1;
        }
        public void them(string maNV, string maCa)
        {
            l.Add(new DangKyCa(maNV,maCa));
            luuFile();
        }
        public void xoa(string maNV, string maCa)
        {
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].MaNV == maNV && l[i].MaCa==maCa)
                    break;
            if (i < l.Count)
            {
                l.RemoveAt(i);
            }
            luuFile();
        }
    }
}
