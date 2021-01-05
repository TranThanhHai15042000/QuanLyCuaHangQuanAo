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
        DataTable tblCuaHang;
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
            LoadThongTinCuaHang();
           
        }

        public void gridviewNhanVien()
        {
            //data grid view nhan vien
            string sql;
            sql = "SELECT * FROM dbo.tblNhanVien  EXCEPT SELECT* FROM dbo.tblNhanVien WHERE Users = 'admin'";
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

        private void LoadThongTinCuaHang()
        {

            string sql = "select * from tblThongTinShop where id = 1 ";
            tblCuaHang = DataProvider.Instance.ExecuteQuery(sql);

            txtTenShop.Text = tblCuaHang.Rows[0]["TenShop"].ToString();
            txtDiaChi.Text = tblCuaHang.Rows[0]["Diachi"].ToString();
            txtSDT.Text = tblCuaHang.Rows[0]["SDT"].ToString();
            txtLoiChao.Text = tblCuaHang.Rows[0]["LoiChao"].ToString();



        }





        string imglogoloc = "";


        private void fSetting_Load(object sender, EventArgs e)
        {
            LoadThongTinCuaHang();
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
            DAO.DAO_Setting.GetAnh(pictureBox1 , imglogoloc);
        }

        private void SaveIMGlogo_Click(object sender, EventArgs e)
        {
            
            DAO_Setting.SaveAnh(imglogoloc);
        }

        private void BtnSaveThongtin_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnSaveThongtin_Click_1(object sender, EventArgs e)
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
                try
                {

                    //Chèn thêm
                    string sql = "UPDATE tblThongTinShop SET Tenshop=N'" + txtTenShop.Text+ "',DiaChi=N'" +
                    txtDiaChi.Text+ "',SDT='" + txtSDT.Text + "',LoiChao=N'" + txtLoiChao.Text + "'WHERE id= 1";
                    //Functions.RunSQL(sql);

                    DataProvider.Instance.ExecuteQuery(sql);
                    LoadDataGridView();
                  //  ResetValues();


                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu thất bại", "Thông báo");
                }
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

        private void SaveIMGlogo_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imglogoloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                using (var cmd = new SqlCommand("update tblThongTinShop set logo=@logo where ID=1"))
                {
                    cmd.Connection = DataProvider.getConnection();
                    cmd.Parameters.AddWithValue("@logo", img);
                    DataProvider.getConnection().Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã lưu");
                    }
                    else
                    {
                        MessageBox.Show("Lưu không thành công!");
                    }
                    DataProvider.getConnection().Close();
                }
            }
            catch (Exception ex)
            {
                DataProvider.getConnection().Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
