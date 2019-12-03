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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace QuanliBanHang
{
    public partial class formXacNhanBill : Form
    {

        public SqlDataAdapter da;
        public formXacNhanBill()
        {
            InitializeComponent();

            HienThongTinBill();

            hienChiTietBill();

            x();
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
            string query = "select TenFoodDrink_CTB, SoLuong, DonGia_CTB,GhiChu from ChiTietBill where IdBill='" + Convert.ToInt32(IdBillformXacNhan) + "'";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["TenFoodDrink_CTB"].ToString();
                item.SubItems.Add(reader["SoLuong"].ToString());
                item.SubItems.Add(reader["DonGia_CTB"].ToString());
                item.SubItems.Add(Convert.ToString(Convert.ToInt32(reader["SoLuong"].ToString()) * Convert.ToDouble(reader["DonGia_CTB"].ToString())));
                item.SubItems.Add(reader["GhiChu"].ToString());
                listViewXacNhanBill.Items.Add(item);
            }            
        }

        private void buttonInBill_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PDF(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont("D:\\Demo PMQLBH\\VietFontsWeb1_ttf\\vuArial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            PdfPTable pdftb = new PdfPTable(dgv.Columns.Count);
            pdftb.DefaultCell.Padding = 3;
            pdftb.WidthPercentage = 100;
            pdftb.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftb.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font fc = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD);

            
            Paragraph dong1 = new Paragraph("Id bill: " + labelIdBill_Text.Text + "               Ngày lập bill: " + labelNgayLapBill_Text.Text, fc);
            Paragraph dong2 = new Paragraph("Nhân viên lập bill: " + labelNhanVienLapBill_Text.Text , fc);
            Paragraph dong3 = new Paragraph("Tổng bill: " + labelTongBill_Text.Text, fc);
            Paragraph dong4 = new Paragraph("Giảm giá: " + labelGiamGia_Text.Text, fc);
            Paragraph dong5 = new Paragraph("Hình thức thanh toán: " + labelHinhThucThanhToan_Text.Text, fc);
            Paragraph dong6 = new Paragraph("  ",fc);
            //them header
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fc));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftb.AddCell(cell);
            }

            //THem dong
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftb.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {

                    Document pdfdoc = new Document(PageSize.A6, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(dong1);
                    pdfdoc.Add(dong2);
                    pdfdoc.Add(dong3);
                    pdfdoc.Add(dong4);
                    pdfdoc.Add(dong5);
                    pdfdoc.Add(dong6);
                    pdfdoc.Add(pdftb);
                    pdfdoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Lưu báo cáo thành công", "Thông báo");
            }
        }

        void x()
        {
            string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string query = "select TenFoodDrink_CTB as [Tên món ăn], SoLuong as [Số lượng], DonGia_CTB as [Đơn giá] from ChiTietBill where IdBill='" + Convert.ToInt32(IdBillformXacNhan) + "'";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {      
            PDF(dgv, "Bill "+ labelIdBill_Text.Text);
        }
    }
}
