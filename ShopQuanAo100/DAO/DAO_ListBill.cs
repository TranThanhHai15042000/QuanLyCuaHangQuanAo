using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo100.DAO
{

    public class DAO_ListBill
    {
    
        public static void Find(DataGridView dgv, string txtFind)
        {


            try
            {
               
                using (SqlDataAdapter da = new SqlDataAdapter("select * from tblHoadon where ( IDhoadon like '" +txtFind + "%' or idKhachHang like N'" + txtFind + "%' or idNhanVien like '" + txtFind + "%' or NgayBan like '" + txtFind + "%' or TongTien like '" + txtFind + "%'       )", DataProvider.getConnection()))
                {
                    DataTable dtsearch = new DataTable("HoaDon");
                    da.Fill(dtsearch);
                    dgv.DataSource = dtsearch;

                }
         

            }
            catch (Exception ex)
            {
              
                MessageBox.Show(ex.Message);
            }

        }


    }
}