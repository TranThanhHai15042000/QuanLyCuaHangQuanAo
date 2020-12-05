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
    public class DAO_CTHang
    {
        //public static SqlConnection con = null;
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, DataProvider.getConnection());
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }

        //public static string GetFieldValues(string sql)
        //{
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D8S4ML5\SQLEXPRESS;Initial Catalog=QLQA_Main;Integrated Security=True");

        //string ma = "";
        //SqlCommand cmd = new SqlCommand(sql, DataProvider.getConnection());
        //SqlDataReader reader;
        //reader = cmd.ExecuteReader();
        //while (reader.Read())
        //    ma = reader.GetValue(0).ToString();
        //reader.Close();
        //return ma;


        //using (var conn = new SqlConnection(con) 
        //using (var cmd = conn.CreateCommand()) 
        //{
        //    conn.Open();
        //    cmd.CommandText = "SELECT * FROM learer WHERE id = @id";
        //    cmd.Parameters.AddWithValue("@id", index);
        //    using (var reader = cmd.ExecuteReader())
        //    {
        //        if (reader.Read())
        //        {
        //             = reader.GetString(reader.GetOrdinal("Ten"))
        //        }
        //    }
        //}
        //}
        public static string SimpleRead(string sql)
        {
            string ma = "";
            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;

            // create a connection object
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D8S4ML5\SQLEXPRESS;Initial Catalog=QLQA_Main;Integrated Security=True");

            // create a command object
            SqlCommand cmd = new SqlCommand(
                sql, conn);

            try
            {
                // open the connection
                conn.Open();

                // 1.  get an instance of the SqlDataReader
                rdr = cmd.ExecuteReader();

                // print a set of column headers


                // 2.  print necessary columns of each record
                while (rdr.Read())
                {
                    // get the results of each column
                    ma = rdr.GetValue(0).ToString();
                    // ma = (string)rdr["ten"];
                    // print out the results

                }
            }
            finally
            {
                // 3. close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return ma;
        }

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

        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = DataProvider.getConnection(); //Kết nối cơ sở dữ liệu
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }


    }
   
}