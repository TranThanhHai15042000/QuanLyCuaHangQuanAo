﻿namespace QuanLyQuanAo
{
    partial class fLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.lblKQ = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUseName = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(161, 354);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(0, 19);
            this.lblKQ.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtUseName
            // 
            // 
            // 
            // 
            this.txtUseName.CustomButton.Image = null;
            this.txtUseName.CustomButton.Location = new System.Drawing.Point(267, 2);
            this.txtUseName.CustomButton.Name = "";
            this.txtUseName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUseName.CustomButton.TabIndex = 1;
            this.txtUseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUseName.CustomButton.UseSelectable = true;
            this.txtUseName.CustomButton.Visible = false;
            this.txtUseName.DisplayIcon = true;
            this.txtUseName.Icon = ((System.Drawing.Image)(resources.GetObject("txtUseName.Icon")));
            this.txtUseName.Lines = new string[0];
            this.txtUseName.Location = new System.Drawing.Point(215, 71);
            this.txtUseName.MaxLength = 32767;
            this.txtUseName.Name = "txtUseName";
            this.txtUseName.PasswordChar = '\0';
            this.txtUseName.PromptText = "Enter your user name";
            this.txtUseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUseName.SelectedText = "";
            this.txtUseName.SelectionLength = 0;
            this.txtUseName.SelectionStart = 0;
            this.txtUseName.ShortcutsEnabled = true;
            this.txtUseName.Size = new System.Drawing.Size(295, 30);
            this.txtUseName.TabIndex = 0;
            this.txtUseName.UseSelectable = true;
            this.txtUseName.WaterMark = "Enter your user name";
            this.txtUseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
           // this.txtUseName.Click += new System.EventHandler(this.txtUseName_Click);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(267, 2);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.DisplayIcon = true;
            this.txtPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtPass.Icon")));
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(215, 123);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PromptText = "Enter your password";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(295, 30);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMark = "Enter your password";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            //this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(215, 174);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(110, 17);
            this.metroCheckBox1.TabIndex = 2;
            this.metroCheckBox1.Text = "Remember me";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(419, 223);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 282);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUseName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKQ);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fLogin";
            this.Text = " Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
           // this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtUseName;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

