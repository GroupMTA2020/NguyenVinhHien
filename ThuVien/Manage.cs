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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            customizeDesing();
            label3.Text = Taikhoan.Tendangnhap;
            label4.Text = Taikhoan.Quyen;


        }
        private void customizeDesing()
        {
            panQLP.Visible = false;
            pnQLS.Visible = false;
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panQLP.Visible == true)
            {
                panQLP.Visible = false;
            }
        }
        private void hideSubmenuQL()
        {
            if (pnQLS.Visible == true)
            {
                pnQLS.Visible = false;
            }
        }
        private void AbrirFormEnPanel(object Formijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = Formijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }
        private void btnphieu_Click(object sender, EventArgs e)
        {
            showSubmenu(panQLP);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            AbrirFormEnPanel(new FormPhieuTra());
        }

        private void btnphieumuon_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            AbrirFormEnPanel(new FormQLPhieuMuon());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubmenuQL();
            AbrirFormEnPanel(new Datra());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubmenuQL();
            AbrirFormEnPanel(new Dangmuon());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubmenu(pnQLS);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new DocGia());
        }

        private void btnsach_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormSach());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormTaiKhoan());
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            if ( Taikhoan.Quyen == Quyentruy.User)
            {
                btndocgia.Visible = false;
                btntaikhoan.Visible = false;
                btnphieu.Visible = false;
            }
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
