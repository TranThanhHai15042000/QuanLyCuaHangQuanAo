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
    public partial class fThongKeDoanhThu : Form
    {
        public fThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private Form currentchildform;
        string CurrentMonth =   DateTime.Now.ToString("MM");
        private void Childfrom(Form child)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();

            }
            currentchildform = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            PanelChart.Controls.Add(child);
            PanelChart.Tag = child;
            child.BringToFront();
            child.Show();

        }


        private void DoanhSoBanHang()
        {

            //   MessageBox.Show(CurrentMonth);
            try
            {
                //DataProvider.getConnection().Open();
                //// SqlCommand cmdCountTongHD = new SqlCommand("select COUNT(IDhoadon) from HoaDon", connect);
                //SqlCommand cmdCountTongHDThangNay = new SqlCommand("SELECT COUNT  (MONTH(NgayBan)) AS  HDtimene FROM dbo.tblHoaDon where month(ngayban) = '" + CurrentMonth + "'  ", DataProvider.getConnection());
                //SqlCommand cmdCountHDToday = new SqlCommand("select count(idHoaDon) from dbo.tblHoaDon where cast (NgayBan as date) = cast(getdate() as DATE)", DataProvider.getConnection());
                //SqlCommand cmdCountTongTienThangNay = new SqlCommand("select sum(TongTien) from dbo.tblHoaDon where MONTH(NgayBan) = '" + CurrentMonth + "'  ", DataProvider.getConnection());
                //SqlCommand cmdCountTienToday = new SqlCommand("select sum(TongTien) from dbo.tblHoaDon where cast (NgayBan as date) = cast(getdate() as date)", DataProvider.getConnection());

                string cmdCountTongHDThangNay2 = "SELECT COUNT  (MONTH(NgayBan)) AS  HDtimene FROM dbo.tblHoaDon where month(ngayban) = '" + CurrentMonth + "'  ";
                string cmdCountHDToday2 = "select count(idHoaDon) from dbo.tblHoaDon where cast (NgayBan as date) = cast(getdate() as DATE)";
                string cmdCountTongTienThangNay2 = "select sum(TongTien) from dbo.tblHoaDon where MONTH(NgayBan) = '" + CurrentMonth + "'  ";
                string cmdCountTienToday2 = "select sum(TongTien) from dbo.tblHoaDon where cast (NgayBan as date) = cast(getdate() as date)";
                string cmdCountDistinctMasp = "SELECT COUNT(DISTINCT idCTHang)  FROM dbo.tblHoaDon JOIN dbo.tblCT_HoaDon ON tblCT_HoaDon.idHoaDon = tblHoaDon.idHoaDon WHERE MONTH(NgayBan) = '" + CurrentMonth + "' ";
                string cmdCountDistinctMaspToday = "SELECT COUNT(DISTINCT idCTHang)  FROM dbo.tblHoaDon JOIN dbo.tblCT_HoaDon ON tblCT_HoaDon.idHoaDon = tblHoaDon.idHoaDon  where cast(NgayBan as date) = cast(getdate() as date)";
               // SqlCommand cmdCountDistinctMasp = new SqlCommand("SELECT COUNT(DISTINCT value) FROM HoaDon CROSS APPLY STRING_SPLIT(HDmasp, ',') where MONTH(HDtime) = '" + CurrentMonth + "' ", DataProvider.getConnection());
               //  SqlCommand cmdCountDistinctMaspToday = new SqlCommand("SELECT COUNT(DISTINCT value) FROM HoaDon CROSS APPLY STRING_SPLIT(HDmasp, ',') where cast([HDtime] as date) = cast(getdate() as date) ", DataProvider.getConnection());

                int CountTongHD = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(cmdCountTongHDThangNay2));
                int CountHDtoday = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(cmdCountHDToday2));
                var CountTongTienThangNay = (DataProvider.Instance.ExecuteScalar(cmdCountTongTienThangNay2));
                var CountTienToday = (DataProvider.Instance.ExecuteScalar(cmdCountTienToday2));
                int CountDistinctMasp = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(cmdCountDistinctMasp));
                int CountDistinctMaspToday = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(cmdCountDistinctMaspToday));
                if (CountTienToday == DBNull.Value)
                {
                    lbDoanhSoToday.Text = "Hôm nay: " + 0;
                }
                else
                {
                    lbDoanhSoToday.Text = "Hôm nay: " + CountTienToday.ToString();
                }
                if (CountTongTienThangNay == DBNull.Value)
                {
                    lbDoanhSoToday.Text = "0";
                }
                else
                {
                    lbTongDoanhSo.Text = CountTongTienThangNay.ToString();
                }
                lbSumHD.Text = CountTongHD.ToString();
                lbHDtoday.Text = "Hôm nay: " + CountHDtoday.ToString();
                lbSumSP.Text = CountDistinctMasp.ToString();
                lbSPtoday.Text = "Hôm nay: " + CountDistinctMaspToday.ToString();
                DataProvider.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
                DataProvider.getConnection().Close();
            }
        }


        private void TongSLSPTrongKho()
        {
            try
            {
                // DataProvider.getConnection().Open();
                //SqlCommand cmdCountTongspTrongkho = new SqlCommand("select sum(Soluong) from dbo.tblCT_Hang", DataProvider.getConnection());
                //SqlCommand cmdCountNhapKhoToday = new SqlCommand("select COUNT(idCTHang) from dbo.tblCT_Hang where cast(ngaynhap as date) = cast(getdate() as date)", DataProvider.getConnection());
                string cmdCountTongspTrongkho = "select sum(Soluong) from dbo.tblCT_Hang";
                string cmdCountNhapKhoToday = "select COUNT(idCTHang) from dbo.tblCT_Hang where cast(ngaynhap as date) = cast(getdate() as date)";


                int CountTongspTrongkho = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(cmdCountTongspTrongkho));
                int CountCountNhapKhoToday = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(cmdCountNhapKhoToday));
              
                
                lbTongSP.Text = CountTongspTrongkho.ToString();
                lbNhapKhoToday.Text = "Nhập kho hôm nay: " + CountCountNhapKhoToday.ToString() + " sản phẩm";
                DataProvider.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoaiSPTrongKho()
        {
            try
            {
               // DataProvider.getConnection().Open();
                //SqlCommand cmdCountLoaiSPTrongkho = new SqlCommand("select count(idCTHang) from dbo.tblCT_Hang", DataProvider.getConnection());
                string cmdCountLoaiSPTrongkho = "select count(idCTHang) from dbo.tblCT_Hang";
                
                int CountCountLoaiSPTrongkho = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(cmdCountLoaiSPTrongkho));
                lbTongLoaiSp.Text = CountCountLoaiSPTrongkho.ToString();
                DataProvider.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TongTienKhachNo()
        {
            try
            {
                DataProvider.getConnection().Open();
                SqlCommand cmdSumKhachNoThang = new SqlCommand("select sum(HDno) from HoaDon where MONTH(HDtime) = '" + CurrentMonth + "' ", DataProvider.getConnection());
                SqlCommand cmdKhachNoToday = new SqlCommand("select sum(HDno) from HoaDon where cast ([HDtime] as date) = cast(getdate() as date)", DataProvider.getConnection());

                int SumKhachNoThang = Convert.ToInt32(cmdSumKhachNoThang.ExecuteScalar());
                var KhachNoToday = cmdKhachNoToday.ExecuteScalar();
                if (KhachNoToday == DBNull.Value)
                {
                    lbKhachNoToday.Text = "Hôm nay: 0";
                }
                else
                {
                    lbKhachNoToday.Text = "Hôm nay: " + KhachNoToday.ToString();
                }
                lbKhachNoThang.Text = SumKhachNoThang.ToString();
                DataProvider.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Childfrom(new ChartMoney());
        }

        private void btnSoLuong_Click(object sender, EventArgs e)
        {
            Childfrom(new ChartSLSP());
        }

        private void btnSPHetHang_Click(object sender, EventArgs e)
        {
            Childfrom(new ChartSPHet());
        }

        private void fThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            Childfrom(new ChartMoney());
            DoanhSoBanHang();
            TongSLSPTrongKho();
            LoaiSPTrongKho();
           // TongTienKhachNo();
        }
    }
}
