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
    public partial class fQuanLy : Form
    {
        private DTO_Master loginMaster;

        public DTO_Master LoginMaster
        {
            get
            {
                return loginMaster;
            }
            set
            {
                loginMaster = value;
            }
        }
        public fQuanLy(DTO_Master boss)
        {
            InitializeComponent();
            this.LoginMaster = boss;
            
        }
        public fQuanLy()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
