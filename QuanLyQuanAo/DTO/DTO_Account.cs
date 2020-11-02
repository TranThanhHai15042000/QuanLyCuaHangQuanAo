using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DTO
{
    public class DTO_Account
    {
        private string userName;
        
        public string UserName
        {
            get 
            {
                return userName;
            }
            set 
            {
                userName = value;
            }
        }

        private string pass;

        public string Pass
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
            }
        }

        public DTO_Account(string userName, string pass) 
        {
            this.userName = userName;
            this.pass = pass;
        }

        public DTO_Account(DataRow row)
        {
            this.userName = row["Users"].ToString();
            this.pass = row["Pass"].ToString();
        }
        

    }
}
