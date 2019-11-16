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
    public partial class formXacNhanBill : Form
    {
        public formXacNhanBill()
        {
            InitializeComponent();

            HienThongTinBill();

            hienChiTietBill();
        }

        public static string IdBillformXacNhan = string.Empty;

        void HienThongTinBill()
        {
            labelIdBill_Text.Text = IdBillformXacNhan;

            string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            
            string queryNgayLapBill = "select NgayLapBill from Bill where Id='" + Convert.ToInt32(IdBillformXacNhan) + "'";
            SqlCommand cmdNgayLapBill = new SqlCommand(queryNgayLapBill, connection);
            string layngay = Convert.ToString(cmdNgayLapBill.ExecuteScalar());
            DateTime x = Convert.ToDateTime(layngay);
            labelNgayLapBill_Text.Text = Convert.ToString(x.Date.ToString("dd/MM/yyyy"));

            string queryNhanVienLap = "select NhanVienLap from Bill where Id='" + Convert.ToInt32(IdBillformXacNhan) + "'";
            SqlCommand cmdNhanVienLap = new SqlCommand(queryNhanVienLap, connection);
            labelNhanVienLapBill_Text.Text = Convert.ToString(cmdNhanVienLap.ExecuteScalar());

            string queryTongBill = "select TongBill from Bill where Id='" + Convert.ToInt32(IdBillformXacNhan) + "'";
            SqlCommand cmdTongBill = new SqlCommand(queryTongBill, connection);
            labelTongBill_Text.Text = Convert.ToString(cmdTongBill.ExecuteScalar());

            string queryGiamGia = "select GiamGia from Bill where Id='" + Convert.ToInt32(IdBillformXacNhan) + "'";
            SqlCommand cmdGiamGia = new SqlCommand(queryGiamGia, connection);
            labelGiamGia_Text.Text = Convert.ToString(cmdGiamGia.ExecuteScalar());

            string queryHinhThucThanhToan = "select HinhThucThanhToan from Bill where Id='" + Convert.ToInt32(IdBillformXacNhan) + "'";
            SqlCommand cmdHinhThucThanhToan = new SqlCommand(queryHinhThucThanhToan, connection);
            labelHinhThucThanhToan_Text.Text = Convert.ToString(cmdHinhThucThanhToan.ExecuteScalar());
        }

        void hienChiTietBill()
        {
            string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            string query = "select TenFoodDrink_CTB, SoLuong, DonGia_CTB from ChiTietBill where IdBill='" + Convert.ToInt32(IdBillformXacNhan) + "'";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["TenFoodDrink_CTB"].ToString();
                item.SubItems.Add(reader["SoLuong"].ToString());
                item.SubItems.Add(reader["DonGia_CTB"].ToString());
                item.SubItems.Add(Convert.ToString(Convert.ToInt32(reader["SoLuong"].ToString()) * Convert.ToDouble(reader["DonGia_CTB"].ToString())));
                listViewXacNhanBill.Items.Add(item);
            }            
        }

        private void buttonInBill_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
