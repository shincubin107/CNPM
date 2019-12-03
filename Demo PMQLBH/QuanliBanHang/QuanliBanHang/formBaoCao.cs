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
    public partial class formBaoCao : Form
    {
        public string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
        public SqlDataAdapter da;
        public static string usernameBaoCao = string.Empty;

        public formBaoCao()
        {
            InitializeComponent();

            HienTextBox(); 

            hienbaocao();
        }

        void hienbaocao()
        {
            string NgayBaoCao = dateTimePickerNgayBaoCao.Value.ToString("yyyy/MM/dd");

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            //Xóa view hiện tại trong sql
            string queryXoaView = "drop view viewBill";
            SqlCommand cmdXoaView = new SqlCommand(queryXoaView, connection);
            cmdXoaView.ExecuteNonQuery();

            //Tạo 1 view mới trong sql
            string queryTaoView = "create view viewBill as select TenFoodDrink_CTB as [Món ăn đã bán], SoLuong as [Số Lượng], DonGia_CTB as [Đơn Giá] from ChiTietBill where IdBill in (select Id from Bill where NgayLapBill = '" + NgayBaoCao + "')";
            SqlCommand cmdTaoView = new SqlCommand(queryTaoView, connection);
            cmdTaoView.ExecuteNonQuery();

            //Hiện danh sách món ăn đã bán lên
            string query = "select [Món ăn đã bán] , sum([Số Lượng]) as [Số Lượng], [Đơn Giá] from viewBill group by [Món ăn đã bán],  [Đơn Giá]";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBaoCao.DataSource = dt;
            dataGridViewBaoCao.Columns[0].Width = 323;
            dataGridViewBaoCao.Columns[1].Width = 100;
            dataGridViewBaoCao.Columns[2].Width = 110;
            dataGridViewBaoCao.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            double tdt = 0;
            for (int i = 0; i <= dataGridViewBaoCao.RowCount - 1; i++)
            {
                tdt = tdt + Convert.ToDouble(dataGridViewBaoCao.Rows[i].Cells[1].Value.ToString()) * Convert.ToDouble(dataGridViewBaoCao.Rows[i].Cells[2].Value.ToString());
            }
            labelTongDT_Text.Text = Convert.ToString(tdt);
        }

        void HienTextBox()
        {
            string NgayBaoCao = dateTimePickerNgayBaoCao.Value.ToString("yyyy/MM/dd");

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string querySoLuongBill = "select count(Id) from Bill where NgayLapBill = '" + NgayBaoCao + "'";
            SqlCommand cmdSoLuongBill = new SqlCommand(querySoLuongBill, connection);
            labelSoLuongBill_Text.Text = Convert.ToString(cmdSoLuongBill.ExecuteScalar());

            string queryCash = "select count(HinhThucThanhToan) from Bill where NgayLapBill = '" + NgayBaoCao + "' and HinhThucThanhToan = N'Tiền Mặt' group by HinhThucThanhToan";
            SqlCommand cmdCash = new SqlCommand(queryCash, connection);
            labelCash_Text.Text = Convert.ToString(cmdCash.ExecuteScalar());

            string queryCreditCard = "select count(HinhThucThanhToan) from Bill where NgayLapBill = '" + NgayBaoCao + "' and HinhThucThanhToan = 'Credit Card' group by HinhThucThanhToan";
            SqlCommand cmdCreditCard = new SqlCommand(queryCreditCard, connection);
            labelCreditCard_Text.Text = Convert.ToString(cmdCreditCard.ExecuteScalar());

            string queryDTTT = "select sum(TongBill) from Bill where NgayLapBill = '" + NgayBaoCao + "'";
            SqlCommand cmdDTTT = new SqlCommand(queryDTTT, connection);
            labelDTTT_Text.Text = Convert.ToString(cmdDTTT.ExecuteScalar());

            string queryGiamGia = "select sum(GiamGia) from Bill where NgayLapBill = '" + NgayBaoCao + "'";
            SqlCommand cmdGiamGia = new SqlCommand(queryGiamGia, connection);
            labelGiamGia_Text.Text = Convert.ToString(cmdGiamGia.ExecuteScalar());

            string queryNhanVien = "select TenUserHienThi from TaiKhoan where Username = '" + usernameBaoCao + "'";
            SqlCommand cmdNhanVien = new SqlCommand(queryNhanVien, connection);
            labelNhanVien.Text = Convert.ToString(cmdNhanVien.ExecuteScalar());
        }

        private void buttonHienBaoCao_Click(object sender, EventArgs e)
        {
            HienTextBox();

            hienbaocao();
        }

        
        public void PDF(DataGridView dataGridViewBaoCao , string filename)
        {
            string NgayBaoCao = dateTimePickerNgayBaoCao.Value.ToString("yyyy/MM/dd");


            BaseFont bf = BaseFont.CreateFont("D:\\Demo PMQLBH\\VietFontsWeb1_ttf\\vuArial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            PdfPTable pdftb = new PdfPTable(dataGridViewBaoCao.Columns.Count);
            pdftb.DefaultCell.Padding = 3;
            pdftb.WidthPercentage = 100;
            pdftb.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftb.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font BaoCaoFont = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font TieudeBang = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);

            Paragraph BaoCao = new Paragraph("BÁO CÁO DOANH THU SBTC\n", BaoCaoFont);
            BaoCao.Alignment = 1;
            Paragraph line = new Paragraph("-------------------------------------\n", BaoCaoFont);
            line.Alignment = 1;
            Paragraph dong1 = new Paragraph("Ngày báo cáo: " +NgayBaoCao + "                                                 Nhân viên kết ca: " + labelNhanVien.Text, text);
            Paragraph dong2 = new Paragraph("Bill: "+ labelSoLuongBill_Text.Text+ "                                          Cash: " +labelCash_Text.Text+ "                              Credit Card: " +labelCreditCard_Text.Text, text);
            Paragraph dong3 = new Paragraph("Tổng doanh thu: "+ labelTongDT_Text.Text +"            Giảm giá: "+ labelGiamGia_Text.Text +"              Doanh thu thực tế: "+ labelDTTT_Text.Text +"\n\n", text);
            Paragraph QLKT = new Paragraph("Quản lý SBTC         \n\n\n\n...........................    ", TieudeBang);
            QLKT.Alignment = 2;
                                            
            //them header
            foreach (DataGridViewColumn column in dataGridViewBaoCao.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, TieudeBang));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240,240,240);
                pdftb.AddCell(cell);
            }

            //THem dong
            foreach (DataGridViewRow row in dataGridViewBaoCao.Rows)
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
                    
                    Document pdfdoc = new Document(PageSize.A4, 20f, 20f, 20f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(BaoCao);
                    pdfdoc.Add(line);
                    pdfdoc.Add(dong1);
                    pdfdoc.Add(dong2);
                    pdfdoc.Add(dong3);
                    pdfdoc.Add(pdftb);
                    pdfdoc.Add(QLKT);
                    pdfdoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Lưu bill thành công", "Thông báo");
            }
        }


        private void buttonXuatBaoCao_Click(object sender, EventArgs e)
        {
            string NgayBaoCao = dateTimePickerNgayBaoCao.Value.ToString("ddMMyyyy");
            PDF(dataGridViewBaoCao, "BaoCao("+NgayBaoCao+")");

        }
    }
}
