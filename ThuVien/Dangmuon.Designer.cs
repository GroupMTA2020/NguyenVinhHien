namespace ThuVien
{
    partial class Dangmuon
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
            this.dgvdangmuon = new System.Windows.Forms.DataGridView();
            this.cbp_chon = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhaiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdangmuon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdangmuon
            // 
            this.dgvdangmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdangmuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.HoTen,
            this.MaSach,
            this.NgayMuon,
            this.NgayPhaiTra,
            this.TinhTrang});
            this.dgvdangmuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdangmuon.Location = new System.Drawing.Point(0, 286);
            this.dgvdangmuon.Name = "dgvdangmuon";
            this.dgvdangmuon.RowHeadersWidth = 51;
            this.dgvdangmuon.RowTemplate.Height = 24;
            this.dgvdangmuon.Size = new System.Drawing.Size(1275, 446);
            this.dgvdangmuon.TabIndex = 0;
            // 
            // cbp_chon
            // 
            this.cbp_chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbp_chon.FormattingEnabled = true;
            this.cbp_chon.Items.AddRange(new object[] {
            "MaPhieuMuon",
            "HoTen"});
            this.cbp_chon.Location = new System.Drawing.Point(281, 121);
            this.cbp_chon.Name = "cbp_chon";
            this.cbp_chon.Size = new System.Drawing.Size(279, 33);
            this.cbp_chon.TabIndex = 20;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(1061, 206);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(132, 45);
            this.btntimkiem.TabIndex = 19;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(704, 121);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(280, 30);
            this.txttimkiem.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "TÌm Kiếm";
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.MaPhieuMuon.HeaderText = "Mã Phiếu Mượn";
            this.MaPhieuMuon.MinimumWidth = 6;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            this.MaPhieuMuon.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 180;
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
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
            this.NgayPhaiTra.HeaderText = "Ngày Phải Trả";
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
            // Dangmuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 732);
            this.Controls.Add(this.cbp_chon);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvdangmuon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dangmuon";
            this.Text = "Dangmuon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdangmuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdangmuon;
        private System.Windows.Forms.ComboBox cbp_chon;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhaiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}