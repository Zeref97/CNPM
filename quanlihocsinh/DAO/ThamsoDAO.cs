using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlihocsinh.DAO
{
    public class ThamsoDAO
    {
        private static ThamsoDAO instance;

        public static ThamsoDAO Instance
        {
            get { if (instance == null) instance = new ThamsoDAO(); return ThamsoDAO.instance; }
            private set { ThamsoDAO.instance = value; }
        }
        ThamsoDAO() { }

        public int getThamSo(string name)
        {
            //int result;
            string query = string.Format("Select {0} FROM THAMSO",name);
            object data = DataProvider.Instance.ExecuteScalar(query);
            return (int)data;
        }
    }
}
