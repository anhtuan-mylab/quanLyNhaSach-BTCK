namespace ql_nhaSach
{
    partial class form03_nv_thuNgan
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_nv = new System.Windows.Forms.TextBox();
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_maHD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_maSach = new System.Windows.Forms.ComboBox();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGV_hoaDon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tongCong = new System.Windows.Forms.TextBox();
            this.btn_tinhTong = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.date_ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_taoHD = new System.Windows.Forms.Button();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_hoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thu ngân : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.txt_nv);
            this.panel1.Controls.Add(this.btn_dangXuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 44);
            this.panel1.TabIndex = 2;
            // 
            // txt_nv
            // 
            this.txt_nv.Location = new System.Drawing.Point(97, 11);
            this.txt_nv.Name = "txt_nv";
            this.txt_nv.ReadOnly = true;
            this.txt_nv.Size = new System.Drawing.Size(125, 20);
            this.txt_nv.TabIndex = 4;
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.Location = new System.Drawing.Point(563, 9);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Size = new System.Drawing.Size(75, 23);
            this.btn_dangXuat.TabIndex = 2;
            this.btn_dangXuat.Text = "Đăng xuất";
            this.btn_dangXuat.UseVisualStyleBackColor = true;
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_maHD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbo_maSach);
            this.groupBox1.Controls.Add(this.txt_donGia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_soLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // cbo_maHD
            // 
            this.cbo_maHD.FormattingEnabled = true;
            this.cbo_maHD.Location = new System.Drawing.Point(114, 22);
            this.cbo_maHD.Name = "cbo_maHD";
            this.cbo_maHD.Size = new System.Drawing.Size(237, 21);
            this.cbo_maHD.TabIndex = 11;
            this.cbo_maHD.SelectedIndexChanged += new System.EventHandler(this.cbo_maHD_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã hóa đơn :";
            // 
            // cbo_maSach
            // 
            this.cbo_maSach.FormattingEnabled = true;
            this.cbo_maSach.Location = new System.Drawing.Point(114, 47);
            this.cbo_maSach.Name = "cbo_maSach";
            this.cbo_maSach.Size = new System.Drawing.Size(237, 21);
            this.cbo_maSach.TabIndex = 9;
            this.cbo_maSach.SelectedIndexChanged += new System.EventHandler(this.cbo_maSach_SelectedIndexChanged);
            // 
            // txt_donGia
            // 
            this.txt_donGia.Location = new System.Drawing.Point(482, 48);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.ReadOnly = true;
            this.txt_donGia.Size = new System.Drawing.Size(122, 20);
            this.txt_donGia.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đơn giá :";
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(482, 22);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(122, 20);
            this.txt_soLuong.TabIndex = 3;
            this.txt_soLuong.TextChanged += new System.EventHandler(this.txt_soLuong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách :";
            // 
            // dataGV_hoaDon
            // 
            this.dataGV_hoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_hoaDon.Location = new System.Drawing.Point(13, 277);
            this.dataGV_hoaDon.Name = "dataGV_hoaDon";
            this.dataGV_hoaDon.Size = new System.Drawing.Size(630, 200);
            this.dataGV_hoaDon.TabIndex = 4;
            this.dataGV_hoaDon.SelectionChanged += new System.EventHandler(this.dataGV_hoaDon_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng cộng :";
            // 
            // txt_tongCong
            // 
            this.txt_tongCong.Location = new System.Drawing.Point(80, 486);
            this.txt_tongCong.Name = "txt_tongCong";
            this.txt_tongCong.ReadOnly = true;
            this.txt_tongCong.Size = new System.Drawing.Size(241, 20);
            this.txt_tongCong.TabIndex = 6;
            // 
            // btn_tinhTong
            // 
            this.btn_tinhTong.Location = new System.Drawing.Point(567, 484);
            this.btn_tinhTong.Name = "btn_tinhTong";
            this.btn_tinhTong.Size = new System.Drawing.Size(75, 23);
            this.btn_tinhTong.TabIndex = 7;
            this.btn_tinhTong.Text = "Tính tổng";
            this.btn_tinhTong.UseVisualStyleBackColor = true;
            this.btn_tinhTong.Click += new System.EventHandler(this.btn_tinhTong_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(380, 19);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(119, 23);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(255, 19);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(119, 23);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(130, 19);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(119, 23);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(14, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 57);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.date_ngayNhap);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_taoHD);
            this.groupBox3.Controls.Add(this.txt_maHD);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(15, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 60);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tạo hóa đơn";
            // 
            // date_ngayNhap
            // 
            this.date_ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngayNhap.Location = new System.Drawing.Point(293, 19);
            this.date_ngayNhap.Name = "date_ngayNhap";
            this.date_ngayNhap.Size = new System.Drawing.Size(205, 20);
            this.date_ngayNhap.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày nhập :";
            // 
            // btn_taoHD
            // 
            this.btn_taoHD.Location = new System.Drawing.Point(516, 17);
            this.btn_taoHD.Name = "btn_taoHD";
            this.btn_taoHD.Size = new System.Drawing.Size(97, 23);
            this.btn_taoHD.TabIndex = 14;
            this.btn_taoHD.Text = "Tạo hóa đơn";
            this.btn_taoHD.UseVisualStyleBackColor = true;
            this.btn_taoHD.Click += new System.EventHandler(this.btn_taoHD_Click);
            // 
            // txt_maHD
            // 
            this.txt_maHD.Location = new System.Drawing.Point(83, 19);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.Size = new System.Drawing.Size(125, 20);
            this.txt_maHD.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã hóa đơn :";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(486, 484);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 14;
            this.btn_luu.Text = "Lưu dữ liệu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // form03_nv_thuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 519);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_tinhTong);
            this.Controls.Add(this.txt_tongCong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGV_hoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "form03_nv_thuNgan";
            this.Text = "form03_nv_thuNgan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form03_nv_thuNgan_FormClosing);
            this.Load += new System.EventHandler(this.form03_nv_thuNgan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_hoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGV_hoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tongCong;
        private System.Windows.Forms.Button btn_tinhTong;
        private System.Windows.Forms.Button btn_dangXuat;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_maSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_ngayNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_taoHD;
        private System.Windows.Forms.ComboBox cbo_maHD;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txt_nv;
    }
}