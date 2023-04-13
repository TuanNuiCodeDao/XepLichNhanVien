using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLichNhanVien.DTO
{
    public class Lich
    {
        private string maCa;
        private string maPhong;
        private string maNV;
        private string maCM;
        private int ngay;
        public Lich() { }
        public Lich(string maCa, string maPhong, string maNV,string maCM, int ngay)
        {
            this.MaCa = maCa;
            this.MaPhong = maPhong;
            this.MaNV = maNV;
            this.Ngay = ngay;
            this.MaCM = maCM;
        }

        public string MaCa { get => maCa; set => maCa = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public int Ngay { get => ngay; set => ngay = value; }
        public string MaCM { get => maCM; set => maCM = value; }
    }
}
