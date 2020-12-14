using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopQuanAo100.DAO;

namespace ShopQuanAo100
{
    public partial class fSize : Form

    {

        DataTable tblSize; //Chứa dữ liệu bảng Chất liệu
        public fSize()
        {
            InitializeComponent();
        }

        private void fSize_Load(object sender, EventArgs e)
        {
            LoadDataGridView(); //Hiển thị bảng tblChatLieu
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT idSize, TenSize FROM tblSize";
            tblSize = DataProvider.Instance.ExecuteQuery(sql); //Đọc dữ liệu từ bảng
            dgvSize.DataSource = tblSize; //Nguồn dữ liệu            
            dgvSize.Columns[0].HeaderText = "Mã chất liệu";
            dgvSize.Columns[1].HeaderText = "Mã chất liệu";
            dgvSize.Columns[0].Width = 100;
            dgvSize.Columns[1].Width = 300;
            dgvSize.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvSize.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaSize.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSize.Focus();
                return;
            }
            if (txtTenSize.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSize.Focus();
                return;
            }
            sql = "Select idSize From tblSize where idSize=N'" + txtMaSize.Text.Trim() + "'";
            if (DAO_ChatLieu.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSize.Focus();
                return;
            }

            sql = "INSERT INTO tblSize VALUES(N'" +
                txtMaSize.Text + "',N'" + txtMaSize.Text + "')";
            DataProvider.Instance.ExecuteQuery(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();

           // txtMaSize.Enabled = false;
        }

        private void dgvSize_Click(object sender, EventArgs e)
        {
            if (tblSize.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaSize.Text = dgvSize.CurrentRow.Cells["idSize"].Value.ToString();
            txtTenSize.Text = dgvSize.CurrentRow.Cells["TenSize"].Value.ToString();
        }

        private void ResetValue()
        {
            txtMaSize.Text = "";
            txtTenSize.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblSize.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSize.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenSize.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblSize SET TenSize=N'" +
                txtTenSize.Text.ToString() +
                "' WHERE idSize=N'" + txtMaSize.Text + "'";
            DataProvider.Instance.ExecuteQuery(sql);
            LoadDataGridView();
            ResetValue();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSize.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSize.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblSize WHERE idSize=N'" + txtMaSize.Text + "'";
                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaSize.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSize.Focus();
                return;
            }
            if (txtTenSize.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSize.Focus();
                return;
            }
            sql = "Select idSize From tblSize where idSize=N'" + txtMaSize.Text.Trim() + "'";
            if (DAO_ChatLieu.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSize.Focus();
                return;
            }

            sql = "INSERT INTO tblSize VALUES(N'" +
                txtMaSize.Text + "',N'" + txtMaSize.Text + "')";
            DataProvider.Instance.ExecuteQuery(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();

            // txtMaSize.Enabled = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblSize.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSize.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenSize.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblSize SET TenSize=N'" +
                txtTenSize.Text.ToString() +
                "' WHERE idSize=N'" + txtMaSize.Text + "'";
            DataProvider.Instance.ExecuteQuery(sql);
            LoadDataGridView();
            ResetValue();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSize.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSize.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblSize WHERE idSize=N'" + txtMaSize.Text + "'";
                DataProvider.Instance.ExecuteQuery(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
