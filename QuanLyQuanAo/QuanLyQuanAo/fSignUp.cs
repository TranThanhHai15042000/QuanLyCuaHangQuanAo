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
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptrOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     

        private void fSignUp_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn sẽ thoát chương trình ? ", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            panelUser.ForeColor = Color.FromArgb(123, 121, 100);
            txtUser.ForeColor = Color.FromArgb(123, 121, 100);

            panelUser.ForeColor = Color.Black;
            txtUser.ForeColor = Color.Black;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            panelUser.ForeColor = Color.FromArgb(123, 121, 100);
            txtUser.ForeColor = Color.FromArgb(123, 121, 100);

            panelUser.ForeColor = Color.Black;
            txtUser.ForeColor = Color.Black;
        }

        private void txtRePass_Click(object sender, EventArgs e)
        {
            txtRePass.Clear();
            panelUser.ForeColor = Color.FromArgb(123, 121, 100);
            txtUser.ForeColor = Color.FromArgb(123, 121, 100);

            panelUser.ForeColor = Color.Black;
            txtUser.ForeColor = Color.Black;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            panelUser.ForeColor = Color.FromArgb(123, 121, 100);
            txtUser.ForeColor = Color.FromArgb(123, 121, 100);

            panelUser.ForeColor = Color.Black;
            txtUser.ForeColor = Color.Black;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
               lblKQ.Text = ("Bạn chưa nhập tài khoản");
                txtUser.Focus(); // đưa con trỏ chuột về lại ô name
            }
            else if (txtPass.Text == "")
            {
                lblKQ.Text = ("Bạn chưa nhập mật khẩu");
                txtPass.Focus();
            }
            else if (txtRePass.Text == "")
            {
                lblKQ.Text = ("Bạn chưa xác nhận mật khẩu");
                txtRePass.Focus();
            }
            else if (txtEmail.Text == "")
            {
                lblKQ.Text = ("Bạn chưa nhập E-mail");
                txtEmail.Focus();
            }
       
            
            else if (txtPass.Text != txtRePass.Text)
            {
                lblKQ.Text = ("ReviewPassword is not same password");
                txtRePass.Focus();// đưa con trỏ về ô mật khẩu
                txtRePass.SelectAll();// chọn tất cả dữ liệu
            }
            else
            {

                
            }

        }

        private void lblKQ_Click(object sender, EventArgs e)
        {

        }

        private void checkAgree_CheckedChanged(object sender, EventArgs e)
        {
            //if ((Keys)e.KeyChar == Keys.Enter)
            //{
            //    checkAgree.TabIndex= tru
            //}
        }
    }
}
