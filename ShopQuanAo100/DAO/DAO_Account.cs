using ShopQuanAo100.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo100.DAO
{
    public class DAO_Account
    {
        private static DAO_Account instance;

        public static DAO_Account Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Account();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private DAO_Account() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT *FROM dbo.tblNhanVien WHERE Users = N'" + userName + "' AND Pass= N'" + passWord + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public DTO_Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select *from tblNhanVien where Users = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new DTO_Account(item);
            }
            return null;
        }
    }
}
