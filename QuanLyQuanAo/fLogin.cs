using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanAo.DAO;
using QuanLyQuanAo.DTO;

namespace QuanLyQuanAo
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void lblUseName_Click(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn sẽ thoát chương trình ? ","Thông báo ",MessageBoxButtons.OKCancel )!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        bool Login(string userName, string passWord)
        {
            return DAO_Account.Instance.Login( userName , passWord);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUseName.Text;
            string passWord = txtPass.Text;
            if (Login(userName, passWord))
            {
                DTO_Account loginAccount = DAO_Account.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void txtUseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            fMuaHangOnline f = new fMuaHangOnline();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
