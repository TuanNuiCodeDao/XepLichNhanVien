using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XepLichNhanVien.DAO;

namespace XepLichNhanVien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = @"C:\DataQuanLyXepLich";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string path_ = @"C:\DataQuanLyXepLich\DuongDan.txt";
            if (!File.Exists(path_))
            {
                File.Create(path_);
            }
            try
            {
                FilePath_.Instance.docFile();
                CaTrucDAO.Instance.docFile();
                ChuyenMonDAO.Instance.docFile();
                DangKyCaDAO.Instance.docFile();
                NhanVienDAO.Instance.docFile();
                PhanCongDAO.Instance.docFile();
                PhongDAO.Instance.docFile();
            }catch (Exception ex)
            {
                F_DuongDan f = new F_DuongDan();
                f.ShowDialog();
            }
            Application.Run(new FChinh());
        }
    }
}
