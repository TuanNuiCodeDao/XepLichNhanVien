using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLichNhanVien.DTO
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private string maCM;
        private int check;
        private int thuHai;
        private int thuBa;
        private int thuTu;
        private int thuNam;
        private int thuSau;
        private int thuBay;
        private int chuNhat;
        public NhanVien() { }
        public NhanVien(string maNV, string maCM, string hoTen, int check, int thuHai, int thuBa, int thuTu, int thuNam, int thuSau, int thuBay, int chuNhat)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.MaCM = maCM;
            this.Check = check;
            this.ThuHai = thuHai;
            this.ThuBa = thuBa;
            this.ThuTu = thuTu;
            this.ThuNam = thuNam;
            this.ThuSau = thuSau;
            this.ThuBay = thuBay;
            this.ChuNhat = chuNhat;
        }
        public string getDinhDangLuuFile()
        {
            return maNV + "|" + MaCM + "|" + hoTen + "|" + check + "|" + thuHai + "|" + thuBa + "|" + thuTu + "|" + thuNam
                + "|" + thuSau + "|" + thuBay + "|" + chuNhat;
        }
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string MaCM { get => maCM; set => maCM = value; }
        public int ThuHai { get => thuHai; set => thuHai = value; }
        public int ThuBa { get => thuBa; set => thuBa = value; }
        public int ThuTu { get => thuTu; set => thuTu = value; }
        public int ThuNam { get => thuNam; set => thuNam = value; }
        public int ThuSau { get => thuSau; set => thuSau = value; }
        public int ThuBay { get => thuBay; set => thuBay = value; }
        public int ChuNhat { get => chuNhat; set => chuNhat = value; }
        public int Check { get => check; set => check = value; }
    }
}
