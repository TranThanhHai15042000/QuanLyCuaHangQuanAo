using ShopQuanAo100.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo100
{
    public partial class fAddKH : Form
    {
        public fAddKH()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChiKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiKH.Focus();
                return;
            }
            if (mtbSDTKhach.Text == "(   )    -") // mặc định của trường masktextNumber
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbSDTKhach.Focus();
                return;
            }

            try
            {
                //Kiểm tra tồn tại mã khách 
                sql = "SELECT iDKhachHang FROM tblKhachHang WHERE iDKhachHang=N'" + txtMaKhach.Text.Trim() + "'";
                if (DAO_KhachHang.CheckKey(sql))
                {
                    MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKhach.Focus();
                    return;
                }

                //Chèn thêm
                sql = "INSERT INTO dbo.tblKhachHang VALUES (N'" + txtMaKhach.Text.Trim() +
                            "',N'" + txtTenKhach.Text.Trim() + "',N'" + txtDiaChiKH.Text.Trim() + "','" + mtbSDTKhach.Text + "',N'" + dateTimeSNKH.Value.ToString() + "')";
                //Functions.RunSQL(sql);

                DataProvider.Instance.ExecuteQuery(sql);
              //  fBill f = new fBill();
              //  f.Load();
                MessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
          //  ActivateButton(sender, RGBColors.color4);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuanTen_Click(object sender, EventArgs e)
        {
            if (txtTenKhach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            else

            {
                string newname = txtTenKhach.Text.Trim().ToLower();
                string kq = newname[0].ToString().ToUpper();
                for (int i = 1; i < newname.Length; i++)
                {

                    if (newname[i] != ' ')
                    {
                        if (newname[i - 1] == ' ')
                        {
                            kq = kq;
                        }
                        else kq = kq + newname[i];
                    }
                    if (newname[i] == ' ')
                    {
                        kq = kq + ' ' + newname[i + 1].ToString().ToUpper();
                    }
                    //else  kq = kq + newname[i];
                }
                txtTenKhach.Text = kq;
            }
         
        }
        private void LoadData()
        {
            string sql = "Select * from tblKhachHang ";
            DataProvider.Instance.ExecuteQuery(sql);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChiKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChiKH.Focus();
                return;
            }
            if (mtbSDTKhach.Text == "(   )    -") // mặc định của trường masktextNumber
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbSDTKhach.Focus();
                return;
            }

            try
            {
                //Kiểm tra tồn tại mã khách 
                sql = "SELECT iDKhachHang FROM tblKhachHang WHERE iDKhachHang=N'" + txtMaKhach.Text.Trim() + "'";
                if (DAO_KhachHang.CheckKey(sql))
                {
                    MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKhach.Focus();
                    return;
                }

                //Chèn thêm
                sql = "INSERT INTO dbo.tblKhachHang VALUES (N'" + txtMaKhach.Text.Trim() +
                            "',N'" + txtTenKhach.Text.Trim() + "',N'" + txtDiaChiKH.Text.Trim() + "','" + mtbSDTKhach.Text + "',N'" + dateTimeSNKH.Value.ToString() + "')";
                //Functions.RunSQL(sql);

                DataProvider.Instance.ExecuteQuery(sql);
                //  fBill f = new fBill();
                //  f.Load();
                MessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
