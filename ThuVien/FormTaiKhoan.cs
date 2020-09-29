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
    public partial class FormTaiKhoan : Form
    {
        Models.Taikhoan myTK;
        public FormTaiKhoan()
        {
            InitializeComponent();
            hienthidanhsach();
            txtMaDocGia.Enabled = false;
            design();
        }
        public void hienthidanhsach()
        {
            DataTable dataTable = Models.Taikhoan.getTable_Taikhoan();
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
            txtMaDocGia.Text = "";
            txttendangnhap.Text = "";
            txtmatkhau.Text = "";
            cbbquyen.Text = "";
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
        private void btnSVThem_Click(object sender, EventArgs e)
        {
            clearData();
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

        private void btnSVXoa_Click(object sender, EventArgs e)
        {
            string _txtMaDocGia = "";
            try
            {
                _txtMaDocGia = txtMaDocGia.Text;
                MessageBox.Show(_txtMaDocGia);
            }
            catch { }
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                myTK = new Models.Taikhoan(txtMaDocGia.Text, txttendangnhap.Text, txtmatkhau.Text, cbbquyen.Text);
                var i = myTK.DeleteTaikhoan();
                if (i > 0)
                {
                    MessageBox.Show("Xóa Thành Công !");

                }
                else
                    MessageBox.Show("Xóa Không thành công");
            }
            hienthidanhsach();
        }

        private void btnSVHuy_Click(object sender, EventArgs e)
        {
            if (btnSVHuy.Tag.ToString() == "Them")
            {
                txtMaDocGia.Text = "";
                txtmatkhau.Text = "";
                txttendangnhap.Text = "";
                cbbquyen.Text = "";
            }
            if (btnSVHuy.Tag.ToString() == "Sua")
            {
                txtMaDocGia.Text = "";
                txtmatkhau.Text = "";
                txttendangnhap.Text = "";
                cbbquyen.Text = "";
            }
            btnReload();
        }

        private void btnSVLuu_Click(object sender, EventArgs e)
        {
            if (btnSVLuu.Tag.ToString() == "Them")
            {
                myTK = new Models.Taikhoan(txtMaDocGia.Text, txttendangnhap.Text, txtmatkhau.Text, cbbquyen.Text);
                var i = myTK.InsertTaikhoan();
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
                myTK = new Models.Taikhoan(txtMaDocGia.Text, txttendangnhap.Text, txtmatkhau.Text, cbbquyen.Text);
                var i = myTK.UpdateTaikhoan();
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

        private void dgvphieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaDocGia.Text = dgvphieumuon.Rows[index].Cells["MaDocGia"].Value.ToString();
                txttendangnhap.Text = dgvphieumuon.Rows[index].Cells["TenDangNhap"].Value.ToString();
                txtmatkhau.Text = dgvphieumuon.Rows[index].Cells["MatKhau"].Value.ToString();
                cbbquyen.Text = dgvphieumuon.Rows[index].Cells["Quyen"].Value.ToString();
            }
        }
        public void SearchByKey(string query, string value)
        {
            query = query + "N'%" + value + "%'";
            DataTable data = Models.Connection.SeachInDataBase(query);
            if (data.Rows.Count == 0) MessageBox.Show("Không Tìm Thấy");
            else dgvphieumuon.DataSource = data;
        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            hienthidanhsach();
        }
        
        private void btntimkiem_Click(object sender, EventArgs e)
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
                if (GiaTri == "MaDocGia") query = "Select * from TaiKHoan where MaDocGia like ";
                if (GiaTri == "TenDangNhap") query = "Select * from TaiKHoan where TenDangNhap like ";
                SearchByKey(query, keyRow);
            }
        }
    }
}
