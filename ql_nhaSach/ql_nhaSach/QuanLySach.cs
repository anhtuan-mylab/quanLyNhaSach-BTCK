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
    public partial class QuanLySach : Form
    {
        SqlConnection connsql;


        public QuanLySach()
        {
            InitializeComponent();

            connsql = new SqlConnection(@"Data Source=ANHTUAN-PC\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");
        }

        public void load_danhSach()
        {
            string select_string = "select * from Sach";

            SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);

            DataTable dtable = new DataTable();

            sda.Fill(dtable);

            int j = 0;

            for (int i = 0; i < dtable.Rows.Count-1; i++)
			{
                ListViewItem item = new ListViewItem();
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();

                item.Text = (j + 1).ToString();
                item.SubItems.Add(dtable.Rows[i].ItemArray[0].ToString());
                item.SubItems.Add(dtable.Rows[i].ItemArray[1].ToString());
                item.SubItems.Add(dtable.Rows[i].ItemArray[2].ToString());
                item.SubItems.Add(dtable.Rows[i].ItemArray[3].ToString());
                item.SubItems.Add(dtable.Rows[i].ItemArray[4].ToString());
                item.SubItems.Add(dtable.Rows[i].ItemArray[5].ToString());
                item.SubItems.Add(dtable.Rows[i].ItemArray[6].ToString());
                item.SubItems.Add(dtable.Rows[i].ItemArray[7].ToString());

                j++;
                list_danhSachSach.Items.Add(item);
			}
        }

        private void QuanLySach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            load_danhSach();
        }

        private void list_danhSachSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_danhSachSach.SelectedItems.Count>0)
            {
                ListViewItem item = list_danhSachSach.SelectedItems[0];

                txt_maSach.Text = item.SubItems[1].Text;
                txt_tenSach.Text = item.SubItems[2].Text;
                txt_tacGia.Text = item.SubItems[3].Text;
                txt_nhaXuatBan.Text = item.SubItems[4].Text;
                txt_theLoai.Text = item.SubItems[5].Text;
                txt_soLuong.Text = item.SubItems[6].Text;
                txt_donGia.Text = item.SubItems[7].Text;
                txt_ngayNhap.Text = item.SubItems[8].Text;

            }
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            
            DangNhap dn = new DangNhap();
            dn.Show();

            this.Hide();
        }
    }
}
