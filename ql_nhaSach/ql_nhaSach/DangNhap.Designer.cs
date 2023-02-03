namespace ql_nhaSach
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.lbl_tenDangNhap = new System.Windows.Forms.Label();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.lbl_matKhap = new System.Windows.Forms.Label();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.btn_nhapLai = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tenDangNhap
            // 
            this.lbl_tenDangNhap.AutoSize = true;
            this.lbl_tenDangNhap.Location = new System.Drawing.Point(12, 136);
            this.lbl_tenDangNhap.Name = "lbl_tenDangNhap";
            this.lbl_tenDangNhap.Size = new System.Drawing.Size(84, 13);
            this.lbl_tenDangNhap.TabIndex = 0;
            this.lbl_tenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Location = new System.Drawing.Point(102, 133);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(170, 20);
            this.txt_tenDangNhap.TabIndex = 1;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(102, 159);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(170, 20);
            this.txt_matKhau.TabIndex = 3;
            this.txt_matKhau.UseSystemPasswordChar = true;
            // 
            // lbl_matKhap
            // 
            this.lbl_matKhap.AutoSize = true;
            this.lbl_matKhap.Location = new System.Drawing.Point(12, 162);
            this.lbl_matKhap.Name = "lbl_matKhap";
            this.lbl_matKhap.Size = new System.Drawing.Size(53, 13);
            this.lbl_matKhap.TabIndex = 2;
            this.lbl_matKhap.Text = "Mật Khẩu";
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Location = new System.Drawing.Point(54, 202);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_dangNhap.TabIndex = 4;
            this.btn_dangNhap.Text = "Đăng Nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // btn_nhapLai
            // 
            this.btn_nhapLai.Location = new System.Drawing.Point(145, 202);
            this.btn_nhapLai.Name = "btn_nhapLai";
            this.btn_nhapLai.Size = new System.Drawing.Size(75, 23);
            this.btn_nhapLai.TabIndex = 5;
            this.btn_nhapLai.Text = "Nhập Lại";
            this.btn_nhapLai.UseVisualStyleBackColor = true;
            this.btn_nhapLai.Click += new System.EventHandler(this.btn_nhapLai_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1250, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_nhapLai);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.lbl_matKhap);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.lbl_tenDangNhap);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tenDangNhap;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.Label lbl_matKhap;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Button btn_nhapLai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}