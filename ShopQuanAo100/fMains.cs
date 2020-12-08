using ShopQuanAo100.DAO;
using FontAwesome.Sharp;
using ShopQuanAo100.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShopQuanAo100
{
    public partial class fMains : Form
    {

        public static string tennv = "";


        SqlConnection connect = DataProvider.getConnection();
        // SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-A0E9NLI\MSSQLSERVER2019;Initial Catalog=doan-3;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataSet ds;
        SqlDataAdapter da;



        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private DTO_Account loginAccount;

        public DTO_Account LoginAccount
        {
            get
            {
                return loginAccount;
            }
            set
            {
                loginAccount = value;
            }
        }


        private IconButton currentbtn;
        private Panel lefborderbtn;
        private Form currentchildform;

    

        public fMains(DTO_Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            timer1.Start();//dong ho
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public fMains()
        {
            InitializeComponent();
            //leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(7, 90);
            //panelMenu.Controls.Add(leftBorderBtn);
            ////Form
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(140, 212, 122);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button


                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;


                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();


                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;



            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelcon.Text = childForm.Text;


        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelcon.Text = "Home";
        }
        //Drag Form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {  
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new fListBill());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new fBill());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new fCTHangNKHo());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new fCTHangTonKho());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new fThongKeDoanhThu());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

            //  ActivateButton(sender, RGBColors.color3);


            if (PanelDropDownSP.Height == 200)
            {
                PanelDropDownSP.Height = 50;
            }
            else
            {
                PanelDropDownSP.Height = 200;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelDropDownSP.Height = 50;
            try
            {
                connect.Open();
                cmd.CommandText = "select Users,tennv from tblNhanVien where Users='" + fLogin.userName + "'";
                cmd.Connection = connect;
                rdr = cmd.ExecuteReader();
                bool temp = false;
                while (rdr.Read())
                {
                    LabelUser.Text = rdr.GetString(1);
                    tennv = rdr.GetString(1);
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("not found");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // hien thi logo
            //try
            //{
            //    SqlCommand command;
            //    string sqllogo = "select logo from ThongTinShop where ID=1 ";
            //    if (connect.State != ConnectionState.Open)
            //        connect.Open();
            //    command = new SqlCommand(sqllogo, connect);
            //    SqlDataReader reader = command.ExecuteReader();

            //    reader.Read();
            //    if (reader.HasRows)
            //    {
            //        byte[] img = (byte[])(reader[0]);
            //        if (img == null)
            //        {
            //            picLogo.Image = null;
            //        }
            //        else
            //        {
            //            MemoryStream ms = new MemoryStream(img);
            //            picLogo.Image = Image.FromStream(ms);

            //        }
            //        connect.Close();
            //    }
            //    else
            //    {
            //        connect.Close();
            //        MessageBox.Show("bi loi");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    connect.Close();
            //    MessageBox.Show("loi logo: " + ex.Message);
            //}
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            /*OpenChildForm(new ());*/
        }

        private void panelTitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
           
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
         
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbDateTime.Text = datetime.ToString("dd/MM/yyyy HH:mm:ss");
            this.labelGioBig.Text = datetime.ToString("HH:mm:ss");
            this.lbNgayThangBig.Text = datetime.ToString("dd/MM/yyyy");
            this.lbDateBig.Text = datetime.ToString("dddd");
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        

      

     

        private void iconButtonSP_Click_2(object sender, EventArgs e)
        {
            if (PanelDropDownSP.Height == 170)
            {
                PanelDropDownSP.Height = 50;
            }
            else
            {
                PanelDropDownSP.Height = 210;
            }
        }

        private void iconButtonSPLoai_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new fChatLieu());
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new fSize());
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new fSetting());
        }

        private void PanelDropDownSP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
