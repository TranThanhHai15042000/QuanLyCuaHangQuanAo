namespace ShopQuanAo100
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnBoQua = new FontAwesome.Sharp.IconButton();
            this.btnHienThi = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(802, 392);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(179, 1);
            this.panel7.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(802, 263);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 1);
            this.panel6.TabIndex = 27;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.ForeColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(800, 97);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(181, 1);
            this.panel8.TabIndex = 27;
            // 
            // cbbFind
            // 
            this.cbbFind.BackColor = System.Drawing.Color.White;
            this.cbbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbFind.ForeColor = System.Drawing.Color.Black;
            this.cbbFind.FormattingEnabled = true;
            this.cbbFind.Items.AddRange(new object[] {
            "Mã khách",
            "Tên khách",
            "Số điện thoại",
            "Ngày sinh",
            "Địa chỉ"});
            this.cbbFind.Location = new System.Drawing.Point(802, 331);
            this.cbbFind.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFind.Name = "cbbFind";
            this.cbbFind.Size = new System.Drawing.Size(177, 28);
            this.cbbFind.TabIndex = 6;
            // 
            // txtTimKH
            // 
            this.txtTimKH.BackColor = System.Drawing.Color.White;
            this.txtTimKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKH.ForeColor = System.Drawing.Color.Black;
            this.txtTimKH.Location = new System.Drawing.Point(802, 374);
            this.txtTimKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKH.Multiline = true;
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(179, 24);
            this.txtTimKH.TabIndex = 7;
            this.txtTimKH.TextChanged += new System.EventHandler(this.txtTimKH_TextChanged);
            // 
            // mtbSDTKhach
            // 
            this.mtbSDTKhach.BackColor = System.Drawing.Color.White;
            this.mtbSDTKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbSDTKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSDTKhach.ForeColor = System.Drawing.Color.Black;
            this.mtbSDTKhach.Location = new System.Drawing.Point(800, 157);
            this.mtbSDTKhach.Margin = new System.Windows.Forms.Padding(2);
            this.mtbSDTKhach.Mask = "(999) 000-0000";
            this.mtbSDTKhach.Name = "mtbSDTKhach";
            this.mtbSDTKhach.Size = new System.Drawing.Size(181, 15);
            this.mtbSDTKhach.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(667, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã khách";
            // 
            // lblNameKH
            // 
            this.lblNameKH.AutoSize = true;
            this.lblNameKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNameKH.ForeColor = System.Drawing.Color.Black;
            this.lblNameKH.Location = new System.Drawing.Point(667, 121);
            this.lblNameKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameKH.Name = "lblNameKH";
            this.lblNameKH.Size = new System.Drawing.Size(123, 20);
            this.lblNameKH.TabIndex = 9;
            this.lblNameKH.Text = "Tên khách hàng";
            // 
            // lblDateKH
            // 
            this.lblDateKH.AutoSize = true;
            this.lblDateKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateKH.ForeColor = System.Drawing.Color.Black;
            this.lblDateKH.Location = new System.Drawing.Point(667, 204);
            this.lblDateKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateKH.Name = "lblDateKH";
            this.lblDateKH.Size = new System.Drawing.Size(78, 20);
            this.lblDateKH.TabIndex = 13;
            this.lblDateKH.Text = "Ngày sinh";
            // 
            // btnChuanTen
            // 
            this.btnChuanTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnChuanTen.FlatAppearance.BorderSize = 0;
            this.btnChuanTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuanTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChuanTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.btnChuanTen.Location = new System.Drawing.Point(993, 117);
            this.btnChuanTen.Margin = new System.Windows.Forms.Padding(4);
            this.btnChuanTen.Name = "btnChuanTen";
            this.btnChuanTen.Size = new System.Drawing.Size(36, 28);
            this.btnChuanTen.TabIndex = 12;
            this.btnChuanTen.Text = "Chuẩn";
            this.btnChuanTen.UseVisualStyleBackColor = false;
            this.btnChuanTen.Click += new System.EventHandler(this.btnChuanTen_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSDT.ForeColor = System.Drawing.Color.Black;
            this.lblSDT.Location = new System.Drawing.Point(667, 162);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(102, 20);
            this.lblSDT.TabIndex = 14;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblDiaChiKH
            // 
            this.lblDiaChiKH.AutoSize = true;
            this.lblDiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDiaChiKH.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChiKH.Location = new System.Drawing.Point(667, 245);
            this.lblDiaChiKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChiKH.Name = "lblDiaChiKH";
            this.lblDiaChiKH.Size = new System.Drawing.Size(61, 20);
            this.lblDiaChiKH.TabIndex = 16;
            this.lblDiaChiKH.Text = "Địa chỉ ";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.BackColor = System.Drawing.Color.White;
            this.txtDiaChiKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChiKH.Location = new System.Drawing.Point(800, 245);
            this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChiKH.Multiline = true;
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(179, 24);
            this.txtDiaChiKH.TabIndex = 5;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.BackColor = System.Drawing.Color.White;
            this.txtMaKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhach.ForeColor = System.Drawing.Color.Black;
            this.txtMaKhach.Location = new System.Drawing.Point(800, 79);
            this.txtMaKhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhach.Multiline = true;
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(181, 24);
            this.txtMaKhach.TabIndex = 0;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.BackColor = System.Drawing.Color.White;
            this.txtTenKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhach.Location = new System.Drawing.Point(799, 122);
            this.txtTenKhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhach.Multiline = true;
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(181, 24);
            this.txtTenKhach.TabIndex = 1;
            this.txtTenKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKhach_KeyPress);
            // 
            // dateTimeSNKH
            // 
            this.dateTimeSNKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeSNKH.Location = new System.Drawing.Point(799, 204);
            this.dateTimeSNKH.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeSNKH.Name = "dateTimeSNKH";
            this.dateTimeSNKH.Size = new System.Drawing.Size(198, 22);
            this.dateTimeSNKH.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnHienThi);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 62);
            this.panel1.TabIndex = 39;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(780, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 62);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnBoQua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBoQua.FlatAppearance.BorderSize = 0;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBoQua.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnBoQua.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBoQua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(650, 0);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(130, 62);
            this.btnBoQua.TabIndex = 13;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click_1);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnHienThi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHienThi.FlatAppearance.BorderSize = 0;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHienThi.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnHienThi.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHienThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(520, 0);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(130, 62);
            this.btnHienThi.TabIndex = 12;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLuu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(390, 0);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 62);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSua.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(260, 0);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 62);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(130, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 62);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnThem.IconColor = System.Drawing.Color.Gainsboro;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 62);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(27, 35);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.Size = new System.Drawing.Size(634, 501);
            this.dgvKhachHang.TabIndex = 15;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(685, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông Tin Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(613, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 1);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(800, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 1);
            this.panel3.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(667, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tìm Kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(667, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tìm kiếm theo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(667, 376);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Từ Khóa ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(24, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Danh Sách Khách Hàng";
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.dateTimeSNKH);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.cbbFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDiaChiKH);
            this.Controls.Add(this.txtTimKH);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.mtbSDTKhach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChuanTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDateKH);
            this.Controls.Add(this.lblNameKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fKhachHang";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbFind;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.MaskedTextBox mtbSDTKhach;
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
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnHienThi;
        private FontAwesome.Sharp.IconButton btnBoQua;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}