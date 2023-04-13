using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLichNhanVien.DTO
{
    public class Phong
    {
        private string maPhong;
        private string tenPhong;
        private string ghiChu;
        public Phong()
        {

        }
        public Phong(string maPhong,string tenPhong, string ghiChu)
        {
            this.MaPhong = maPhong;
            this.TenPhong = tenPhong;
            this.GhiChu = ghiChu;
        }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string getDinhDangLuuFile()
        {
            return MaPhong + "|" + tenPhong + "|" + ghiChu;    
        }
    }
}
