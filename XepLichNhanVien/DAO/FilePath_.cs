using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XepLichNhanVien.DTO;

namespace XepLichNhanVien.DAO
{
    public class FilePath_
    {
        private string path;
        private static FilePath_ instance;
        public static FilePath_ Instance
        {
            get { if (instance == null) instance = new FilePath_(); return instance; }
            private set { instance = value; }
        }
        
        public FilePath_() {
            docFile();

        }
        public void docFile()
        {
            using (StreamReader sr = new StreamReader(@"C:\DataQuanLyXepLich\DuongDan.txt"))
            {
                string line="";
                while ((line = sr.ReadLine()) != null)
                {
                    path = line;
                }
            }
        }
        public void luuFile(string path_)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\DataQuanLyXepLich\DuongDan.txt"))
            {
                sw.WriteLine(path_);
            }
            path = path_;
            CaTrucDAO.Instance.docFile();
            ChuyenMonDAO.Instance.docFile();
            DangKyCaDAO.Instance.docFile();
            NhanVienDAO.Instance.docFile();
            PhanCongDAO.Instance.docFile();
            PhongDAO.Instance.docFile();
        }
        public string Path { get => path; set => path = value; }
    }
}
