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
    public partial class DangNhap : Form
    {
        SqlConnection connsql;


        public static string nameVar;

        public DangNhap()
        {
            InitializeComponent();

            connsql = new SqlConnection(@"Data Source=ANHTUAN-PC\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");

        }

        



        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txt_tenDangNhap.Text;
            password = txt_matKhau.Text;

            connsql.Open();

            try
            {
                string select_string = "select * from DangNhap where username = '" + txt_tenDangNhap.Text + "' AND password = '" + txt_matKhau.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(select_string, connsql);

                DataTable dtable = new DataTable();

                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_tenDangNhap.Text;
                    password = txt_tenDangNhap.Text;

                    // Đưa cái bảng tiếp theo vào.

                    if (txt_tenDangNhap.Text == "admin" && txt_matKhau.Text == "admin")
                    {
                        //MessageBox.Show("Bang cho admin.");
                        form01_admin_02 form_admin = new form01_admin_02();
                        form_admin.Show();
                        this.Hide();

                    }

                    else
                    {
                        //MessageBox.Show("Bang cho nhan vien.");
                        nameVar = txt_tenDangNhap.Text;
                        form03_nv_thuNgan form_nvthungan = new form03_nv_thuNgan();
                        form_nvthungan.Show();
                        this.Hide();

                        
                        
                        
                        
                    }
                }
                else
                {
                    MessageBox.Show("Ten Dang Nhap hay Mat Khau sai.");
                    txt_tenDangNhap.Clear();
                    txt_matKhau.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại.");
            }
            finally
            {
                connsql.Close();
            }
        }

        private void btn_nhapLai_Click(object sender, EventArgs e)
        {
            txt_tenDangNhap.Clear();
            txt_matKhau.Clear();
        }



        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
