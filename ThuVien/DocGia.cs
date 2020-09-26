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
    public partial class DocGia : Form
    {
        
        public DocGia()
        {
            InitializeComponent();
            
        }
       
        private void dgvDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            

        }

        private void DocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connection.close();
        }

        private void dgvDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSVThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {
        }

        private void btnSVLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSVHuy_Click(object sender, EventArgs e)
        {
        }

        private void btnSVXoa_Click(object sender, EventArgs e)
        {
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
