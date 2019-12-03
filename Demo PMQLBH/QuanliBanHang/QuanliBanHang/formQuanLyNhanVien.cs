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
using System.Threading;

namespace QuanliBanHang
{
    public partial class formQuanLyNhanVien : Form
    {
        public string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
        public SqlDataAdapter da;
        public int vitri = 0;
        public formQuanLyNhanVien()
        {
            InitializeComponent();

            LichLam();

            LuaChonMacDinh();
        }

        void LichLam()      //Hiện số giờ làm nhân viên
        {
            String Thang = DateTime.Now.ToString("MM");     //Lấy tháng hiện tại
            labelThang.Text = Thang;

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query =  "select GioCongNhanVien.username as [Nhân viên SBTC], GioCongNhanVien.ngay1 as [Ngày 1], GioCongNhanVien.ngay2 as [Ngày 2], GioCongNhanVien.ngay3 as [Ngày 3], GioCongNhanVien.ngay4 as [Ngày 4], GioCongNhanVien.ngay5 as [Ngày 5], GioCongNhanVien.ngay6 as [Ngày 6], GioCongNhanVien.ngay7 as [Ngày7], GioCongNhanVien.ngay8 as [Ngày 8], GioCongNhanVien.ngay9 as [Ngày 9], GioCongNhanVien.ngay10 as [Ngày 10], GioCongNhanVien.ngay11 as [Ngày 11], GioCongNhanVien.ngay12 as [Ngày 12], GioCongNhanVien.ngay13 as [Ngày 13], GioCongNhanVien.ngay14 as [Ngày 14], GioCongNhanVien.ngay15 as [Ngày 15], GioCongNhanVien.ngay16 as [Ngày 16], GioCongNhanVien.ngay17 as [Ngày 17], GioCongNhanVien.ngay18 as [Ngày 18], GioCongNhanVien.ngay19 as [Ngày 19], GioCongNhanVien.ngay20 as [Ngày 20], GioCongNhanVien.ngay21 as [Ngày 21], GioCongNhanVien.ngay22 as [Ngày 22], GioCongNhanVien.ngay23 as [Ngày 23], GioCongNhanVien.ngay24 as [Ngày 24], GioCongNhanVien.ngay25 as [Ngày 25], GioCongNhanVien.ngay26 as [Ngày 26], GioCongNhanVien.ngay27 as [Ngày 27], GioCongNhanVien.ngay28 as [Ngày 28], GioCongNhanVien.ngay29 as [Ngày 29], GioCongNhanVien.ngay30 as [Ngày 30],GioCongNhanVien.ngay31 as [Ngày 31], LuongTheoGio as [Lương theo giờ], TongGioLam as [Tổng giờ làm] from GioCongNhanVien,TaiKhoan where TaiKhoan.Username=GioCongNhanVien.username and TaiKhoan.TrangThai='On'";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewLichLam.DataSource = dt;
            dataGridViewLichLam.Columns[0].Width = 170;
            dataGridViewLichLam.Columns[32].Width = 150;
            dataGridViewLichLam.Columns[33].Width = 150;
        }

        void LuaChonMacDinh()       //Lựa chọn mặc định khi vừa mở form
        {
            textBoxGioLam.Text = dataGridViewLichLam.Rows[0].Cells[1].Value.ToString();
            textBoxLuongTheoGio.Text = dataGridViewLichLam.Rows[0].Cells[32].Value.ToString();
        }
        

        private void dataGridViewLichLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewLichLam.CurrentCell.RowIndex;
            int c = dataGridViewLichLam.CurrentCell.ColumnIndex;
            textBoxGioLam.Text = dataGridViewLichLam.Rows[row].Cells[c].Value.ToString();
            textBoxLuongTheoGio.Text = dataGridViewLichLam.Rows[row].Cells[32].Value.ToString();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            int row = dataGridViewLichLam.CurrentCell.RowIndex;
            string tenNV = dataGridViewLichLam.Rows[row].Cells[0].Value.ToString();
            string x = Convert.ToString(dataGridViewLichLam.CurrentCell.ColumnIndex);   //Lấy vị trí ngày làm

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            if (Convert.ToInt32(x) > 0)     //Nếu từ cột thứ 2 thì mới bắt đầu cập nhật giờ làm
            {
                string query = "update GioCongNhanVien set ngay" + x + " = @ngay" + x + " where username = '" + tenNV + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("ngay" + x, Convert.ToInt32(textBoxGioLam.Text));
                cmd.ExecuteNonQuery();
            }
            vitri = dataGridViewLichLam.CurrentRow.Index;
            LichLam();
            CapNhatGioLam();            
        }

        void CapNhatGioLam()        //Cập nhật lại tổng giờ làm sau khi bấm nút cập nhật giờ làm
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            int row = dataGridViewLichLam.CurrentCell.RowIndex;
            string tenNV = dataGridViewLichLam.Rows[vitri].Cells[0].Value.ToString();
            int tongiolam = 0;
            for (int i = 1; i < dataGridViewLichLam.ColumnCount - 2; i++)   //cộng toàn bộ giờ làm
            {
                tongiolam = tongiolam + Convert.ToInt32(dataGridViewLichLam.Rows[vitri].Cells[i].Value.ToString());
            }

            string querytonggiolam = "update GioCongNhanVien set TongGioLam = @TongGioLam where username = N'" + tenNV + "'";
            SqlCommand cmdtongiolam = new SqlCommand(querytonggiolam, connection);
            cmdtongiolam.Parameters.AddWithValue("TongGioLam", tongiolam);
            cmdtongiolam.ExecuteNonQuery();
            LichLam();           
        }

        void HienLuongDK()      //Hiện lương dự kiến
        {
            vitri = dataGridViewLichLam.CurrentRow.Index;
            int tonggiolam = 0;
            for (int i = 1; i < dataGridViewLichLam.ColumnCount - 2; i++)
            {
                tonggiolam = tonggiolam + Convert.ToInt32(dataGridViewLichLam.Rows[vitri].Cells[i].Value.ToString());
            }
            textBoxLuongDK.Text = Convert.ToString(tonggiolam * Convert.ToInt32(dataGridViewLichLam.Rows[vitri].Cells[dataGridViewLichLam.ColumnCount - 2].Value.ToString()));
        }

        private void buttonHienLuongDK_Click(object sender, EventArgs e)
        {
            HienLuongDK();
        }

        private void buttonRefeshThang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string tenNV;
            for (int j = 0; j < dataGridViewLichLam.RowCount; j++)  //Bắt đầu từ dòng 1
            {
                string queryRFTGC = "update GioCongNhanVien set TongGioLam= @TongGioLam where username = N'"+ dataGridViewLichLam.Rows[j].Cells[0].Value.ToString() + "'";
                SqlCommand cmdRFTGC = new SqlCommand(queryRFTGC, connection);
                cmdRFTGC.Parameters.AddWithValue("TongGioLam", 0);  //Cập nhật tổng giờ làm bằng 0
                cmdRFTGC.ExecuteNonQuery();
                for (int i = 1; i < dataGridViewLichLam.ColumnCount - 2; i++)   //bắt đầu từ cột thứ 2
                {
                    tenNV = dataGridViewLichLam.Rows[j].Cells[0].Value.ToString();
                    string query = "update GioCongNhanVien set ngay" + i + " = @ngay" + i + " where username = N'" + tenNV + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("ngay" + i , 0); //Cập nhật giờ làm tại vị trí đó lại bằng 0
                    cmd.ExecuteNonQuery();
                }
            }
            LichLam();
        }

        private void buttonLuongTheoGio_Click(object sender, EventArgs e)   //Cập nhật lương theo giờ
        {
            int row = dataGridViewLichLam.CurrentCell.RowIndex;
            string tenNV = dataGridViewLichLam.Rows[row].Cells[0].Value.ToString();
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "update GioCongNhanVien set LuongTheoGio = @LuongTheoGio where username = N'" + tenNV + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("LuongTheoGio", Convert.ToInt32(textBoxLuongTheoGio.Text));
            cmd.ExecuteNonQuery();
            LichLam();
        }
    }
}
