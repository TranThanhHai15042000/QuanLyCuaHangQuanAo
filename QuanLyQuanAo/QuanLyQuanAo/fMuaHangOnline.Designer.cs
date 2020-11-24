namespace QuanLyQuanAo
{
    partial class fMuaHangOnline
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
            this.btnInBill = new System.Windows.Forms.Button();
            this.cbBLoai = new System.Windows.Forms.ComboBox();
            this.txbSumMoney = new System.Windows.Forms.TextBox();
            this.dataViewListBuy = new System.Windows.Forms.DataGridView();
            this.btnNewBill = new System.Windows.Forms.Button();
            this.txbMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKHBuyOnline = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNameKH = new System.Windows.Forms.TextBox();
            this.txbSĐTKH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCreateKey = new System.Windows.Forms.TextBox();
            this.btnCreateKey = new System.Windows.Forms.Button();
            this.txbDateinBill = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNameH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbSlH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPriceH = new System.Windows.Forms.TextBox();
            this.btnAddToBill = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txbSTT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbSafe = new System.Windows.Forms.TextBox();
            this.txbNVSell = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbMaH = new System.Windows.Forms.TextBox();
            this.dataViewKho = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSumBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSumMoney = new System.Windows.Forms.Button();
            this.dataViewSum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewListBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(1119, 732);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(135, 74);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnInBill
            // 
            this.btnInBill.Location = new System.Drawing.Point(957, 732);
            this.btnInBill.Name = "btnInBill";
            this.btnInBill.Size = new System.Drawing.Size(135, 74);
            this.btnInBill.TabIndex = 1;
            this.btnInBill.Text = "Thanh toán";
            this.btnInBill.UseVisualStyleBackColor = true;
            this.btnInBill.Click += new System.EventHandler(this.btnInBill_Click);
            // 
            // cbBLoai
            // 
            this.cbBLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBLoai.FormattingEnabled = true;
            this.cbBLoai.Items.AddRange(new object[] {
            "Nón",
            "Áo",
            "Quần",
            "Vớ"});
            this.cbBLoai.Location = new System.Drawing.Point(336, 262);
            this.cbBLoai.Name = "cbBLoai";
            this.cbBLoai.Size = new System.Drawing.Size(202, 33);
            this.cbBLoai.TabIndex = 4;
            // 
            // txbSumMoney
            // 
            this.txbSumMoney.Enabled = false;
            this.txbSumMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSumMoney.Location = new System.Drawing.Point(1084, 392);
            this.txbSumMoney.Name = "txbSumMoney";
            this.txbSumMoney.Size = new System.Drawing.Size(202, 36);
            this.txbSumMoney.TabIndex = 8;
            this.txbSumMoney.TextChanged += new System.EventHandler(this.txbSumMoney_TextChanged);
            // 
            // dataViewListBuy
            // 
            this.dataViewListBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewListBuy.Location = new System.Drawing.Point(731, 482);
            this.dataViewListBuy.Name = "dataViewListBuy";
            this.dataViewListBuy.RowHeadersWidth = 51;
            this.dataViewListBuy.RowTemplate.Height = 24;
            this.dataViewListBuy.Size = new System.Drawing.Size(564, 234);
            this.dataViewListBuy.TabIndex = 9;
            this.dataViewListBuy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewListBuy_CellContentClick);
            // 
            // btnNewBill
            // 
            this.btnNewBill.Location = new System.Drawing.Point(790, 732);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(135, 74);
            this.btnNewBill.TabIndex = 13;
            this.btnNewBill.Text = "Tạo hóa đơn mới";
            this.btnNewBill.UseVisualStyleBackColor = true;
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // txbMaKH
            // 
            this.txbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaKH.Location = new System.Drawing.Point(336, 87);
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.Size = new System.Drawing.Size(202, 36);
            this.txbMaKH.TabIndex = 14;
            // 
            // lblMaKHBuyOnline
            // 
            this.lblMaKHBuyOnline.AutoSize = true;
            this.lblMaKHBuyOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKHBuyOnline.Location = new System.Drawing.Point(62, 87);
            this.lblMaKHBuyOnline.Name = "lblMaKHBuyOnline";
            this.lblMaKHBuyOnline.Size = new System.Drawing.Size(249, 29);
            this.lblMaKHBuyOnline.TabIndex = 15;
            this.lblMaKHBuyOnline.Text = "Mã khách hàng(STT)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "SĐT";
            // 
            // txbNameKH
            // 
            this.txbNameKH.Enabled = false;
            this.txbNameKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameKH.Location = new System.Drawing.Point(336, 144);
            this.txbNameKH.Name = "txbNameKH";
            this.txbNameKH.Size = new System.Drawing.Size(202, 36);
            this.txbNameKH.TabIndex = 21;
            // 
            // txbSĐTKH
            // 
            this.txbSĐTKH.Enabled = false;
            this.txbSĐTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSĐTKH.Location = new System.Drawing.Point(336, 201);
            this.txbSĐTKH.Name = "txbSĐTKH";
            this.txbSĐTKH.Size = new System.Drawing.Size(202, 36);
            this.txbSĐTKH.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 74);
            this.button1.TabIndex = 23;
            this.button1.Text = "Đăng ký mã nếu mua lần đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(968, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ngày in ";
            // 
            // txbCreateKey
            // 
            this.txbCreateKey.Enabled = false;
            this.txbCreateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCreateKey.Location = new System.Drawing.Point(1084, 329);
            this.txbCreateKey.Name = "txbCreateKey";
            this.txbCreateKey.Size = new System.Drawing.Size(202, 36);
            this.txbCreateKey.TabIndex = 26;
            this.txbCreateKey.TextChanged += new System.EventHandler(this.txbCreateKey_TextChanged);
            // 
            // btnCreateKey
            // 
            this.btnCreateKey.Location = new System.Drawing.Point(973, 309);
            this.btnCreateKey.Name = "btnCreateKey";
            this.btnCreateKey.Size = new System.Drawing.Size(94, 56);
            this.btnCreateKey.TabIndex = 27;
            this.btnCreateKey.Text = "Tạo mã hóa đơn";
            this.btnCreateKey.UseVisualStyleBackColor = true;
            this.btnCreateKey.Click += new System.EventHandler(this.btnCreateKey_Click);
            // 
            // txbDateinBill
            // 
            this.txbDateinBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDateinBill.Location = new System.Drawing.Point(1084, 87);
            this.txbDateinBill.Name = "txbDateinBill";
            this.txbDateinBill.Size = new System.Drawing.Size(202, 36);
            this.txbDateinBill.TabIndex = 28;
            this.txbDateinBill.TextChanged += new System.EventHandler(this.txbDateinBill_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tên hàng";
            // 
            // txbNameH
            // 
            this.txbNameH.Enabled = false;
            this.txbNameH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameH.Location = new System.Drawing.Point(741, 262);
            this.txbNameH.Name = "txbNameH";
            this.txbNameH.Size = new System.Drawing.Size(202, 36);
            this.txbNameH.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 31;
            this.label8.Text = "Số lượng";
            // 
            // txbSlH
            // 
            this.txbSlH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSlH.Location = new System.Drawing.Point(336, 382);
            this.txbSlH.Name = "txbSlH";
            this.txbSlH.Size = new System.Drawing.Size(202, 36);
            this.txbSlH.TabIndex = 32;
            this.txbSlH.TextChanged += new System.EventHandler(this.txbSlH_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 29);
            this.label9.TabIndex = 33;
            this.label9.Text = "Giá";
            // 
            // txbPriceH
            // 
            this.txbPriceH.Enabled = false;
            this.txbPriceH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPriceH.Location = new System.Drawing.Point(741, 321);
            this.txbPriceH.Name = "txbPriceH";
            this.txbPriceH.Size = new System.Drawing.Size(202, 36);
            this.txbPriceH.TabIndex = 34;
            // 
            // btnAddToBill
            // 
            this.btnAddToBill.Enabled = false;
            this.btnAddToBill.Location = new System.Drawing.Point(626, 482);
            this.btnAddToBill.Name = "btnAddToBill";
            this.btnAddToBill.Size = new System.Drawing.Size(99, 74);
            this.btnAddToBill.TabIndex = 35;
            this.btnAddToBill.Text = "Thêm hàng vào Bill";
            this.btnAddToBill.UseVisualStyleBackColor = true;
            this.btnAddToBill.Click += new System.EventHandler(this.btnAddToBill_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(968, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 29);
            this.label10.TabIndex = 36;
            this.label10.Text = "STT";
            // 
            // txbSTT
            // 
            this.txbSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSTT.Location = new System.Drawing.Point(1084, 259);
            this.txbSTT.Name = "txbSTT";
            this.txbSTT.Size = new System.Drawing.Size(202, 36);
            this.txbSTT.TabIndex = 37;
            this.txbSTT.TextChanged += new System.EventHandler(this.txbSTT_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(578, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 29);
            this.label11.TabIndex = 39;
            this.label11.Text = "Giảm giá(%)";
            // 
            // txbSafe
            // 
            this.txbSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSafe.Location = new System.Drawing.Point(741, 389);
            this.txbSafe.Name = "txbSafe";
            this.txbSafe.Size = new System.Drawing.Size(202, 36);
            this.txbSafe.TabIndex = 40;
            this.txbSafe.TextChanged += new System.EventHandler(this.txbSafe_TextChanged);
            // 
            // txbNVSell
            // 
            this.txbNVSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNVSell.Location = new System.Drawing.Point(1084, 144);
            this.txbNVSell.Name = "txbNVSell";
            this.txbNVSell.Size = new System.Drawing.Size(202, 36);
            this.txbNVSell.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(968, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 29);
            this.label12.TabIndex = 42;
            this.label12.Text = "MaNV";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(210, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 29);
            this.label13.TabIndex = 43;
            this.label13.Text = "Mã ";
            // 
            // txbMaH
            // 
            this.txbMaH.Enabled = false;
            this.txbMaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaH.Location = new System.Drawing.Point(336, 321);
            this.txbMaH.Name = "txbMaH";
            this.txbMaH.Size = new System.Drawing.Size(202, 36);
            this.txbMaH.TabIndex = 44;
            // 
            // dataViewKho
            // 
            this.dataViewKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewKho.Location = new System.Drawing.Point(67, 482);
            this.dataViewKho.Name = "dataViewKho";
            this.dataViewKho.RowHeadersWidth = 51;
            this.dataViewKho.RowTemplate.Height = 24;
            this.dataViewKho.Size = new System.Drawing.Size(553, 234);
            this.dataViewKho.TabIndex = 45;
            this.dataViewKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewKho_CellClick);
            this.dataViewKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewKho_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(74, 390);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 74);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1000, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "=";
            // 
            // txbSumBill
            // 
            this.txbSumBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSumBill.Location = new System.Drawing.Point(482, 747);
            this.txbSumBill.Name = "txbSumBill";
            this.txbSumBill.Size = new System.Drawing.Size(215, 36);
            this.txbSumBill.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(704, 748);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Bằng chữ";
            // 
            // btnSumMoney
            // 
            this.btnSumMoney.Location = new System.Drawing.Point(67, 722);
            this.btnSumMoney.Name = "btnSumMoney";
            this.btnSumMoney.Size = new System.Drawing.Size(99, 74);
            this.btnSumMoney.TabIndex = 50;
            this.btnSumMoney.Text = "Tính tổng tiền";
            this.btnSumMoney.UseVisualStyleBackColor = true;
            this.btnSumMoney.Click += new System.EventHandler(this.btnSumMoney_Click_1);
            // 
            // dataViewSum
            // 
            this.dataViewSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewSum.Location = new System.Drawing.Point(172, 722);
            this.dataViewSum.Name = "dataViewSum";
            this.dataViewSum.RowHeadersWidth = 51;
            this.dataViewSum.RowTemplate.Height = 24;
            this.dataViewSum.Size = new System.Drawing.Size(304, 84);
            this.dataViewSum.TabIndex = 51;
            this.dataViewSum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewSum_CellClick);
            this.dataViewSum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // fMuaHangOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 828);
            this.Controls.Add(this.dataViewSum);
            this.Controls.Add(this.btnSumMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSumBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataViewKho);
            this.Controls.Add(this.txbMaH);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbNVSell);
            this.Controls.Add(this.txbSafe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbSTT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAddToBill);
            this.Controls.Add(this.txbPriceH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbSlH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbNameH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbDateinBill);
            this.Controls.Add(this.btnCreateKey);
            this.Controls.Add(this.txbCreateKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbSĐTKH);
            this.Controls.Add(this.txbNameKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaKHBuyOnline);
            this.Controls.Add(this.txbMaKH);
            this.Controls.Add(this.btnNewBill);
            this.Controls.Add(this.dataViewListBuy);
            this.Controls.Add(this.txbSumMoney);
            this.Controls.Add(this.cbBLoai);
            this.Controls.Add(this.btnInBill);
            this.Controls.Add(this.btnOut);
            this.Name = "fMuaHangOnline";
            this.Text = "Mua Hàng";
            this.Load += new System.EventHandler(this.fMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewListBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnInBill;
        private System.Windows.Forms.ComboBox cbBLoai;
        private System.Windows.Forms.TextBox txbSumMoney;
        private System.Windows.Forms.DataGridView dataViewListBuy;
        private System.Windows.Forms.Button btnNewBill;
        private System.Windows.Forms.TextBox txbMaKH;
        private System.Windows.Forms.Label lblMaKHBuyOnline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNameKH;
        private System.Windows.Forms.TextBox txbSĐTKH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCreateKey;
        private System.Windows.Forms.Button btnCreateKey;
        private System.Windows.Forms.TextBox txbDateinBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNameH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbSlH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbPriceH;
        private System.Windows.Forms.Button btnAddToBill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbSTT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbSafe;
        private System.Windows.Forms.TextBox txbNVSell;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbMaH;
        private System.Windows.Forms.DataGridView dataViewKho;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSumBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSumMoney;
        private System.Windows.Forms.DataGridView dataViewSum;
    }
}