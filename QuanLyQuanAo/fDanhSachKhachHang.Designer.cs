namespace QuanLyQuanAo
{
    partial class fDanhSachKhachHang
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
            this.dataViewKH = new System.Windows.Forms.DataGridView();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnSearchKH = new System.Windows.Forms.Button();
            this.tbxSearchKH = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewKH
            // 
            this.dataViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewKH.Location = new System.Drawing.Point(389, 18);
            this.dataViewKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataViewKH.Name = "dataViewKH";
            this.dataViewKH.RowHeadersWidth = 51;
            this.dataViewKH.RowTemplate.Height = 24;
            this.dataViewKH.Size = new System.Drawing.Size(490, 152);
            this.dataViewKH.TabIndex = 0;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(764, 522);
            this.btnOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(116, 51);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnSearchKH
            // 
            this.btnSearchKH.Location = new System.Drawing.Point(1, 18);
            this.btnSearchKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchKH.Name = "btnSearchKH";
            this.btnSearchKH.Size = new System.Drawing.Size(116, 51);
            this.btnSearchKH.TabIndex = 2;
            this.btnSearchKH.Text = "Tìm";
            this.btnSearchKH.UseVisualStyleBackColor = true;
            this.btnSearchKH.Click += new System.EventHandler(this.btnSearchKH_Click);
            // 
            // tbxSearchKH
            // 
            this.tbxSearchKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchKH.Location = new System.Drawing.Point(137, 40);
            this.tbxSearchKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSearchKH.Name = "tbxSearchKH";
            this.tbxSearchKH.Size = new System.Drawing.Size(233, 30);
            this.tbxSearchKH.TabIndex = 3;
            this.tbxSearchKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fDanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 604);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbxSearchKH);
            this.Controls.Add(this.btnSearchKH);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.dataViewKH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fDanhSachKhachHang";
            this.Text = "fDanhSachKhachHang";
            this.Load += new System.EventHandler(this.fDanhSachKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewKH;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnSearchKH;
        private System.Windows.Forms.TextBox tbxSearchKH;
        private System.Windows.Forms.ListView listView1;
    }
}