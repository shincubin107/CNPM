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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace QuanliBanHang
{
    public partial class formQuanLiBanHang : Form
    {
        public string connectionSTR = @"Data Source=LAPTOP-7RRV7AH5;Initial Catalog=PhanMemQuanLyBanHangSBTC;Integrated Security=True";
        public SqlDataAdapter da;

        public static string username = string.Empty;
        public static string MonDuocChon = "";  
        public static double DonGia = 0;    
        public static int Soluong = 0;
        public static double ThanhTien = 0;
        public static double TongTien = 0;
        public int count = 0;       //Biến KT trong bill có món hay không
        public double TienGiamGia = 0;
        public string NhanVienThanhToan;

        public formQuanLiBanHang()
        {
            InitializeComponent();

            DanhMuc();

            HienThiUsername();

            HienMENU();

            LuaChonMacDinh();

            //PhanQuyenNhanVien();

            HienTongTien();

        }


        void DanhMuc()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelDanhMuc.ForeColor == Color.Teal)
            {
               labelDanhMuc.ForeColor = Color.Red;
            }
            else
            {
               labelDanhMuc.ForeColor = Color.Teal;
            }
        }

        private void MucDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MucThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            formThongTinTaiKhoan f = new formThongTinTaiKhoan();
            f.ShowDialog();
            HienThiUsername();
        }

        private void MucQuanLiBanHang_Click(object sender, EventArgs e)
        {            
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "Select LoaiTaiKhoan from TaiKhoan where Username= '" + username + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            Int32 LoaiTaiKhoan = (Int32)cmd.ExecuteScalar();

            if (LoaiTaiKhoan == 1)
            {
                MessageBox.Show("Bạn không phải là Quản lý nên không được truy cập !!!", "Thông báo");

            }
            else
            {
                formQuanLiBanHang_admin f = new formQuanLiBanHang_admin();
                f.ShowDialog();
            }
            
        }

        void HienMENU()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "select TenFoodDrink as [Món Ăn], TenDanhMuc as [Danh Mục], Gia as [Giá Tiền] from FoodDrink  where TrangThai ='Sale' group by TenDanhMuc, TenFoodDrink, Gia";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewMenu.DataSource = dt;
            dataGridViewMenu.Columns[0].Width = 240;
            dataGridViewMenu.Columns[1].Width = 140;
            dataGridViewMenu.Columns[2].Width = 140;
            dataGridViewMenu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void comboBoxDanhMucItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string item = this.comboBoxDanhMucItems.GetItemText(this.comboBoxDanhMucItems.SelectedItem);

            string query = "select TenFoodDrink as [Món Ăn], TenDanhMuc as [Danh Mục], Gia as [Giá Tiền] from FoodDrink where TenDanhMuc = N'" + item + "' and TrangThai = N'Sale' group by TenDanhMuc, TenFoodDrink, Gia";
            da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMenu.DataSource = dt;
            dataGridViewMenu.Columns[0].Width = 239;
            dataGridViewMenu.Columns[1].Width = 140;
            dataGridViewMenu.Columns[2].Width = 140;
            dataGridViewMenu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (item == "Ticket" || item == "Drink")
            {
                string queryTC = "select TenFoodDrink as [Món Ăn], TenDanhMuc as [Danh Mục], Gia as [Giá Tiền] from FoodDrink where TenDanhMuc = N'" + item + "' and TrangThai = N'Sale' group by TenDanhMuc, TenFoodDrink, Gia";
                da = new SqlDataAdapter(queryTC, connection);
                DataTable dtTC = new DataTable();
                da.Fill(dtTC);
                dataGridViewMenu.DataSource = dtTC;

                dataGridViewMenu.Columns[0].Width = 256;
                dataGridViewMenu.Columns[1].Width = 140;
                dataGridViewMenu.Columns[2].Width = 140;
                dataGridViewMenu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (item == "Tất cả")
            {
                string queryTC = "select TenFoodDrink as [Món Ăn], TenDanhMuc as [Danh Mục], Gia as [Giá Tiền] from FoodDrink where TrangThai = N'Sale' group by TenDanhMuc, TenFoodDrink, Gia";
                da = new SqlDataAdapter(queryTC, connection);
                DataTable dtTC = new DataTable();
                da.Fill(dtTC);
                dataGridViewMenu.DataSource = dtTC;

                dataGridViewMenu.Columns[0].Width = 240;
                dataGridViewMenu.Columns[1].Width = 140;
                dataGridViewMenu.Columns[2].Width = 140;
                dataGridViewMenu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            //Khúc này là lấy giá trị đầu tiên khi mở qua một danh mục menu khác khi vừa mới chọn
            MonDuocChon = dataGridViewMenu.Rows[0].Cells[0].Value.ToString();
            DonGia = Convert.ToDouble(dataGridViewMenu.Rows[0].Cells[2].Value.ToString());
            ThanhTien = Soluong * DonGia;           
        }

        public void HienThiUsername()
        {
            formLichLam.username = username;

            if (!string.IsNullOrEmpty(username))
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                string query = "Select TenUserHienThi from TaiKhoan where Username= '" + username + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                string TenHienThi = (string)cmd.ExecuteScalar();
                mucTaikhoan.Text = TenHienThi;
                NhanVienThanhToan = TenHienThi;
            }
        }

        void PhanQuyenNhanVien()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "Select LoaiTaiKhoan from TaiKhoan where Username= '" + username + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            Int32 LoaiTaiKhoan = (Int32)cmd.ExecuteScalar();


            if (LoaiTaiKhoan == 1)
            {
                mucQuanly.Dispose();               
            }
        }

        void LuaChonMacDinh()
        {
            labelTienGiamGia.Text = "0";
            MonDuocChon = dataGridViewMenu.Rows[0].Cells[0].Value.ToString();
            DonGia = Convert.ToDouble(dataGridViewMenu.Rows[0].Cells[2].Value.ToString());
            ThanhTien = Soluong * DonGia;
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                MonDuocChon = dataGridViewMenu.Rows[numrow].Cells[0].Value.ToString();
                string x = dataGridViewMenu.Rows[numrow].Cells[2].Value.ToString();
                DonGia = Convert.ToDouble(x);
            }          
        }

        private void listViewBill_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewBill.Columns[e.ColumnIndex].Width;
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (Soluong>0)      //Nếu Số lượng thêm vào lớn hơn 0 thì mới thực hiện lệnh thêm
            {
                if (count > 0)      //Kt Bill đã có món hay chưa: count>0 suy ra Bill đã có món
                {                  
                    int vitrimontrung = 0;
                    int countmon = 0;
                    for (int i = 0; i < count; i++) //Kiểm tra món vừa chọn có trùng hay không
                    {
                        string mondacotrongbill = listViewBill.Items[i].SubItems[0].Text;
                        if (mondacotrongbill == MonDuocChon)
                        {
                            vitrimontrung = i; //Lấy vị trí món trùng nếu có
                            countmon++;    
                        }
                    }
                    if (countmon > 0)   //Nếu countmon>0 suy ra món vừa chọn đã có trong bill nên chỉ thay đổi số lượng của món trong bill
                    {
                        int soluongcu = Convert.ToInt32(listViewBill.Items[vitrimontrung].SubItems[1].Text.ToString());
                        int soluongmoi = soluongcu + Soluong;
                        listViewBill.Items[vitrimontrung].SubItems[1].Text = Convert.ToString(soluongmoi);
                        listViewBill.Items[vitrimontrung].SubItems[3].Text = Convert.ToString(soluongmoi * Convert.ToDouble(listViewBill.Items[vitrimontrung].SubItems[2].Text));
                        TongTien = TongTien + Soluong * Convert.ToDouble(listViewBill.Items[vitrimontrung].SubItems[2].Text);   //Tổng tiền cộng thêm tiền của số lượng*giá của món mới vừa thêm
                    }
                    else    //Nếu countmon<=0 suy ra món vừa chọn không có trong bill
                    {
                        ThanhTien = DonGia * Soluong;
                        string[] item = { MonDuocChon, Convert.ToString(Soluong), Convert.ToString(DonGia), Convert.ToString(ThanhTien) };
                        var x = new ListViewItem(item);
                        listViewBill.Items.Add(x);
                        TongTien = TongTien + ThanhTien;
                        count++;
                    }
                }

                if (count == 0)     //Bill chưa có món nào
                {
                    ThanhTien = DonGia * Soluong;
                    string[] item = { MonDuocChon, Convert.ToString(Soluong), Convert.ToString(DonGia), Convert.ToString(ThanhTien) };
                    var x = new ListViewItem(item);
                    listViewBill.Items.Add(x);
                    count++;
                    TongTien = TongTien + ThanhTien;
                }
                listViewBill.Columns[1].TextAlign = HorizontalAlignment.Right;
                listViewBill.Columns[2].TextAlign = HorizontalAlignment.Right;
                listViewBill.Columns[3].TextAlign = HorizontalAlignment.Right;
                TienGiamGia = (TongTien * 10) / 100;
                HienTongTien();
            }
            if (labelTienGiamGia.Text != "0")
            {
                labelTienGiamGia.Text = Convert.ToString(TienGiamGia);
                textBoxTongTien.Text = Convert.ToString(Convert.ToDouble(labelGiaTamTinh.Text) - TienGiamGia);
            }

        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (Soluong>0)
            {
                if (count > 0)      //Kt Bill đã có món hay chưa: count>0 suy ra Bill đã có món
                {
                    int vitrimontrung = 0;
                    int countmon = 0;
                    for (int i = 0; i < count; i++)     //Kiểm tra món vừa chọn có trùng hay không
                    {
                        string mondacotrongbill = listViewBill.Items[i].SubItems[0].Text;
                        if (mondacotrongbill == MonDuocChon)    
                        {
                            vitrimontrung = i;      //Lấy vị trí món trùng nếu có
                            countmon++;
                        }
                    }
                    if (countmon > 0)   //Nếu countmon>0 suy ra món vừa chọn đã có trong bill nên chỉ thay đổi số lượng của món trong bill
                    {
                        int soluonghientai = Convert.ToInt32(listViewBill.Items[vitrimontrung].SubItems[1].Text.ToString());
                        if (soluonghientai - Soluong <= 0)      //Nếu số lượng hiện tại trừ số lượng cần xóa < 0
                        {
                            if (soluonghientai < Soluong)       //Nếu số lượng cần xóa lớn hơn số lượng hiện tại, lấy tổng tiền - số lượng hiện tại*đơn giá 
                            {
                                TongTien = TongTien - soluonghientai * Convert.ToDouble(listViewBill.Items[vitrimontrung].SubItems[2].Text);
                                count--;
                                listViewBill.Items[vitrimontrung].Remove();
                            }
                            if (soluonghientai >= Soluong)       //Nếu số lượng cần xóa nhỏ hơn số lượng hiện tại thì trừ tiền bình thường
                            {
                                TongTien = TongTien - Soluong * Convert.ToDouble(listViewBill.Items[vitrimontrung].SubItems[2].Text);
                                count--;
                                listViewBill.Items[vitrimontrung].Remove();
                            }
                        }
                        else        //Nếu số lượng hiện tại trừ số lượng cần xóa > 0 thì trừ tiền bình thường
                        {
                            soluonghientai = Convert.ToInt32(listViewBill.Items[vitrimontrung].SubItems[1].Text.ToString());
                            int soluongmoi = soluonghientai - Soluong;
                            listViewBill.Items[vitrimontrung].SubItems[1].Text = Convert.ToString(soluongmoi);
                            listViewBill.Items[vitrimontrung].SubItems[3].Text = Convert.ToString(soluongmoi * Convert.ToDouble(listViewBill.Items[vitrimontrung].SubItems[2].Text));
                            TongTien = TongTien - Soluong * Convert.ToDouble(listViewBill.Items[vitrimontrung].SubItems[2].Text);
                        }
                    }
                }
                listViewBill.Columns[1].TextAlign = HorizontalAlignment.Right;
                listViewBill.Columns[2].TextAlign = HorizontalAlignment.Right;
                listViewBill.Columns[3].TextAlign = HorizontalAlignment.Right;
                TienGiamGia = (TongTien * 10) / 100;
                HienTongTien();
            }
            if (labelTienGiamGia.Text != "")
            {
                labelTienGiamGia.Text = Convert.ToString(TienGiamGia);
            }
            if (textBoxTongTien.Text != "")
            {
                textBoxTongTien.Text = Convert.ToString(Convert.ToDouble(textBoxTongTien.Text) - TienGiamGia);
            }
        }

        void HienTongTien()
        {
            textBoxTongTien.Text = Convert.ToString(TongTien);
            labelGiaTamTinh.Text = Convert.ToString(TongTien);
        }

        private void SoLuongMonThem_ValueChanged(object sender, EventArgs e)
        {
            Int32 nn = Convert.ToInt32(SoLuongMonThem.Value.ToString());
            Soluong = nn;
        }


        public int countGiamGia = 0;
        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            countGiamGia++;
            if (countGiamGia % 2 != 0)
            {
                labelTienGiamGia.Text = Convert.ToString(TienGiamGia);
                textBoxTongTien.Text = Convert.ToString(TongTien - TienGiamGia);
            }
            else
            {
                labelTienGiamGia.Text = "0";
                textBoxTongTien.Text = Convert.ToString(TongTien);
            }
        }

        private void btnThanhToanCash_Click(object sender, EventArgs e)
        {
            string Ngay = DateTime.Now.ToString("dd/MM/yyyy");

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            if (listViewBill.Items.Count != 0)
            {               
                DialogResult dlr = MessageBox.Show("Ngày Lập Bill: " + Ngay + "\t Nhân viên: " + NhanVienThanhToan + "\nTổng tiền: " + textBoxTongTien.Text + "\nGiảm giá: " + labelTienGiamGia.Text + "\nHình Thức Thanh Toán: Tiền mặt", "Xác Nhận Thanh Toán", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {                   
                    string queryKiemTraIdRong = "Select Id from Bill";
                    SqlCommand cmdKiemTraIdRong = new SqlCommand(queryKiemTraIdRong, connection);
                    if (cmdKiemTraIdRong.ExecuteScalar() != null)
                    {
                        string queryLayIdGanNhat = "select max(Id) from Bill";
                        SqlCommand cmdLayIdGanNhat = new SqlCommand(queryLayIdGanNhat, connection);
                        string id = Convert.ToString(cmdLayIdGanNhat.ExecuteScalar());                       

                        string queryThemBill = "insert into Bill(Id,NgayLapBill,HinhThucThanhToan,TongBill,GiamGia,NhanVienLap) values(@Id, @NgayLapBill, @HinhThucThanhToan, @TongBill,@GiamGia,@NhanVienLap)";
                        SqlCommand cmdThemBill = new SqlCommand(queryThemBill, connection);

                        cmdThemBill.Parameters.AddWithValue("Id",Convert.ToInt32(id) + 1);
                        cmdThemBill.Parameters.AddWithValue("NgayLapBill", Convert.ToDateTime(Ngay));
                        cmdThemBill.Parameters.AddWithValue("HinhThucThanhToan", "Tiền Mặt");
                        cmdThemBill.Parameters.AddWithValue("TongBill", Convert.ToDouble(textBoxTongTien.Text));
                        cmdThemBill.Parameters.AddWithValue("GiamGia", Convert.ToDouble(labelTienGiamGia.Text));
                        cmdThemBill.Parameters.AddWithValue("NhanVienLap", username);
                        cmdThemBill.ExecuteNonQuery();

                        //Thêm vào chi tiết bill
                        for (int sodong = 0; sodong < count; sodong++)
                        {
                            string queryLayIdFD = "select Id from FoodDrink where TenFoodDrink = N'"+ listViewBill.Items[sodong].SubItems[0].Text + "'";
                            SqlCommand cmdLayIdFD = new SqlCommand(queryLayIdFD, connection);
                            int IdFD = Convert.ToInt32(cmdLayIdFD.ExecuteScalar());

                            string queryThemChiTietBill = "insert into ChiTietBill(IdBill,IdFD,TenFoodDrink_CTB,SoLuong,DonGia_CTB) values (@IdBill,@IdFD,@TenFoodDrink_CTB,@SoLuong,@DonGia_CTB)";
                            SqlCommand cmdThemChiTietBill = new SqlCommand(queryThemChiTietBill, connection);
                            cmdThemChiTietBill.Parameters.AddWithValue("IdBill", Convert.ToInt32(id) + 1);
                            cmdThemChiTietBill.Parameters.AddWithValue("IdFD", IdFD);
                            cmdThemChiTietBill.Parameters.AddWithValue("TenFoodDrink_CTB", listViewBill.Items[sodong].SubItems[0].Text);
                            cmdThemChiTietBill.Parameters.AddWithValue("SoLuong", listViewBill.Items[sodong].SubItems[1].Text);
                            cmdThemChiTietBill.Parameters.AddWithValue("DonGia_CTB", listViewBill.Items[sodong].SubItems[2].Text);
                            cmdThemChiTietBill.ExecuteNonQuery();
                        }
                    }
                    if (cmdKiemTraIdRong.ExecuteScalar() == null)
                    {
                        string queryThemBill = "insert into Bill(Id,NgayLapBill,HinhThucThanhToan,TongBill,GiamGia,NhanVienLap) values(@Id, @NgayLapBill, @HinhThucThanhToan, @TongBill,@GiamGia,@NhanVienLap)";
                        SqlCommand cmdThemBill = new SqlCommand(queryThemBill, connection);

                        cmdThemBill.Parameters.AddWithValue("Id", 1);
                        cmdThemBill.Parameters.AddWithValue("NgayLapBill", Convert.ToDateTime(Ngay));
                        cmdThemBill.Parameters.AddWithValue("HinhThucThanhToan", "Tiền Mặt");
                        cmdThemBill.Parameters.AddWithValue("TongBill", Convert.ToDouble(textBoxTongTien.Text));
                        cmdThemBill.Parameters.AddWithValue("GiamGia", Convert.ToDouble(labelTienGiamGia.Text));
                        cmdThemBill.Parameters.AddWithValue("NhanVienLap", username);
                        cmdThemBill.ExecuteNonQuery();

                        //Thêm vào bảng chi tiết bill
                        for (int sodong = 0; sodong < count; sodong++)
                        {
                            string queryLayIdFD = "select Id from FoodDrink where TenFoodDrink = N'" + listViewBill.Items[sodong].SubItems[0].Text + "'";
                            SqlCommand cmdLayIdFD = new SqlCommand(queryLayIdFD, connection);
                            int IdFD = Convert.ToInt32(cmdLayIdFD.ExecuteScalar());

                            string queryThemChiTietBill = "insert into ChiTietBill(IdBill,IdFD,TenFoodDrink_CTB,SoLuong,DonGia_CTB) values (@IdBill,@IdFD,@TenFoodDrink_CTB,@SoLuong,@DonGia_CTB)";
                            SqlCommand cmdThemChiTietBill = new SqlCommand(queryThemChiTietBill, connection);
                            cmdThemChiTietBill.Parameters.AddWithValue("IdBill", 1);
                            cmdThemChiTietBill.Parameters.AddWithValue("IdFD", IdFD);
                            cmdThemChiTietBill.Parameters.AddWithValue("TenFoodDrink_CTB", listViewBill.Items[sodong].SubItems[0].Text);
                            cmdThemChiTietBill.Parameters.AddWithValue("SoLuong", listViewBill.Items[sodong].SubItems[1].Text);
                            cmdThemChiTietBill.Parameters.AddWithValue("DonGia_CTB", listViewBill.Items[sodong].SubItems[2].Text);
                            cmdThemChiTietBill.ExecuteNonQuery();
                        }
                    }

                    //Xóa tạo bill mới
                    for (int n = count - 1; n >= 0; n--)
                    {
                        listViewBill.Items[n].Remove();
                    }

                    count = 0;
                    TongTien = 0;
                    labelTienGiamGia.Text = "0";
                    labelGiaTamTinh.Text = "0";
                    textBoxTongTien.Text = "0";
                    return;
                }

                if (dlr == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void buttonThanhToanCredit_Click(object sender, EventArgs e)
        {
            string Ngay = DateTime.Now.ToString("dd/MM/yyyy");

            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            if (listViewBill.Items.Count != 0)  //Kiểm tra bill rỗng hay không, bill có món thì mới thanh toán
            {
                DialogResult dlr = MessageBox.Show("Ngày Lập Bill: " + Ngay + "\t Nhân viên: " + NhanVienThanhToan + "\nTổng tiền: " + textBoxTongTien.Text + "\nGiảm giá: " + labelTienGiamGia.Text + "\nHình Thức Thanh Toán: Credit Card", "Xác Nhận Thanh Toán", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {                 
                    string queryKiemTraIdRong = "Select Id from Bill";
                    SqlCommand cmdKiemTraIdRong = new SqlCommand(queryKiemTraIdRong, connection);
                    if (cmdKiemTraIdRong.ExecuteScalar() != null)
                    {
                        string queryLayIdGanNhat = "select max(Id) from Bill";
                        SqlCommand cmdLayIdGanNhat = new SqlCommand(queryLayIdGanNhat, connection);
                        string id = Convert.ToString(cmdLayIdGanNhat.ExecuteScalar());

                        string queryThemBill = "insert into Bill(Id,NgayLapBill,HinhThucThanhToan,TongBill,GiamGia,NhanVienLap) values(@Id, @NgayLapBill, @HinhThucThanhToan, @TongBill,@GiamGia,@NhanVienLap)";
                        SqlCommand cmdThemBill = new SqlCommand(queryThemBill, connection);

                        cmdThemBill.Parameters.AddWithValue("Id", Convert.ToInt32(id) + 1);
                        cmdThemBill.Parameters.AddWithValue("NgayLapBill", Convert.ToDateTime(Ngay));
                        cmdThemBill.Parameters.AddWithValue("HinhThucThanhToan", "Credit Card");
                        cmdThemBill.Parameters.AddWithValue("TongBill", Convert.ToDouble(textBoxTongTien.Text));
                        cmdThemBill.Parameters.AddWithValue("GiamGia", Convert.ToDouble(labelTienGiamGia.Text));
                        cmdThemBill.Parameters.AddWithValue("NhanVienLap", username);
                        cmdThemBill.ExecuteNonQuery();

                        //Thêm vào chi tiết bill
                        for (int sodong = 0; sodong < count; sodong++)
                        {
                            string queryLayIdFD = "select Id from FoodDrink where TenFoodDrink = N'" + listViewBill.Items[sodong].SubItems[0].Text + "'";
                            SqlCommand cmdLayIdFD = new SqlCommand(queryLayIdFD, connection);
                            int IdFD = Convert.ToInt32(cmdLayIdFD.ExecuteScalar());

                            string queryThemChiTietBill = "insert into ChiTietBill(IdBill,IdFD,TenFoodDrink_CTB,SoLuong,DonGia_CTB) values (@IdBill,@IdFD,@TenFoodDrink_CTB,@SoLuong,@DonGia_CTB)";
                            SqlCommand cmdThemChiTietBill = new SqlCommand(queryThemChiTietBill, connection);
                            cmdThemChiTietBill.Parameters.AddWithValue("IdBill", Convert.ToInt32(id) + 1);
                            cmdThemChiTietBill.Parameters.AddWithValue("IdFD", IdFD);
                            cmdThemChiTietBill.Parameters.AddWithValue("TenFoodDrink_CTB", listViewBill.Items[sodong].SubItems[0].Text);
                            cmdThemChiTietBill.Parameters.AddWithValue("SoLuong", listViewBill.Items[sodong].SubItems[1].Text);
                            cmdThemChiTietBill.Parameters.AddWithValue("DonGia_CTB", listViewBill.Items[sodong].SubItems[2].Text);
                            cmdThemChiTietBill.ExecuteNonQuery();
                        }
                    }
                    if (cmdKiemTraIdRong.ExecuteScalar() == null)
                    {
                        string queryThemBill = "insert into Bill(Id,NgayLapBill,HinhThucThanhToan,TongBill,GiamGia,NhanVienLap) values(@Id, @NgayLapBill, @HinhThucThanhToan, @TongBill,@GiamGia,@NhanVienLap)";
                        SqlCommand cmdThemBill = new SqlCommand(queryThemBill, connection);

                        cmdThemBill.Parameters.AddWithValue("Id", 1);
                        cmdThemBill.Parameters.AddWithValue("NgayLapBill", Convert.ToDateTime(Ngay));
                        cmdThemBill.Parameters.AddWithValue("HinhThucThanhToan", "Credit Card");
                        cmdThemBill.Parameters.AddWithValue("TongBill", Convert.ToDouble(textBoxTongTien.Text));
                        cmdThemBill.Parameters.AddWithValue("GiamGia", Convert.ToDouble(labelTienGiamGia.Text));
                        cmdThemBill.Parameters.AddWithValue("NhanVienLap", username);
                        cmdThemBill.ExecuteNonQuery();

                        for (int sodong = 0; sodong < count; sodong++)
                        {
                            string queryLayIdFD = "select Id from FoodDrink where TenFoodDrink = N'" + listViewBill.Items[sodong].SubItems[0].Text + "'";
                            SqlCommand cmdLayIdFD = new SqlCommand(queryLayIdFD, connection);
                            int IdFD = Convert.ToInt32(cmdLayIdFD.ExecuteScalar());

                            string queryThemChiTietBill = "insert into ChiTietBill(IdBill,IdFD,TenFoodDrink_CTB,SoLuong,DonGia_CTB) values (@IdBill,@IdFD,@TenFoodDrink_CTB,@SoLuong,@DonGia_CTB)";
                            SqlCommand cmdThemChiTietBill = new SqlCommand(queryThemChiTietBill, connection);
                            cmdThemChiTietBill.Parameters.AddWithValue("IdBill", 1);
                            cmdThemChiTietBill.Parameters.AddWithValue("IdFD", IdFD);
                            cmdThemChiTietBill.Parameters.AddWithValue("TenFoodDrink_CTB", listViewBill.Items[sodong].SubItems[0].Text);
                            cmdThemChiTietBill.Parameters.AddWithValue("SoLuong", listViewBill.Items[sodong].SubItems[1].Text);
                            cmdThemChiTietBill.Parameters.AddWithValue("DonGia_CTB", listViewBill.Items[sodong].SubItems[2].Text);
                            cmdThemChiTietBill.ExecuteNonQuery();
                        }
                    }

                    //Xóa tạo bill mới
                    for (int n = count - 1; n >= 0; n--)
                    {
                        listViewBill.Items[n].Remove();
                    }

                    count = 0;
                    TongTien = 0;
                    labelTienGiamGia.Text = "0";
                    labelGiaTamTinh.Text = "0";
                    textBoxTongTien.Text = "0";
                    return;
                }

                if (dlr == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void buttonRefeshBill_Click(object sender, EventArgs e)
        {
            for (int n = count - 1; n >= 0; n--)
            {
                listViewBill.Items[n].Remove();
            }
            count = 0;
            TongTien = 0;
            labelTienGiamGia.Text = "0";
            labelGiaTamTinh.Text = "0";
            textBoxTongTien.Text = "0";
        }

        private void mucBaoCao_Click(object sender, EventArgs e)
        {
            formBaoCao f = new formBaoCao();
            f.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            string query = "Select LoaiTaiKhoan from TaiKhoan where Username= '" + username + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            Int32 LoaiTaiKhoan = (Int32)cmd.ExecuteScalar();

            if (LoaiTaiKhoan == 1)
            {
                MessageBox.Show("Bạn không phải là Quản lý nên không được truy cập !!!", "Thông báo");

            }
            else
            {
                formQuanLyNhanVien f = new formQuanLyNhanVien();
                f.Show();
            }        
        }

        private void xemLịchLàmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLichLam f = new formLichLam();
            f.Show();
        }

        private void formQuanLiBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNhapHang f = new formNhapHang();
            f.ShowDialog();
        }
    }
}
