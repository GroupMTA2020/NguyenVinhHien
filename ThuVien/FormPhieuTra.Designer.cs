namespace ThuVien
{
    partial class FormPhieuTra
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
            this.dgvphieutra = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSVSua = new System.Windows.Forms.Button();
            this.btnSVXoa = new System.Windows.Forms.Button();
            this.btnSVHuy = new System.Windows.Forms.Button();
            this.btnSVLuu = new System.Windows.Forms.Button();
            this.btnSVThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpngaytra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntatca = new System.Windows.Forms.Button();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbp_chon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbmaphieumuon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieutra)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvphieutra
            // 
            this.dgvphieutra.AllowUserToAddRows = false;
            this.dgvphieutra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieutra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvphieutra.Location = new System.Drawing.Point(0, 254);
            this.dgvphieutra.Name = "dgvphieutra";
            this.dgvphieutra.RowHeadersWidth = 51;
            this.dgvphieutra.RowTemplate.Height = 24;
            this.dgvphieutra.Size = new System.Drawing.Size(1364, 348);
            this.dgvphieutra.TabIndex = 17;
            this.dgvphieutra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieutra_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 100);
            this.panel2.TabIndex = 16;
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
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1364, 100);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // btnSVSua
            // 
            this.btnSVSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSVSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVSua.Location = new System.Drawing.Point(631, 4);
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
            this.btnSVXoa.Location = new System.Drawing.Point(1086, 4);
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
            this.btnSVHuy.Location = new System.Drawing.Point(912, 54);
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
            this.btnSVLuu.Location = new System.Drawing.Point(350, 54);
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
            this.btnSVThem.Location = new System.Drawing.Point(177, 4);
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
            this.button1.Location = new System.Drawing.Point(941, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(581, 204);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(280, 30);
            this.txttimkiem.TabIndex = 13;
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
            // dtpngaytra
            // 
            this.dtpngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaytra.Location = new System.Drawing.Point(758, 43);
            this.dtpngaytra.Name = "dtpngaytra";
            this.dtpngaytra.Size = new System.Drawing.Size(280, 30);
            this.dtpngaytra.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Phiếu Mượn";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaphieu.Location = new System.Drawing.Point(206, 44);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(280, 30);
            this.txtmaphieu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbmaphieumuon);
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
            this.panel1.Controls.Add(this.txtmaphieu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 254);
            this.panel1.TabIndex = 15;
            // 
            // btntatca
            // 
            this.btntatca.Location = new System.Drawing.Point(1130, 189);
            this.btntatca.Name = "btntatca";
            this.btntatca.Size = new System.Drawing.Size(132, 45);
            this.btntatca.TabIndex = 22;
            this.btntatca.Text = "Tất Cả";
            this.btntatca.UseVisualStyleBackColor = true;
            this.btntatca.Click += new System.EventHandler(this.btntatca_Click);
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttinhtrang.Location = new System.Drawing.Point(758, 94);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(280, 30);
            this.txttinhtrang.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tình Trạng";
            // 
            // cbp_chon
            // 
            this.cbp_chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbp_chon.FormattingEnabled = true;
            this.cbp_chon.Items.AddRange(new object[] {
            "MaPhieu",
            "MaSach",
            "NgayTra"});
            this.cbp_chon.Location = new System.Drawing.Point(207, 204);
            this.cbp_chon.Name = "cbp_chon";
            this.cbp_chon.Size = new System.Drawing.Size(279, 33);
            this.cbp_chon.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(576, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Trả";
            // 
            // cbbmaphieumuon
            // 
            this.cbbmaphieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmaphieumuon.FormattingEnabled = true;
            this.cbbmaphieumuon.Location = new System.Drawing.Point(207, 89);
            this.cbbmaphieumuon.Name = "cbbmaphieumuon";
            this.cbbmaphieumuon.Size = new System.Drawing.Size(280, 33);
            this.cbbmaphieumuon.TabIndex = 23;
            this.cbbmaphieumuon.Click += new System.EventHandler(this.cbbmaphieumuon_Click);
            // 
            // FormPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 702);
            this.Controls.Add(this.dgvphieutra);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhieuTra";
            this.Text = "FormPhieuTra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieutra)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvphieutra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpngaytra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbp_chon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnSVSua;
        private System.Windows.Forms.Button btnSVXoa;
        private System.Windows.Forms.Button btnSVHuy;
        private System.Windows.Forms.Button btnSVLuu;
        private System.Windows.Forms.Button btnSVThem;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btntatca;
        private System.Windows.Forms.ComboBox cbbmaphieumuon;
    }
}