using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ql_nhaSach
{
    public partial class form03_nv_thuNgan : Form
    {
        DataTable dtable;
        SqlConnection connsql = new SqlConnection(@"Data Source=ANHTUAN-PC\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");


        public form03_nv_thuNgan()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void form03_nv_thuNgan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void load_tennv()
        {
            //string select_string = "select * from DangNhap where username!='admin' AND password != 'admin'";
            //SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            //DataTable dtable = new DataTable();
            //sda.Fill(dtable);
            //cbo_nv.DataSource = dtable;
            //cbo_nv.DisplayMember = "username";
            //cbo_nv.ValueMember = "username";
            
        }

        public void load_cbo_maSach()
        {
            string select_string = "select * from Sach";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable_1 = new DataTable();
            sda.Fill(dtable_1);
            cbo_maSach.DataSource = dtable_1;
            cbo_maSach.DisplayMember = "MaSach";
            cbo_maSach.ValueMember = "MaSach";


            cbo_maSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_maSach.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        public void load_solg_donGia()
        {
            string select_string = "select SoLuong, DonGia from Sach where MaSach = '" + cbo_maSach.SelectedValue.ToString() + "'";

            connsql.Open();
            SqlCommand cmd = new SqlCommand(select_string, connsql);
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                txt_donGia.Text = sdr["DonGia"].ToString();
            }
            connsql.Close();


        }



        public void load_hd()
        {
            string select_string = "select * from HoaDon";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            cbo_maHD.DataSource = dtable;
            cbo_maHD.DisplayMember = "SoHD";
            cbo_maHD.ValueMember = "SoHD";
        }

        public void load_ct_hoaDon()
        {
            string select_string = "select * from CT_HoaDon where SoHD = '" + cbo_maHD.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGV_hoaDon.DataSource = dtable;
        }

        private void form03_nv_thuNgan_Load(object sender, EventArgs e)
        {

            txt_nv.Text = DangNhap.nameVar;

            load_cbo_maSach();
            load_solg_donGia();
            load_hd();
            //load_tennv();
        }

        private void cbo_maSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_solg_donGia();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from CT_HoaDon";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataRow new_row = dtable.NewRow();
                new_row["SoHD"] = cbo_maHD.SelectedValue.ToString();
                new_row["MaSach"] = cbo_maSach.SelectedValue.ToString();
                new_row["SoLuong"] = txt_soLuong.Text;
                new_row["DonGia"] = txt_donGia.Text;

                dtable.Rows.Add(new_row);

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                load_ct_hoaDon();



                MessageBox.Show("Thêm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại.");
            }



        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_maHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_ct_hoaDon();
        }

        private void btn_tinhTong_Click(object sender, EventArgs e)
        {
            string select_string = "select sum(DonGia*SoLuong) as thanhtien from CT_HoaDon";

            connsql.Open();
            SqlCommand cmd = new SqlCommand(select_string, connsql);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txt_tongCong.Text = sdr["thanhtien"].ToString();
            }
            connsql.Close();
                      
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from HoaDon";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow find_row = dtable.Rows.Find(cbo_maHD.SelectedValue.ToString());
                if (find_row != null)
                {
                    find_row["Tong"] = txt_tongCong.Text;
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Lưu dữ liệu thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại.");
            }
            
        }

        private void btn_taoHD_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from HoaDon";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow find_row = dtable.Rows.Find(txt_maHD.Text);
                if (find_row != null)
                {
                    MessageBox.Show("Mã hóa đơn bị trùng.");
                }
                else
                {
                    DataRow new_row = dtable.NewRow();
                    new_row["SoHD"] = txt_maHD.Text;
                    new_row["NgayLapHD"] = date_ngayNhap.Value.Date.ToString();
                    new_row["MaNV"] = txt_nv.Text;

                    dtable.Rows.Add(new_row);
                    MessageBox.Show("Thêm hóa đơn thành công.");

                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                load_hd();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm hóa đơn thất bại.");
            }

          
        }



        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from CT_HoaDon";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[2];
                key[0] = dtable.Columns[0];
                key[1] = dtable.Columns[1];
                dtable.PrimaryKey = key;

                object[] bc = new object[2] { cbo_maHD.SelectedValue.ToString(), cbo_maSach.Text };

                DataRow find_rows = dtable.Rows.Find(bc);
                if (find_rows != null)
                {
                    find_rows.Delete();
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                load_ct_hoaDon();



                MessageBox.Show("Xóa thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại.");
            }
        }


        private void dataGV_hoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGV_hoaDon.CurrentRow != null)
            {
                txt_soLuong.Text = dataGV_hoaDon.CurrentRow.Cells[2].Value.ToString();
                cbo_maSach.Text = dataGV_hoaDon.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string select_string = "select * from CT_HoaDon";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            DataColumn[] key = new DataColumn[2];
            key[0] = dtable.Columns[0];
            key[1] = dtable.Columns[1];
            dtable.PrimaryKey = key;

            object[] bc = new object[2] { cbo_maHD.SelectedValue.ToString(), cbo_maSach.Text };

            DataRow find_rows = dtable.Rows.Find(bc);
            if (find_rows != null)
            {
                find_rows["SoLuong"] = txt_soLuong.Text;
            }

            SqlCommandBuilder cB = new SqlCommandBuilder(sda);
            sda.Update(dtable);

            load_ct_hoaDon();
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();

            this.Hide();
        }


    }
}
