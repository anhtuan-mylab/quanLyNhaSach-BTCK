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
using System.Windows.Forms.DataVisualization.Charting;

namespace ql_nhaSach
{
    public partial class form01_admin_02 : Form
    {
        SqlConnection connsql;

        public form01_admin_02()
        {
            InitializeComponent();

            connsql = new SqlConnection(@"Data Source=ANHTUAN-PC\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");

        }

        private void txt_maSach_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Vui lòng nhập mã sách.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }


        #region TAB_Sach 

        public void load_tg()
        {


            string select_string = "select * from TacGia";

            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);

            DataTable dtable = new DataTable();

            sda.Fill(dtable);

            grid_tacGia.DataSource = dtable;


        }

        public void load_nxb()
        {


            string select_string = "select * from NhaXuatBan";

            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);

            DataTable dtable = new DataTable();

            sda.Fill(dtable);

            grid_nxb.DataSource = dtable;

        }

        public void load_sach_all()
        {


            string select_string = "select * from Sach";

            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);

            DataTable dtable = new DataTable();

            sda.Fill(dtable);

            grid_sach.DataSource = dtable;

            
        }

        public void load_sach_loc()
        {


            string select_string_loc = "select * from Sach,TacGia,NhaXuatBan where (Sach.MaTacGia=TacGia.MaTacGia AND Sach.MaNhaSanXuat=NhaXuatBan.MaNhaXuatBan) AND Sach.MaTacGia= '" + cbo_tacGia.SelectedValue + "' AND Sach.MaNhaSanXuat= '" + cbo_nhaXuatBan.SelectedValue + "'";

            SqlDataAdapter sda_loc = new SqlDataAdapter(select_string_loc, connsql);

            DataTable dtable = new DataTable();

            sda_loc.Fill(dtable);

            grid_sach.DataSource = dtable;
        }

        public void load_cbo_tacGia()
        {
            string select_cbo_tacgia = "select * from TacGia";
            SqlDataAdapter sda_cbo_tacgia = new SqlDataAdapter(select_cbo_tacgia, connsql);
            DataTable dtable_cbo_tacgia = new DataTable();
            sda_cbo_tacgia.Fill(dtable_cbo_tacgia);

            cbo_tacGia.DataSource = dtable_cbo_tacgia;
            cbo_tacGia.DisplayMember = "TenTacGia";
            cbo_tacGia.ValueMember = "MaTacGia";

            DataRow new_row = dtable_cbo_tacgia.NewRow();
            new_row["TenTacGia"] = "Chon tat ca";
            dtable_cbo_tacgia.Rows.Add(new_row);

            cbo_tacGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_tacGia.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbo_tacGia.SelectedIndex = cbo_tacGia.Items.Count - 1;

        }

        public void load_cbo_nxb()
        {
            string select_cbo_nxb = "select * from NhaXuatBan";
            SqlDataAdapter sda_nxb = new SqlDataAdapter(select_cbo_nxb, connsql);
            DataTable dtable_cbo_nxb = new DataTable();
            sda_nxb.Fill(dtable_cbo_nxb);

            cbo_nhaXuatBan.DataSource = dtable_cbo_nxb;
            cbo_nhaXuatBan.DisplayMember = "TenNhaXuatBan";
            cbo_nhaXuatBan.ValueMember = "MaNhaXuatBan";



            DataRow new_row = dtable_cbo_nxb.NewRow();
            new_row["TenNhaXuatBan"] = "Chon tat ca.";
            dtable_cbo_nxb.Rows.Add(new_row);

            cbo_nhaXuatBan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_nhaXuatBan.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbo_nhaXuatBan.SelectedIndex = cbo_nhaXuatBan.Items.Count - 1;

        }

        public void load_sach_tg_all()
        {
            string select_string = "select * from Sach,TacGia,NhaXuatBan where (Sach.MaTacGia=TacGia.MaTacGia AND Sach.MaNhaSanXuat=NhaXuatBan.MaNhaXuatBan) AND Sach.MaTacGia= '" + cbo_tacGia.SelectedValue + "'";

            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            grid_sach.DataSource = dtable;
        }

        public void load_sach_all_nxb()
        {
            string select_string = "select * from Sach,TacGia,NhaXuatBan where (Sach.MaTacGia=TacGia.MaTacGia AND Sach.MaNhaSanXuat=NhaXuatBan.MaNhaXuatBan) AND Sach.MaNhaSanXuat= '" + cbo_nhaXuatBan.SelectedValue + "'";
            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            grid_sach.DataSource = dtable;
        }

        private void form01_admin_02_Load(object sender, EventArgs e)
        {


            load_tg();
            load_nxb();


            if (cbo_tacGia.SelectedIndex == (cbo_tacGia.Items.Count - 1) && (cbo_nhaXuatBan.SelectedIndex == cbo_nhaXuatBan.Items.Count - 1))
            {
                load_sach_all();
            }

            load_cbo_tacGia();
            load_cbo_nxb();

        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            if (cbo_tacGia.SelectedIndex == (cbo_tacGia.Items.Count - 1) && (cbo_nhaXuatBan.SelectedIndex == cbo_nhaXuatBan.Items.Count - 1))
            {
                load_sach_all();
            }
            
            else if (cbo_nhaXuatBan.SelectedIndex == (cbo_nhaXuatBan.Items.Count -1))
            {
                load_sach_tg_all();
            }

            else if (cbo_tacGia.SelectedIndex == (cbo_tacGia.Items.Count - 1))
            {
                load_sach_all_nxb();
            }
            
            else
            {
                load_sach_loc();
            }

        }

        #region tg_
        private void btn_nhap_TG_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from Tacgia";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow kt_trung = dtable.Rows.Find(txt_maTacGia.Text);

                if (kt_trung != null)
                {
                    MessageBox.Show("Nhập tên tác giả bị trùng.");
                }
                else
                {
                    DataRow new_row = dtable.NewRow();
                    new_row["MaTacGia"] = txt_maTacGia.Text;
                    new_row["TenTacGia"] = txt_tenTacGia.Text;

                    dtable.Rows.Add(new_row);
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã thêm thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã thêm thất bại.");
            }

            load_cbo_tacGia();
            load_tg();





        }

        private void btn_xoa_TG_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from Tacgia";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow d_row = dtable.Rows.Find(txt_maTacGia.Text);

                if (d_row != null)
                {
                    d_row.Delete();
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã xóa thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xóa thất bại.");
            }

            load_cbo_tacGia();
            load_tg();



        }

        private void btn_chinhSua_TG_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from Tacgia";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow d_row = dtable.Rows.Find(txt_maTacGia.Text);

                if (d_row != null)
                {
                    d_row["TenTacGia"] = txt_tenTacGia.Text;
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã sửa thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã sửa thất bại.");
            }

            load_cbo_tacGia();
            load_tg();
        }
        #endregion


        #region nhan_thay_doi
        private void grid_tacGia_SelectionChanged(object sender, EventArgs e)
        {
            if (grid_tacGia.CurrentRow != null)
            {
                txt_maTacGia.Text = grid_tacGia.CurrentRow.Cells[0].Value.ToString();
                txt_tenTacGia.Text = grid_tacGia.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void grid_nxb_SelectionChanged(object sender, EventArgs e)
        {
            if (grid_nxb.CurrentRow != null)
            {
                txt_maNXB.Text = grid_nxb.CurrentRow.Cells[0].Value.ToString();
                txt_tenNXB.Text = grid_nxb.CurrentRow.Cells[1].Value.ToString();
            }
        }

        #endregion

        #region nxb_nut
        private void btn_nhap_NXB_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from NhaXuatBan";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow kt_trung = dtable.Rows.Find(txt_maNXB.Text);

                if (kt_trung != null)
                {
                    MessageBox.Show("Nhập tên nhà xuất bản bị trùng.");
                }
                else
                {
                    DataRow new_row = dtable.NewRow();
                    new_row["MaNhaXuatBan"] = txt_maNXB.Text;
                    new_row["TenNhaXuatBan"] = txt_tenNXB.Text;

                    dtable.Rows.Add(new_row);
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã thêm thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã thêm thất bại.");
            }

            load_cbo_nxb();
            load_nxb();
        }

        private void btn_xoa_NXB_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from NhaXuatBan";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow d_row = dtable.Rows.Find(txt_maNXB.Text);

                if (d_row != null)
                {
                    d_row.Delete();
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã xóa thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xóa thất bại.");
            }

            load_cbo_nxb();
            load_nxb();
        }

        private void btn_chinhSua_NXB_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from NhaXuatBan";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow d_row = dtable.Rows.Find(txt_maNXB.Text);

                if (d_row != null)
                {
                    d_row["TenNhaXuatBan"] = txt_tenNXB.Text;
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã sửa thành công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã sửa thất bại.");
            }

            load_cbo_nxb();
            load_nxb();
        }



        #endregion

        #region sah_nhap_chihSua_xoa



        #endregion



        private void btn_nhap_Sach_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from Sach";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow kt_trung = dtable.Rows.Find(txt_maSach.Text);

                if (kt_trung != null)
                {
                    MessageBox.Show("Nhập tên sách bị trùng.");
                }
                else
                {
                    DataRow new_row = dtable.NewRow();
                    new_row["MaSach"] = txt_maSach.Text;
                    new_row["TenSach"] = txt_tenSach.Text;
                    new_row["MaTacGia"] = cbo_tacGia.SelectedValue.ToString();
                    new_row["MaNhaSanXuat"] = cbo_nhaXuatBan.SelectedValue.ToString();
                    new_row["TheLoai"] = txt_theLoai.Text;
                    new_row["SoLuong"] = txt_soLuong.Text;
                    new_row["DonGia"] = txt_donGia.Text;

                    dtable.Rows.Add(new_row);
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã thêm thành công.");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã thêm thất bại.");
            }

        }

        private void btn_chinhSua_Sach_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from Sach";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;


                DataRow kt_trung = dtable.Rows.Find(txt_maSach.Text);

                if (kt_trung != null)
                {
                    kt_trung["TenSach"] = txt_tenSach.Text;
                    kt_trung["MaTacGia"] = cbo_tacGia.SelectedValue.ToString();
                    kt_trung["MaNhaSanXuat"] = cbo_nhaXuatBan.SelectedValue.ToString();
                    kt_trung["TheLoai"] = txt_theLoai.Text;
                    kt_trung["SoLuong"] = txt_soLuong.Text;
                    kt_trung["DonGia"] = txt_donGia.Text;
                }
               

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã Chỉnh sửa thành công.");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Chỉnh sửa thất bại.");
            }
        }

        private void grid_sach_SelectionChanged(object sender, EventArgs e)
        {
            if (grid_sach.CurrentRow != null)
            {
                txt_maSach.Text = grid_sach.CurrentRow.Cells[0].Value.ToString();
                txt_tenSach.Text = grid_sach.CurrentRow.Cells[1].Value.ToString();
                cbo_tacGia.SelectedValue = grid_sach.CurrentRow.Cells[2].Value.ToString();
                cbo_nhaXuatBan.SelectedValue = grid_sach.CurrentRow.Cells[3].Value.ToString();
                txt_theLoai.Text = grid_sach.CurrentRow.Cells[4].Value.ToString();
                txt_soLuong.Text = grid_sach.CurrentRow.Cells[5].Value.ToString();
                txt_donGia.Text = grid_sach.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btn_xoa_Sach_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select * from Sach";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataColumn[] key = new DataColumn[1];
                key[0] = dtable.Columns[0];
                dtable.PrimaryKey = key;

                DataRow kt_trung = dtable.Rows.Find(txt_maSach.Text);

                if (kt_trung != null)
                {
                    kt_trung.Delete();
                }

                SqlCommandBuilder cB = new SqlCommandBuilder(sda);
                sda.Update(dtable);

                MessageBox.Show("Đã Xóa thành công.");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Xóa thất bại.");
            }


        }

        private void btn_taiLai_Click(object sender, EventArgs e)
        {
            load_sach_all();
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            txt_maSach.Clear();
            txt_tenSach.Clear();
            txt_donGia.Clear();
            txt_soLuong.Clear();
            txt_theLoai.Clear();
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void btn_nhapLai_Click(object sender, EventArgs e)
        {
            txt_nhapNoiDung.Clear();
        }

        private void form01_admin_02_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        #endregion


        #region TAB_TraCuu 
        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            string select_string_tacgia = "select * from Sach,TacGia,NhaXuatBan where Sach.MaTacGia=TacGia.MaTacGia AND Sach.MaNhaSanXuat=NhaXuatBan.MaNhaXuatBan AND (TacGia.MaTacGia = '" + txt_nhapNoiDung.Text + "' OR TacGia.TenTacGia = '" + txt_nhapNoiDung.Text + "')";


            SqlDataAdapter sda = new SqlDataAdapter(select_string_tacgia, connsql);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);



            string select_string_sach = "select * from Sach,TacGia,NhaXuatBan where Sach.MaTacGia=TacGia.MaTacGia AND Sach.MaNhaSanXuat=NhaXuatBan.MaNhaXuatBan AND (Sach.MaSach = '" + txt_nhapNoiDung.Text + "' OR Sach.TenSach = '" + txt_nhapNoiDung.Text + "')";
            SqlDataAdapter sda_sach = new SqlDataAdapter(select_string_sach, connsql);
            DataTable dtable_sach = new DataTable();
            sda_sach.Fill(dtable_sach);

            string select_string_nxb = "select * from Sach,TacGia,NhaXuatBan where Sach.MaTacGia=TacGia.MaTacGia AND Sach.MaNhaSanXuat=NhaXuatBan.MaNhaXuatBan AND (MaNhaXuatBan = '" + txt_nhapNoiDung.Text + "' OR TenNhaXuatBan = '" + txt_nhapNoiDung.Text + "')";
            SqlDataAdapter sda_nxb = new SqlDataAdapter(select_string_nxb, connsql);
            DataTable dtable_nxb = new DataTable();
            sda_nxb.Fill(dtable_nxb);

            if (rdo_tacGia.Checked == true)
            {
                grid_timKiem.DataSource = dtable;
            }

            if (rdo_nhaXuatBan.Checked == true)
            {
                grid_timKiem.DataSource = dtable_nxb;
            }

            if (rdo_sach.Checked == true)
            {
                grid_timKiem.DataSource = dtable_sach;
            }


        }

        #endregion 

        #region TAB_Trang_chủ (Thống kê) 

        private void btn_thongKe_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select NgayLapHD, COUNT(SoHD) as SoHoaDon from HoaDon where NgayLapHD >= '" + date_ngayBD.Value.Date.ToString("d") + "'" + " AND NgayLapHD <= '" + date_ngayKT.Value.Date.ToString("d") + "'" + " GROUP BY NgayLapHD";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                grid_thongKENgay.DataSource = dtable;

                chart1.Titles.Add("Thống kê số đơn hàng theo ngày.");

                chart1.Series.Add("Số Hóa Đơn");
                chart1.Series["Số Hóa Đơn"].XValueMember = "NgayLapHD";
                chart1.Series["Số Hóa Đơn"].YValueMembers = "SoHoaDon";
                //Đưa số hiệu lên bên trên mỗi cột.
                chart1.Series["Số Hóa Đơn"].IsValueShownAsLabel = true;
                //Xóa mấy cái đường kẻ trong sơ đồ.
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                //Đẩy dữ liệu từ Datagrid vào table.
                chart1.DataSource = dtable;
                chart1.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công ! Vui lòng bấm nút tải lại.");
            }





            
        }

        private void btn_thongKeTT_Click(object sender, EventArgs e)
        {
            try
            {
                string select_string = "select NgayLapHD, COUNT(SoHD) as SoHoaDon, SUM(Tong) as tongtien from HoaDon where NgayLapHD >= '" + date_ngayBD_tt.Value.Date.ToString("d") + "'" + " AND NgayLapHD <= '" + date_ngayKT_tt.Value.Date.ToString("d") + "'" + " GROUP BY NgayLapHD";
                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                grid_tongTien.DataSource = dtable;

                chart_tongTien.Titles.Add("Thống kê tổng tiền theo ngày.");

                chart_tongTien.Series.Add("Tổng tiền");
                chart_tongTien.Series["Tổng tiền"].XValueMember = "NgayLapHD";
                chart_tongTien.Series["Tổng tiền"].YValueMembers = "tongtien";
                //Đưa số hiệu lên bên trên mỗi cột.
                chart_tongTien.Series["Tổng tiền"].IsValueShownAsLabel = true;
                //Xóa mấy cái đường kẻ trong sơ đồ.
                chart_tongTien.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart_tongTien.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                //Đẩy dữ liệu từ Datagrid vào table.
                chart_tongTien.DataSource = dtable;
                chart_tongTien.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công ! Vui lòng bấm nút tải lại.");
            }
            





        }

        private void btn_refresh_grid_tongtien_Click(object sender, EventArgs e)
        {
            grid_tongTien.DataSource = null;
            chart_tongTien.Series.RemoveAt(0);
            chart_tongTien.Titles.RemoveAt(0);
        }

        private void btn_taiLai_grid_soHD_Click(object sender, EventArgs e)
        {
            grid_thongKENgay.DataSource = null;
            chart1.Series.RemoveAt(0);
            chart1.Titles.RemoveAt(0);
        }

        #endregion 

        



        



    }
}
