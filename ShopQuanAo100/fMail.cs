using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace ShopQuanAo100
{
    public partial class fMail : Form
    {
       
        public fMail()
        {
            InitializeComponent();
        }
        Attachment attach  = null;
  
        private void label2_Click(object sender, EventArgs e)
        {

        }

        void GuiMail(string from, string to, string subject, string message, Attachment file= null)
        {
            
          
           try
            {
                MailMessage mess = new MailMessage(from, to, subject, message);
                if (attach != null)
                {
                    mess.Attachments.Add(attach);
                }
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;

                client.Credentials = new NetworkCredential(txtTenDN.Text, txtMatKhau.Text);
                client.Send(mess);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        void Clear()
        {
            txtTo.Text = "";
            txtFile.Text = "";
            txtSubject.Text = "";
            txtMes.Text = "";
           
          


        }
        private void btnSend_Click(object sender, EventArgs e)
        {

            attach = null;
            try
            {
                FileInfo file = new FileInfo(txtFile.Text);
                attach = new Attachment(txtFile.Text);
                GuiMail(txtTenDN.Text, txtTo.Text, txtSubject.Text, txtMes.Text, attach);
                MessageBox.Show("Đã gởi mail thành công!");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);

            }

          
        }

        private void fMail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                //  txtFile = open.FileName;
                txtFile.Text = open.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                //  txtFile = open.FileName;
                txtTo.Text = open.FileName;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
