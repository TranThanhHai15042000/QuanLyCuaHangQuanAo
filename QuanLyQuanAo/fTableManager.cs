using QuanLyQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo
{
    public partial class fTableManager : Form
    {
        private DTO_Account loginAccount;

        public DTO_Account LoginAccount
        {
            get
            {
                return loginAccount;
            }
            set
            {
                loginAccount = value;
            }
        }
        public fTableManager(DTO_Account acc) 
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void thôngTinTàiKhoảngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void btnOutPMQL_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhachHang f1 = new fKhachHang();
            f1.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            fMuaHangOffline f = new fMuaHangOffline();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngNhậpQuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXacNhanAdmin f1 = new fXacNhanAdmin();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            fMuaHangOffline f = new fMuaHangOffline();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
