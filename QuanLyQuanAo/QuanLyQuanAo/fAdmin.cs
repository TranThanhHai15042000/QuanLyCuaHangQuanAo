using QuanLyQuanAo.DAO;
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

namespace QuanLyQuanAo
{
    public partial class fAdmin : Form
    {
       
        public fAdmin()
        { 
            InitializeComponent();
          //  LoadHat();
          //  LoadAo();
          //  LoadQuan();
          //  LoadSock();
           // LoadDSBill();
        }
        //void LoadDSBill()
        //{
        //    //string query = "SELECT *From dbo.DSBill";
        //    //dataViewDSBill.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //}
        //void LoadHat()
        //{
        //    //string query = "SELECT* FROM dbo.Hat";
        //    //dataViewHat.DataSource = DataProvider.Instance.ExecuteQuery(query);  
        //}
        //void LoadAo()
        ////{
        ////    string query = "SELECT* FROM dbo.Ao";
        ////    dataViewAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //}
        //void LoadQuan()
        //{
        //    //string query = "SELECT* FROM dbo.Quan";
        //    //dataViewQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //}
        //void LoadSock()
        //{
        //    //string query = "SELECT* FROM dbo.Sock";
        //    //dataViewSock.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //}
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tpQuan_Click(object sender, EventArgs e)
        {

        }

        private void tpSock_Click(object sender, EventArgs e)
        {

        }

        private void tbDoanhthu_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchSock_Click(object sender, EventArgs e)
        {
            if (cbBSearchKDSock.SelectedItem.ToString()== "Nam")
            {
                string query = "select NgayNhapSock,idSock ,nameS,SoLuongS,priceS from dbo.Sock where KieuDangS=N'Nam'";
                dataViewSearchSock.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchKDSock.SelectedItem.ToString() == "Nữ")
            {
                string query = "select NgayNhapSock,idSock ,nameS,SoLuongS,priceS from dbo.Sock where KieuDangS=N'Nữ'";
                dataViewSearchSock.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }

        private void txbNameSock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteHangE_Click(object sender, EventArgs e)
        {

        }

        private void cbBSearchHangTonKho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSearchAo_Click(object sender, EventArgs e)
        {
            /*if (cbBSearchAo.SelectedItem.ToString() == "AoNam")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SizeA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nam' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchAo.SelectedItem.ToString() == "AoNu")
            {
                string query = "select idAo ,nameA,SizeA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nữ'";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }*/
            if (cbBSearchKDAo.SelectedItem.ToString() == "AoNam"&& cbBSearchSizeAo.SelectedItem.ToString()=="S")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nam'and SizeA='S' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchKDAo.SelectedItem.ToString() == "AoNam" && cbBSearchSizeAo.SelectedItem.ToString() == "M")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nam'and SizeA='M' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchKDAo.SelectedItem.ToString() == "AoNam" && cbBSearchSizeAo.SelectedItem.ToString() == "L")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nam'and SizeA='L' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchKDAo.SelectedItem.ToString() == "AoNam" && cbBSearchSizeAo.SelectedItem.ToString() == "XL")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nam'and SizeA='XL' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchKDAo.SelectedItem.ToString() == "AoNam" && cbBSearchSizeAo.SelectedItem.ToString() == "XXL")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nam'and SizeA='XXL' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchKDAo.SelectedItem.ToString() == "AoNu" && cbBSearchSizeAo.SelectedItem.ToString() == "S")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nữ'and SizeA='S' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchKDAo.SelectedItem.ToString() == "AoNu" && cbBSearchSizeAo.SelectedItem.ToString() == "M")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nữ'and SizeA='M' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchKDAo.SelectedItem.ToString() == "AoNu" && cbBSearchSizeAo.SelectedItem.ToString() == "L")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nữ'and SizeA='L' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchKDAo.SelectedItem.ToString() == "AoNu" && cbBSearchSizeAo.SelectedItem.ToString() == "XL")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nữ'and SizeA='XL' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchKDAo.SelectedItem.ToString() == "AoNu" && cbBSearchSizeAo.SelectedItem.ToString() == "XXL")
            {
                string query = "select NgayNhapAo,idAo ,nameA,SoLuongA,priceA from dbo.Ao where KieuDangA=N'Nữ'and SizeA='XXL' ";
                dataViewSearchAo.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }

        private void btnAddQuan_Click(object sender, EventArgs e)
        {
            string AddIDQ = txbIDQ.Text.ToString();
            string UpdateQ = dateTimeNhapQ.Value.ToString();
            string AddNameQ = txbNameQ.Text.ToString();
            string AddSizeQ = txbSizeQ.Text.ToString();
            string AddPriceQ = txbPriceQ.Text.ToString();
            string AddSoLuongQ = txbSLQ.Text.ToString();
            string AddKDQ = txbKDQ.Text.ToString();
            if (AddIDQ.Length!=0&& UpdateQ.Length!=0&& AddNameQ.Length!=0&& AddSizeQ.Length!=0&& AddPriceQ.Length!=0&& AddSoLuongQ.Length!=0&& AddKDQ.Length!=0)
            {
                try
                {
                    string query = "SET IDENTITY_INSERT QuanlyQuanAo. dbo. Quan ON insert into Quan(idQuan,NgayNhapQuan,nameQ,SizeQ,SoLuongQ,KieuDangQ,priceQ) values('" + AddIDQ + "','" + UpdateQ + "','" + AddNameQ + "','" + AddSizeQ + "','" + AddSoLuongQ + "','" + AddKDQ + "','" + AddPriceQ + "')";
                    DataTable result = DataProvider.Instance.ExecuteQuery(query);
                    if (MessageBox.Show("Thêm thành công", "Thông báo ", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        string query1 = "SELECT* FROM dbo.Quan";
                        dataViewQuan.DataSource = DataProvider.Instance.ExecuteQuery(query1);

                        this.txbIDQ.Enabled = false;
                        this.txbNameQ.Enabled = false;
                        this.txbSizeQ.Enabled = false;
                        this.txbSLQ.Enabled = false;
                        this.txbKDQ.Enabled = false;
                        this.txbPriceQ.Enabled = false;
                        this.dateTimeNhapQ.Enabled = false;

                        btnAddQ.Enabled = false;
                        btnChangeQ.Enabled = true;

                        this.btnSearchQuan.Enabled = true;
                        this.cbBSearchSizeQ.Enabled = true;
                        this.cbBSearchKieuDangQ.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại ");
                }
            }
            else MessageBox.Show("Nhập đủ thông tin cần thêm", "Thông báo", MessageBoxButtons.OKCancel);
        }

        private void btnShowQuan_Click(object sender, EventArgs e)
        {

        }

        private void tbxSearchNameQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowHat_Click(object sender, EventArgs e)
        {

        }

        private void txbSearchAo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddHat_Click(object sender, EventArgs e)
        {
            string IdHat = txbIDHat.Text.ToString();
            string DateAddHat = dateTimeNhapHat.Value.ToString();
            string NameHat = txbNameHat.Text.ToString();
            string SizeHat = txbSizeHat.Text.ToString();
            string PriceHat = txbPriceHat.Text.ToString();
            string slHat = txbSLHat.Text.ToString();
            string kdHat = txbKDHat.Text.ToString();
            if (IdHat.Length != 0 && NameHat.Length != 0 && SizeHat.Length != 0 && PriceHat.Length != 0 && slHat.Length != 0 && kdHat.Length != 0)
            {
                try
                {
                    string query = "SET IDENTITY_INSERT QuanlyQuanAo. dbo. Hat ON insert into dbo.Hat(Ngàynhậpnón,Mãsốnón,Tênnón,Sizenón,Sốlượngnón,Kiểudángnón,Giánón) values('" + DateAddHat + "','" + IdHat + "','" + NameHat + "','" + SizeHat + "','" + slHat + "','" + kdHat + "','" + PriceHat + "') ";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    if (MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        string query1 = "SELECT* FROM dbo.Hat";
                        dataViewHat.DataSource = DataProvider.Instance.ExecuteQuery(query1);

                        this.txbIDHat.Enabled = false;
                        this.txbKDHat.Enabled = false;
                        this.txbNameHat.Enabled = false;
                        this.txbPriceHat.Enabled = false;
                        this.dateTimeNhapHat.Enabled = false;
                        this.txbSLHat.Enabled = false;
                        this.txbSizeHat.Enabled = false;

                        this.btnAddHat.Enabled = false;
                        this.btnChangeHat.Enabled = true;

                        this.btnSearchHat.Enabled = true;
                        this.txbSearchHat.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            else MessageBox.Show("Nhập đủ thông tin cần thêm", "Thông báo", MessageBoxButtons.OKCancel);
        }

     
        private void tpAo_Click(object sender, EventArgs e)
        {
            
        }

        private void cbBSearchAo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOutAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAo_Click(object sender, EventArgs e)
        {
            if (txbAddIDAo.Text != null)
            {
                string DeleteSLAo = txbSLAddAo.Text.ToString();
                string DeleteIDAo = txbAddIDAo.Text.ToString();
                try
                {
                    string query = "  Update dbo.Ao Set SoLuongA=SoLuongA-'" + DeleteSLAo + "' where idAo = '" + DeleteIDAo + "'";
                    DataTable result = DataProvider.Instance.ExecuteQuery(query);
                    if (MessageBox.Show("Xóa thành công", "Thông báo ", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        string queryDelete = "SELECT* FROM dbo.Ao";
                        dataViewAo.DataSource = DataProvider.Instance.ExecuteQuery(queryDelete);

                        this.txbAddIDAo.Enabled = false;
                        this.txbSLAddAo.Enabled = false;

                        this.btnDeleteAo.Enabled = false;

                        this.btnSearchAo.Enabled = true;
                        this.cbBSearchSizeAo.Enabled = true;
                        this.cbBSearchKDAo.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại ", "Thông báo");
                }   
            }
            /*else
            {
                string DeleteNameA = txbNameAo.Text.ToString();
                string DeleteSizeA = txbSizeAo.Text.ToString();
                string DeleteSLAo = txbSLAddAo.Text.ToString();
                string DeleteKDAo = txbKieuDangAo.Text.ToString();
                try
                {
                    string query = " Update dbo.Ao Set SoLuongA=SoLuongA-'"+DeleteSLAo+"' where nameA ='"+DeleteNameA+"' and SizeA ='"+DeleteSizeA+"'and KieuDangA='"+DeleteKDAo+"' ";
                    DataTable result = DataProvider.Instance.ExecuteQuery(query);
                    if (MessageBox.Show("Xóa thành công", "Thông báo ", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        string queryDelete = "SELECT* FROM dbo.Ao";
                        dataViewAo.DataSource = DataProvider.Instance.ExecuteQuery(queryDelete);
                        
                        this.txbNameAo.Enabled = false;
                        this.txbSizeAo.Enabled = false;
                        this.txbSLAddAo.Enabled = false;
                        this.txbKieuDangAo.Enabled = false;

                        this.btnDeleteAo.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại ", "Thông báo");
                }
            }*/
            this.btnChangeAo.Enabled = true;

        }

        
        private void btnAddAo_Click(object sender, EventArgs e)
        {
            string AddIDAo=txbAddIDAo.Text.ToString();
            string DateUpdate = dateTimeAddAo.Value.ToString();
            string AddNameA = txbNameAo.Text.ToString();
            string AddSizeA = txbSizeAo.Text.ToString();
            string AddPriceA = txbPriceAo.Text.ToString();
            string AddSoLuongA = txbSLAddAo.Text.ToString();
            string AddKDAo = txbKieuDangAo.Text.ToString();
            try
            {
                string query = "SET IDENTITY_INSERT QuanlyQuanAo. dbo. Ao ON insert into Ao(idAo,NgayNhapAo,nameA,SizeA,SoluongA,KieuDangA,priceA) values('" + AddIDAo + "','" + DateUpdate + "','" + AddNameA + "','" + AddSizeA + "','" + AddSoLuongA + "','" + AddKDAo + "','" + AddPriceA + "')";
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
                if (MessageBox.Show("Thêm thành công", "Thông báo ", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                {
                    string query1 = "SELECT* FROM dbo.Ao";
                    dataViewAo.DataSource = DataProvider.Instance.ExecuteQuery(query1);
                    
                    this.txbAddIDAo.Enabled = false;
                    this.txbNameAo.Enabled = false;
                    this.txbSLAddAo.Enabled = false;
                    this.txbKieuDangAo.Enabled = false;
                    this.txbSizeAo.Enabled = false;
                    this.dateTimeAddAo.Enabled = false;
                    this.txbPriceAo.Enabled = false;

                    this.btnChangeAo.Enabled = false;

                    this.btnSearchAo.Enabled = true;
                    this.cbBSearchSizeAo.Enabled = true;
                    this.cbBSearchKDAo.Enabled = true;
                }  
            }
            catch(Exception )
            {
                MessageBox.Show("Thêm thất bại ");
                
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataViewAo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbBSearchSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataViewQuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchQuan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBSearchKieuDangQ.SelectedItem.ToString() == "QuanNam" && cbBSearchSizeQ.SelectedItem.ToString() == "S")
                {
                    string query = "select NgayNhapQuan,idQuan ,nameQ,SoLuongQ,priceQ from dbo.Quan where KieuDangQ=N'Nam'and SizeQ='S' ";
                    dataViewSearchQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
                if (cbBSearchKieuDangQ.SelectedItem.ToString() == "QuanNam" && cbBSearchSizeQ.SelectedItem.ToString() == "M")
                {
                    string query = "select NgayNhapQuan,idQuan ,nameQ,SoLuongQ,priceQ from dbo.Quan where KieuDangQ=N'Nam'and SizeQ='M' ";
                    dataViewSearchQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
                if (cbBSearchKieuDangQ.SelectedItem.ToString() == "QuanNam" && cbBSearchSizeQ.SelectedItem.ToString() == "L")
                {
                    string query = "select NgayNhapQuan,idQuan ,nameQ,SoLuongQ,priceQ from dbo.Quan where KieuDangQ=N'Nam'and SizeQ='L' ";
                    dataViewSearchQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
                if (cbBSearchKieuDangQ.SelectedItem.ToString() == "QuanNam" && cbBSearchSizeQ.SelectedItem.ToString() == "XL")
                {
                    string query = "select NgayNhapQuan,idQuan ,nameQ,SoLuongQ,priceQ from dbo.Quan where KieuDangQ=N'Nam'and SizeQ='XL' ";
                    dataViewSearchQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
                if (cbBSearchKieuDangQ.SelectedItem.ToString() == "QuanNam" && cbBSearchSizeQ.SelectedItem.ToString() == "XXL")
                {
                    string query = "select NgayNhapQuan,idQuan ,nameQ,SoLuongQ,priceQ from dbo.Quan where KieuDangQ=N'Nam'and SizeQ='XXL' ";
                    dataViewSearchQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
                if (cbBSearchKieuDangQ.SelectedItem.ToString() == "QuanNu" && cbBSearchSizeQ.SelectedItem.ToString() == "S")
                {
                    string query = "select NgayNhapQuan,idQuan ,nameQ,SoLuongQ,priceQ from dbo.Quan where KieuDangQ=N'Nữ'and SizeQ='S' ";
                    dataViewSearchQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
                if (cbBSearchKieuDangQ.SelectedItem.ToString() == "QuanNu" && cbBSearchSizeQ.SelectedItem.ToString() == "M")
                {
                    string query = "select NgayNhapQuan,idQuan ,nameQ,SoLuongQ,priceQ from dbo.Quan where KieuDangQ=N'Nữ'and SizeQ='M' ";
                    dataViewSearchQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
                if (cbBSearchKieuDangQ.SelectedItem.ToString() == "QuanNu" && cbBSearchSizeQ.SelectedItem.ToString() == "L")
                {
                    string query = "select NgayNhapQuan,idQuan ,nameQ,SoLuongQ,priceQ from dbo.Quan where KieuDangQ=N'Nữ'and SizeQ='L' ";
                    dataViewSearchQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
                if (cbBSearchKieuDangQ.SelectedItem.ToString() == "QuanNu" && cbBSearchSizeQ.SelectedItem.ToString() == "XL")
                {
                    string query = "select NgayNhapQuan,idQuan ,nameQ,SoLuongQ,priceQ from dbo.Quan where KieuDangQ=N'Nữ'and SizeQ='XL' ";
                    dataViewSearchQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
                if (cbBSearchKieuDangQ.SelectedItem.ToString() == "QuanNu" && cbBSearchSizeQ.SelectedItem.ToString() == "XXL")
                {
                    string query = "select NgayNhapQuan,idQuan ,nameQ,SoLuongQ,priceQ from dbo.Quan where KieuDangQ=N'Nữ'and SizeQ='XXL' ";
                    dataViewSearchQuan.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tìm thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dtViewSearchQuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbBSearchKDSale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchHangE_Click(object sender, EventArgs e)
        {
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Ao" && cbBSearchSizeSale.SelectedIndex.ToString() == "S" && cbBSearchKDSale.SelectedIndex.ToString()=="Nam")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'S' and LoaiHangSale=N'Ao'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Quan" && cbBSearchSizeSale.SelectedIndex.ToString() == "S" && cbBSearchKDSale.SelectedIndex.ToString() == "Nam")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'S' and LoaiHangSale=N'Quan'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Ao" && cbBSearchSizeSale.SelectedIndex.ToString() == "M" && cbBSearchKDSale.SelectedIndex.ToString() == "Nam")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'M' and LoaiHangSale=N'Ao'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Ao" && cbBSearchSizeSale.SelectedIndex.ToString() == "XL" && cbBSearchKDSale.SelectedIndex.ToString() == "Nam")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'XL' and LoaiHangSale=N'Ao'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Ao" && cbBSearchSizeSale.SelectedIndex.ToString() == "L" && cbBSearchKDSale.SelectedIndex.ToString() == "Nam")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'L' and LoaiHangSale=N'Ao'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Ao" && cbBSearchSizeSale.SelectedIndex.ToString() == "XXL" && cbBSearchKDSale.SelectedIndex.ToString() == "Nam")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'XXL' and LoaiHangSale=N'Ao'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Quan" && cbBSearchSizeSale.SelectedIndex.ToString() == "M" && cbBSearchKDSale.SelectedIndex.ToString() == "Nam")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'M' and LoaiHangSale=N'Quan'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Quan" && cbBSearchSizeSale.SelectedIndex.ToString() == "L" && cbBSearchKDSale.SelectedIndex.ToString() == "Nam")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'L' and LoaiHangSale=N'Quan'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Quan" && cbBSearchSizeSale.SelectedIndex.ToString() == "XL" && cbBSearchKDSale.SelectedIndex.ToString() == "Nam")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'XL' and LoaiHangSale=N'Quan'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Quan" && cbBSearchSizeSale.SelectedIndex.ToString() == "XXL" && cbBSearchKDSale.SelectedIndex.ToString() == "Nam")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'XXL' and LoaiHangSale=N'Quan'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Ao" && cbBSearchSizeSale.SelectedIndex.ToString() == "S" && cbBSearchKDSale.SelectedIndex.ToString() == "Nữ")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'S' and LoaiHangSale=N'Ao'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Quan" && cbBSearchSizeSale.SelectedIndex.ToString() == "S" && cbBSearchKDSale.SelectedIndex.ToString() == "Nữ")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'S' and LoaiHangSale=N'Quan'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Ao" && cbBSearchSizeSale.SelectedIndex.ToString() == "M" && cbBSearchKDSale.SelectedIndex.ToString() == "Nữ")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'M' and LoaiHangSale=N'Ao'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Ao" && cbBSearchSizeSale.SelectedIndex.ToString() == "XL" && cbBSearchKDSale.SelectedIndex.ToString() == "Nữ")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'XL' and LoaiHangSale=N'Ao'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Ao" && cbBSearchSizeSale.SelectedIndex.ToString() == "L" && cbBSearchKDSale.SelectedIndex.ToString() == "Nữ")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'L' and LoaiHangSale=N'Ao'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Ao" && cbBSearchSizeSale.SelectedIndex.ToString() == "XXL" && cbBSearchKDSale.SelectedIndex.ToString() == "Nữ")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'XXL' and LoaiHangSale=N'Ao'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Quan" && cbBSearchSizeSale.SelectedIndex.ToString() == "M" && cbBSearchKDSale.SelectedIndex.ToString() == "Nữ")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'M' and LoaiHangSale=N'Quan'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Quan" && cbBSearchSizeSale.SelectedIndex.ToString() == "L" && cbBSearchKDSale.SelectedIndex.ToString() == "Nữ")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'L' and LoaiHangSale=N'Quan'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Quan" && cbBSearchSizeSale.SelectedIndex.ToString() == "XL" && cbBSearchKDSale.SelectedIndex.ToString() == "Nữ")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'XL' and LoaiHangSale=N'Quan'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (cbBSearchLoaiSale.SelectedIndex.ToString() == "Quan" && cbBSearchSizeSale.SelectedIndex.ToString() == "XXL" && cbBSearchKDSale.SelectedIndex.ToString() == "Nữ")
            {
                string query = "select TenHangSale, priceSale, priceUnSale, NgayNhapHSale, SoLuongHSale from dbo.Sale where KieuDangHSale=N'Nam' and SizeHSale=N'XXL' and LoaiHangSale=N'Quan'";
                dataViewSearchSale.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }

        }

        private void dataViewSearchSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbBSearchKDSock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbHangTonKho_Click(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm áo ? ", "Thông báo ", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.txbAddIDAo.Enabled = true;
                this.txbNameAo.Enabled = true;
                this.txbSLAddAo.Enabled = true;
                this.txbKieuDangAo.Enabled = true;
                this.txbSizeAo.Enabled = true;
                this.dateTimeAddAo.Enabled = true;
                this.txbPriceAo.Enabled = true;

                this.btnAddAo.Enabled = true;
                this.btnChangeAo.Enabled = false;

                this.btnSearchAo.Enabled = false;
                this.cbBSearchSizeAo.Enabled = false;
                this.cbBSearchKDAo.Enabled = false;
            }
            else 
            {
                if (MessageBox.Show("Bạn muốn xóa áo theo ID ? ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    this.txbAddIDAo.Enabled = true;
                    this.txbSLAddAo.Enabled = true;
                    this.btnDeleteAo.Enabled = true;
                    this.btnChangeAo.Enabled = false;

                    this.btnSearchAo.Enabled = false;
                    this.cbBSearchSizeAo.Enabled = false;
                    this.cbBSearchKDAo.Enabled = false;
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbAddIDAo.Text = null;
            txbNameAo.Text = null;
            txbSLAddAo.Text = null;
            txbKieuDangAo.Text = null;
            txbSizeAo.Text = null;
            dateTimeAddAo.Text = null;
            txbPriceAo.Text = null;

            this.txbAddIDAo.Enabled = false;
            this.txbNameAo.Enabled = false;
            this.txbSLAddAo.Enabled = false;
            this.txbKieuDangAo.Enabled = false;
            this.txbSizeAo.Enabled = false;
            this.dateTimeAddAo.Enabled = false;
            this.txbPriceAo.Enabled = false;

            this.btnDeleteAo.Enabled = false;
            this.btnAddAo.Enabled = false;
            this.btnChangeAo.Enabled = true;

            this.btnSearchAo.Enabled = true;
            this.cbBSearchSizeAo.Enabled = true;
            this.cbBSearchKDAo.Enabled = true;
        }

     

    
        private void button1_Click_1(object sender, EventArgs e)
        {
            txbIDHat.Text = null;
            txbKDHat.Text = null;
            txbNameHat.Text = null;
            txbPriceHat.Text = null;
            dateTimeNhapHat.Text = null;
            txbSLHat.Text = null;
            txbSizeHat.Text = null;

            this.txbIDHat.Enabled = false;
            this.txbKDHat.Enabled = false;
            this.txbNameHat.Enabled = false;
            this.txbPriceHat.Enabled = false;
            this.dateTimeNhapHat.Enabled = false;
            this.txbSLHat.Enabled = false;
            this.txbSizeHat.Enabled = false;

            this.btnAddHat.Enabled = false;
            this.btnDeleteHat.Enabled = false;
            this.btnChangeHat.Enabled = true;

            this.btnSearchHat.Enabled = true;
            this.txbSearchHat.Enabled = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeHat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm nón ? ", "Thông báo ", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                btnAddHat.Enabled = true;
                btnChangeHat.Enabled = false;
                btnDeleteHat.Enabled = false;

                this.txbIDHat.Enabled = true;
                this.txbKDHat.Enabled = true;
                this.txbNameHat.Enabled = true;
                this.txbPriceHat.Enabled = true;
                this.dateTimeNhapHat.Enabled = true;
                this.txbSLHat.Enabled = true;
                this.txbSizeHat.Enabled = true;

                this.btnSearchHat.Enabled = false;
                this.txbSearchHat.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa áo theo ID ? ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    this.txbIDHat.Enabled = true;
                    this.txbSLHat.Enabled = true;

                    this.btnDeleteHat.Enabled = true;
                    this.btnChangeHat.Enabled = false;

                    this.btnSearchHat.Enabled = false;
                    this.txbSearchHat.Enabled = false;
                }
            }
        }

        private void btnCancelQ_Click(object sender, EventArgs e)
        {
            txbIDQ.Text = null;
            txbNameQ.Text = null;
            txbSizeQ.Text = null;
            txbSLQ.Text = null;
            txbKDQ.Text = null;
            txbPriceQ.Text = null;
            dateTimeNhapQ.Text = null;
            
            this.txbIDQ.Enabled = false;
            this.txbNameQ.Enabled = false;
            this.txbSizeQ.Enabled = false;
            this.txbSLQ.Enabled = false;
            this.txbKDQ.Enabled = false;
            this.txbPriceQ.Enabled = false;
            this.dateTimeNhapQ.Enabled = false;
            
            this.btnDeleteQ.Enabled = false;
            this.btnAddQ.Enabled = false;
            this.btnChangeQ.Enabled = true;

            this.btnSearchQuan.Enabled = true;
            this.cbBSearchSizeQ.Enabled = true;
            this.cbBSearchKieuDangQ.Enabled = true;
        }

        private void btnChangeQ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm quần ? ", "Thông báo ", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.txbIDQ.Enabled = true;
                this.txbNameQ.Enabled = true;
                this.txbSizeQ.Enabled = true;
                this.txbSLQ.Enabled = true;
                this.txbKDQ.Enabled = true;
                this.txbPriceQ.Enabled = true;
                this.dateTimeNhapQ.Enabled = true;

                btnAddQ.Enabled = true;
                btnChangeQ.Enabled = false;

                this.btnSearchQuan.Enabled = false;
                this.cbBSearchSizeQ.Enabled = false;
                this.cbBSearchKieuDangQ.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa quần theo ID ? ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    this.txbIDQ.Enabled = true;
                    this.txbSLQ.Enabled = true;

                    this.btnDeleteQ.Enabled = true;
                    this.btnChangeQ.Enabled = false;

                    this.btnSearchQuan.Enabled = false;
                    this.cbBSearchSizeQ.Enabled = false;
                    this.cbBSearchKieuDangQ.Enabled = false;
                }
                /*else
                {
                    this.txbSizeQ.Enabled = true;
                    this.txbNameQ.Enabled = true;
                    this.txbSLQ.Enabled = true;
                    this.txbKDQ.Enabled = true;

                    this.btnDeleteQ.Enabled = true;
                    this.btnChangeQ.Enabled = false;
                }*/

            }
        }

        private void btnDeleteQ_Click(object sender, EventArgs e)
        {
            if (txbIDQ.Text != null)
            {
                string DeleteSLQ = txbSLQ.Text.ToString();
                string DeleteIDQ = txbIDQ.Text.ToString();
                try
                {
                    string query = "  Update dbo.Quan Set SoLuongQ=SoLuongQ-'" + DeleteSLQ + "' where idQuan = '" + DeleteIDQ + "'";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    if (MessageBox.Show("Xóa thành công", "Thông báo ", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        string queryDelete = "SELECT* FROM dbo.Quan";
                        dataViewQuan.DataSource = DataProvider.Instance.ExecuteQuery(queryDelete);
                        
                        this.txbIDQ.Enabled = false;
                        this.txbSLQ.Enabled = false;

                        this.btnDeleteQ.Enabled = false;

                        this.btnSearchQuan.Enabled = true;
                        this.cbBSearchSizeQ.Enabled = true;
                        this.cbBSearchKieuDangQ.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại ", "Thông báo");
                }
            }
            /*else
            {
                string DeleteNameQ = txbNameQ.Text.ToString();
                string DeleteSizeQ = txbSizeQ.Text.ToString();
                string DeleteSLQ = txbSLQ.Text.ToString();
                string DeleteKDQ = txbKDQ.Text.ToString();
                try
                {
                    string query = " Update dbo.Quan Set SoLuongQ=SoLuongQ-'" + DeleteSLQ + "' where nameQ ='" + DeleteNameQ + "' and SizeQ ='" + DeleteSizeQ + "'and KieuDangQ='" + DeleteKDQ + "' ";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    if (MessageBox.Show("Xóa thành công", "Thông báo ", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        string queryDelete = "SELECT* FROM dbo.Quan";
                        dataViewAo.DataSource = DataProvider.Instance.ExecuteQuery(queryDelete);
                        
                        this.txbNameQ.Enabled = false;
                        this.txbSizeQ.Enabled = false;
                        this.txbSLQ.Enabled = false;
                        this.txbKDQ.Enabled = false;

                        this.btnDeleteQ.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại ", "Thông báo");
                }
            }*/
            this.btnChangeQ.Enabled = true;
        }

        private void btnDeleteHat_Click(object sender, EventArgs e)
        {
            if (txbAddIDAo.Text != null)
            {
                string DeleteSLHat = txbSLHat.Text.ToString();
                string DeleteIDHat = txbIDHat.Text.ToString();
                try
                {
                    string query = "  Update dbo.Hat Set Sốlượngnón=Sốlượngnón-'" + DeleteSLHat + "' where Mãsốnón = '" + DeleteIDHat + "'";
                    DataTable result = DataProvider.Instance.ExecuteQuery(query);
                    if (MessageBox.Show("Xóa thành công", "Thông báo ", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        string query2 = "SELECT* FROM dbo.Hat";
                        dataViewHat.DataSource = DataProvider.Instance.ExecuteQuery(query2);
                     

                        this.txbIDHat.Enabled = false;
                        this.txbSLHat.Enabled = false;

                        this.btnDeleteHat.Enabled = false;
                        this.btnChangeHat.Enabled = true;

                        this.btnSearchHat.Enabled = true;
                        this.txbSearchHat.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại ", "Thông báo");
                }
            }
        }

        private void btnCancelSock_Click(object sender, EventArgs e)
        {
            txbIDSock.Text = null;
            txbKDSock.Text = null;
            txbNameSock.Text = null;
            txbPriceSock.Text = null;
            dateTimeSock.Text = null;
            txbSLSock.Text = null;
            txbSizeSock.Text = null;

            this.txbIDSock.Enabled = false;
            this.txbKDSock.Enabled = false;
            this.txbNameSock.Enabled = false;
            this.txbPriceSock.Enabled = false;
            this.dateTimeSock.Enabled = false;
            this.txbSLSock.Enabled = false;
            this.txbSizeSock.Enabled = false;

            this.btnAddSock.Enabled = false;
            this.btnDeleteSock.Enabled = false;
            this.btnChangeSock.Enabled = true;

            this.btnSearchSock.Enabled = true;
            this.cbBSearchKDSock.Enabled = true;
            
        }

        private void btnChangeSock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm vớ ? ", "Thông báo ", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                btnAddSock.Enabled = true;
                btnChangeSock.Enabled = false;
                btnDeleteSock.Enabled = false;
                
                this.txbIDSock.Enabled = true;
                this.txbKDSock.Enabled = true;
                this.txbNameSock.Enabled = true;
                this.txbPriceSock.Enabled = true;
                this.dateTimeSock.Enabled = true;
                this.txbSLSock.Enabled = true;
                this.txbSizeSock.Enabled = true;

                this.btnSearchSock.Enabled = false;
                this.cbBSearchKDSock.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa vớ theo ID ? ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    this.txbIDSock.Enabled = true;
                    this.txbSLSock.Enabled = true;

                    this.btnDeleteSock.Enabled = true;
                    this.btnChangeSock.Enabled = false;

                    this.btnSearchSock.Enabled = false;
                    this.cbBSearchKDSock.Enabled = false;
                }
            }
        }

        private void btnAddSock_Click(object sender, EventArgs e)
        {
            string IdSock = txbIDSock.Text.ToString();
            string DateAddSock = dateTimeSock.Value.ToString();
            string NameSock = txbNameSock.Text.ToString();
            string SizeSock = txbSizeSock.Text.ToString();
            string PriceSock = txbPriceSock.Text.ToString();
            string slSock = txbSLSock.Text.ToString();
            string kdSock = txbKDSock.Text.ToString();
            if (IdSock.Length != 0 && NameSock.Length != 0 && SizeSock.Length != 0 && PriceSock.Length != 0 && slSock.Length != 0 && kdSock.Length != 0)
            {
                try
                {
                    string query = "SET IDENTITY_INSERT QuanlyQuanAo. dbo. Sock ON insert into dbo.Sock(NgayNhapSock,idSock,nameS,SizeS,SoLuongS,KieuDangS,priceS) values('" + DateAddSock + "','" + IdSock + "','" + NameSock + "','" + SizeSock + "','" + slSock + "','" + kdSock + "','" + PriceSock + "') ";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    if (MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        string query1 = "SELECT* FROM dbo.Sock";
                        dataViewSock.DataSource = DataProvider.Instance.ExecuteQuery(query1);

                        this.txbIDSock.Enabled = false;
                        this.txbKDSock.Enabled = false;
                        this.txbNameSock.Enabled = false;
                        this.txbPriceSock.Enabled = false;
                        this.dateTimeSock.Enabled = false;
                        this.txbSLSock.Enabled = false;
                        this.txbSizeSock.Enabled = false;

                        this.btnAddSock.Enabled = false;
                        this.btnChangeSock.Enabled = true;

                        this.btnSearchSock.Enabled = true;
                        this.cbBSearchKDSock.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
            else MessageBox.Show("Nhập đủ thông tin cần thêm", "Thông báo", MessageBoxButtons.OKCancel);
        }

        private void btnDeleteSock_Click(object sender, EventArgs e)
        {
            if (txbAddIDAo.Text != null)
            {
                string DeleteSLSock = txbSLSock.Text.ToString();
                string DeleteIDSock = txbIDSock.Text.ToString();
                try
                {
                    string query = "  Update dbo.Sock Set SoLuongS=SoLuongS-'" + DeleteSLSock + "' where idSock  = '" + DeleteIDSock + "'";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    if (MessageBox.Show("Xóa thành công", "Thông báo ", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        string queryDelete = "SELECT* FROM dbo.Sock";
                        dataViewSock.DataSource = DataProvider.Instance.ExecuteQuery(queryDelete);

                        this.txbIDSock.Enabled = false;
                        this.txbSLSock.Enabled = false;

                        this.btnDeleteSock.Enabled = false;
                        this.btnChangeSock.Enabled = true;

                        this.btnSearchSock.Enabled = true;
                        this.cbBSearchKDSock.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại ", "Thông báo");
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string query = "SELECT *From dbo.DSBill";
            dataViewDSBill.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void dataViewDSBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddHangE_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchHat_Click(object sender, EventArgs e)
        {

        }
    }
}
