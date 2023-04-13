using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLichNhanVien.DTO
{
    public class PhanCong
    {
        private string maPhong;
        private string maCM;
        private string maCa;
        private int soLuong;
        public PhanCong() { }
        public PhanCong(string maPhong, string maCa,string maCM, int soLuong)
        {
            this.MaPhong = maPhong;
            this.MaCM = maCM;
            this.SoLuong = soLuong;
            this.MaCa = maCa;
        }
        public string getDinhDangLuuFile()
        {
            return maPhong +"|"+ maCa+"|" + maCM + "|" + soLuong;
        }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaCM { get => maCM; set => maCM = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaCa { get => maCa; set => maCa = value; }
    }
}
