using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.Models;

namespace ThuVien
{
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
            showTableSach();
        }
        public void showTableSach()
        {
            DataTable dataTable = Models.Sach.getListBook();
            dtgvSach.DataSource = dataTable;
        }
        private void dtgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmasach.Text = dtgvSach.Rows[index].Cells["Masach"].Value.ToString();
                txttensach.Text = dtgvSach.Rows[index].Cells["Tensach"].Value.ToString();
                txttacgia.Text = dtgvSach.Rows[index].Cells["Tacgia"].Value.ToString();
                txttheloai.Text = dtgvSach.Rows[index].Cells["Theloai"].Value.ToString();
                txtnhaxuatban.Text = dtgvSach.Rows[index].Cells["Nhaxuatban"].Value.ToString();
                txtgiasach.Text = dtgvSach.Rows[index].Cells["Giasach"].Value.ToString();
                nb_SoLuong.Text = dtgvSach.Rows[index].Cells["Soluong"].Value.ToString();
                txttinhtrang.Text = dtgvSach.Rows[index].Cells["Tinhtrang"].Value.ToString();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
        }

        private void Add_Click(object sender, EventArgs e)
        {
        }
        
        private void Save_Click(object sender, EventArgs e)
        {
            
        }

        private void Repair_Click(object sender, EventArgs e)
        {
           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
           
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            
        }
        

        private void FormSach_Load(object sender, EventArgs e)
        {
           
        }
    }
}
