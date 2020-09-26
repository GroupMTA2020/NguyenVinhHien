namespace ThuVien
{
    partial class FormQLPhieuMuon
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
            this.dgvphieumuon = new System.Windows.Forms.DataGridView();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhaiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSVSua = new System.Windows.Forms.Button();
            this.btnSVXoa = new System.Windows.Forms.Button();
            this.btnSVHuy = new System.Windows.Forms.Button();
            this.btnSVLuu = new System.Windows.Forms.Button();
            this.btnSVThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpngaymuon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpngaytra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbmasach = new System.Windows.Forms.ComboBox();
            this.cbmadocgia = new System.Windows.Forms.ComboBox();
            this.btntatca = new System.Windows.Forms.Button();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbp_chon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieumuon)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvphieumuon
            // 
            this.dgvphieumuon.AllowUserToAddRows = false;
            this.dgvphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieumuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.MaDocGia,
            this.MaSach,
            this.NgayMuon,
            this.NgayPhaiTra,
            this.TinhTrang});
            this.dgvphieumuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvphieumuon.Location = new System.Drawing.Point(0, 254);
            this.dgvphieumuon.Name = "dgvphieumuon";
            this.dgvphieumuon.RowHeadersWidth = 51;
            this.dgvphieumuon.RowTemplate.Height = 24;
            this.dgvphieumuon.Size = new System.Drawing.Size(1382, 368);
            this.dgvphieumuon.TabIndex = 14;
            this.dgvphieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieumuon_CellClick);
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.MaPhieuMuon.HeaderText = "Mã Phiếu";
            this.MaPhieuMuon.MinimumWidth = 6;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            this.MaPhieuMuon.Width = 125;
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã Độc Giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.Width = 130;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Width = 150;
            // 
            // NgayPhaiTra
            // 
            this.NgayPhaiTra.DataPropertyName = "NgayPhaiTra";
            this.NgayPhaiTra.HeaderText = "Ngày Trả";
            this.NgayPhaiTra.MinimumWidth = 6;
            this.NgayPhaiTra.Name = "NgayPhaiTra";
            this.NgayPhaiTra.Width = 150;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 622);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 100);
            this.panel2.TabIndex = 13;
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
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1382, 100);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // btnSVSua
            // 
            this.btnSVSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSVSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVSua.Location = new System.Drawing.Point(640, 4);
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
            this.btnSVXoa.Location = new System.Drawing.Point(1101, 4);
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
            this.btnSVHuy.Location = new System.Drawing.Point(924, 54);
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
            this.btnSVLuu.Location = new System.Drawing.Point(356, 54);
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
            this.btnSVThem.Location = new System.Drawing.Point(180, 4);
            this.btnSVThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSVThem.Name = "btnSVThem";
            this.btnSVThem.Size = new System.Drawing.Size(100, 42);
            this.btnSVThem.TabIndex = 0;
            this.btnSVThem.Text = "Thêm";
            this.btnSVThem.UseVisualStyleBackColor = true;
            this.btnSVThem.Click += new System.EventHandler(this.btnSVThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Sách";
            // 
            // dtpngaymuon
            // 
            this.dtpngaymuon.Location = new System.Drawing.Point(745, 40);
            this.dtpngaymuon.Name = "dtpngaymuon";
            this.dtpngaymuon.Size = new System.Drawing.Size(200, 22);
            this.dtpngaymuon.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Độc Giả";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Location = new System.Drawing.Point(206, 44);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(280, 22);
            this.txtmaphieu.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày Mượn ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Trả";
            // 
            // dtpngaytra
            // 
            this.dtpngaytra.Location = new System.Drawing.Point(745, 89);
            this.dtpngaytra.Name = "dtpngaytra";
            this.dtpngaytra.Size = new System.Drawing.Size(200, 22);
            this.dtpngaytra.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "TÌm Kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(568, 200);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(280, 22);
            this.txttimkiem.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.ForeColor = System.Drawing.Color.Plum;
            this.panel3.Location = new System.Drawing.Point(35, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 3);
            this.panel3.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(930, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbmasach);
            this.panel1.Controls.Add(this.cbmadocgia);
            this.panel1.Controls.Add(this.btntatca);
            this.panel1.Controls.Add(this.txttinhtrang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbp_chon);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpngaytra);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtmaphieu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpngaymuon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 254);
            this.panel1.TabIndex = 12;
            // 
            // cbbmasach
            // 
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(207, 138);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(280, 24);
            this.cbbmasach.TabIndex = 25;
            this.cbbmasach.Click += new System.EventHandler(this.cbbmasach_Click);
            // 
            // cbmadocgia
            // 
            this.cbmadocgia.FormattingEnabled = true;
            this.cbmadocgia.Location = new System.Drawing.Point(206, 93);
            this.cbmadocgia.Name = "cbmadocgia";
            this.cbmadocgia.Size = new System.Drawing.Size(280, 24);
            this.cbmadocgia.TabIndex = 24;
            this.cbmadocgia.Click += new System.EventHandler(this.cbmadocgia_Click);
            // 
            // btntatca
            // 
            this.btntatca.Location = new System.Drawing.Point(1140, 193);
            this.btntatca.Name = "btntatca";
            this.btntatca.Size = new System.Drawing.Size(132, 45);
            this.btntatca.TabIndex = 23;
            this.btntatca.Text = "Tất Cả";
            this.btntatca.UseVisualStyleBackColor = true;
            this.btntatca.Click += new System.EventHandler(this.btntatca_Click_1);
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(745, 141);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(280, 22);
            this.txttinhtrang.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tình Trạng";
            // 
            // cbp_chon
            // 
            this.cbp_chon.FormattingEnabled = true;
            this.cbp_chon.Items.AddRange(new object[] {
            "MaPhieuMuon",
            "MaDocGia",
            "MaSach"});
            this.cbp_chon.Location = new System.Drawing.Point(207, 200);
            this.cbp_chon.Name = "cbp_chon";
            this.cbp_chon.Size = new System.Drawing.Size(279, 24);
            this.cbp_chon.TabIndex = 17;
            // 
            // FormQLPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 722);
            this.Controls.Add(this.dgvphieumuon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLPhieuMuon";
            this.Text = "FormQLPhieuMuon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieumuon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvphieumuon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpngaymuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpngaytra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbp_chon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnSVSua;
        private System.Windows.Forms.Button btnSVXoa;
        private System.Windows.Forms.Button btnSVHuy;
        private System.Windows.Forms.Button btnSVLuu;
        private System.Windows.Forms.Button btnSVThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btntatca;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhaiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.ComboBox cbbmasach;
        private System.Windows.Forms.ComboBox cbmadocgia;
    }
}