using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DTO
{
    public class DTO_Master
    {
        private string userNameMaster;

        public string UserNameMaster
        {
            get
            {
                return userNameMaster;
            }
            set
            {
                userNameMaster = value;
            }
        }

        private string passMaster;

        public string PassMaster
        {
            get
            {
                return passMaster;
            }
            set
            {
                passMaster = value;
            }
        }

        public DTO_Master(string userNameMaster, string passMaster)
        {
            this.userNameMaster = userNameMaster;
            this.passMaster = passMaster;
        }

        public DTO_Master(DataRow row)
        {
            this.userNameMaster = row["Users"].ToString();
            this.passMaster = row["Pass"].ToString();
        }
    }
}
