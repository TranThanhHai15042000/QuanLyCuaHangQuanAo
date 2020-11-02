namespace QuanLyQuanAo
{
    partial class fXacNhanAdmin
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
            this.btnOut = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblXacNhanPass = new System.Windows.Forms.Label();
            this.txbXacNhanPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNameQuanLy = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(531, 199);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(126, 59);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(126, 199);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 59);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblXacNhanPass
            // 
            this.lblXacNhanPass.AutoSize = true;
            this.lblXacNhanPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacNhanPass.Location = new System.Drawing.Point(107, 109);
            this.lblXacNhanPass.Name = "lblXacNhanPass";
            this.lblXacNhanPass.Size = new System.Drawing.Size(124, 29);
            this.lblXacNhanPass.TabIndex = 2;
            this.lblXacNhanPass.Text = "Mật khẩu ";
            // 
            // txbXacNhanPass
            // 
            this.txbXacNhanPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbXacNhanPass.Location = new System.Drawing.Point(352, 109);
            this.txbXacNhanPass.Name = "txbXacNhanPass";
            this.txbXacNhanPass.Size = new System.Drawing.Size(244, 36);
            this.txbXacNhanPass.TabIndex = 2;
            this.txbXacNhanPass.UseSystemPasswordChar = true;
            this.txbXacNhanPass.TextChanged += new System.EventHandler(this.txbXacNhanPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên quản lý";
            // 
            // txbNameQuanLy
            // 
            this.txbNameQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameQuanLy.Location = new System.Drawing.Point(352, 46);
            this.txbNameQuanLy.Name = "txbNameQuanLy";
            this.txbNameQuanLy.Size = new System.Drawing.Size(244, 36);
            this.txbNameQuanLy.TabIndex = 1;
            this.txbNameQuanLy.TextChanged += new System.EventHandler(this.txbNameQuanLy_TextChanged);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(328, 199);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(126, 59);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "Đổi mật khẩu ";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.button1_Click);
            // 
            // fXacNhanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 326);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txbNameQuanLy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbXacNhanPass);
            this.Controls.Add(this.lblXacNhanPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnOut);
            this.Name = "fXacNhanAdmin";
            this.Text = "fXacNhanAdmin";
            this.Load += new System.EventHandler(this.fXacNhanAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblXacNhanPass;
        private System.Windows.Forms.TextBox txbXacNhanPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNameQuanLy;
        private System.Windows.Forms.Button btnChangePass;
    }
}