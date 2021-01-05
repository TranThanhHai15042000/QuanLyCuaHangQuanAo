using ShopQuanAo100.DAO;
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

namespace ShopQuanAo100
{
    public partial class ChartMoney : Form
    {
        public ChartMoney()
        {
            InitializeComponent();
        }

        string CurrentMonth = DateTime.Now.ToString("MM");
        private void ChartMoney_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].XValueType = ChartValueType.DateTime;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM";

            //connect.Open();
            ////SqlDataAdapter adapt = new SqlDataAdapter("SELECT CAST(HDtime AS DATE) AS Ngay,COUNT(value) as slsp, HDthanhtoan as tien FROM HoaDon CROSS APPLY STRING_SPLIT(HDmasp, ',') where MONTH(HDtime) = '"+ CurrentMonth + "' group by HDtime, HDthanhtoan ORDER BY HDtime", connect);
            //SqlDataAdapter adapt = new SqlDataAdapter("select CAST(HDtime AS DATE) as Ngay, sum(HDthanhtoan) AS tien from HoaDon where MONTH(HDtime) = '" + CurrentMonth + "' group by CAST(HDtime AS DATE) ORDER by CAST(HDtime AS DATE)", connect);

            //adapt.Fill(ds);
            //chart1.DataSource = ds;
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT  CAST(NgayBan AS DATE) as Ngay,  SUM(TongTien) as Tien  FROM dbo.tblHoaDon WHERE MONTH(NgayBan) = " + CurrentMonth + "  group by CAST(NgayBan AS DATE)", DataProvider.getConnection());
            adapt.Fill(ds);
            chart1.DataSource = ds;


            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Series1"].XValueMember = "Ngay";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Series1"].YValueMembers = "Tien";
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            //ChartSlspDayByDay.Titles.Add("Salary Chart");
        }
    }
}
