using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo100.DAO
{
    public class DAO_Setting
    {


      //  string imglogoloc = "";
        public static void GetAnh(PictureBox ptr, string imglogoloc)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imglogoloc = dlg.FileName.ToString();
                    ptr.ImageLocation = imglogoloc;
                }
            }
            catch (Exception ex)
            {
                DataProvider.getConnection().Close();
                MessageBox.Show("Error during insert: " + ex.Message);
            }

        }

        public static void SaveAnh(string imglogoloc)

        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imglogoloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                using (var cmd = new SqlCommand("update ThongTinShop set logo=@logo where ID=1"))
                {
                    cmd.Connection = DataProvider.getConnection();
                    cmd.Parameters.AddWithValue("@logo", img);
                    DataProvider.getConnection().Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã lưu");
                    }
                    else
                    {
                        MessageBox.Show("Lưu không thành công!");
                    }
                    DataProvider.getConnection().Close();
                }
            }
            catch (Exception ex)
            {
                DataProvider.getConnection().Close();
                MessageBox.Show(ex.Message);
            }
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

        //public static void GetDataCuaHang(string Ten,string Sdt, string DiaChi,string LoiChao)
        //{

        //   

        //    SqlCommand command = new SqlCommand(sqlquery, DataProvider.getConnection());
        //    SqlDataReader sdr = command.ExecuteReader();
        //    while (sdr.Read())
        //    {

        //        Ten = sdr["TenShop"].ToString();
        //        Sdt = sdr["SDT"].ToString();
        //        DiaChi = sdr["Diachi"].ToString();
        //        LoiChao = sdr["Loichao"].ToString();
        //    }
        //}

        public static void GetDataCuaHang(string sql)
        {
           
           // string sqlquery = "SELECT * FROM dbo.tblThongTinShop WHERE id = 1";
            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader sdr = null;

            // create a connection object
            SqlConnection conn = new SqlConnection(DataProvider.Con());

            // create a command object
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // open the connection
                conn.Open();

                // 1.  get an instance of the SqlDataReader
                sdr = cmd.ExecuteReader();

                // print a set of column headers


                // 2.  print necessary columns of each record
                while (sdr.Read())
                {
                    //Ten = sdr["TenShop"].ToString();
                    //Sdt = sdr["SDT"].ToString();
                    //DiaChi = sdr["Diachi"].ToString();
                    //LoiChao = sdr["Loichao"].ToString();

                }
            }
            finally
            {
                // 3. close the reader
                if (sdr != null)
                {
                    sdr.Close();
                }

                // close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
           
        }


    }
}
