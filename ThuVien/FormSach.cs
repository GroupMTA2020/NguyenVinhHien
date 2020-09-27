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
            if (searchChoice_cbx.SelectedIndex == 0)// ma sach
            {
                //do something
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachById(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Enter Masach to search, Please.");
                }

            }
            else if (searchChoice_cbx.SelectedIndex == 1)// ten sach
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByName(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Enter Tensach to search, Please.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 2)// tac gia
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByAuthor(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Enter Tacgia to search, Please.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 3)// the loai    
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByType(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Enter Theloai to search, Please.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 4)// nha xuat ban
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByPubliser(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Enter Nhaxuatban to search, Please.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 5)// gia sach
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByPrice(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Enter Price to search, Please.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 6)//so luong
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByAmount(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Enter Soluong to search, Please.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 7)// tinh trang
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByState(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Enter Tinhtrang to search, Please.");
                }
            }
            else
            {
                MessageBox.Show("Enter Info to search, Please.");
            }
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
