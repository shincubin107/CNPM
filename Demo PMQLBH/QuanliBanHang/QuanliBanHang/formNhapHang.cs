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
    public partial class formNhapHang : Form
    {
        public string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
        public SqlDataAdapter da;

        public static string username = string.Empty;
        public string NCC = "";
        public string PhieuDuocChon = "";
        public formNhapHang()
        {
            InitializeComponent();      

            HienDanhSachPhieuNhap();

            ChieuDaiPhieuNhap();

            LuaChonMacDinh();
        }

        void LuaChonMacDinh()
        {
            if (dataGridViewDanhSachPhieuNhap.RowCount>0)
            {
                PhieuDuocChon = dataGridViewDanhSachPhieuNhap.Rows[0].Cells[0].Value.ToString();
                formChiTietPhieuNhap.PhieuDuocChon = PhieuDuocChon;
            }           
        }

        private void buttonLuuPhieu_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            //Nếu các textbox còn trống thì thông báo nhập lại
            if (textBoxMaPhieu.Text == "" || textBoxDiaChiNCC.Text == "" || textBoxTongTien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo"); return;
            }

            //kiểm tra các textbox đã đầy đủ thông tin chưa
            if (textBoxMaPhieu.Text != "" || textBoxDiaChiNCC.Text != "" || textBoxTongTien.Text != "")    
            {
                //Kiểm tra mã phiếu có tồn tại hay không
                string queryKTMaPhieu = "select MaPhieu from PhieuNhap where MaPhieu = '"+Convert.ToInt32(textBoxMaPhieu.Text)+"'";
                SqlCommand cmdKTMaPhieu = new SqlCommand(queryKTMaPhieu,connection);

                if (cmdKTMaPhieu.ExecuteScalar() != null)       //Nếu đã tồn tại mã phiếu
                {
                    MessageBox.Show("Mã phiếu đã tồn tại", "Thông báo");
                }

                if (cmdKTMaPhieu.ExecuteScalar() == null)       //Nếu không tồn tại mã phiếu
                {
                    int count = 0;
                    if (dataGridViewNhapHang.RowCount <= 1)     //Nếu không có dữ liệu trong datagridview thì hiện thông báo này
                    {
                        MessageBox.Show("Bạn chưa thêm món hàng nào trong phiếu nhập", "Thông báo");
                    }

                    if (dataGridViewNhapHang.RowCount > 1)  //nếu bảng đã có ít nhất 1 dòng dữ liệu
                    {
                        for (int n = 0; n < dataGridViewNhapHang.RowCount - 1; n++)     //xét nếu có dữ liệu nào trống
                        {
                            for (int m = 0; m < dataGridViewNhapHang.ColumnCount; m++)
                            {
                                if (dataGridViewNhapHang.Rows[n].Cells[m].Value == null)
                                {
                                    count++;        //nếu có dữ liệu trống thì count tăng lên
                                }
                            }
                        }

                        if (count > 0)      //Nếu có dữ liệu trống thì thông báo nhập lại đủ
                        {
                            MessageBox.Show("Bạn chưa nhập đủ thông tin của hàng hóa", "Thông báo");
                        }

                        if (count == 0)     //nếu không có dữ liệu trống thì nhập vào phiếu nhập và CTPN
                        {
                            string queryThemPhieuNhap = "insert into PhieuNhap(MaPhieu,NgayLapPhieu,NCC,DiaChiNCC,NhanVienLap) values (@MaPhieu,@NgayLapPhieu,@NCC,@DiaChiNCC,@NhanVienLap)";
                            SqlCommand cmdThemPhieuNhap = new SqlCommand(queryThemPhieuNhap, connection);
                            cmdThemPhieuNhap.Parameters.AddWithValue("MaPhieu", textBoxMaPhieu.Text);
                            cmdThemPhieuNhap.Parameters.AddWithValue("NgayLapPhieu", Convert.ToDateTime(dateTimePickerNgayTao.Value.ToString("dd/MM/yyyy")));
                            cmdThemPhieuNhap.Parameters.AddWithValue("NCC", NCC);
                            cmdThemPhieuNhap.Parameters.AddWithValue("DiaChiNCC", textBoxDiaChiNCC.Text);
                            cmdThemPhieuNhap.Parameters.AddWithValue("NhanVienLap", textBoxNVLapPhieu.Text);
                            cmdThemPhieuNhap.ExecuteNonQuery();

                            for (int i = 0; i < dataGridViewNhapHang.RowCount - 1; i++)
                            {
                                string queryCTPN = "insert into ChiTietPhieuNhap(MaPhieu,TongTienPhieuNhap,TenHang,SoLuong,DonViTinh,DonGia,ThanhTien) values (@MaPhieu,@TongTienPhieuNhap,@TenHang,@SoLuong,@DonViTinh,@DonGia,@ThanhTien)";
                                SqlCommand cmdCTPN = new SqlCommand(queryCTPN, connection);

                                cmdCTPN.Parameters.AddWithValue("MaPhieu", textBoxMaPhieu.Text);
                                cmdCTPN.Parameters.AddWithValue("TongTienPhieuNhap", Convert.ToDouble(textBoxTongTien.Text));
                                cmdCTPN.Parameters.AddWithValue("TenHang", dataGridViewNhapHang.Rows[i].Cells[0].Value.ToString());
                                cmdCTPN.Parameters.AddWithValue("SoLuong", Convert.ToInt32(dataGridViewNhapHang.Rows[i].Cells[1].Value.ToString()));
                                cmdCTPN.Parameters.AddWithValue("DonViTinh", dataGridViewNhapHang.Rows[i].Cells[2].Value.ToString());
                                cmdCTPN.Parameters.AddWithValue("DonGia", Convert.ToDouble(dataGridViewNhapHang.Rows[i].Cells[3].Value.ToString()));
                                cmdCTPN.Parameters.AddWithValue("ThanhTien", Convert.ToDouble(dataGridViewNhapHang.Rows[i].Cells[4].Value.ToString()));
                                cmdCTPN.ExecuteNonQuery();
                            }
                        }                     
                    }                    
                    count = 0; //trả biến check count về lại 0
                }                              
            }
            
            RefeshNhapHang();
            HienDanhSachPhieuNhap();
            ChieuDaiPhieuNhap();
            dataGridViewNhapHang.Rows.Clear();
            LuaChonMacDinh();
        }

        void RefeshNhapHang()       //Refesh lại toàn bộ textbox
        {
            textBoxMaPhieu.Text = "";
            dateTimePickerNgayTao.Value = DateTime.Now;
            comboBoxNCC.SelectedIndex = 0;
            textBoxDiaChiNCC.Text = "";
            textBoxNVLapPhieu.Text = "";
            textBoxTongTien.Text = "";          
        }

        void ChieuDaiPhieuNhap()    //Hiện chiều dài của các cột datagridviewNhapHang
        {
            dataGridViewNhapHang.Columns[0].Width = 200;
            dataGridViewNhapHang.Columns[1].Width = 100;
            dataGridViewNhapHang.Columns[2].Width = 120;
            dataGridViewNhapHang.Columns[3].Width = 130;
            dataGridViewNhapHang.Columns[4].Width = 130;
        }

        private void comboBoxNCC_SelectedIndexChanged(object sender, EventArgs e)   //Lấy giá trị trong comboboxNCC
        {
            string item = this.comboBoxNCC.GetItemText(this.comboBoxNCC.SelectedItem);
            NCC = item;
            HienDiaChiNCC();
        }

        void HienDiaChiNCC()        //Hiện địa chỉ NCC lên textbox
        {
            if (NCC == "Cty TNHH Tân Hiệp Phát")
            {
                textBoxDiaChiNCC.Text = "Số 12 đường CMT8, phường 14, quận 3 TP.HCM";
            }
            else if (NCC == "Cty Cung Cấp Rau Quả Hoàng Anh")
            {
                textBoxDiaChiNCC.Text = "Số 45 đường Nguyễn Thị Thập, phường Tân Quy, quận 7 TP.HCM";
            }
            else if (NCC == "Cty Cung Cấp Trứng Gà D&M")
            {
                textBoxDiaChiNCC.Text = "Số 329 đường Phạm Hùng, phường 12, quận 8 TPHCM";
            }
            else if (NCC == "Cty TNHH MegaFood (NCC các loại cá viên)")
            {
                textBoxDiaChiNCC.Text = "Số 98 đường  Nguyễn Chí Thanh, phường 8 quận 5 TPHCM";
            }
            else if (NCC == "Cty TNHH AceCook (NCC các loại mì,nui,gạo)")
            {
                textBoxDiaChiNCC.Text = "Số 221 đường Thành Thái, phường 2, quận 10 TPHCM";
            }
            else if (NCC == "Cty Cung Cấp Gia Vị Tiêu Dùng GiaVi")
            {
                textBoxDiaChiNCC.Text = "Số 333 đường Hoàng Văn Thụ, phường 6, quận Tân Bình TPHCM";
            }
            else
            {
                textBoxDiaChiNCC.Text = "";
            }
        }

        void HienDanhSachPhieuNhap()     //Hiện danh sách phiếu nhập lên datagridviewDanhSachPhieuNhap
        {
            textBoxNVLapPhieu.Text = username;
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string query = "Select MaPhieu as [Mã Phiếu], NgayLapPhieu as [Ngày Lập Phiếu], NCC as[NCC], DiaChiNCC as [Địa Chỉ NCC], NhanVienLap as [Nhân Viên Lập Bill] from PhieuNhap";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDanhSachPhieuNhap.DataSource = dt;
        }

        private void buttonHienPhieuNhap_Click(object sender, EventArgs e)
        {
            String TuNgay = dateTimePickerTuNgay.Value.ToString("yyyy/MM/dd");
            String DenNgay = dateTimePickerDenNgay.Value.ToString("yyyy/MM/dd");

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string query = "Select MaPhieu as [Mã Phiếu], NgayLapPhieu as [Ngày Lập Phiếu], NCC as[NCC], DiaChiNCC as [Địa Chỉ NCC], NhanVienLap as [Nhân Viên Lập Bill] from PhieuNhap where NgayLapPhieu between'" + TuNgay + "' and'" + DenNgay + "'";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDanhSachPhieuNhap.DataSource = dt;
        }

        private void dataGridViewDanhSachPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewDanhSachPhieuNhap.CurrentCell.RowIndex;
            if (row >= 0)
            {
                PhieuDuocChon = dataGridViewDanhSachPhieuNhap.Rows[row].Cells[0].Value.ToString();
                formChiTietPhieuNhap.PhieuDuocChon = PhieuDuocChon;
            }
        }

        private void buttonChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            formChiTietPhieuNhap f = new formChiTietPhieuNhap();           
            f.ShowDialog();
        }

        private void buttonXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string queryXoaCTPN = "delete from ChiTietPhieuNhap where MaPhieu = '"+PhieuDuocChon+"'";
            SqlCommand cmdXoaCTPN = new SqlCommand(queryXoaCTPN,connection);
            cmdXoaCTPN.ExecuteNonQuery();

            string queryXoaPN = "delete from PhieuNhap where MaPhieu = '" + PhieuDuocChon + "'";
            SqlCommand cmdXoaPN = new SqlCommand(queryXoaPN, connection);
            cmdXoaPN.ExecuteNonQuery();
            HienDanhSachPhieuNhap();
        }   
    }
}
