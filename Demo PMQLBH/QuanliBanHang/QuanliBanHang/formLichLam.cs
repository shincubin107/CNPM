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
    public partial class formLichLam : Form
    {
        public string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
        public SqlDataAdapter da;

        public static string username = string.Empty;

        public formLichLam()
        {
            InitializeComponent();

            hienLichLam();

            LuaChonMacDinh();

            PQ(); 
        }

        void LuaChonMacDinh()       //lựa chọn mặc định khi vừa mở form
        {
            textBoxGioLam.Text = dataGridViewLichLam.Rows[0].Cells[1].Value.ToString();
        }

        void hienLichLam()      //hiện thời gian làm nhân viên
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string query = "select TaiKhoan.TenUserHienThi as [Nhân viên SBTC], TaiKhoan.ChucVu as [Chức vụ], LichLam.ngay1 as [Ngày 1], LichLam.ngay2 as [Ngày 2], LichLam.ngay3 as [Ngày 3], LichLam.ngay4 as [Ngày 4], LichLam.ngay5 as [Ngày 5], LichLam.ngay6 as [Ngày 6], LichLam.ngay7 as [Ngày7], LichLam.ngay8 as [Ngày 8], LichLam.ngay9 as [Ngày 9], LichLam.ngay10 as [Ngày 10], LichLam.ngay11 as [Ngày 11], LichLam.ngay12 as [Ngày 12], LichLam.ngay13 as [Ngày 13], LichLam.ngay14 as [Ngày 14], LichLam.ngay15 as [Ngày 15], LichLam.ngay16 as [Ngày 16], LichLam.ngay17 as [Ngày 17], LichLam.ngay18 as [Ngày 18], LichLam.ngay19 as [Ngày 19], LichLam.ngay20 as [Ngày 20], LichLam.ngay21 as [Ngày 21], LichLam.ngay22 as [Ngày 22], LichLam.ngay23 as [Ngày 23], LichLam.ngay24 as [Ngày 24], LichLam.ngay25 as [Ngày 25], LichLam.ngay26 as [Ngày 26], LichLam.ngay27 as [Ngày 27], LichLam.ngay28 as [Ngày 28], LichLam.ngay29 as [Ngày 29], LichLam.ngay30 as [Ngày 30],LichLam.ngay31 as [Ngày 31]  from LichLam,TaiKhoan where TaiKhoan.Username=LichLam.username and TaiKhoan.TrangThai='On'"; 
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewLichLam.DataSource = dt;
            dataGridViewLichLam.Columns[0].Width = 170;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            int row = dataGridViewLichLam.CurrentCell.RowIndex;
            string tenNV = dataGridViewLichLam.Rows[row].Cells[0].Value.ToString();
            string x = Convert.ToString(dataGridViewLichLam.CurrentCell.ColumnIndex);

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            if (dataGridViewLichLam.CurrentCell.ColumnIndex > 1)    //Nếu dữ liệu từ cột thứ 3 trở đi
            {
                string query = "update LichLam set ngay" + Convert.ToString(Convert.ToInt32(x) - 1) + " = @ngay" + Convert.ToString(Convert.ToInt32(x) - 1) + " where LichLam.username in (select Username from TaiKhoan where TenUserHienThi = N'" + tenNV + "') ";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("ngay" + Convert.ToString(Convert.ToInt32(x) - 1), textBoxGioLam.Text);
                cmd.ExecuteNonQuery();
            }
            hienLichLam();
        }

        private void dataGridViewLichLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewLichLam.CurrentCell.RowIndex;
            int c = dataGridViewLichLam.CurrentCell.ColumnIndex;
            if (row>=0 && c>1)
            {
                textBoxGioLam.Text = dataGridViewLichLam.Rows[row].Cells[c].Value.ToString();
            }          
        }

        void PQ()       //Phân quyền nhân viên vs quản lý
        {
            if (!string.IsNullOrEmpty(username))
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                string query = "Select LoaiTaiKhoan from TaiKhoan where Username= '" + username + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)  //Nếu là nhân viên thì ẩn các button và readonly dtgrvw
                {
                    buttonCapNhat.Dispose();
                    textBoxGioLam.Dispose();
                    buttonRefesh.Dispose();
                    dataGridViewLichLam.ReadOnly = true;
                }

            }
        }

        private void buttonRefesh_Click(object sender, EventArgs e)     //Cập nhật lại toàn bộ thời gian 
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string tenNV;
            for (int j = 0; j < dataGridViewLichLam.RowCount-1; j++)
            {                
                for (int i = 2; i < dataGridViewLichLam.ColumnCount; i++)
                {
                    tenNV = dataGridViewLichLam.Rows[j].Cells[0].Value.ToString();
                    string query = "update LichLam set ngay" + Convert.ToString(i - 1) + " = @ngay" + Convert.ToString(i - 1) + " where username = N'" + tenNV + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("ngay" + Convert.ToString(i - 1), " ");
                    cmd.ExecuteNonQuery();
                }
            }
            hienLichLam();
        }
    }
}

    	