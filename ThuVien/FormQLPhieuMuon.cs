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
           
        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {
        }
       
        private void btnSVXoa_Click(object sender, EventArgs e)
        {
        }

        private void btnSVLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSVHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvphieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btntatca_Click_1(object sender, EventArgs e)
        {
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       
        private void FormQLPhieuMuon_Load(object sender, EventArgs e)
        {
        }

        private void cbmadocgia_Click(object sender, EventArgs e)
        {
          
        }

        private void cbbmasach_Click(object sender, EventArgs e)
        {
           
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
    }
}
