using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo
{
    public partial class fNewAccount : Form
    {
        public fNewAccount()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text.ToString();
            string pass = tbxPass.Text.ToString();
            string passAgain = tbxPassAgain.Text.ToString();
            if (username.Length != 0 && pass.Length != 0 && passAgain.Length != 0)
            {
                if (pass == passAgain)
                {
                    string query = "insert into dbo.Account(UserName,Pass) values('" + username + "', '" + pass + "') select *from dbo.Account ";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("Thêm tài khoản mới thành công", "Thông báo", MessageBoxButtons.OK);
                    
                    fLogin f3 = new fLogin();
                    this.Hide();
                    f3.ShowDialog();
                    this.Show();
                }
                else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần nhập", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
