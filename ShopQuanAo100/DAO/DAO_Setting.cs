using System;
using System.Collections.Generic;
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
    }
}
