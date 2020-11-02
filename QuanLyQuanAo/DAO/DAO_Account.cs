using QuanLyQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
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
            string query = "SELECT *FROM dbo.tblUsers WHERE Users = N'" + userName + "' AND Pass= N'" + passWord +"'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count >0;
        }
        
        public DTO_Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select *from tblUsers where Users = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new DTO_Account(item);
            }
            return null;
        }
        
    }
}
