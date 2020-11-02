namespace QuanLyQuanAo
{
    partial class fChangePassMaster
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
            this.lblUseName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUseName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txBNewPassTop = new System.Windows.Forms.TextBox();
            this.txbNewPassBot = new System.Windows.Forms.TextBox();
            this.btnNewPass = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUseName
            // 
            this.lblUseName.AutoSize = true;
            this.lblUseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseName.Location = new System.Drawing.Point(51, 31);
            this.lblUseName.Name = "lblUseName";
            this.lblUseName.Size = new System.Drawing.Size(182, 29);
            this.lblUseName.TabIndex = 4;
            this.lblUseName.Text = "Tên đăng nhập";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(51, 122);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(117, 29);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtUseName
            // 
            this.txtUseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseName.Location = new System.Drawing.Point(355, 31);
            this.txtUseName.Name = "txtUseName";
            this.txtUseName.Size = new System.Drawing.Size(268, 36);
            this.txtUseName.TabIndex = 12;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(355, 122);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(268, 36);
            this.txtPass.TabIndex = 13;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txBNewPassTop
            // 
            this.txBNewPassTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBNewPassTop.Location = new System.Drawing.Point(355, 218);
            this.txBNewPassTop.Name = "txBNewPassTop";
            this.txBNewPassTop.Size = new System.Drawing.Size(268, 36);
            this.txBNewPassTop.TabIndex = 14;
            this.txBNewPassTop.UseSystemPasswordChar = true;
            // 
            // txbNewPassBot
            // 
            this.txbNewPassBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPassBot.Location = new System.Drawing.Point(355, 322);
            this.txbNewPassBot.Name = "txbNewPassBot";
            this.txbNewPassBot.Size = new System.Drawing.Size(268, 36);
            this.txbNewPassBot.TabIndex = 15;
            this.txbNewPassBot.UseSystemPasswordChar = true;
            // 
            // btnNewPass
            // 
            this.btnNewPass.Location = new System.Drawing.Point(525, 428);
            this.btnNewPass.Name = "btnNewPass";
            this.btnNewPass.Size = new System.Drawing.Size(115, 74);
            this.btnNewPass.TabIndex = 16;
            this.btnNewPass.Text = "Đổi mật khẩu";
            this.btnNewPass.UseVisualStyleBackColor = true;
            this.btnNewPass.Click += new System.EventHandler(this.btnNewPass_Click);
            // 
            // btnOut
            // 
            this.btnOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOut.Location = new System.Drawing.Point(714, 428);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(115, 74);
            this.btnOut.TabIndex = 17;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // fChangePassMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 556);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnNewPass);
            this.Controls.Add(this.txbNewPassBot);
            this.Controls.Add(this.txBNewPassTop);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUseName);
            this.Name = "fChangePassMaster";
            this.Text = "fChangePassMaster";
            this.Load += new System.EventHandler(this.fChangePassMaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUseName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUseName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txBNewPassTop;
        private System.Windows.Forms.TextBox txbNewPassBot;
        private System.Windows.Forms.Button btnNewPass;
        private System.Windows.Forms.Button btnOut;
    }
}