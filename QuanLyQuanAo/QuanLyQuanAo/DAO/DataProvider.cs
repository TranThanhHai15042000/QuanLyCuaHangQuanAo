﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;


namespace QuanLyQuanAo.DAO
{
    public class DataProvider
    {
        public static string Con()
        {
            return @"Data Source=DESKTOP-O7T6R5H\SQLEXPRESS2019;Initial Catalog=Quan_Ly_QuanAoo;Integrated Security=True";
        }
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7T6R5H\SQLEXPRESS2019;Initial Catalog=Quan_Ly_QuanAoo;Integrated Security=True");
            return con;
        }


        private static DataProvider instance;
        public string connectionStr = @"Data Source=DESKTOP-O7T6R5H\SQLEXPRESS2019;Initial Catalog=Quan_Ly_QuanAoo;Integrated Security=True";

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

        public  DataTable ExecuteQuery(string query)
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
            object data = 0 ;
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
