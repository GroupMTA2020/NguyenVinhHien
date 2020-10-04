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
    public partial class Datra : Form
    {
        public Datra()
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
            string query = "select * from datra()";
            dgvdatra.DataSource = getData(query).Tables[0];
        }
        public void SearchByKey(string query, string value)
        {

            query = query + "N'%" + value + "%'";
            DataTable data = Models.Connection.SeachInDataBase(query);
            if (data.Rows.Count == 0) MessageBox.Show("Không Tìm Thấy");
            else dgvdatra.DataSource = data;
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
                if (GiaTri == "MaPhieuTra") query = "Select * from datra() where MaPhieuTra like ";
                if (GiaTri == "HoTen") query = "Select * from datra() where HoTen like ";
                if (GiaTri == "MaSach") query = "Select * from datra() where MaSach like ";
                SearchByKey(query, keyRow);
            }
        }
        void design()
        {
            dgvdatra.BorderStyle = BorderStyle.None;
            dgvdatra.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvdatra.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvdatra.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvdatra.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvdatra.BackgroundColor = Color.White;
            dgvdatra.EnableHeadersVisualStyles = false;
            dgvdatra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvdatra.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvdatra.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvdatra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
