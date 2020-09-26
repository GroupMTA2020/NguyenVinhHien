namespace ThuVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.Iberrormessage = new System.Windows.Forms.Label();
            this.panelpass = new System.Windows.Forms.Panel();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBoxclose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 593);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 87);
            this.button1.TabIndex = 36;
            this.button1.Text = "Đăng Ký";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(36, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(229, 114);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(57, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxclose.Image")));
            this.pictureBoxclose.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(51, 35);
            this.pictureBoxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxclose.TabIndex = 35;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Don\'t have an account ?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btndangnhap);
            this.panel2.Controls.Add(this.Iberrormessage);
            this.panel2.Controls.Add(this.panelpass);
            this.panel2.Controls.Add(this.textBoxpass);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textBoxuser);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(294, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 593);
            this.panel2.TabIndex = 4;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.Black;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.White;
            this.btndangnhap.Location = new System.Drawing.Point(235, 497);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(283, 67);
            this.btndangnhap.TabIndex = 35;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            this.btndangnhap.MouseLeave += new System.EventHandler(this.btndangnhap_MouseLeave);
            this.btndangnhap.MouseHover += new System.EventHandler(this.btndangnhap_MouseHover);
            // 
            // Iberrormessage
            // 
            this.Iberrormessage.AutoSize = true;
            this.Iberrormessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iberrormessage.ForeColor = System.Drawing.Color.Black;
            this.Iberrormessage.Image = ((System.Drawing.Image)(resources.GetObject("Iberrormessage.Image")));
            this.Iberrormessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Iberrormessage.Location = new System.Drawing.Point(177, 418);
            this.Iberrormessage.Name = "Iberrormessage";
            this.Iberrormessage.Size = new System.Drawing.Size(140, 25);
            this.Iberrormessage.TabIndex = 34;
            this.Iberrormessage.Text = "Error Massage";
            this.Iberrormessage.Visible = false;
            // 
            // panelpass
            // 
            this.panelpass.BackColor = System.Drawing.Color.Black;
            this.panelpass.Location = new System.Drawing.Point(182, 388);
            this.panelpass.Name = "panelpass";
            this.panelpass.Size = new System.Drawing.Size(517, 1);
            this.panelpass.TabIndex = 18;
            // 
            // textBoxpass
            // 
            this.textBoxpass.BackColor = System.Drawing.Color.White;
            this.textBoxpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpass.ForeColor = System.Drawing.Color.Black;
            this.textBoxpass.HideSelection = false;
            this.textBoxpass.Location = new System.Drawing.Point(279, 343);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.PasswordChar = '*';
            this.textBoxpass.Size = new System.Drawing.Size(390, 27);
            this.textBoxpass.TabIndex = 17;
            this.textBoxpass.TabStop = false;
            this.textBoxpass.Text = "PassWord";
            this.textBoxpass.Enter += new System.EventHandler(this.textBoxpass_Enter);
            this.textBoxpass.Leave += new System.EventHandler(this.textBoxpass_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(182, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 1);
            this.panel3.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(182, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxuser
            // 
            this.textBoxuser.BackColor = System.Drawing.Color.White;
            this.textBoxuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxuser.ForeColor = System.Drawing.Color.Black;
            this.textBoxuser.HideSelection = false;
            this.textBoxuser.Location = new System.Drawing.Point(279, 251);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(390, 27);
            this.textBoxuser.TabIndex = 31;
            this.textBoxuser.TabStop = false;
            this.textBoxuser.Text = "UsersName";
            this.textBoxuser.Enter += new System.EventHandler(this.textBoxuser_Enter);
            this.textBoxuser.Leave += new System.EventHandler(this.textBoxuser_Leave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(182, 240);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(53, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label Iberrormessage;
        private System.Windows.Forms.Panel panelpass;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.Button button1;
    }
}

