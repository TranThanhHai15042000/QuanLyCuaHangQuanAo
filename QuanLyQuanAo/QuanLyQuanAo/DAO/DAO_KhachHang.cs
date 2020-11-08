using QuanLyQuanAo.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.DAO
{
    public class DAO_KhachHang
    {
        private static DAO_KhachHang instance;
        public static DAO_KhachHang Instance
        {
            get
            {
                if (instance == null) instance = new DAO_KhachHang();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private DAO_KhachHang() { }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, DataProvider.getConnection());
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            return false;
        }
        public static void RunSqlDel(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DataProvider.getConnection();
            cmd.CommandText = query;
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        
    }
}
