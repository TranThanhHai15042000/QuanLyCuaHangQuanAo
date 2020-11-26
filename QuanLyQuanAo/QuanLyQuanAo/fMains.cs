using QuanLyQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLyQuanAo
{

    public partial class fMains : Form
    {
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
  
        public fMains(DTO_Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        // fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeform;

        //constructor
        public fMains()
        {
            InitializeComponent();
            random = new Random();
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
        }

        //methods
        //private Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColors.ColorList.Count);
        //    while(tempIndex == index)
        //    {
        //      index = random.Next(ThemeColors.ColorList.Count);

        //    }
        //    tempIndex = index;
        //    string color = ThemeColors.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}
        //private void ActivateButton(object btnSender)
        //{
        //    if(btnSender != null)
        //    {
        //        if(currentButton != (Button)btnSender)
        //        {
        //            DisableButton();
        //            Color color = SelectThemeColor();
        //            currentButton = (Button)btnSender;
        //            currentButton.BackColor = color;
        //            currentButton.ForeColor = Color.White;
        //            currentButton.Font = new System.Drawing.Font("Century Gothic", 17.5F, System.Drawing.FontStyle.Bold);
        //            PanelTitleBar.BackColor = color;
        //            panelLogo.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
        //            ThemeColors.PrimaryColor = color;
        //            ThemeColors.SecondaryColor = ThemeColors.ChangeColorBrightness(color, -0.3);
        //        }
        //    }
        //}
        //private void OpenChildForm(Form childForm, object btnSender)
        //{
        //    if(activeform!=null)
        //    {
        //        activeform.Close();
        //    }
        //    ActivateButton(btnSender);
        //    activeform = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    this.panelDeskTopPanel.Controls.Add(childForm);
        //    this.panelDeskTopPanel.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //    lblTittle.Text = childForm.Text;

        //}
        //private void DisableButton()
        //{
        //    foreach (Control previousBtn in panelMenu.Controls)
        //    {
        //        if(previousBtn.GetType()==typeof(Button))
        //        {
        //            previousBtn.BackColor = Color.FromArgb(51, 51, 76);
        //            previousBtn.ForeColor = Color.Gainsboro;
        //            previousBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
        //        }
        //    }
        //}

        //private void btnProduct_Click(object sender, EventArgs e)
        //{

        //    ActivateButton(sender);
        //}

        //private void btnOrders_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void btnCustom_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void btnRepor_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void btnNotifica_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void btnSetting_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        private void fMains_Load(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            fCTHang f = new fCTHang();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnRepor_Click(object sender, EventArgs e)
        {
            
        }

       

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void lblTittle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button4.Height;
            Sidepanel.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
            Sidepanel.Height = btnCustom.Height;
            Sidepanel.Top = btnCustom.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            this.Hide();
            f.ShowDialog();
            this.Show();
            Sidepanel.Height = btnOrders.Height;
            Sidepanel.Top = btnOrders.Top;
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            fCTHang f = new fCTHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
            Sidepanel.Height = btnProduct.Height;
            Sidepanel.Top = btnProduct.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
            Sidepanel.Height = btnSoQuy.Height;
            Sidepanel.Top = btnSoQuy.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnBaoCao.Height;
            Sidepanel.Top = btnBaoCao.Top;
        }

        int lx, ly;
        int sw, sh;

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
        }
    }
}
