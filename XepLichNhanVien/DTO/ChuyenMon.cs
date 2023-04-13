using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLichNhanVien.DTO
{
    public class ChuyenMon
    {
        private string maCM;
        private string tenCM;
        private string ghiChu;
        public ChuyenMon()
        {

        }
        public ChuyenMon(string maCM, string tenCM, string ghiChu)
        {
            this.MaCM = maCM;
            this.TenCM = tenCM;
            this.GhiChu = ghiChu;
        }

        public string MaCM { get => maCM; set => maCM = value; }
        public string TenCM { get => tenCM; set => tenCM = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public string getDinhDangLuuFile()
        {
            return MaCM + "|" + TenCM + "|" + GhiChu;
        }
    }
}
