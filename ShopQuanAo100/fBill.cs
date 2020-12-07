using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopQuanAo100.DAO;

namespace ShopQuanAo100
{
    public partial class fBill : Form
    {
        DataTable tblCTHDB;

        public static string thanhtoan = "";//nut Tính tiền chuyển tạm thời cho form TT
        public static string IDhoadon = "";
        public static string HDmasp = "";
        public static string HDtensp = "";
        public static string HDdongia = "";
        public static string HDsl = "";
        public static string HDloai = "";
        //  public static string HDthanhtoan = "";
        public static string HDdonvi = "";
        public static string SDT = "";
        public static string TenKH = "";


        public fBill()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.idCTHang, b.Ten, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM tblCT_HoaDon AS a, tblCT_Hang AS b WHERE a.idHoaDon = N'" + txtMaHoaDon.Text + "' AND a.idCTHang=b.idCTHang";
            tblCTHDB = DataProvider.Instance.ExecuteQuery(sql);
            dgvHoaDon.DataSource = tblCTHDB;
            //dgvHoaDon.DataSource = tblCTHDB;
            //dgvHoaDon.DataSource = tblCTHDB;
            //dgvHoaDon.Columns[0].HeaderText = "Mã hàng";
            //dgvHoaDon.Columns[1].HeaderText = "Tên hàng";
            //dgvHoaDon.Columns[2].HeaderText = "Số lượng";
            //dgvHoaDon.Columns[3].HeaderText = "Đơn giá";
            //dgvHoaDon.Columns[4].HeaderText = "Giảm giá %";
            //dgvHoaDon.Columns[5].HeaderText = "Thành tiền";
            //dgvHoaDon.Columns[0].Width = 80;
            //dgvHoaDon.Columns[1].Width = 130;
            //dgvHoaDon.Columns[2].Width = 80;
            //dgvHoaDon.Columns[3].Width = 90;
            //dgvHoaDon.Columns[4].Width = 90;
            //dgvHoaDon.Columns[5].Width = 90;
            //dgvHoaDon.AllowUserToAddRows = false;
            //dgvHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void clearsp()
        {
            txtTenSP.Clear();
            cbbMaSP.Text = "";
            txtsoluongsp.Clear();
            txtDonGiaSP.Clear();
            txtgiamphantramsp.Clear();
            txtThanhTien.Clear();
            cbbChatLieu.Text="";
            cbbSize.Text="";
            cbbSize.SelectedItem = null;
            cbbSize.Text = null;

            cbbChatLieu.Text = null;
        }
        public void huyhd()
        {
            txtTenKH.Clear();
            cbbSDTKH.Text = "";
            txtTenSP.Clear();
            cbbMaSP.Text = "";
            txtsoluongsp.Clear();
            txtDonGiaSP.Clear();
            txtgiamphantramsp.Clear();
            txtThanhTien.Clear();
            cbbSize.SelectedItem = null;
            cbbSize.Text = null;
            txtTongTien.Clear();
            txtgiamtientong.Clear();
            txtgiamphantramtong.Clear();
            txtthanhtoan.Clear();
            txtcongtientong.Clear();
            txtcongphantramtong.Clear();
            dgvHoaDon.Rows.Clear();
            dgvHoaDon.Refresh();
        }

        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = DAO_Bill.ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {

        }

        private void fBill_Load(object sender, EventArgs e)
        {
            string sql;
            try
            {
              
                // tạo ngẫu nhiên khóa chính
                CreateKey();

                // lấy dữ liệu nhân viên
                DataTable nv = DAO_Bill.GetData("SELECT idNhanVien, TenNV FROM tblNhanVien");
                cbbMaNhanVien.DataSource = nv;
                cbbMaNhanVien.DisplayMember = "TenNV";
                cbbMaNhanVien.ValueMember = "idNhanVien";

                //lấy dữ liệu hàng
                DataTable hang = DAO_Bill.GetData("SELECT idCTHang, ten FROM tblCT_Hang");
                cbbMaSP.DataSource = hang;
                cbbMaSP.DisplayMember = "ten";
                cbbMaSP.ValueMember = "idCTHang";

                // lấy dữ liệu Khách hàng
                DataTable kh = DAO_Bill.GetData("SELECT idKhachHang, dienthoai FROM tblKhachHang");
                cbbSDTKH.DataSource = kh;
                cbbSDTKH.DisplayMember = "dienthoai";
                cbbSDTKH.ValueMember = "idKhachHang";


                //lấy dữ liệu size
                DataTable size = DAO_Bill.GetData("SELECT idSize, tenSize FROM tblCT_Hang");
                cbbMaSP.DataSource = size;
                cbbMaSP.DisplayMember = "tenSize";
                cbbMaSP.ValueMember = "idSize";

                // lấy dữ liệu chất liệu
                DataTable chatlieu = DAO_Bill.GetData("SELECT idChatLieu, TenChatLieu FROM tblKhachHang");
                cbbSDTKH.DataSource = chatlieu;
                cbbSDTKH.DisplayMember = "TenChatLieu";
                cbbSDTKH.ValueMember = "idChatLieu";



                if (txtMaHoaDon.Text != "")
                {
                  //  LoadInfoHoaDon();
                   // btnXoa.Enabled = true;
                  //  btnthanhtoan.Enabled = true;
                }
                LoadDataGridView();
                clearsp();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void LoadInfoHoaDon()
        {
            //string str;
            //str = "SELECT NgayBan FROM tblHDBan WHERE MaHDBan = N'" + txtMaHDBan.Text + "'";
            //txtNgayBan.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));
            //str = "SELECT MaNhanVien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHDBan.Text + "'";
            //cboMaNhanVien.Text = Functions.GetFieldValues(str);
            //str = "SELECT MaKhach FROM tblHDBan WHERE MaHDBan = N'" + txtMaHDBan.Text + "'";
            //cboMaKhach.Text = Functions.GetFieldValues(str);
            //str = "SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHDBan.Text + "'";
            //txtTongTien.Text = Functions.GetFieldValues(str);
            //lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongTien.Text);
        }
        private void CreateKey()
        {
            txtMaHoaDon.Text = DAO_Bill.CreateKey("HDB");
        }




        private void btnthem_Click(object sender, EventArgs e)
        {

            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT idHoaDon FROM tblHoaDon WHERE idHoaDon=N'" + txtMaHoaDon.Text + "'";
            if (!DAO_Bill.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (dtpNgayBan.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpNgayBan.Focus();
                    return;
                }
                if (cbbMaNhanVien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbMaNhanVien.Focus();
                    return;
                }
                if (cbbSDTKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbSDTKH.Focus();
                    return;
                }
                sql = "INSERT INTO tblHoaDon(idHoadon, NgayBan, TongTien,idNhanVien, idKhachHang) VALUES (N'" + txtMaHoaDon.Text.Trim() + "','" +
                        dtpNgayBan.Value.ToString() + "',N'" + txtTongTien.Text +  "',N'" +
                        cbbSDTKH.SelectedValue + "'," + cbbMaNhanVien.SelectedValue + ")";
                DataProvider.Instance.ExecuteQuery(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cbbMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaSP.Focus();
                return;
            }
            if ((txtsoluongsp.Text.Trim().Length == 0) || (txtsoluongsp.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluongsp.Text = "";
                txtsoluongsp.Focus();
                return;
            }
            if (txtgiamphantramsp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgiamphantramsp.Focus();
                return;
            }
            sql = "SELECT idCTHang FROM tblCT_HoaDon WHERE idCTHang=N'" + cbbMaSP.SelectedValue + "' AND idHoaDon = N'" + txtMaHoaDon.Text.Trim() + "'";
            if (DAO_Bill.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearsp ();
                cbbMaSP.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(DAO_Bill.SimpleRead("SELECT SoLuong FROM tblCT_Hang WHERE idCTHang = N'" + cbbMaSP.SelectedValue + "'"));
            if (Convert.ToDouble(txtsoluongsp.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluongsp.Text = "";
                txtsoluongsp.Focus();
                return;
            }
            sql = "INSERT INTO tblCT_HoaDon(SoLuong,DonGia,GiamGia,ThanhTien, idCTHang,idHoaDon) VALUES( " + txtsoluongsp.Text + "," + txtDonGiaSP.Text + "," + txtgiamphantramsp.Text + "," + txtThanhTien.Text + ", N'" + cbbMaSP.SelectedValue + "',N'" + txtMaHoaDon.Text.Trim() +"')";
            DataProvider.Instance.ExecuteQuery(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtsoluongsp.Text);
            sql = "UPDATE tblCT_Hang SET SoLuong =" + SLcon + " WHERE idCTHang= N'" + cbbMaSP.SelectedValue + "'";
            DataProvider.Instance.ExecuteQuery(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(DAO_Bill.SimpleRead("SELECT TongTien FROM tblHoaDon WHERE idHoaDon = N'" + txtMaHoaDon.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE tblHoadon SET TongTien =" + Tongmoi + " WHERE idHoaDon = N'" + txtMaHoaDon.Text + "'";
            DataProvider.Instance.ExecuteQuery(sql);
            txtTongTien.Text = Tongmoi.ToString();
            lblBangChu.Text = "Bằng chữ: " + DAO_Bill.ChuyenSoSangChu(Tongmoi);
            clearsp();
            //btnXoa.Enabled = true;
            //btnThem.Enabled = true;
            //btnInHoaDon.Enabled = true;


            //bool found = false;
            //if (dgvHoaDon.Rows.Count > 0)
            //{
            //    foreach (DataGridViewRow row in dgvHoaDon.Rows)
            //    {
            //        if (Convert.ToString(row.Cells[0].Value) == cbbMaSP.Text)
            //        {
            //            //neu them san pham giong nhau se cộng dồn số lượng và tiền vào ô
            //            row.Cells[2].Value = (int.Parse(txtsoluongsp.Text) + Convert.ToInt16(row.Cells[2].Value.ToString()));
            //            row.Cells[4].Value = (double.Parse(txtThanhTien.Text) + Convert.ToDouble(row.Cells[4].Value.ToString()));
            //            found = true;
            //            /////////////////////
            //        }
            //    }
            //    if (!found)
            //    {
            //        dgvHoaDon.Rows.Add(cbbMaSP.Text, txtTenSP.Text, txtsoluongsp.Text, txtDonGiaSP.Text, txtThanhTien.Text, txtChatLieu.Text, txtSize.Text, txtgiamphantramsp.Text);
            //    }
            //}
            //else
            //{
            //    dgvHoaDon.Rows.Add(cbbMaSP.Text, txtTenSP.Text, txtsoluongsp.Text, txtDonGiaSP.Text, txtThanhTien.Text, txtChatLieu.Text, txtSize.Text, txtgiamphantramsp.Text);
            //}

            //double sum = 0;
            //for (int i = 0; i < dgvHoaDon.Rows.Count; ++i)
            //{
            //    sum += Convert.ToDouble(dgvHoaDon.Rows[i].Cells[4].Value);
            //}
            //txtTongTien.Text = sum.ToString("###,###");
            ////------------------- update sql -----------------//
            //string sql = "update tblCT_Hang set soluong=soluong - '" + txtsoluongsp.Text + "' where idCTHang ='" + cbbMaSP.Text + "' ";
            //DataProvider.Instance.ExecuteQuery(sql);

            //clearsp();
        }

        private void cbbTenSp_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbbMaSP.Text == "")
            {
                txtTenSP.Text = "";
                txtDonGiaSP.Text = "";
                txtsoluongsp.Text = "";
            }
            // Khi chọn MÃ hàng tự động hiện ra
            str = "SELECT Ten FROM tblCT_Hang WHERE idCTHang =N'" + cbbMaSP.SelectedValue.ToString() + "'";
            txtTenSP.Text = DAO_Bill.SimpleRead(str);
            str = "SELECT DonGiaBan FROM tblCT_Hang WHERE idCTHang =N'" + cbbMaSP.SelectedValue.ToString() + "'";
            txtDonGiaSP.Text = DAO_Bill.SimpleRead(str);

            //str = "select soluong from tblCT_Hang where (tensp= N'" + cbbMaSP.Text + "') ";
            //DAO_Bill.CheckSL(str,checkslsp);

            str = "SELECT SoLuong FROM tblCT_Hang WHERE idCTHang = N'" + cbbMaSP.SelectedValue.ToString() + "'";
            txtsoluongsp.Text = DAO_Bill.SimpleRead(str);
            //str = "SELECT idChatLieu FROM tblCT_Hang WHERE idCTHang = N'" + cbbChatLieu.SelectedValue.ToString() + "'";
            //cbbChatLieu.Text = DAO_Bill.SimpleRead(str);
            //str = "SELECT idSize FROM tblCT_Hang WHERE idCTHang = N'" + cbbSize.SelectedValue.ToString() + "'";
            //cbbSize.Text = DAO_Bill.SimpleRead(str);

            // thành tiền
            double giamgiaTextbox = 0;
            double slsp = 0;
            double dongiasp = 0;
            double thanhtiensp;
            double thanhtiensp2;
            if (txtsoluongsp.Text != "")
            {
                slsp = double.Parse(txtsoluongsp.Text);
            }
            if (txtDonGiaSP.Text != "")
            {
                dongiasp = double.Parse(txtDonGiaSP.Text);
            }

            thanhtiensp = slsp * dongiasp;
            //tien giam gia cua san pham
            if (txtgiamphantramsp.Text != "")
            {
                giamgiaTextbox = double.Parse(txtgiamphantramsp.Text);
            }

            double giamgiasp = (giamgiaTextbox * thanhtiensp) / 100;
            //tien san pham = (so luong * don gia ) - giam gia
            thanhtiensp2 = thanhtiensp - giamgiasp;

            txtThanhTien.Text = thanhtiensp2.ToString("###,###");
        }


        double checkslsp;//kiem tra so luong san pham nao do trong ton kho
        private void txtsoluongsp_TextChanged(object sender, EventArgs e)
        {
            #region
            //string str = "SELECT SoLuong FROM tblCT_Hang WHERE idCTHang = N'" + cbbMaSP.SelectedValue.ToString() + "'";
            //checkslsp = Convert.ToDouble(DAO_Bill.SimpleRead(str));
            //if (string.IsNullOrWhiteSpace(txtsoluongsp.Text))
            //{

            //}
            //else if (string.IsNullOrWhiteSpace(txtDonGiaSP.Text))
            //{

            //}
            //else if (string.IsNullOrWhiteSpace(txtgiamphantramsp.Text))
            //{

            //}
            //else
            //{
            //    int slspHienTai = Convert.ToInt32(txtsoluongsp.Text);
            //    if (slspHienTai > checkslsp)
            //    {
            //        txtsoluongsp.Text = checkslsp.ToString();
            //    }
            //    else
            //    {

            //double giamgiaTextbox;
            //double slsp;
            //double dongiasp;
            //double thanhtiensp;
            //double thanhtiensp2;


            //dongiasp = double.Parse(txtDonGiaSP.Text);
            //thanhtiensp = slsp * dongiasp;

            ////tien giam gia cua san pham
            //giamgiaTextbox = double.Parse(txtgiamphantramsp.Text);
            //double giamgiasp = (giamgiaTextbox * thanhtiensp) / 100;
            ////tien san pham = (so luong * don gia ) - giam gia
            //thanhtiensp2 = thanhtiensp - giamgiasp;


            //txttiensp.Text = thanhtiensp2.ToString("###,###");
            #endregion 

            double tt, sl, dg, gg;
            if (txtsoluongsp.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluongsp.Text);
            if (txtgiamphantramsp.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamphantramsp.Text);
            if (txtDonGiaSP.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaSP.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
            //    }


            //}

        }

        private void btnhuyHD_Click(object sender, EventArgs e)
        {
            huyhd();
            CreateKey();
        }



        private void cbbSDT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {



        }

        private void cbbSDTKH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbbSDTKH.Text == "")
            {
                txtTenKH.Text = "";
            }
            // Khi chọn SDT Tên khách tự động hiện ra
            str = "SELECT TenKhach FROM tblKhachHang WHERE idKhachHang =N'" + cbbSDTKH.SelectedValue.ToString() + "'";
            txtTenKH.Text = DAO_Bill.SimpleRead(str);


            // Khi chọn sdT ten khach  tự động hiện ra
            str = "SELECT idKhachHang FROM tblKhachHang WHERE idKhachHang =N'" + cbbSDTKH.SelectedValue.ToString() + "'";
            txtMaKhach.Text = DAO_Bill.SimpleRead(str);

            //// Khi chọn sdT ma khach  tự động hiện ra
            //str = "SELECT idKhachHang FROM tblKhachHang WHERE DienThoai =N'" + cbbSDTKH.SelectedValue.ToString() + "'";
            //txtMaKhach.Text = DAO_Bill.SimpleRead(str);


        }

        private void txtgiamphantramsp_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtsoluongsp.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluongsp.Text);
            if (txtgiamphantramsp.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamphantramsp.Text);
            if (txtDonGiaSP.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaSP.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }


        string maspedit;
        int slspedit;
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow.Index != -1)
            {
                clearsp();


                txtMaHoaDon.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString();
                txtsoluongsp.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString();
                txtDonGiaSP.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();

                txtThanhTien.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();

                cbbSize.Text = dgvHoaDon.CurrentRow.Cells[5].Value.ToString();
                cbbChatLieu.Text = dgvHoaDon.CurrentRow.Cells[6].Value.ToString();
                txtgiamphantramsp.Text = dgvHoaDon.CurrentRow.Cells[7].Value.ToString();
                maspedit = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                slspedit = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells[2].Value.ToString());
            }
            else
            {
                MessageBox.Show("No data!");
            }
        }
    }
}