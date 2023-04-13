using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLichNhanVien.DTO
{
    public class CaTruc
    {
        private string ma;
        private string ten;
        private string ghiChu;
        public CaTruc() { }
        public CaTruc(string ma, string ten, string ghiChu)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.GhiChu = ghiChu;
        }
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string getDinhDangLuuFile()
        {
            return ma + "|" +ten+ "|" + ghiChu;
        }
    }
}
