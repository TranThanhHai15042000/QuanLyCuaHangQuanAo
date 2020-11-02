using QuanLyQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class DAO_Master
    {
        private static DAO_Master instance;

        public static DAO_Master Instance
        {
            get
            {
                if (instance == null) instance = new DAO_Master();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private DAO_Master() { }

        public bool LoginMaster(string userNameMaster, string passWordMaster)
        {
            string query = "SELECT *FROM dbo.tblMaster WHERE Users = N'" + userNameMaster + "' AND Pass = N'" + passWordMaster + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public DTO_Master GetAccountByUserNameMaster(string userNameMaster)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select *from dbo.tblMaster  where Users = '" + userNameMaster + "'");

            foreach (DataRow item in data.Rows)
            {
                return new DTO_Master(item);
            }
            return null;
        }
    }
}
