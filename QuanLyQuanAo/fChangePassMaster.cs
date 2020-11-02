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
    public partial class fChangePassMaster : Form
    {
        public fChangePassMaster()
        {
            InitializeComponent();
        }

        private void fChangePassMaster_Load(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewPass_Click(object sender, EventArgs e)
        {
            string newpass = txBNewPassTop.Text.ToString();
            string username = txtUseName.Text.ToString();
            if (MessageBox.Show("Bạn muốn đổi mật khẩu ?", "Thông báo ", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (txbNewPassBot.Text.ToString() == newpass && username.Length != 0 && txtPass.Text.ToString().Length != 0 && newpass.Length != 0 && txbNewPassBot.Text.ToString().Length != 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công ", "Thông báo");
                    string query = "update dbo.Master set PassMaster= '" + newpass + "' where UserNameMaster= '" + username + "' SELECT* FROM dbo.Master";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    fLogin f = new fLogin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công, vẫn sử dụng mật khẩu cũ", "Thông báo");
                }
            }
        }
    }
}
