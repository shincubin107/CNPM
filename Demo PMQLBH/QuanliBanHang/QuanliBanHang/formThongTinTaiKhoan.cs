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

namespace QuanliBanHang
{
    public partial class formThongTinTaiKhoan : Form
    {
        public static string username_TTTK = string.Empty;
        public formThongTinTaiKhoan()
        {
            InitializeComponent();

            DisplayAllTextBox();
        }

        private void textBoxTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            
        }

        void DisplayAllTextBox()
        {
            if (!string.IsNullOrEmpty(username_TTTK))
            {
                string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();

                string queryTaiKhoan = "Select Username from TaiKhoan where Username= '" + username_TTTK + "'";
                SqlCommand cmdTaiKhoan = new SqlCommand(queryTaiKhoan, connection);
                string TaiKhoan = (string)cmdTaiKhoan.ExecuteScalar();
                textBoxTaiKhoan.Text = TaiKhoan;

                string queryTenHienThi = "Select TenUserHienThi from TaiKhoan where Username= '" + username_TTTK + "'";
                SqlCommand cmdTenHienThi = new SqlCommand(queryTenHienThi, connection);
                string TenHienThi = (string)cmdTenHienThi.ExecuteScalar();
                textBoxTenHienThi.Text = TenHienThi;
            }
        }

        private void textBoxNhapLai_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string queryMatKhau = "Select Password from TaiKhoan where Username= '" + username_TTTK + "'";
            SqlCommand cmdMatKhau = new SqlCommand(queryMatKhau, connection);
            string MatKhau = (string)cmdMatKhau.ExecuteScalar();
            if (textBoxMatKhau.Text == "")
            {
                string queryCapNhatTenHienThi1 = "update TaiKhoan set TenUserHienThi=@TenUserHienThi where Username='" + username_TTTK + "'";
                SqlCommand cmdCapNhatTenHienThi1 = new SqlCommand(queryCapNhatTenHienThi1, connection);
                cmdCapNhatTenHienThi1.Parameters.AddWithValue("TenUserHienThi", textBoxTenHienThi.Text);
                cmdCapNhatTenHienThi1.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công", "Thông báo");
                DisplayAllTextBox();
            }
            if (textBoxMatKhau.Text != "")
            {
                if (textBoxMatKhau.Text == MatKhau)
                {
                    if (textBoxNhapLai.Text == textBoxMatKhauMoi.Text)
                    {
                        string queryCapNhat = "update TaiKhoan set Password=@Password where Username='" + username_TTTK + "'";
                        SqlCommand cmdCapNhat = new SqlCommand(queryCapNhat, connection);
                        cmdCapNhat.Parameters.AddWithValue("Password", textBoxMatKhauMoi.Text);
                        cmdCapNhat.ExecuteNonQuery();

                        string queryCapNhatTenHienThi = "update TaiKhoan set TenUserHienThi=@TenUserHienThi where Username='" + username_TTTK + "'";
                        SqlCommand cmdCapNhatTenHienThi = new SqlCommand(queryCapNhatTenHienThi, connection);
                        cmdCapNhatTenHienThi.Parameters.AddWithValue("TenUserHienThi", textBoxTenHienThi.Text);
                        cmdCapNhatTenHienThi.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        DisplayAllTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu mới nhập chưa đúng", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mật Khẩu cũ chưa đúng", "Thông báo");
                }
            }
            DisplayAllTextBox();
        }

        private void formThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
