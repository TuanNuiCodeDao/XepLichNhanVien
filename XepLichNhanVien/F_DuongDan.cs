using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XepLichNhanVien.DAO;

namespace XepLichNhanVien
{
    public partial class F_DuongDan : Form
    {
        public F_DuongDan()
        {
            InitializeComponent();
            string path= FilePath_.Instance.Path;
            if (path == null)
                path = "";
            tbUrl.Text = path;
            if(string.IsNullOrEmpty(tbUrl.Text))
                button1.Enabled = false;
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                tbUrl.Text = f.SelectedPath+"\\";
                button1.Enabled = true;
            }
            else
            {
                tbUrl.Text = "";
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FilePath_.Instance.luuFile(tbUrl.Text);
                MessageBox.Show("Thiết lập đường dẫn thành công !");
                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Thiết lập đường dẫn thất bại !");
            }
        }

        private void F_DuongDan_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FilePath_.Instance.luuFile(tbUrl.Text);
                e.Cancel = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thiết lập đường dẫn chưa hoàn tất !");
                e.Cancel = true;
            }
        }
    }
}
