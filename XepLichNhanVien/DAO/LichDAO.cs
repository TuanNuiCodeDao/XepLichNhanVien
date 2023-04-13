using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XepLichNhanVien.DTO;

namespace XepLichNhanVien.DAO
{
    public class LichDAO
    {
        private static LichDAO instance;
        public static LichDAO Instance
        {
            get { if (instance == null) instance = new LichDAO(); return instance; }
            private set { instance = value; }
        }
        public LichDAO()
        {
        }
        public List<Lich> getDSByMaPhongAndMaCa(List<Lich> l,string maPhong, string maCa)
        {
            List<Lich> l1 = new List<Lich>();
            foreach (Lich i in l)
                if (i.MaPhong == maPhong && i.MaCa == maCa)
                    l1.Add(i);
            return l1;
        }
    }
}
