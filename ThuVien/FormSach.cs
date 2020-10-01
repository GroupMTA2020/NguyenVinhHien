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
            design();
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
            if(searchChoice_cbx.SelectedIndex == 0)// ma sach
            {
                //do something
                if( txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachById(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Enter Masach to search, Please.");
                }

            }
            else if( searchChoice_cbx.SelectedIndex == 1)// ten sach
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
            else if(searchChoice_cbx.SelectedIndex == 2)// tac gia
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
            else if( searchChoice_cbx.SelectedIndex == 3)// the loai    
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
            else if(searchChoice_cbx.SelectedIndex == 4)// nha xuat ban
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
            else if( searchChoice_cbx.SelectedIndex == 5)// gia sach
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
            else if(searchChoice_cbx.SelectedIndex == 6)//so luong
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
            else if(searchChoice_cbx.SelectedIndex == 7)// tinh trang
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
            Save_btn.Tag = "ADD";
            txtmasach.Text = "MS" + dtgvSach.Rows.Count.ToString("0000");
            btnReload();
            textBoxChangeState();
        }
        public void textBoxChangeState()
        {
            txtmasach.Enabled = txttensach.Enabled = txttacgia.Enabled 
                = txttheloai.Enabled = txtnhaxuatban.Enabled = txtgiasach.Enabled
                = nb_SoLuong.Enabled = txttinhtrang.Enabled = !txtmasach.Enabled;
        }
        void btnReload()
        {
            Repair_btn.Visible = Remove_btn.Visible =
                Add_btn.Visible = !Add_btn.Visible;
            Save_btn.Visible = Cancel_btn.Visible = !Save_btn.Visible;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (Save_btn.Tag.ToString() == "ADD")
            {
                Sach s = new Sach(txtmasach.Text, txttensach.Text, txttacgia.Text,txttheloai.Text
                                ,txtnhaxuatban.Text,Convert.ToInt32(txtgiasach.Text),Convert.ToInt32(nb_SoLuong.Value),txttinhtrang.Text);
                var i = s.insertSach();
                if (i == 0)
                {
                    MessageBox.Show("Add not success.");
                }
                else
                {
                    MessageBox.Show("Add success.");
                    showTableSach();
                }
                btnReload();
                textBoxChangeState();
            }
            else if (Save_btn.Tag.ToString() == "Repair")
            {
                Sach s = new Sach(txtmasach.Text, txttensach.Text, txttacgia.Text, txttheloai.Text
                                , txtnhaxuatban.Text, Convert.ToInt32(txtgiasach.Text), Convert.ToInt32(nb_SoLuong.Value), txttinhtrang.Text);
                int i = s.updateBook();
                if (i == 0)
                    MessageBox.Show("update not success.");
                else
                {
                    MessageBox.Show("update success.");
                    showTableSach();
                }
                txtmasach.Enabled = !txtmasach.Enabled;
                btnReload();
                textBoxChangeState();
            }
        }

        private void Repair_Click(object sender, EventArgs e)
        {
            Save_btn.Tag = "Repair";
            btnReload();
            textBoxChangeState();
            txtmasach.Enabled = !txtmasach.Enabled;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            btnReload();
            textBoxChangeState();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text != "")
            {
                Sach s = new Sach(txtmasach.Text);
                var i = s.deleteBook();
                if (i > 0)
                { 
                    showTableSach(); 
                }
                else MessageBox.Show("Delete Not Success");
            }
            else { MessageBox.Show("Choose a Row to Remove."); }
        }
        void design()
        {
            dtgvSach.BorderStyle = BorderStyle.None;
            dtgvSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgvSach.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvSach.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtgvSach.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgvSach.BackgroundColor = Color.White;
            dtgvSach.EnableHeadersVisualStyles = false;
            dtgvSach.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgvSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            if(Taikhoan.Quyen == Quyentruy.User)
            {
                Add_btn.Visible = false;
                Repair_btn.Visible = false;
                Save_btn.Visible = false;
                Cancel_btn.Visible = false;
                Remove_btn.Visible = false;
            }
        }
    }
}
