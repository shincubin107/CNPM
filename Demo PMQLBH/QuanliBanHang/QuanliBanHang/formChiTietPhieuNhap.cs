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
    public partial class formChiTietPhieuNhap : Form
    {
        public string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
        public SqlDataAdapter da;

        public static string PhieuDuocChon = "";
        public formChiTietPhieuNhap()
        {
            InitializeComponent();

            HienThongTinChiTietPhieuNhap();
        }

        void HienThongTinChiTietPhieuNhap()     //Hiện toàn bộ thông tin của phiếu nhập
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string queryMaPhieu = "select MaPhieu from PhieuNhap where MaPhieu = '"+PhieuDuocChon+"'";
            SqlCommand cmdMaPhieu = new SqlCommand(queryMaPhieu, connection);
            labelMaPhieu_Text.Text = Convert.ToString(cmdMaPhieu.ExecuteScalar());

            string queryNgayTao = "select NgayLapPhieu from PhieuNhap where MaPhieu = '" + PhieuDuocChon + "'";
            SqlCommand cmdNgayTao = new SqlCommand(queryNgayTao, connection);
            labelNgayTao_Text.Text = Convert.ToString(cmdNgayTao.ExecuteScalar());

            string queryNCC = "select NCC from PhieuNhap where MaPhieu = '" + PhieuDuocChon + "'";
            SqlCommand cmdNCC = new SqlCommand(queryNCC, connection);
            labelNCC_Text.Text = Convert.ToString(cmdNCC.ExecuteScalar());

            string queryDiaChiNCC = "select DiaChiNCC from PhieuNhap where MaPhieu = '" + PhieuDuocChon + "'";
            SqlCommand cmdDiaChiNCC = new SqlCommand(queryDiaChiNCC, connection);
            labelDiaChiNCC_Text.Text = Convert.ToString(cmdDiaChiNCC.ExecuteScalar());

            string queryNVLapPhieu = "select NhanVienLap from PhieuNhap where MaPhieu = '" + PhieuDuocChon + "'";
            SqlCommand cmdNVLapPhieu = new SqlCommand(queryNVLapPhieu, connection);
            labelNVLapPhieu_Text.Text = Convert.ToString(cmdNVLapPhieu.ExecuteScalar());

            string queryTongTien = "select TongTienPhieuNhap from ChiTietPhieuNhap where MaPhieu = '" + PhieuDuocChon + "'";
            SqlCommand cmdTongTien = new SqlCommand(queryTongTien, connection);
            labelTongTien_Text.Text = Convert.ToString(cmdTongTien.ExecuteScalar());

            string query = "Select TenHang as [Tên Hàng], SoLuong as [Số Lượng], DonViTinh as [Đơn Vị Tính], DonGia as [Đơn Giá], ThanhTien as [Thành Tiền] from ChiTietPhieuNhap where MaPhieu = '" + PhieuDuocChon + "'";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewChiTietPhieuNhap.DataSource = dt;
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
