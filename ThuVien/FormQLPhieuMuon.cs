using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class FormQLPhieuMuon : Form
    {
        Models.phieumuon myPM;
        public FormQLPhieuMuon()
        {
            InitializeComponent();
            hienthidanhsach();
            design();
            txtmaphieu.Enabled = false;
            
        }
        public void hienthidanhsach()
        {
            DataTable dataTable = Models.phieumuon.getTable_phieumuon();
            dgvphieumuon.DataSource = dataTable;
        }
        void btnReload()
        {
            btnSVSua.Visible = btnSVXoa.Visible =
                btnSVThem.Visible = !btnSVSua.Visible;
            btnSVHuy.Visible = btnSVLuu.Visible = !btnSVLuu.Visible;
        }
        private void clearData()
        {
            txtmaphieu.Text = "";
            cbmadocgia.Text = "";
            dtpngaymuon.Refresh();
            dtpngaytra.Refresh();
            cbbmasach.Text = "";
        }

        private void btnSVThem_Click(object sender, EventArgs e)
        {
            clearData();
            txtmaphieu.Text = "PM" + dgvphieumuon.Rows.Count.ToString("0000");
            btnSVLuu.Tag = "Them";
            btnSVHuy.Tag = "Them";
            btnReload();
        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {
            btnReload();
            btnSVLuu.Tag = "Sua";
            btnSVHuy.Tag = "Sua";
        }
        string convertToDateSQL(string dateC)
        {
            string result;
            string date = dateC.Split(' ')[0];
            var X = date.Split('/');
            result = X[2] + "-" + X[1] + "-" + X[0];
            return result;
        }
        private void btnSVXoa_Click(object sender, EventArgs e)
        {
            string _maphieumuon = "";
            try
            {
                _maphieumuon = txtmaphieu.Text;
                MessageBox.Show(_maphieumuon);
            }
            catch { }
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string ngaymuon = convertToDateSQL(dtpngaymuon.Value.ToString("dd/MM/yyy"));
                string ngaytra = convertToDateSQL(dtpngaytra.Value.ToString("dd/MM/yyy"));
                myPM = new Models.phieumuon(txtmaphieu.Text, cbmadocgia.Text, cbbmasach.Text, ngaymuon
                    , ngaytra,txttinhtrang.Text);
                var i = myPM.Deletephieumuon();
                if (i > 0)
                {
                    MessageBox.Show("Xóa Thành Công !");

                }
                else
                    MessageBox.Show("Xóa Không thành công");
            }
            hienthidanhsach();
        }

        private void btnSVLuu_Click(object sender, EventArgs e)
        {
            if (btnSVLuu.Tag.ToString() == "Them")
            {
                string ngaymuon = convertToDateSQL(dtpngaymuon.Value.ToString("dd/MM/yyy"));
                string ngaytra = convertToDateSQL(dtpngaytra.Value.ToString("dd/MM/yyy"));
                myPM = new Models.phieumuon(txtmaphieu.Text, cbmadocgia.Text, cbbmasach.Text, ngaymuon
                    , ngaytra, txttinhtrang.Text);
                //HienThiDanhSachSV();
                var i = myPM.Insertphieumuon();
                if (i == 0)
                {
                    MessageBox.Show("Thêm mới thất bại !");
                }
                else
                {
                    MessageBox.Show("Thêm mới thành công !");
                    hienthidanhsach();
                }
            }
            if (btnSVLuu.Tag.ToString() == "Sua")
            {
                string ngaymuon = convertToDateSQL(dtpngaymuon.Value.ToString("dd/MM/yyy"));
                string ngaytra = convertToDateSQL(dtpngaytra.Value.ToString("dd/MM/yyy"));
                myPM = new Models.phieumuon(txtmaphieu.Text, cbmadocgia.Text, cbbmasach.Text, ngaymuon
                   , ngaytra, txttinhtrang.Text);
                var i = myPM.Updatephieumuon();
                if (i == 0)
                {
                    MessageBox.Show("Sửa thất bại !");
                }
                else
                {
                    MessageBox.Show("Sửa thành công !");
                    hienthidanhsach();
                }
            }
        }

        private void btnSVHuy_Click(object sender, EventArgs e)
        {
            if (btnSVHuy.Tag.ToString() == "Them")
            {
                txtmaphieu.Text = "";
                cbmadocgia.Text = "";
                dtpngaymuon.Refresh();
                dtpngaytra.Refresh();
                cbbmasach.Text = "";
                txttinhtrang.Text = "";
            }
            if (btnSVHuy.Tag.ToString() == "Sua")
            {
                txtmaphieu.Text = "";
                cbmadocgia.Text = "";
                dtpngaymuon.Refresh();
                dtpngaytra.Refresh();
                cbbmasach.Text = "";
                txttinhtrang.Text = "";
            }
            btnReload();
        }

        private void dgvphieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmaphieu.Text = dgvphieumuon.Rows[index].Cells["MaPhieuMuon"].Value.ToString();
                cbmadocgia.Text = dgvphieumuon.Rows[index].Cells["MaDocGia"].Value.ToString();
                dtpngaymuon.Text = dgvphieumuon.Rows[index].Cells["NgayMuon"].Value.ToString();
                dtpngaytra.Text = dgvphieumuon.Rows[index].Cells["NgayPhaiTra"].Value.ToString();
                cbbmasach.Text = dgvphieumuon.Rows[index].Cells["MaSach"].Value.ToString();
                txttinhtrang.Text = dgvphieumuon.Rows[index].Cells["TinhTrang"].Value.ToString();
            }
        }
        private void btntatca_Click_1(object sender, EventArgs e)
        {
            hienthidanhsach();
        }
        public void SearchByKey(string query, string value)
        {
            query = query + "N'%" + value + "%'";
            DataTable data = Models.Connection.SeachInDataBase(query);
            if (data.Rows.Count == 0) MessageBox.Show("Không Tìm Thấy");
            else dgvphieumuon.DataSource = data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string GiaTri = cbp_chon.GetItemText(this.cbp_chon.SelectedItem).Trim();

            string keyRow = txttimkiem.Text;
            if (GiaTri == "" || keyRow == "")
            {
                MessageBox.Show("Chưa Có Thông Tin Cần Tìm");
            }
            else
            {

                string query = "";
                //set value of query if valuaCol change 
                if (GiaTri == "MaDocGia") query = "Select * from PhieuMuon where MaDocGia like ";
                if (GiaTri == "MaPhieuMuon") query = "Select * from PhieuMuon where MaPhieuMuon like ";
                if (GiaTri == "MaSach") query = "Select * from PhieuMuon where MaSach like ";
                SearchByKey(query, keyRow);
            }
        }
        void design()
        {
            dgvphieumuon.BorderStyle = BorderStyle.None;
            dgvphieumuon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvphieumuon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvphieumuon.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvphieumuon.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvphieumuon.BackgroundColor = Color.White;
            dgvphieumuon.EnableHeadersVisualStyles = false;
            dgvphieumuon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvphieumuon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvphieumuon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvphieumuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormQLPhieuMuon_Load(object sender, EventArgs e)
        {
        }

        private void cbmadocgia_Click(object sender, EventArgs e)
        {
            cbmadocgia.DataSource = Models.phieumuon.listmadocgia();
            cbmadocgia.DisplayMember = "MaDocGia";
        }

        private void cbbmasach_Click(object sender, EventArgs e)
        {
            cbbmasach.DataSource = Models.phieumuon.listmasach();
            cbbmasach.DisplayMember = "MaSach";
        }
    }
}
