using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLichNhanVien.DTO
{
    public class DangKyCa
    {
        private string maNV;
        private string maCa;
        public DangKyCa()
        { }
        public DangKyCa(string maNV, string maCa)
        {
            this.MaNV = maNV;
            this.MaCa = maCa;
        }
        public string getDinhDangLuuFile()
        {
            return maNV + "|" + maCa;
        }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaCa { get => maCa; set => maCa = value; }
    }
}
