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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayThang
            // 
            this.dtpNgayThang.Location = new System.Drawing.Point(689, 73);
            this.dtpNgayThang.Name = "dtpNgayThang";
            this.dtpNgayThang.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayThang.TabIndex = 10;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(51, 41);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(295, 32);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Tìm kiếm theo: ID hóa đơn, Tổng tiền thanh toán, \r\nSĐT khách hàng, Tên khách hàng" +
    ".";
            // 
            // txtTimKiemBill
            // 
            this.txtTimKiemBill.Location = new System.Drawing.Point(54, 76);
            this.txtTimKiemBill.Name = "txtTimKiemBill";
            this.txtTimKiemBill.Size = new System.Drawing.Size(260, 20);
            this.txtTimKiemBill.TabIndex = 8;
            // 
            // dgvListBill
            // 
            this.dgvListBill.AllowUserToAddRows = false;
            this.dgvListBill.AllowUserToDeleteRows = false;
            this.dgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBill.Location = new System.Drawing.Point(54, 103);
            this.dgvListBill.Name = "dgvListBill";
            this.dgvListBill.ReadOnly = true;
            this.dgvListBill.Size = new System.Drawing.Size(835, 318);
            this.dgvListBill.TabIndex = 7;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuatExcel.IconColor = System.Drawing.Color.Black;
            this.btnXuatExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatExcel.IconSize = 16;
            this.btnXuatExcel.Location = new System.Drawing.Point(689, 30);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(200, 37);
            this.btnXuatExcel.TabIndex = 12;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReload.IconColor = System.Drawing.Color.Black;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 16;
            this.btnReload.Location = new System.Drawing.Point(331, 73);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // fListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dtpNgayThang);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.txtTimKiemBill);
            this.Controls.Add(this.dgvListBill);
            this.Name = "fListBill";
            this.Text = "Đơn hàng";
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
    }
}