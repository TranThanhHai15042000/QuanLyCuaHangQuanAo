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
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;
using COMExcel = Microsoft.Office.Interop.Excel;
namespace ShopQuanAo100
{
    public partial class fListBill : Form
    {
        DataTable tblListBill;
        public fListBill()
        {
            InitializeComponent();
        }

        private void fListBill_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
       
        void LoadDataGridView()
        {
            string sql = "SELECT idHoaDon,TenNV,tenkhach,ngayban,tongtien FROM dbo.tblHoaDon hd JOIN dbo.tblKhachHang kh ON kh.iDKhachHang = hd.iDKhachHang JOIN dbo.tblNhanVien nv ON nv.iDNhanVien = hd.iDNhanVien where hd.TongTien >0";
            tblListBill =  DataProvider.Instance.ExecuteQuery(sql); 
            dgvListBill.DataSource = tblListBill;
         
            dgvListBill.Columns[0].HeaderText = "ID hóa đơn";
            dgvListBill.Columns[1].HeaderText = "Tên nhân viên";
            dgvListBill.Columns[2].HeaderText = "Tên khách hàng";
            dgvListBill.Columns[3].HeaderText = "Ngày bán";
            dgvListBill.Columns[4].HeaderText = "Tổng tiền";
           
            dgvListBill.Columns[0].Width = 150;
            dgvListBill.Columns[1].Width = 100;
            dgvListBill.Columns[2].Width = 120;
            dgvListBill.Columns[3].Width = 170;
            dgvListBill.Columns[4].Width = 200;


            dgvListBill.AllowUserToAddRows = false;
            dgvListBill.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
          private void txtTimKiemBill_TextChanged(object sender, EventArgs e)
        {
            DAO_ListBill.Find(dgvListBill, txtTimKiemBill.Text);
            if (dgvListBill.Rows.Count > 0 && dgvListBill.Rows != null)
            {
                labelFind.Text = "Đã tìm thấy";
            }
            else
            {
                labelFind.Text = "Không tìm thấy...";
            }

            if (string.IsNullOrWhiteSpace(txtTimKiemBill.Text))
            {
                labelFind.Text = "Tìm kiếm theo: ID hóa đơn, Tổng tiền thanh toán, " +
                    "SĐT khách hàng, Tên khách hàng.";
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable  tblThongtinHD = null;
            dgvListBill.DataSource = tblThongtinHD;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "THE MR.SIMPLE SYTLE.";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "27 - LÝ TỰ TRONG - QUẬN 1 - TPHCM";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (+84)987644753";
            exRange.Range["D2:G2"].Font.Size = 16;
            exRange.Range["D2:G2"].Font.Bold = true;
            exRange.Range["D2:G2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["D2:G2"].MergeCells = true;
            exRange.Range["D2:G2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D2:G2"].Value = "DANH SÁCH HÓA ĐƠN BÁN";
             sql = "SELECT idHoaDon,TenNV,tenkhach,ngayban,tongtien FROM dbo.tblHoaDon hd JOIN dbo.tblKhachHang kh ON kh.iDKhachHang = hd.iDKhachHang JOIN dbo.tblNhanVien nv ON nv.iDNhanVien = hd.iDNhanVien where hd.TongTien >0";

            tblThongtinHD = DAO_Bill.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";

          
            exRange.Range["B11:B11"].Value = "Mã hóa đơn";
            exRange.Range["B11:B11"].ColumnWidth = 20;
            exRange.Range["C11:C11"].Value = "Tên nhân viên";
            exRange.Range["C11:C11"].ColumnWidth = 20;
            exRange.Range["D11:D11"].Value = "Tên khách";
            exRange.Range["D11:D11"].ColumnWidth = 20;
            exRange.Range["E11:E11"].Value = "Ngày bán";
            exRange.Range["E11:E11"].ColumnWidth = 20;
            exRange.Range["F11:F11"].Value = "Tổng tiền";
            exRange.Range["F11:F11"].ColumnWidth = 20;
            //   exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHD.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHD.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHD.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHD.Rows[hang][cot].ToString() + "%";
                }
            }

            //for (int i = 1; i < dgvListBill.Columns.Count + 1; i++)
            //{
            //    exSheet.Cells[1, i] = dgvListBill.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < dgvListBill.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dgvListBill.Columns.Count; j++)
            //    {
            //        exSheet.Cells[i + 2, j + 1] = dgvListBill.Rows[i].Cells[j].Value.ToString();

            //        exSheet.Cells[cot + 2][hang + 12] = dgvListBill.Rows[hang][cot].ToString();
            //             if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = dgvListBill.Rows[hang][cot].ToString() + "%";
            //    }
            //}
            exApp.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fMail f = new fMail();
           // this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
