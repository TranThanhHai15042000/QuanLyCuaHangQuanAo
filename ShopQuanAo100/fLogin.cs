using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ShopQuanAo100.DTO;
using ShopQuanAo100.DAO;

namespace ShopQuanAo100
{
    public partial class fLogin : Form
    {

        public static string userName = "";
        public fLogin()
        {
            InitializeComponent();
        }


        bool Login(string userName, string passWord)
        {
            return DAO_Account.Instance.Login(userName, passWord);
        }

        void login()
        {
             userName = txtUseName.Text;
            string passWord = txtPass.Text;
            if (userName == "")
            {

                //lblKQ.Text = "Bạn chưa nhập tài khoản";
                txtUseName.Focus();
                txtUseName.SelectAll();
            }
            else if (passWord == "")
            {
                //lblKQ.Text = "Bạn chưa nhập mật khẩu";
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
        private void button1_Click(object sender, EventArgs e)
        {
            login();
            //fMains f = new fMains();
            //this.Hide();
            //f.ShowDialog();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUseName_Click(object sender, EventArgs e)
        {
            txtUseName.BackColor = Color.White;
            panelUser.BackColor = Color.White;
            panelPass.BackColor = SystemColors.ControlLight;
            txtPass.BackColor = SystemColors.ControlLight;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.White;
            panelPass.BackColor = Color.White;
            panelUser.BackColor = SystemColors.ControlLight;
            txtUseName.BackColor = SystemColors.ControlLight;
        }

        private void iconPictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;

        }

        private void iconPictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
