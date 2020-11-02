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
    public partial class fDanhSachKhachHang : Form
    {
        public fDanhSachKhachHang()
        {
            InitializeComponent();
            LoadKH();
        }

        private void fDanhSachKhachHang_Load(object sender, EventArgs e)
        {

        }
        void LoadKH()
        {
            string query = "SELECT *From dbo.KhachHang";
            dataViewKH.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchKH_Click(object sender, EventArgs e)
        {
            string temp = tbxSearchKH.Text.ToString();
            string query = "SELECT *FROM dbo.KhachHang where TênKH = '"+temp+"'";
            dataViewKH.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
    }
}
