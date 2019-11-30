using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanliBanHang
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void LabelTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDangNhap_Click(object sender, EventArgs e)
        {


            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True");
            try
            {
                connection.Open();      
                string taikhoan = txtTaiKhoan.Text;
                string matkhau = txtMatKhau.Text;
                string query = "select * from TaiKhoan where Username = @Username and Password = @Password and TrangThai='On' ";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("Username",taikhoan));
                cmd.Parameters.Add(new SqlParameter("Password",matkhau));
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    formQuanLiBanHang.username = taikhoan;
                    formThongTinTaiKhoan.username_TTTK = taikhoan;
                    formBaoCao.usernameBaoCao = taikhoan;
                    formNhapHang.username = taikhoan;

                    formQuanLiBanHang f = new formQuanLiBanHang();

                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";

                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại","Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
