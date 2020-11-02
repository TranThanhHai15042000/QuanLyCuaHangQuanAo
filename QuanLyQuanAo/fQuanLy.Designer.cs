namespace QuanLyQuanAo
{
    partial class fQuanLy
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
            this.btnDSNV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(684, 246);
            this.btnOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(99, 43);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnDSNV
            // 
            this.btnDSNV.Location = new System.Drawing.Point(52, 67);
            this.btnDSNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDSNV.Name = "btnDSNV";
            this.btnDSNV.Size = new System.Drawing.Size(178, 43);
            this.btnDSNV.TabIndex = 1;
            this.btnDSNV.Text = "Danh sách nhân viên";
            this.btnDSNV.UseVisualStyleBackColor = true;
            this.btnDSNV.Click += new System.EventHandler(this.btnDSNV_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thống kê doanh thu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDSNV);
            this.Controls.Add(this.btnOut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fQuanLy";
            this.Text = "Master";
            this.Load += new System.EventHandler(this.fQuanLy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnDSNV;
        private System.Windows.Forms.Button button1;
    }
}