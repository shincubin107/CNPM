using QuanliBanHang.DAO;
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
                string query = "select * from TaiKhoan where Username ='" + taikhoan + "' and Password ='" + matkhau + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    formQuanLiBanHang.username = taikhoan;
                    formThongTinTaiKhoan.username_TTTK = taikhoan;
                    formBaoCao.usernameBaoCao = taikhoan;

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

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show("Bạn muốn thoát chưa trình ?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }*/
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
