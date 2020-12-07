using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopQuanAo100.DAO;

namespace ShopQuanAo100
{
    public partial class fSetting : Form
    {
        DataTable tblNV;
        DataTable tblKH;
        public fSetting()
        {
           // InitializeComponent();

            if (fMains.tennv == "Admin")
            {
                //MessageBox.Show("ban la nhan vien");
                InitializeComponent();
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Chỉ có admin mới có thể truy cập chức năng này!");
                //this.Close();
            }
        }

        public void LoadDataGridView()
        {
            gridviewNhanVien();
            gridviewKhachHang();
        }

        public void gridviewNhanVien()
        {
            //data grid view nhan vien
            string sql;
            sql = "SELECT * FROM dbo.tblNhanVien";
            tblNV = DataProvider.Instance.ExecuteQuery(sql);
            dataGridViewNV.DataSource = tblNV; //Hiển thị vào dataGridView

            dataGridViewNV.Columns[0].HeaderText = "ID";
            dataGridViewNV.Columns[1].HeaderText = "Tên Nhân viên";
            dataGridViewNV.Columns[2].HeaderText = "Giới tính";
            dataGridViewNV.Columns[3].HeaderText = "Địa chỉ";
            dataGridViewNV.Columns[4].HeaderText = "Điện thoại";
            dataGridViewNV.Columns[5].HeaderText = "Ngày sinh";
            dataGridViewNV.Columns[6].HeaderText = "User";
            dataGridViewNV.Columns[7].HeaderText = "Pass";
            dataGridViewNV.Columns[0].Width = 20;
            dataGridViewNV.Columns[1].Width = 130;
            dataGridViewNV.Columns[2].Width = 70;
            dataGridViewNV.Columns[3].Width = 200;
            dataGridViewNV.Columns[4].Width = 150;
            dataGridViewNV.Columns[5].Width = 300;
            dataGridViewNV.Columns[6].Width = 150;
            dataGridViewNV.Columns[7].Width = 300;
            dataGridViewNV.AllowUserToAddRows = false;                 // Không cho người dùng thêm dữ liệu trực tiếp
            dataGridViewNV.EditMode = DataGridViewEditMode.EditProgrammatically;   //Không cho sửa dữ liệu trực tiếp

        }
        private void gridviewKhachHang()
        {
            //datagridview thong tin khach hang

            string sql;
            sql = "SELECT * from tblKhachHang";
            tblKH = DataProvider.Instance.ExecuteQuery(sql);
            dataGridViewKH.DataSource = tblKH; //Hiển thị vào dataGridView
            dataGridViewKH.Columns[0].HeaderText = "Mã Khách";
            dataGridViewKH.Columns[1].HeaderText = "Tên khách";
            dataGridViewKH.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewKH.Columns[3].HeaderText = "Điện thoại";
            dataGridViewKH.Columns[4].HeaderText = "Ngày sinh";
            dataGridViewKH.Columns[0].Width = 130;
            dataGridViewKH.Columns[1].Width = 130;
            dataGridViewKH.Columns[2].Width = 200;
            dataGridViewKH.Columns[3].Width = 150;
            dataGridViewKH.Columns[4].Width = 300;
            dataGridViewKH.AllowUserToAddRows = false;        // Không cho người dùng thêm dữ liệu trực tiếp
            dataGridViewKH.EditMode = DataGridViewEditMode.EditProgrammatically;      //Không cho sửa dữ liệu trực tiếp
        }






        string imglogoloc = "";


        private void fSetting_Load(object sender, EventArgs e)
        {
           
        }

        public void ResetValues()
        {
            txtTenShop.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtLoiChao.Text = "";

        }
        private void btnButtonChooseIMG_Click(object sender, EventArgs e)
        {
            DAO_Setting.GetAnh(pictureBox1, imglogoloc);
            
        }

        private void SaveIMGlogo_Click(object sender, EventArgs e)
        {
            
            DAO_Setting.SaveAnh(imglogoloc);
        }

        private void BtnSaveThongtin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenShop.Text))
            {
                MessageBox.Show("Trống!");
                txtTenShop.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                txtSDT.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                txtDiaChi.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtLoiChao.Text))
            {
                txtLoiChao.Select();
            }
            else
            {
               
            }
        }

        private void BtnSaveThongtin_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra tồn tại mã khách 



                //Chèn thêm
                string sql = sql = "UPDATE tblThongTinShop SET Tenshop=N'" + txtTenShop.Text.Trim().ToString() + "',DiaChi=N'" +
                txtDiaChi.Text.Trim().ToString() + "',SDT='" + txtSDT.Text.ToString() + "',LoiChao=N'" + txtLoiChao.Text.Trim().ToString() + "WHERE id= 1"; 
                //Functions.RunSQL(sql);

                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                ResetValues();

             
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void btnChiTietKhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnChiTietNhanVien_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
