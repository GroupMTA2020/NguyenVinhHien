namespace ThuVien
{
    partial class FormSach
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
            this.searchChoice_cbx = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttacgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Repair_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nb_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.txttheloai = new System.Windows.Forms.TextBox();
            this.txtnhaxuatban = new System.Windows.Forms.TextBox();
            this.txtgiasach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // searchChoice_cbx
            // 
            this.searchChoice_cbx.DisplayMember = "1";
            this.searchChoice_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchChoice_cbx.FormattingEnabled = true;
            this.searchChoice_cbx.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Tác giả",
            "Thể loại",
            "Nhà xuất bản",
            "Giá sách",
            "Số lượng"});
            this.searchChoice_cbx.Location = new System.Drawing.Point(202, 230);
            this.searchChoice_cbx.Name = "searchChoice_cbx";
            this.searchChoice_cbx.Size = new System.Drawing.Size(279, 33);
            this.searchChoice_cbx.TabIndex = 17;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1112, 220);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(132, 45);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.search_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.ForeColor = System.Drawing.Color.Plum;
            this.panel3.Location = new System.Drawing.Point(35, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 0);
            this.panel3.TabIndex = 14;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(745, 227);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(280, 30);
            this.txttimkiem.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "TÌm Kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhà Xuất Bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thể Loại";
            // 
            // txtmasach
            // 
            this.txtmasach.Enabled = false;
            this.txtmasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmasach.Location = new System.Drawing.Point(206, 44);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(280, 30);
            this.txtmasach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sách";
            // 
            // txttacgia
            // 
            this.txttacgia.Enabled = false;
            this.txttacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttacgia.Location = new System.Drawing.Point(206, 141);
            this.txttacgia.Name = "txttacgia";
            this.txttacgia.Size = new System.Drawing.Size(280, 30);
            this.txttacgia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tác Giả";
            // 
            // Repair_btn
            // 
            this.Repair_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repair_btn.Location = new System.Drawing.Point(612, 21);
            this.Repair_btn.Name = "Repair_btn";
            this.Repair_btn.Size = new System.Drawing.Size(182, 43);
            this.Repair_btn.TabIndex = 1;
            this.Repair_btn.Text = "Sửa";
            this.Repair_btn.UseVisualStyleBackColor = true;
            this.Repair_btn.Click += new System.EventHandler(this.Repair_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Remove_btn);
            this.panel2.Controls.Add(this.Cancel_btn);
            this.panel2.Controls.Add(this.Save_btn);
            this.panel2.Controls.Add(this.Repair_btn);
            this.panel2.Controls.Add(this.Add_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1394, 100);
            this.panel2.TabIndex = 16;
            // 
            // Remove_btn
            // 
            this.Remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.Location = new System.Drawing.Point(1152, 21);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(182, 43);
            this.Remove_btn.TabIndex = 4;
            this.Remove_btn.Text = "Xóa";
            this.Remove_btn.UseVisualStyleBackColor = true;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.Location = new System.Drawing.Point(865, 21);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(182, 43);
            this.Cancel_btn.TabIndex = 3;
            this.Cancel_btn.Text = "Hủy";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Visible = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(348, 21);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(182, 43);
            this.Save_btn.TabIndex = 2;
            this.Save_btn.Text = "Lưu";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Visible = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(84, 21);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(182, 43);
            this.Add_btn.TabIndex = 0;
            this.Add_btn.Text = "Thêm ";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_Click);
            // 
            // dtgvSach
            // 
            this.dtgvSach.AllowUserToAddRows = false;
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masach,
            this.Tensach,
            this.Tacgia,
            this.Theloai,
            this.Nhaxuatban,
            this.Giasach,
            this.Soluong,
            this.Tinhtrang});
            this.dtgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSach.Location = new System.Drawing.Point(0, 269);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.ReadOnly = true;
            this.dtgvSach.RowHeadersWidth = 51;
            this.dtgvSach.RowTemplate.Height = 24;
            this.dtgvSach.Size = new System.Drawing.Size(1394, 499);
            this.dtgvSach.TabIndex = 17;
            this.dtgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellClick);
            // 
            // Masach
            // 
            this.Masach.DataPropertyName = "Masach";
            this.Masach.HeaderText = "Mã Sách";
            this.Masach.MinimumWidth = 6;
            this.Masach.Name = "Masach";
            this.Masach.ReadOnly = true;
            this.Masach.Width = 125;
            // 
            // Tensach
            // 
            this.Tensach.DataPropertyName = "Tensach";
            this.Tensach.HeaderText = "Tên Sách";
            this.Tensach.MinimumWidth = 6;
            this.Tensach.Name = "Tensach";
            this.Tensach.ReadOnly = true;
            this.Tensach.Width = 125;
            // 
            // Tacgia
            // 
            this.Tacgia.DataPropertyName = "Tacgia";
            this.Tacgia.HeaderText = "Tác Giả";
            this.Tacgia.MinimumWidth = 6;
            this.Tacgia.Name = "Tacgia";
            this.Tacgia.ReadOnly = true;
            this.Tacgia.Width = 125;
            // 
            // Theloai
            // 
            this.Theloai.DataPropertyName = "Theloai";
            this.Theloai.HeaderText = "Thể Loại";
            this.Theloai.MinimumWidth = 6;
            this.Theloai.Name = "Theloai";
            this.Theloai.ReadOnly = true;
            this.Theloai.Width = 125;
            // 
            // Nhaxuatban
            // 
            this.Nhaxuatban.DataPropertyName = "Nhaxuatban";
            this.Nhaxuatban.HeaderText = "Nhà Xuất Bản";
            this.Nhaxuatban.MinimumWidth = 6;
            this.Nhaxuatban.Name = "Nhaxuatban";
            this.Nhaxuatban.ReadOnly = true;
            this.Nhaxuatban.Width = 125;
            // 
            // Giasach
            // 
            this.Giasach.DataPropertyName = "Giasach";
            this.Giasach.HeaderText = "Giá sách";
            this.Giasach.MinimumWidth = 6;
            this.Giasach.Name = "Giasach";
            this.Giasach.ReadOnly = true;
            this.Giasach.Width = 125;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            this.Soluong.Width = 125;
            // 
            // Tinhtrang
            // 
            this.Tinhtrang.DataPropertyName = "Tinhtrang";
            this.Tinhtrang.HeaderText = "Tình Trạng";
            this.Tinhtrang.MinimumWidth = 6;
            this.Tinhtrang.Name = "Tinhtrang";
            this.Tinhtrang.ReadOnly = true;
            this.Tinhtrang.Width = 125;
            // 
            // txttensach
            // 
            this.txttensach.Enabled = false;
            this.txttensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensach.Location = new System.Drawing.Point(206, 93);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(280, 30);
            this.txttensach.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txttinhtrang);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nb_SoLuong);
            this.panel1.Controls.Add(this.txttheloai);
            this.panel1.Controls.Add(this.txtnhaxuatban);
            this.panel1.Controls.Add(this.txtgiasach);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.searchChoice_cbx);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtmasach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttensach);
            this.panel1.Controls.Add(this.txttacgia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 269);
            this.panel1.TabIndex = 15;
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Enabled = false;
            this.txttinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttinhtrang.Location = new System.Drawing.Point(1257, 93);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(77, 30);
            this.txttinhtrang.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1107, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tình Trạng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1107, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Số lượng";
            // 
            // nb_SoLuong
            // 
            this.nb_SoLuong.Enabled = false;
            this.nb_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb_SoLuong.Location = new System.Drawing.Point(1257, 40);
            this.nb_SoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nb_SoLuong.Name = "nb_SoLuong";
            this.nb_SoLuong.Size = new System.Drawing.Size(77, 30);
            this.nb_SoLuong.TabIndex = 22;
            // 
            // txttheloai
            // 
            this.txttheloai.Enabled = false;
            this.txttheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttheloai.Location = new System.Drawing.Point(745, 45);
            this.txttheloai.Name = "txttheloai";
            this.txttheloai.Size = new System.Drawing.Size(280, 30);
            this.txttheloai.TabIndex = 21;
            // 
            // txtnhaxuatban
            // 
            this.txtnhaxuatban.Enabled = false;
            this.txtnhaxuatban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhaxuatban.Location = new System.Drawing.Point(745, 89);
            this.txtnhaxuatban.Name = "txtnhaxuatban";
            this.txtnhaxuatban.Size = new System.Drawing.Size(280, 30);
            this.txtnhaxuatban.TabIndex = 20;
            // 
            // txtgiasach
            // 
            this.txtgiasach.Enabled = false;
            this.txtgiasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiasach.Location = new System.Drawing.Point(745, 142);
            this.txtgiasach.Name = "txtgiasach";
            this.txtgiasach.Size = new System.Drawing.Size(280, 30);
            this.txtgiasach.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Giá Sách";
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgvSach);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSach";
            this.Text = "FormSach";
            this.Load += new System.EventHandler(this.FormSach_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_SoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox searchChoice_cbx;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttacgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Repair_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nb_SoLuong;
        private System.Windows.Forms.TextBox txttheloai;
        private System.Windows.Forms.TextBox txtnhaxuatban;
        private System.Windows.Forms.TextBox txtgiasach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinhtrang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttinhtrang;
    }
}