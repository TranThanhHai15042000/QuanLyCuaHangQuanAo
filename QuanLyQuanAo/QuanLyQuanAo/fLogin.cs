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

    

      

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn sẽ thoát chương trình ? ","Thông báo ",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning )!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        bool Login(string userName, string passWord)
        {
            return DAO_Account.Instance.Login( userName , passWord);
        }
        void login()
        {
            string userName = txtUseName.Text;
            string passWord = txtPass.Text;
            if (userName == "")
            {

                lblKQ.Text = "Bạn chưa nhập tài khoản";
                txtUseName.Focus();
                txtUseName.SelectAll();
            }
            else if (passWord == "")
            {
                lblKQ.Text = "Bạn chưa nhập mật khẩu";
                txtPass.Focus();
                txtPass.SelectAll();
            }
            else
            {
                if (Login(userName, passWord))
                {
                    DTO_Account loginAccount = DAO_Account.Instance.GetAccountByUserName(userName);
                    fMains f = new fMains(loginAccount);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtUseName_Click(object sender, EventArgs e)  
        {
            txtUseName.Clear();
          //  ptrUser.BackgroundImage = Properties.Resources.User;
            panelUser.ForeColor = Color.FromArgb(123, 121, 100);
            txtUseName.ForeColor = Color.FromArgb(123, 121, 100);

            panelUser.ForeColor = Color.WhiteSmoke;
            txtUseName.ForeColor = Color.WhiteSmoke;



        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtPass.PasswordChar = '*';
          //  ptrUser.BackgroundImage = Properties.Resources.User;
            panelPass.ForeColor = Color.FromArgb(123, 121, 100);
            txtPass.ForeColor = Color.FromArgb(123, 121, 100);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                login();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                login();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtUseName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
