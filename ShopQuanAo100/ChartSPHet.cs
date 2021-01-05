using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ShopQuanAo100.DAO;

namespace ShopQuanAo100
{
    public partial class ChartSPHet : Form
    {
        public ChartSPHet()
        {
            InitializeComponent();
        }

        private void ChartSPHet_Load(object sender, EventArgs e)
        {

            chart1.Series["Series1"].XValueType = ChartValueType.DateTime;
            DataSet ds = new DataSet();
            DataProvider.getConnection().Open();
            //SqlDataAdapter adapt = new SqlDataAdapter("SELECT CAST(HDtime AS DATE) AS Ngay,COUNT(value) as slsp, HDthanhtoan as tien FROM HoaDon CROSS APPLY STRING_SPLIT(HDmasp, ',') where MONTH(HDtime) = '"+ CurrentMonth + "' group by HDtime, HDthanhtoan ORDER BY HDtime", connect);

            SqlDataAdapter adapt = new SqlDataAdapter("select ten as Ten ,Soluong as SoLuong from dbo.tblCT_Hang where  Soluong <= 30 ", DataProvider.getConnection());

            adapt.Fill(ds);
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Series1"].XValueMember = "Ten";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Series1"].YValueMembers = "SoLuong";
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            //ChartSlspDayByDay.Titles.Add("Salary Chart");
            DataProvider.getConnection().Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
