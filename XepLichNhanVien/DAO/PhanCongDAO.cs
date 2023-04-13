using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XepLichNhanVien.DTO;

namespace XepLichNhanVien.DAO
{
    public class PhanCongDAO
    {
        private static List<PhanCong> l;
        private static PhanCongDAO instance;
        public static PhanCongDAO Instance
        {
            get { if (instance == null) instance = new PhanCongDAO(); return instance; }
            private set { instance = value; }
        }
        public PhanCongDAO()
        {
            l = new List<PhanCong>();
            docFile();
        }

        public List<PhanCong> L { get => l; set => l = value; }

        public void docFile()
        {
            l = new List<PhanCong>();
            using (StreamReader sr = new StreamReader(FilePath_.Instance.Path + "PhanCong.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split('|');
                    if (s.Length == 4)
                    {
                        PhanCong i = new PhanCong(s[0], s[1], s[2], int.Parse(s[3]));
                        l.Add(i);
                    }
                }
            }
        }
        private void luuFile()
        {
            using (StreamWriter sw = new StreamWriter(FilePath_.Instance.Path + "PhanCong.txt"))
            {
                for (int i = 0; i < l.Count; i++)
                {
                    sw.WriteLine(l[i].getDinhDangLuuFile());
                }
            }
        }
        public PhanCong getByMaPhongAndMaCMAndMaCa(string maPhong,string maCa,string maCM)
        {
            foreach (PhanCong i in l)
                if (i.MaPhong == maPhong && i.MaCM == maCM && i.MaCa==maCa)
                    return i;
            return null;
        }
        public List<PhanCong> getDSByMaPhongAndMaCa(string maPhong, string maCa)
        {
            List<PhanCong> l1 = new List<PhanCong>();
            foreach (PhanCong i in l)
                if (i.MaPhong == maPhong && i.MaCa == maCa)
                    l1.Add(i);
            return l1;
        }
        private void them(string maPhong,string maCa, string maCM,int soLuong)
        {
            l.Add(new PhanCong(maPhong,maCa,maCM,soLuong));
            luuFile();
        }
        private void xoa(string maPhong, string maCa, string maCM)
        {
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].MaPhong == maPhong && l[i].MaCM==maCM && l[i].MaCa == maCa)
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
        public void xoaByMaPhong(string maPhong)
        {
            int i = 0;
            while (i < l.Count)
            {
                if (l[i].MaPhong == maPhong)
                    l.RemoveAt(i);
                else i++;
            }
            luuFile();
        }
        public void xoaByMaCa(string maCa)
        {
            int i = 0;
            while (i < l.Count)
            {
                if (l[i].MaCa == maCa)
                    l.RemoveAt(i);
                else i++;
            }
            luuFile();
        }
        public void themPhanCong(string maPhong,string maCa, string maCM, int soLuong)
        {
            if (soLuong == 0)
                return;
            PhanCong p = getByMaPhongAndMaCMAndMaCa(maPhong, maCa, maCM);
            if(p==null)
            {
                if (soLuong < 0)
                    return;
                them(maPhong,maCa, maCM, soLuong);
            }
            else
            {
                int soLuongNew = p.SoLuong + soLuong;
                if (soLuongNew <= 0)
                    xoa(maPhong,maCa, maCM);
                else capNhat(maPhong,maCa,maCM, soLuongNew);
            }
        }
        private void capNhat(string maPhong,string maCa, string maCM, int soLuong)
        {
            PhanCong p = new PhanCong(maPhong,maCa, maCM, soLuong);
            int i;
            for (i = 0; i < l.Count; i++)
                if (l[i].MaPhong == maPhong && l[i].MaCM == maCM && l[i].MaCa == maCa)
                    l[i] = p;
            luuFile();
        }
    }
}
