using QuanLyQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.DAO
{
    class DAO_CTHang
    {
        public DataTable getData()
        {
            SqlConnection con = DataProvider.getConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from [dbo].[tblCT_Hang]", con); // hộ trợ chuyển đổi dữ liệu lấy từ database về cho datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void LoadHang(DataGridView dgv)
        {
            SqlConnection con = DataProvider.getConnection();
            try
            {
                //select idCTHang  as 'Mã CT_hàng ', Ten as 'Tên', Size as 'Size', KieuDang as 'Kiểu dáng' ,ChatLieu as 'Chất liệu',Anh as 'Ảnh',GhiChu as 'Ghi chú' from [dbo].[tblCT_Hang]
                if (con.State == ConnectionState.Closed) con.Open();
                string sql = " SELECT * FROM dbo.tblCT_Hang";//
                SqlCommand command = new SqlCommand(sql, con);  // thục thi câu lệnh query
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                adapter.Fill(data, "tblCT_Hang");//
                dgv.DataSource = data.Tables["tbl_CTHang"];//
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void cellClick(object sender, DataGridViewCellEventArgs e, DataGridView dgv, DTO_CTHang hag)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = dgv.Rows[e.RowIndex]; // lấy từng dòngg
                hag.IdCTHang = Convert.ToString(row.Cells[0].Value);
                hag.Ten = Convert.ToString(row.Cells[1].Value);
                hag.Size = Convert.ToString(row.Cells[2].Value);
                hag.KieuDang = Convert.ToString(row.Cells[3].Value);
                hag.ChatLieu = Convert.ToString(row.Cells[4].Value);
                hag.Anh = Convert.ToString(row.Cells[5].Value);
                hag.GhiChu = Convert.ToString(row.Cells[6].Value);

            }


        }
        public void ThemHang(DTO_CTHang hag)
        {

            SqlConnection con = DataProvider.getConnection();
            try
            {

                if (con.State == ConnectionState.Closed) con.Open();
                string sql = "insert into tbl.CT_Hang(IdCTHang,Ten,Size,KieuDang,ChatLieu,Anh,GhiChu) Values(@IdCTHang, @Ten,@Size,@KieuDang,@ChatLieu,@Anh,@GhiChu)";
                SqlCommand command = new SqlCommand(sql, con);

                command.Parameters.AddWithValue("IdCTHang", hag.IdCTHang);
                command.Parameters.AddWithValue("Ten", hag.Ten);
                command.Parameters.AddWithValue("Size", hag.Size);
                command.Parameters.AddWithValue("KieuDang", hag.KieuDang);
                command.Parameters.AddWithValue("ChatLieu", hag.ChatLieu);
                command.Parameters.AddWithValue("Anh", hag.Anh);
                command.Parameters.AddWithValue("Ghichu", hag.GhiChu);

                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hàng nhập không hợp lệ, vui lòng nhập lại");
                //MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void deleteHang(int intID)
        {
            SqlConnection con = DataProvider.getConnection();
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                string sql = "delete from tblCT_Hang where idCTHang = @idCTHang ";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("idCTHang", intID);
                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void updateHang(DTO_CTHang hag)
        {

            SqlConnection con = DataProvider.getConnection();
            try
            {

                if (con.State == ConnectionState.Closed) con.Open();
                string sql = "update dbo.tblCT_Hang set Ten = @Ten, Size = @Size, KieuDang= @KieuDang, ChatLieu= @ChatLieu, Anh= @Anh,GhiChu=@GhiChu where MaHocSinh = @MaHocSinh";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@Ten", hag.Ten);
                command.Parameters.AddWithValue("@Size", hag.Size);
                command.Parameters.AddWithValue("@KieuDang", hag.KieuDang);
                command.Parameters.AddWithValue("@ChatLieu", hag.ChatLieu);
                command.Parameters.AddWithValue("@Email", hag.Anh);
                command.Parameters.AddWithValue("@MaHocSinh", hag.GhiChu);

                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cập nhật hàng không thành công");
                //MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
