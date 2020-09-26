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
    public partial class FormDangki : Form
    {
        public FormDangki()
        {
            InitializeComponent();
            txtposition.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Nhập Tài Khoản")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Nhập Tài Khoản";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtmk_Enter(object sender, EventArgs e)
        {
            if (txtmk.Text == "Nhập Mật Khẩu")
            {
                txtmk.Text = "";
                txtmk.ForeColor = Color.Black;
                txtmk.UseSystemPasswordChar = true;
            }
        }

        private void txtmk_Leave(object sender, EventArgs e)
        {
            if (txtmk.Text == "")
            {
                txtmk.Text = "Nhập Mật Khẩu";
                txtmk.ForeColor = Color.Black;
                txtmk.UseSystemPasswordChar = false;
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string LoginName = "";
            try
            {
                LoginName = txtuser.Text;
            }
            catch { }
            string Password = "";
            try
            {
                Password = txtmk.Text;
            }
            catch { }        
            if (txtuser.Text != "Nhập Tài Khoản" & txtuser.Text != "")
            {
                if (txtmk.Text != "Nhập Mật Khẩu" & txtmk.Text != "")
                {
                    Models.Taikhoan Tk = new Models.Taikhoan(txtho.Text,txtuser.Text, txtmk.Text, txtposition.Text);
                    var NV = Tk.InsertTaikhoan();
                    if (NV == 0)
                    {                       
                        MessageBox.Show("Tạo Tài Khoản Thấp Bại");
                    }
                    else
                    {
                        MessageBox.Show("Tạo Tài Khoản Thành Công");
                    }
                }
                else msgError2("Bạn Chưa Nhập Mật Khẩu");
                txtuser.Focus();
            }
            else msgError1("Bạn Chưa Nhập Tài Khoản");
            txtuser.Focus();
        }
        private void msgError1(string msg)
        {
            sai1.Text = "            " + msg;
            sai1.Visible = true;
        }
        private void msgError2(string msg)
        {
            sai2.Text = "            " + msg;
            sai2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ts = new Form1();
            ts.Show();
            //ts.FormClosed += LogOut;
            this.Hide();
        }
    }
}
