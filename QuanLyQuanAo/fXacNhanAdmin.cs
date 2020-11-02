using QuanLyQuanAo.DAO;
using QuanLyQuanAo.DTO;
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
    public partial class fXacNhanAdmin : Form
    {
        public fXacNhanAdmin()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool LoginMaster(string userNameMaster, string passWordMaster)
        {
            return DAO_Master.Instance.LoginMaster(userNameMaster, passWordMaster);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userNameMaster = txbNameQuanLy.Text;
            string passWordMaster = txbXacNhanPass.Text;
            if (LoginMaster(userNameMaster, passWordMaster))
            {
                DTO_Master loginMaster = DAO_Master.Instance.GetAccountByUserNameMaster(userNameMaster);
                fQuanLy f = new fQuanLy(loginMaster);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập của master hoặc mật khẩu master!");
            }
        }

        private void fXacNhanAdmin_Load(object sender, EventArgs e)
        {

        }

        private void txbNameQuanLy_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fChangePassMaster f = new fChangePassMaster();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void txbXacNhanPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
