using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLichNhanVien.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }
        public bool checkSDT(string s)
        {
            if (s.Length > 12 || s.Length < 9)
                return false;
            for (int i = 0; i < s.Length; i++)
                if (s[i] > '9' || s[i] < '0')
                    return false;
            return true;
        }
        public string layTenThu(DateTime date)
        {
            return date.ToString("ddd");
        }
    }
}
