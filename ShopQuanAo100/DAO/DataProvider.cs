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
    public class DataProvider
    {

        
        public static string Con()
        {
            return @"Data Source=DESKTOP-D8S4ML5\SQLEXPRESS;Initial Catalog=QLQA_Main;Integrated Security=True";
        }
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D8S4ML5\SQLEXPRESS;Initial Catalog=QLQA_Main;Integrated Security=True");
            return con;
        }


        public static SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-D8S4ML5;Initial Catalog=doan-3;Integrated Security=True");
       


        private static DataProvider instance;
        public string connectionStr = @"Data Source=DESKTOP-D8S4ML5\SQLEXPRESS;Initial Catalog=QLQA_Main;Integrated Security=True";

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        private DataProvider() { }

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand Command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(Command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand Command = new SqlCommand(query, connection);

                data = Command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand Command = new SqlCommand(query, connection);

                data = Command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
