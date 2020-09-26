namespace ThuVien
{
    partial class FormTaiKhoan
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
            this.btntatca = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbp_chon = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSVSua = new System.Windows.Forms.Button();
            this.btnSVXoa = new System.Windows.Forms.Button();
            this.btnSVHuy = new System.Windows.Forms.Button();
            this.btnSVLuu = new System.Windows.Forms.Button();
            this.btnSVThem = new System.Windows.Forms.Button();
            this.dgvphieumuon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbquyen = new System.Windows.Forms.ComboBox();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbquyen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btntatca);
            this.panel1.Controls.Add(this.txtmatkhau);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbp_chon);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaDocGia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttendangnhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 243);
            this.panel1.TabIndex = 0;
            // 
            // btntatca
            // 
            this.btntatca.Location = new System.Drawing.Point(1157, 162);
            this.btntatca.Name = "btntatca";
            this.btntatca.Size = new System.Drawing.Size(132, 45);
            this.btntatca.TabIndex = 36;
            this.btntatca.Text = "Tất Cả";
            this.btntatca.UseVisualStyleBackColor = true;
            this.btntatca.Click += new System.EventHandler(this.btntatca_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(812, 31);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(280, 30);
            this.txtmatkhau.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Mật Khẩu";
            // 
            // cbp_chon
            // 
            this.cbp_chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbp_chon.FormattingEnabled = true;
            this.cbp_chon.Items.AddRange(new object[] {
            "MaDocGia",
            "TenDangNhap"});
            this.cbp_chon.Location = new System.Drawing.Point(226, 166);
            this.cbp_chon.Name = "cbp_chon";
            this.cbp_chon.Size = new System.Drawing.Size(279, 33);
            this.cbp_chon.TabIndex = 33;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(960, 162);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(132, 45);
            this.btntimkiem.TabIndex = 32;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.ForeColor = System.Drawing.Color.Plum;
            this.panel3.Location = new System.Drawing.Point(54, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 3);
            this.panel3.TabIndex = 31;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(600, 166);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(280, 30);
            this.txttimkiem.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "TÌm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã Độc Giả";
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDocGia.Location = new System.Drawing.Point(260, 31);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(280, 30);
            this.txtMaDocGia.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendangnhap.Location = new System.Drawing.Point(260, 80);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(280, 30);
            this.txttendangnhap.TabIndex = 26;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.btnSVSua, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnSVXoa, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnSVHuy, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnSVLuu, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnSVThem, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 661);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1403, 100);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // btnSVSua
            // 
            this.btnSVSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSVSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVSua.Location = new System.Drawing.Point(650, 4);
            this.btnSVSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSVSua.Name = "btnSVSua";
            this.btnSVSua.Size = new System.Drawing.Size(100, 42);
            this.btnSVSua.TabIndex = 2;
            this.btnSVSua.Text = "Sửa";
            this.btnSVSua.UseVisualStyleBackColor = true;
            this.btnSVSua.Click += new System.EventHandler(this.btnSVSua_Click);
            // 
            // btnSVXoa
            // 
            this.btnSVXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSVXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVXoa.Location = new System.Drawing.Point(1118, 4);
            this.btnSVXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnSVXoa.Name = "btnSVXoa";
            this.btnSVXoa.Size = new System.Drawing.Size(100, 42);
            this.btnSVXoa.TabIndex = 4;
            this.btnSVXoa.Text = "Xóa";
            this.btnSVXoa.UseVisualStyleBackColor = true;
            this.btnSVXoa.Click += new System.EventHandler(this.btnSVXoa_Click);
            // 
            // btnSVHuy
            // 
            this.btnSVHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVHuy.Location = new System.Drawing.Point(938, 54);
            this.btnSVHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnSVHuy.Name = "btnSVHuy";
            this.btnSVHuy.Size = new System.Drawing.Size(100, 42);
            this.btnSVHuy.TabIndex = 5;
            this.btnSVHuy.Text = "Hủy";
            this.btnSVHuy.UseVisualStyleBackColor = true;
            this.btnSVHuy.Visible = false;
            this.btnSVHuy.Click += new System.EventHandler(this.btnSVHuy_Click);
            // 
            // btnSVLuu
            // 
            this.btnSVLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSVLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVLuu.Location = new System.Drawing.Point(363, 54);
            this.btnSVLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSVLuu.Name = "btnSVLuu";
            this.btnSVLuu.Size = new System.Drawing.Size(100, 42);
            this.btnSVLuu.TabIndex = 3;
            this.btnSVLuu.Text = "Lưu";
            this.btnSVLuu.UseVisualStyleBackColor = true;
            this.btnSVLuu.Visible = false;
            this.btnSVLuu.Click += new System.EventHandler(this.btnSVLuu_Click);
            // 
            // btnSVThem
            // 
            this.btnSVThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSVThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVThem.Location = new System.Drawing.Point(183, 4);
            this.btnSVThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSVThem.Name = "btnSVThem";
            this.btnSVThem.Size = new System.Drawing.Size(100, 42);
            this.btnSVThem.TabIndex = 0;
            this.btnSVThem.Text = "Thêm";
            this.btnSVThem.UseVisualStyleBackColor = true;
            this.btnSVThem.Click += new System.EventHandler(this.btnSVThem_Click);
            // 
            // dgvphieumuon
            // 
            this.dgvphieumuon.AllowUserToAddRows = false;
            this.dgvphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieumuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.TenDangNhap,
            this.MatKhau,
            this.Quyen});
            this.dgvphieumuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvphieumuon.Location = new System.Drawing.Point(0, 243);
            this.dgvphieumuon.Name = "dgvphieumuon";
            this.dgvphieumuon.RowHeadersWidth = 51;
            this.dgvphieumuon.RowTemplate.Height = 24;
            this.dgvphieumuon.Size = new System.Drawing.Size(1403, 418);
            this.dgvphieumuon.TabIndex = 15;
            this.dgvphieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieumuon_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Quyền";
            // 
            // cbbquyen
            // 
            this.cbbquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbquyen.FormattingEnabled = true;
            this.cbbquyen.Items.AddRange(new object[] {
            "1 ",
            "0"});
            this.cbbquyen.Location = new System.Drawing.Point(812, 80);
            this.cbbquyen.Name = "cbbquyen";
            this.cbbquyen.Size = new System.Drawing.Size(121, 33);
            this.cbbquyen.TabIndex = 39;
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã Độc Giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.Width = 130;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 125;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 150;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            this.Quyen.Width = 150;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 761);
            this.Controls.Add(this.dgvphieumuon);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieumuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntatca;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbp_chon;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnSVSua;
        private System.Windows.Forms.Button btnSVXoa;
        private System.Windows.Forms.Button btnSVHuy;
        private System.Windows.Forms.Button btnSVLuu;
        private System.Windows.Forms.Button btnSVThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvphieumuon;
        private System.Windows.Forms.ComboBox cbbquyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
    }
}