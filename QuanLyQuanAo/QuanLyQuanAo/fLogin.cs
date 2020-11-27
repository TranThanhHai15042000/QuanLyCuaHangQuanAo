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
using System.Runtime.InteropServices;

namespace QuanLyQuanAo
{
    public partial class fLogin : MetroFramework.Forms.MetroForm
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

        private void fLogin_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            login();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            fSignUp f = new fSignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
