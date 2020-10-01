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
    public partial class Dangmuon : Form
    {
        public Dangmuon()
        {
            InitializeComponent();
            hienthidanhsach();
            design();
        }
        public DataSet getData(string query)
        {
            Models.Connection data = new Models.Connection();
            return data.getDataSet(query);

        }
        public void hienthidanhsach()
        {
            string query = "select * from dangmuonchuatra()";
            dgvdangmuon.DataSource = getData(query).Tables[0];
        }
        public void SearchByKey(string query, string value)
        {

            query = query + "N'%" + value + "%'";
            DataTable data = Models.Connection.SeachInDataBase(query);
            if (data.Rows.Count == 0) MessageBox.Show("Không Tìm Thấy");
            else dgvdangmuon.DataSource = data;
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
                if (GiaTri == "MaPhieuMuon") query = "Select * from dangmuonchuatra() where MaPhieuMuon like ";
                if (GiaTri == "HoTen") query = "Select * from dangmuonchuatra() where HoTen like ";
                SearchByKey(query, keyRow);
            }
        }
        void design()
        {
            dgvdangmuon.BorderStyle = BorderStyle.None;
            dgvdangmuon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvdangmuon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvdangmuon.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvdangmuon.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvdangmuon.BackgroundColor = Color.White;
            dgvdangmuon.EnableHeadersVisualStyles = false;
            dgvdangmuon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvdangmuon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvdangmuon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvdangmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
