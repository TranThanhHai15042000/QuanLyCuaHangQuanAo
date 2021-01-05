namespace ShopQuanAo100
{
    partial class fListBill
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
            this.dtpNgayThang = new System.Windows.Forms.DateTimePicker();
            this.labelSearch = new System.Windows.Forms.Label();
            this.txtTimKiemBill = new System.Windows.Forms.TextBox();
            this.dgvListBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFind = new System.Windows.Forms.Label();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnXuatExcel = new FontAwesome.Sharp.IconButton();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayThang
            // 
            this.dtpNgayThang.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtpNgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThang.Location = new System.Drawing.Point(632, 18);
            this.dtpNgayThang.Name = "dtpNgayThang";
            this.dtpNgayThang.Size = new System.Drawing.Size(239, 24);
            this.dtpNgayThang.TabIndex = 10;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.White;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.Black;
            this.labelSearch.Location = new System.Drawing.Point(51, 78);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(73, 18);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Tìm kiếm ";
            // 
            // txtTimKiemBill
            // 
            this.txtTimKiemBill.BackColor = System.Drawing.Color.White;
            this.txtTimKiemBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiemBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemBill.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemBill.Location = new System.Drawing.Point(165, 80);
            this.txtTimKiemBill.Multiline = true;
            this.txtTimKiemBill.Name = "txtTimKiemBill";
            this.txtTimKiemBill.Size = new System.Drawing.Size(259, 24);
            this.txtTimKiemBill.TabIndex = 8;
            this.txtTimKiemBill.TextChanged += new System.EventHandler(this.txtTimKiemBill_TextChanged);
            // 
            // dgvListBill
            // 
            this.dgvListBill.AllowUserToAddRows = false;
            this.dgvListBill.AllowUserToDeleteRows = false;
            this.dgvListBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.dgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBill.Location = new System.Drawing.Point(51, 127);
            this.dgvListBill.Name = "dgvListBill";
            this.dgvListBill.ReadOnly = true;
            this.dgvListBill.RowHeadersWidth = 51;
            this.dgvListBill.Size = new System.Drawing.Size(819, 394);
            this.dgvListBill.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(165, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 1);
            this.panel1.TabIndex = 13;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.BackColor = System.Drawing.Color.White;
            this.labelFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFind.ForeColor = System.Drawing.Color.Black;
            this.labelFind.Location = new System.Drawing.Point(51, 48);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(102, 18);
            this.labelFind.TabIndex = 14;
            this.labelFind.Text = "Tìm kiếm theo";
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMail.BackgroundImage = global::ShopQuanAo100.Properties.Resources.send1;
            this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMail.Location = new System.Drawing.Point(563, 62);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(39, 36);
            this.btnMail.TabIndex = 15;
            this.btnMail.UseVisualStyleBackColor = false;
            this.btnMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnXuatExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuatExcel.IconColor = System.Drawing.Color.Black;
            this.btnXuatExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatExcel.IconSize = 16;
            this.btnXuatExcel.Location = new System.Drawing.Point(632, 49);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(238, 49);
            this.btnXuatExcel.TabIndex = 12;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseMnemonic = false;
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReload.IconColor = System.Drawing.Color.Black;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 16;
            this.btnReload.Location = new System.Drawing.Point(460, 68);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 29);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // fListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 583);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dtpNgayThang);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.txtTimKiemBill);
            this.Controls.Add(this.dgvListBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fListBill";
            this.Text = "Đơn hàng";
            this.Load += new System.EventHandler(this.fListBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnXuatExcel;
        private FontAwesome.Sharp.IconButton btnReload;
        private System.Windows.Forms.DateTimePicker dtpNgayThang;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox txtTimKiemBill;
        private System.Windows.Forms.DataGridView dgvListBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Button btnMail;
    }
}