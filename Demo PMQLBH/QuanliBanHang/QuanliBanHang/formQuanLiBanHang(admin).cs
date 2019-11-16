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
    public partial class formQuanLiBanHang_admin : Form
    {
        public string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
        public SqlDataAdapter da;

        public double x;
        public int i = 0;
        public formQuanLiBanHang_admin()
        {
            InitializeComponent();

            DoanhThu();

            HienTongDoanhThu();

            DanhSachTaiKhoan();

            DanhSachItems();

        }

        void DoanhThu()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "Select NgayLapBill as [Ngày Lập Bill], Id as [ID Bill], HinhThucThanhToan as [Hình Thức Thanh Toán], TongBill as [Tổng Bill] from Bill ";
            da = new SqlDataAdapter(query,connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagirdviewDoanhThu.DataSource = dt;

            datagirdviewDoanhThu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            datagirdviewDoanhThu.Columns[0].Width = 180;        //Hiện chiều rộng của cột
            datagirdviewDoanhThu.Columns[1].Width = 143;
            datagirdviewDoanhThu.Columns[2].Width = 230;
            datagirdviewDoanhThu.Columns[3].Width = 180;
            datagirdviewDoanhThu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void datagirdviewDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                //Hiện các giá trị từ bảng datagridviewDoanhThu lên 
                formXacNhanBill.IdBillformXacNhan = datagirdviewDoanhThu.Rows[numrow].Cells[1].Value.ToString();
            }        
        }

        private void buttonTKTheoNgay_Click(object sender, EventArgs e)
        {
            String TuNgay = dateTimeTuNgay.Value.ToString("yyyy/MM/dd");
            String DenNgay = dateTimeDenNgay.Value.ToString("yyyy/MM/dd");

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "Select NgayLapBill as [Ngày Lập Bill], Id as [ID Bill], HinhThucThanhToan as [Hình Thức Thanh Toán], TongBill as [Tổng Bill] from Bill where NgayLapBill between'" + TuNgay + "' and'" + DenNgay + "'";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);            
            datagirdviewDoanhThu.DataSource = dt;

            datagirdviewDoanhThu.Columns[0].Width = 180;        //Hiện chiều rộng của cột
            datagirdviewDoanhThu.Columns[1].Width = 143;
            datagirdviewDoanhThu.Columns[2].Width = 230;
            datagirdviewDoanhThu.Columns[3].Width = 180;
            datagirdviewDoanhThu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void buttonTKTheoCash_Click(object sender, EventArgs e)
        {
            String TuNgay = dateTimeTuNgay.Value.ToString("yyyy/MM/dd");
            String DenNgay = dateTimeDenNgay.Value.ToString("yyyy/MM/dd");

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "Select NgayLapBill as [Ngày Lập Bill], Id as [ID Bill], HinhThucThanhToan as [Hình Thức Thanh Toán], TongBill as [Tổng Bill] from Bill where NgayLapBill between'" + TuNgay + "' and'" + DenNgay + "' and HinhThucThanhToan= N'Tiền Mặt'";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagirdviewDoanhThu.DataSource = dt;

            datagirdviewDoanhThu.Columns[0].Width = 180;        //Hiện chiều rộng của cột
            datagirdviewDoanhThu.Columns[1].Width = 143;
            datagirdviewDoanhThu.Columns[2].Width = 230;
            datagirdviewDoanhThu.Columns[3].Width = 180;
            datagirdviewDoanhThu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void buttonTKTheoCredit_Click(object sender, EventArgs e)
        {
            String TuNgay = dateTimeTuNgay.Value.ToString("yyyy/MM/dd");
            String DenNgay = dateTimeDenNgay.Value.ToString("yyyy/MM/dd");
                       
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "Select NgayLapBill as [Ngày Lập Bill], Id as [ID Bill], HinhThucThanhToan as [Hình Thức Thanh Toán], TongBill as [Tổng Bill] from Bill where NgayLapBill between'" + TuNgay + "' and'" + DenNgay + "' and HinhThucThanhToan= 'Credit Card'";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagirdviewDoanhThu.DataSource = dt;

            datagirdviewDoanhThu.Columns[0].Width = 180;        //Hiện chiều rộng của cột
            datagirdviewDoanhThu.Columns[1].Width = 143;
            datagirdviewDoanhThu.Columns[2].Width = 230;
            datagirdviewDoanhThu.Columns[3].Width = 180;
            datagirdviewDoanhThu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void buttonTKDTTheoNgay_Click(object sender, EventArgs e)
        {
            String TuNgay = dateTimeTuNgay.Value.ToString("yyyy/MM/dd");
            String DenNgay = dateTimeDenNgay.Value.ToString("yyyy/MM/dd");

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "Select NgayLapBill as [Ngày Lập Bill], Id as [ID Bill], HinhThucThanhToan as [Hình Thức Thanh Toán], TongBill as [Tổng Bill] from Bill where NgayLapBill between'" + TuNgay + "' and'" + DenNgay + "'";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagirdviewDoanhThu.DataSource = dt;

            datagirdviewDoanhThu.Columns[0].Width = 160;        //Hiện chiều rộng của cột
            datagirdviewDoanhThu.Columns[1].Width = 130;
            datagirdviewDoanhThu.Columns[2].Width = 230;
            datagirdviewDoanhThu.Columns[3].Width = 165;
            datagirdviewDoanhThu.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            int sodong = datagirdviewDoanhThu.RowCount;
            double dtNgay = 0;
            for (int i=0;i<sodong-1;i++)
            {
                dtNgay = dtNgay + Convert.ToDouble(datagirdviewDoanhThu.Rows[i].Cells[3].Value.ToString());
            }
            x = dtNgay;
            HienTongDoanhThu();
        }

        void HienTongDoanhThu()
        {
            textBoxHienTongDoanhThu.Text = x.ToString();
        }

        private void buttonChiTietBill_Click(object sender, EventArgs e)
        {
            formXacNhanBill f = new formXacNhanBill();
            f.ShowDialog();
        }

        void DanhSachItems()
        {
            //Hiện danh sách Items
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "Select Id as [ID], TenFoodDrink as [Items], Gia as [Giá Tiền], TenDanhMuc as [Danh Mục],TrangThai as[Trạng Thái]  from FoodDrink where TrangThai = N'Sale'";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewItems.DataSource = dt;

            dataGridViewItems.Columns[0].Width = 50;        //Hiện chiều rộng của cột
            dataGridViewItems.Columns[1].Width = 200;
            dataGridViewItems.Columns[2].Width = 130;
            dataGridViewItems.Columns[3].Width = 100;
            dataGridViewItems.Columns[4].Width = 100;
        }

        void DanhSachTaiKhoan()
        {
            //Hiện danh sách tài khoản
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "Select Username as [Tài Khoản], Password as [Mật khẩu], TenUserHienThi as [Tên Hiển Thị], ChucVu as [Chức Vụ], LoaiTaiKhoan as [Loại Tài Khoản] from TaiKhoan";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewTaiKhoan.DataSource = dt;

            dataGridViewTaiKhoan.Columns[0].Width = 140;
            dataGridViewTaiKhoan.Columns[1].Width = 110;
            dataGridViewTaiKhoan.Columns[2].Width = 170;        //Hiện chiều rộng cột
            dataGridViewTaiKhoan.Columns[3].Width = 160;
            dataGridViewTaiKhoan.Columns[4].Width = 160;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string itemtimkiem = textBoxTimKiem.Text;
            //Câu lệnh lấy giá trị tìm kiếm
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = string.Format("select Id as [ID], TenFoodDrink as [Items], Gia as [Giá Tiền], TenDanhMuc as [Danh Mục], TrangThai as [Trạng Thái] from FoodDrink where TenFoodDrink like N'%{0}%' and TrangThai = N'Sale'", itemtimkiem);
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewItems.DataSource = dt;

            dataGridViewItems.Columns[0].Width = 50;
            dataGridViewItems.Columns[1].Width = 200;
            dataGridViewItems.Columns[2].Width = 130;
            dataGridViewItems.Columns[3].Width = 100;
            dataGridViewItems.Columns[4].Width = 100;
        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            if (numrow >= 0)
            {
                //Hiện các giá trị từ bảng datagridviewItems lên các textbox
                textBoxIDItems.Text = dataGridViewItems.Rows[numrow].Cells[0].Value.ToString();
                textBoxTenItems.Text = dataGridViewItems.Rows[numrow].Cells[1].Value.ToString();
                textBoxDanhMucItems.Text = dataGridViewItems.Rows[numrow].Cells[3].Value.ToString();
                textBoxGiaItems.Text = dataGridViewItems.Rows[numrow].Cells[2].Value.ToString();
            }           
        }

        private void dataGridViewTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            if (numrow >= 0)
            {
                //Hiện các giá trị từ bảng datagridviewTaiKhoan lên các textbox
                textBoxTaiKhoan.Text = dataGridViewTaiKhoan.Rows[numrow].Cells[0].Value.ToString();
                textBoxTenHienThi.Text = dataGridViewTaiKhoan.Rows[numrow].Cells[2].Value.ToString();
                textBoxLoaiTaiKhoan.Text = dataGridViewTaiKhoan.Rows[numrow].Cells[4].Value.ToString();
                textBoxMatKhau.Text = dataGridViewTaiKhoan.Rows[numrow].Cells[1].Value.ToString();
                textBoxChucVu.Text = dataGridViewTaiKhoan.Rows[numrow].Cells[3].Value.ToString();   
            }           
        }

        public int countTimer = 0;
        public int countTimerTenMon = 0;
        private void buttonThemItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string queryKTidMonTrung = "Select Id from FoodDrink where Id ='" + textBoxIDItems.Text + "'";
            SqlCommand cmdKTidMonTrung = new SqlCommand(queryKTidMonTrung, connection);


            if (cmdKTidMonTrung.ExecuteScalar() != null)
            {             
                timerID.Start();
                labelThongBaoTrungID.Text = "Id món đã tồn tại !!!";
                labelThongBaoTrungID.Visible = true;
            }
            
            if (cmdKTidMonTrung.ExecuteScalar() == null)
            {
                DanhSachItems();
                string queryKTMonTrung = "Select TenFoodDrink from FoodDrink where TenFoodDrink =N'" + textBoxTenItems.Text + "'";
                SqlCommand cmdKTMonTrung = new SqlCommand(queryKTMonTrung, connection);
                if (cmdKTMonTrung.ExecuteScalar() != null)      //chạy câu lệnh sql nếu có dữ liệu trả về => tên món đã có rồi
                {
                    timerTenMon.Start();
                    labelThongBaoTrungTenMonAn.Text = "Tên món đã tồn tại !!!";
                    labelThongBaoTrungTenMonAn.Visible = true;
                }
                if (cmdKTMonTrung.ExecuteScalar() == null)
                {
                    string query = "insert into FoodDrink (Id,TenFoodDrink,TenDanhMuc,Gia,TrangThai) values (@Id,@TenFoodDrink,@TenDanhMuc,@Gia,@TrangThai)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    string status = "Sale";
                    cmd.Parameters.AddWithValue("Id", Convert.ToInt32(textBoxIDItems.Text));
                    cmd.Parameters.AddWithValue("TenFoodDrink", textBoxTenItems.Text);
                    cmd.Parameters.AddWithValue("TenDanhMuc", textBoxDanhMucItems.Text);
                    cmd.Parameters.AddWithValue("Gia", Convert.ToDouble(textBoxGiaItems.Text));
                    cmd.Parameters.AddWithValue("TrangThai", status);
                    cmd.ExecuteNonQuery();
                    DanhSachItems();
                }
            }
            DanhSachItems();   
        }

        private void timerID_Tick(object sender, EventArgs e)
        {
            countTimer++;
            if (countTimer == 2)
            {
                timerID.Stop();
                labelThongBaoTrungID.Visible = false;
                timerID.Enabled = false;
                countTimer = 0;
            }
        }

        private void timerTenMon_Tick(object sender, EventArgs e)
        {
            countTimerTenMon++;
            if (countTimerTenMon == 2)
            {
                timerTenMon.Stop();
                labelThongBaoTrungTenMonAn.Visible = false;
                timerTenMon.Enabled = false;
                countTimerTenMon = 0;
            }
        }

        private void buttonSuaItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string queryKTTenMon = "Select TenFoodDrink from FoodDrink where TenFoodDrink = N'" + textBoxTenItems.Text + "'";
            SqlCommand cmdKTTenMon = new SqlCommand(queryKTTenMon,connection);
            if (cmdKTTenMon.ExecuteScalar() != null)
            {
                timerTenMon.Start();
                labelThongBaoTrungTenMonAn.Text = "Tên món đã tồn tại !!!";
                labelThongBaoTrungTenMonAn.Visible = true;
            }
            if (cmdKTTenMon.ExecuteScalar() == null)
            {
                string query = "update FoodDrink set TenFoodDrink=@TenFoodDrink, TenDanhMuc=@TenDanhMuc, Gia=@Gia  where Id='" + textBoxTenItems.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("TenFoodDrink", textBoxTenItems.Text);
                cmd.Parameters.AddWithValue("TenDanhMuc", textBoxDanhMucItems.Text);
                cmd.Parameters.AddWithValue("Gia", Convert.ToDouble(textBoxGiaItems.Text));
                cmd.ExecuteNonQuery();
                DanhSachItems();
            }               
        }

        private void buttonXoaItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string id = textBoxIDItems.Text;

            string query = "delete from FoodDrink where Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            DanhSachItems();
        }

        public int countTimerTaiKhoan = 0;
        private void buttonThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string queryKTTaiKhoan = "Select Username from TaiKhoan where Username = '" + textBoxTaiKhoan.Text + "'";
            SqlCommand cmdKTTaiKhoan = new SqlCommand(queryKTTaiKhoan, connection);
            if (cmdKTTaiKhoan.ExecuteScalar() != null)
            {
                timerTaiKhoan.Start();
                labelTrungTaiKhoan.Text = "Tài khoản đã tồn tại !!!";
                labelTrungTaiKhoan.Visible = true;
            }
            if (cmdKTTaiKhoan.ExecuteScalar() == null)
            {
                string query = "insert into TaiKhoan (Username, Password, TenUserHienThi, ChucVu, LoaiTaiKhoan) values (@Username,@Password,@TenUserHienThi,@ChucVu,@LoaiTaiKhoan)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("Username", textBoxTaiKhoan.Text);
                cmd.Parameters.AddWithValue("Password", textBoxMatKhau.Text);
                cmd.Parameters.AddWithValue("TenUserHienThi", textBoxTenHienThi.Text);
                cmd.Parameters.AddWithValue("ChucVu", textBoxChucVu.Text);
                cmd.Parameters.AddWithValue("LoaiTaiKhoan", textBoxLoaiTaiKhoan.Text);
                cmd.ExecuteNonQuery();
                DanhSachTaiKhoan();
            }            
        }

        private void timerTaiKhoan_Tick(object sender, EventArgs e)
        {
            countTimerTaiKhoan++;
            if (countTimerTaiKhoan == 2)
            {
                timerTaiKhoan.Stop();
                labelTrungTaiKhoan.Visible = false;
                timerTaiKhoan.Enabled = false;
                countTimerTaiKhoan = 0;
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

                string query = "update TaiKhoan set Password=@Password, TenUserHienThi=@TenUserHienThi, ChucVu=@ChucVu, LoaiTaiKhoan=@LoaiTaiKhoan  where Username='" + textBoxTaiKhoan.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("Password", textBoxMatKhau.Text);
                cmd.Parameters.AddWithValue("TenUserHienThi", textBoxTenHienThi.Text);
                cmd.Parameters.AddWithValue("ChucVu", textBoxChucVu.Text);
                cmd.Parameters.AddWithValue("LoaiTaiKhoan", Convert.ToInt32(textBoxLoaiTaiKhoan.Text));
                cmd.ExecuteNonQuery();
                DanhSachTaiKhoan();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string username = textBoxTaiKhoan.Text;
            string query = "delete from TaiKhoan where Username='" + username + "'";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            DanhSachTaiKhoan();
        }      
    }
}
