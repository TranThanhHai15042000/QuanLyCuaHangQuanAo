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
    }
    
}
