﻿namespace QuanLyQuanAo
{
    partial class fKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbFind = new System.Windows.Forms.ComboBox();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.mtbSDTKhach = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameKH = new System.Windows.Forms.Label();
            this.lblDateKH = new System.Windows.Forms.Label();
            this.btnChuanTen = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChiKH = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.dateTimeSNKH = new System.Windows.Forms.DateTimePicker();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHienThi);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 72);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(675, 24);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 30);
            this.btnHienThi.TabIndex = 12;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(769, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(557, 23);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(88, 30);
            this.btnBoQua.TabIndex = 10;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(433, 24);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 30);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(157, 23);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 28);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(24, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 28);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(292, 23);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbFind);
            this.panel2.Controls.Add(this.txtTimKH);
            this.panel2.Controls.Add(this.mtbSDTKhach);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblNameKH);
            this.panel2.Controls.Add(this.lblDateKH);
            this.panel2.Controls.Add(this.btnChuanTen);
            this.panel2.Controls.Add(this.lblSDT);
            this.panel2.Controls.Add(this.lblDiaChiKH);
            this.panel2.Controls.Add(this.txtDiaChiKH);
            this.panel2.Controls.Add(this.txtMaKhach);
            this.panel2.Controls.Add(this.txtTenKhach);
            this.panel2.Controls.Add(this.dateTimeSNKH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 135);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbbFind
            // 
            this.cbbFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFind.FormattingEnabled = true;
            this.cbbFind.Items.AddRange(new object[] {
            "MaKhach",
            "TenKhach",
            "SDT",
            "NgaySinh",
            "DiaChi"});
            this.cbbFind.Location = new System.Drawing.Point(433, 100);
            this.cbbFind.Name = "cbbFind";
            this.cbbFind.Size = new System.Drawing.Size(100, 24);
            this.cbbFind.TabIndex = 25;
            // 
            // txtTimKH
            // 
            this.txtTimKH.Location = new System.Drawing.Point(557, 102);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(242, 22);
            this.txtTimKH.TabIndex = 22;
            this.txtTimKH.TextChanged += new System.EventHandler(this.txtTimKH_TextChanged);
            // 
            // mtbSDTKhach
            // 
            this.mtbSDTKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSDTKhach.Location = new System.Drawing.Point(160, 94);
            this.mtbSDTKhach.Mask = "(999) 000-0000";
            this.mtbSDTKhach.Name = "mtbSDTKhach";
            this.mtbSDTKhach.Size = new System.Drawing.Size(151, 22);
            this.mtbSDTKhach.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã khách";
            // 
            // lblNameKH
            // 
            this.lblNameKH.AutoSize = true;
            this.lblNameKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameKH.Location = new System.Drawing.Point(18, 57);
            this.lblNameKH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNameKH.Name = "lblNameKH";
            this.lblNameKH.Size = new System.Drawing.Size(104, 19);
            this.lblNameKH.TabIndex = 9;
            this.lblNameKH.Text = "Tên khách hàng";
            // 
            // lblDateKH
            // 
            this.lblDateKH.AutoSize = true;
            this.lblDateKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateKH.Location = new System.Drawing.Point(429, 10);
            this.lblDateKH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDateKH.Name = "lblDateKH";
            this.lblDateKH.Size = new System.Drawing.Size(69, 19);
            this.lblDateKH.TabIndex = 13;
            this.lblDateKH.Text = "Ngày sinh";
            // 
            // btnChuanTen
            // 
            this.btnChuanTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuanTen.Location = new System.Drawing.Point(326, 48);
            this.btnChuanTen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnChuanTen.Name = "btnChuanTen";
            this.btnChuanTen.Size = new System.Drawing.Size(70, 31);
            this.btnChuanTen.TabIndex = 12;
            this.btnChuanTen.Text = "Chuẩn";
            this.btnChuanTen.UseVisualStyleBackColor = true;
            this.btnChuanTen.Click += new System.EventHandler(this.btnChuanTen_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(20, 98);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 19);
            this.lblSDT.TabIndex = 14;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblDiaChiKH
            // 
            this.lblDiaChiKH.AutoSize = true;
            this.lblDiaChiKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiKH.Location = new System.Drawing.Point(429, 51);
            this.lblDiaChiKH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiaChiKH.Name = "lblDiaChiKH";
            this.lblDiaChiKH.Size = new System.Drawing.Size(55, 19);
            this.lblDiaChiKH.TabIndex = 16;
            this.lblDiaChiKH.Text = "Địa chỉ ";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(512, 49);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(287, 22);
            this.txtDiaChiKH.TabIndex = 18;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhach.Location = new System.Drawing.Point(160, 19);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(151, 22);
            this.txtMaKhach.TabIndex = 10;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.Location = new System.Drawing.Point(160, 55);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(151, 22);
            this.txtTenKhach.TabIndex = 11;
            this.txtTenKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKhach_KeyPress);
            // 
            // dateTimeSNKH
            // 
            this.dateTimeSNKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeSNKH.Location = new System.Drawing.Point(512, 8);
            this.dateTimeSNKH.Name = "dateTimeSNKH";
            this.dateTimeSNKH.Size = new System.Drawing.Size(287, 20);
            this.dateTimeSNKH.TabIndex = 15;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(20, 195);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.Size = new System.Drawing.Size(863, 201);
            this.dgvKhachHang.TabIndex = 2;
            this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 488);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fKhachHang";
            this.Text = "Danh Mục Khách Hàng";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameKH;
        private System.Windows.Forms.Label lblDateKH;
        private System.Windows.Forms.Button btnChuanTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChiKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.DateTimePicker dateTimeSNKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.MaskedTextBox mtbSDTKhach;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.ComboBox cbbFind;
    }
}