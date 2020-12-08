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
            this.btnXuatExcel = new FontAwesome.Sharp.IconButton();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayThang
            // 
            this.dtpNgayThang.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtpNgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThang.Location = new System.Drawing.Point(945, 156);
            this.dtpNgayThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayThang.Name = "dtpNgayThang";
            this.dtpNgayThang.Size = new System.Drawing.Size(317, 30);
            this.dtpNgayThang.TabIndex = 10;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSearch.Location = new System.Drawing.Point(67, 82);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(96, 25);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Tìm kiếm ";
            // 
            // txtTimKiemBill
            // 
            this.txtTimKiemBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtTimKiemBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiemBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemBill.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiemBill.Location = new System.Drawing.Point(187, 83);
            this.txtTimKiemBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiemBill.Multiline = true;
            this.txtTimKiemBill.Name = "txtTimKiemBill";
            this.txtTimKiemBill.Size = new System.Drawing.Size(345, 30);
            this.txtTimKiemBill.TabIndex = 8;
            // 
            // dgvListBill
            // 
            this.dgvListBill.AllowUserToAddRows = false;
            this.dgvListBill.AllowUserToDeleteRows = false;
            this.dgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBill.Location = new System.Drawing.Point(72, 156);
            this.dgvListBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListBill.Name = "dgvListBill";
            this.dgvListBill.ReadOnly = true;
            this.dgvListBill.RowHeadersWidth = 51;
            this.dgvListBill.Size = new System.Drawing.Size(828, 451);
            this.dgvListBill.TabIndex = 7;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXuatExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuatExcel.IconColor = System.Drawing.Color.Black;
            this.btnXuatExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatExcel.IconSize = 16;
            this.btnXuatExcel.Location = new System.Drawing.Point(945, 195);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(317, 60);
            this.btnXuatExcel.TabIndex = 12;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReload.IconColor = System.Drawing.Color.Black;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 16;
            this.btnReload.Location = new System.Drawing.Point(556, 76);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 36);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(180, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 1);
            this.panel1.TabIndex = 13;
            // 
            // fListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1300, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dtpNgayThang);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.txtTimKiemBill);
            this.Controls.Add(this.dgvListBill);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}