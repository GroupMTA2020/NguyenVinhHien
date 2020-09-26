namespace ThuVien
{
    partial class DocGia
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtNamSinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDG = new System.Windows.Forms.DataGridView();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSVSua = new System.Windows.Forms.Button();
            this.btnSVXoa = new System.Windows.Forms.Button();
            this.btnSVHuy = new System.Windows.Forms.Button();
            this.btnSVLuu = new System.Windows.Forms.Button();
            this.btnSVThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDG)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(849, 140);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(280, 22);
            this.txtDiaChi.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(712, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Địa Chỉ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dtNamSinh);
            this.panel1.Controls.Add(this.cbGioitinh);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbTimKiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaDG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenDN);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 261);
            this.panel1.TabIndex = 18;
            // 
            // dtNamSinh
            // 
            this.dtNamSinh.Location = new System.Drawing.Point(848, 91);
            this.dtNamSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNamSinh.Name = "dtNamSinh";
            this.dtNamSinh.Size = new System.Drawing.Size(280, 22);
            this.dtNamSinh.TabIndex = 22;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(849, 43);
            this.cbGioitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(279, 24);
            this.cbGioitinh.TabIndex = 21;
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "MaDN",
            "TenDN",
            "HoTen",
            "DiaChi"});
            this.cbTimKiem.Location = new System.Drawing.Point(213, 198);
            this.cbTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(279, 24);
            this.cbTimKiem.TabIndex = 17;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(849, 191);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(132, 46);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.ForeColor = System.Drawing.Color.Plum;
            this.panel3.Location = new System.Drawing.Point(35, 180);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 2);
            this.panel3.TabIndex = 14;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(545, 199);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(280, 22);
            this.txttimkiem.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "TÌm Kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(712, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Năm Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(712, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giới Tính";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(213, 42);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(280, 22);
            this.txtMaDG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(213, 94);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(280, 22);
            this.txtTenDN.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(213, 142);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(280, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ Tên";
            // 
            // dgvDG
            // 
            this.dgvDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDG,
            this.TenDN,
            this.HoTen,
            this.GioiTinh,
            this.NamSinh,
            this.DiaChi});
            this.dgvDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDG.Location = new System.Drawing.Point(0, 261);
            this.dgvDG.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDG.Name = "dgvDG";
            this.dgvDG.RowHeadersWidth = 51;
            this.dgvDG.Size = new System.Drawing.Size(1279, 343);
            this.dgvDG.TabIndex = 0;
            this.dgvDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDG_CellClick);
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDocGia";
            this.MaDG.HeaderText = "Mã Độc Giả";
            this.MaDG.MinimumWidth = 6;
            this.MaDG.Name = "MaDG";
            this.MaDG.Width = 125;
            // 
            // TenDN
            // 
            this.TenDN.DataPropertyName = "TenDangNhap";
            this.TenDN.HeaderText = "Tên Đăng Nhập";
            this.TenDN.MinimumWidth = 6;
            this.TenDN.Name = "TenDN";
            this.TenDN.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm Sinh";
            this.NamSinh.MinimumWidth = 6;
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
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
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 604);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1279, 100);
            this.tableLayoutPanel8.TabIndex = 20;
            // 
            // btnSVSua
            // 
            this.btnSVSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSVSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVSua.Location = new System.Drawing.Point(589, 4);
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
            this.btnSVXoa.Location = new System.Drawing.Point(1015, 4);
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
            this.btnSVHuy.Location = new System.Drawing.Point(856, 54);
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
            this.btnSVLuu.Location = new System.Drawing.Point(322, 54);
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
            this.btnSVThem.Location = new System.Drawing.Point(163, 4);
            this.btnSVThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSVThem.Name = "btnSVThem";
            this.btnSVThem.Size = new System.Drawing.Size(100, 42);
            this.btnSVThem.TabIndex = 0;
            this.btnSVThem.Text = "Thêm";
            this.btnSVThem.UseVisualStyleBackColor = true;
            this.btnSVThem.Click += new System.EventHandler(this.btnSVThem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1006, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "Tất Cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 704);
            this.Controls.Add(this.dgvDG);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DocGia";
            this.Text = "DocGia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocGia_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDG)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNamSinh;
        private System.Windows.Forms.DataGridView dgvDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnSVSua;
        private System.Windows.Forms.Button btnSVXoa;
        private System.Windows.Forms.Button btnSVHuy;
        private System.Windows.Forms.Button btnSVLuu;
        private System.Windows.Forms.Button btnSVThem;
        private System.Windows.Forms.Button button1;
    }
}