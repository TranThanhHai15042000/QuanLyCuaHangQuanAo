using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;     // Sử dụng đối tượng MessageBox

namespace Quan_Ly_Ban_Hang.Class
{
    class DMNhanVien
    {
        public static SqlConnection Con;  //Khai báo đối tượng kết nối        

        //  phương thức kết nối
        public static void Connect()
        {
            Con = new SqlConnection();   //Khởi tạo đối tượng
            Con.ConnectionString = @"Data Source=DESKTOP-D8S4ML5;Initial Catalog=QUANLYCUAHANGQUANAO;Integrated Security=True";

            //Kiểm tra kết nối
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();               //Mở kết nối
            }
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        // phương thức đóng kết nối
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }

        public static DataTable GetDataTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = DMChatLieu.Con; //Kết nối cơ sở dữ liệu
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }

    }
}
