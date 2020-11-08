using QuanLyQuanAo.DAO;
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
    public partial class fMuaHangOnline : Form
    {
        public fMuaHangOnline()
        {
            InitializeComponent();
            LoadBill();
        }
        void LoadBill()
        {
            string query = "SELECT *FROM dbo.Bill";
            dataViewListBuy.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void fMuaHang_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbSumMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInBill_Click(object sender, EventArgs e)
        {
            string MaKH = txbMaKH.Text.ToString();
            string MaNV = txbNVSell.Text.ToString();
            string MaBill = txbCreateKey.Text.ToString();
            string sumStr = txbSumBill.Text.ToString();
            string dateInB = txbDateinBill.Text.ToString();

            float sum = float.Parse(sumStr);
            string query = "insert into DSBill(TongTien,NgayinBill,MaBill,MaKH,MaNV) values('"+sum+"','"+dateInB+"','"+MaBill+"','"+MaKH+"','"+MaNV+"') ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            MessageBox.Show("Thanh toán thành công", "Thông báo");
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dataViewShowBuyOn_Click(object sender, EventArgs e)
        {

        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateKey_Click(object sender, EventArgs e)
        {
            txbCreateKey.Text = CBill.CreateKey("hihi");
        }

        private void txbDateinBill_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            string name = txbNameH.Text.ToString();
            string stt = txbSTT.Text.ToString();
            string PriceStr =txbPriceH.Text.ToString();
            string SLStr = txbSlH.Text.ToString();
            string MaKH = txbMaKH.Text.ToString();
            string GGStr = txbSafe.Text.ToString();
            string sumStr = txbSumMoney.Text.ToString();

            int Price = Int32.Parse(PriceStr);
            int SL = Int32.Parse(SLStr);
            int GG = Int32.Parse(GGStr);
            float sum = float.Parse(sumStr);

            string query = "update dbo.Bill set MaKH='"+MaKH+"',Ten='"+name+"',SoLuong='"+SL+"',Gia='"+Price+"',GiamGia='"+GG+"',TongTien='"+sum+"' Where SttBill='"+stt+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            string query1 = "select *From Bill";
            dataViewListBuy.DataSource = DataProvider.Instance.ExecuteQuery(query1);
            
        }

        private void txbSlH_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txbSlH.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txbSlH.Text);
            if (txbSafe.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txbSafe.Text);
            if (txbPriceH.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txbPriceH.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txbSumMoney.Text = tt.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txbSTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumMoney_Click(object sender, EventArgs e)
        {
            string query = "select SUM(Gia) from Bill";

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            btnAddToBill.Enabled = true;

            if (cbBLoai.SelectedItem.ToString() == "Áo")
            {
                txbMaH.Enabled = true;
                if (txbMaH.Text.ToString().Length == 0)
                {
                    string query1 = "select *from dbo.Ao";
                    dataViewKho.DataSource = DataProvider.Instance.ExecuteQuery(query1);

                }
                else
                {
                    string query2 = "select *from dbo.Ao where idAo='"+txbMaH.Text+"'";
                    dataViewKho.DataSource = DataProvider.Instance.ExecuteQuery(query2);
                }

            }
        }

        private void dataViewKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataViewKho.Rows[e.RowIndex];
                txbNameH.Text = row.Cells[2].Value.ToString();
                txbPriceH.Text = row.Cells[6].Value.ToString();
            }
        }

        private void txbSafe_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txbSlH.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txbSlH.Text);
            if (txbSafe.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txbSafe.Text);
            if (txbPriceH.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txbPriceH.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txbSumMoney.Text = tt.ToString();
        }

        private void txbCreateKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumMoney_Click_1(object sender, EventArgs e)
        {
            if (txbSumMoney.Text.ToString().Length != 0)
            {
                string query = "select SUM(TongTien) From Bill  ";
                dataViewSum.DataSource = DataProvider.Instance.ExecuteQuery(query);

            }
            else MessageBox.Show("Chưa đủ thông tin tính Bill", "Thông báo");
        }

        private void dataViewListBuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataViewKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataViewSum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataViewKho.Rows[e.RowIndex];
                //txbSumBill.Text= row.Cells[1].Value.ToString();
            }
        }
    }
}
