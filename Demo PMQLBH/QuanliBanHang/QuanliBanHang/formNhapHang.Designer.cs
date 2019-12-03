namespace QuanliBanHang
{
    partial class formNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNhapHang));
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaPhieu = new System.Windows.Forms.Label();
            this.textBoxMaPhieu = new System.Windows.Forms.TextBox();
            this.labelNgayTao = new System.Windows.Forms.Label();
            this.dateTimePickerNgayTao = new System.Windows.Forms.DateTimePicker();
            this.labelNCC = new System.Windows.Forms.Label();
            this.labelDiaChiNCC = new System.Windows.Forms.Label();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.buttonLuuPhieu = new System.Windows.Forms.Button();
            this.dataGridViewNhapHang = new System.Windows.Forms.DataGridView();
            this.ColumnTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonViTinh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDanhSachPhieuNhap = new System.Windows.Forms.DataGridView();
            this.comboBoxNCC = new System.Windows.Forms.ComboBox();
            this.labelDanhSachPhieuNhap = new System.Windows.Forms.Label();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.labelTuNgay = new System.Windows.Forms.Label();
            this.labelDenNgay = new System.Windows.Forms.Label();
            this.buttonHienPhieuNhap = new System.Windows.Forms.Button();
            this.buttonChiTietPhieuNhap = new System.Windows.Forms.Button();
            this.textBoxNVLapPhieu = new System.Windows.Forms.TextBox();
            this.labelNVLapPhieu = new System.Windows.Forms.Label();
            this.textBoxDiaChiNCC = new System.Windows.Forms.TextBox();
            this.buttonXoaPhieuNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phiếu nhập hàng";
            // 
            // labelMaPhieu
            // 
            this.labelMaPhieu.AutoSize = true;
            this.labelMaPhieu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaPhieu.Location = new System.Drawing.Point(14, 65);
            this.labelMaPhieu.Name = "labelMaPhieu";
            this.labelMaPhieu.Size = new System.Drawing.Size(92, 22);
            this.labelMaPhieu.TabIndex = 0;
            this.labelMaPhieu.Text = "Mã phiếu:";
            // 
            // textBoxMaPhieu
            // 
            this.textBoxMaPhieu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMaPhieu.Location = new System.Drawing.Point(137, 59);
            this.textBoxMaPhieu.Name = "textBoxMaPhieu";
            this.textBoxMaPhieu.Size = new System.Drawing.Size(100, 28);
            this.textBoxMaPhieu.TabIndex = 1;
            // 
            // labelNgayTao
            // 
            this.labelNgayTao.AutoSize = true;
            this.labelNgayTao.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNgayTao.Location = new System.Drawing.Point(246, 65);
            this.labelNgayTao.Name = "labelNgayTao";
            this.labelNgayTao.Size = new System.Drawing.Size(89, 22);
            this.labelNgayTao.TabIndex = 0;
            this.labelNgayTao.Text = "Ngày tạo:";
            // 
            // dateTimePickerNgayTao
            // 
            this.dateTimePickerNgayTao.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayTao.Location = new System.Drawing.Point(341, 59);
            this.dateTimePickerNgayTao.Name = "dateTimePickerNgayTao";
            this.dateTimePickerNgayTao.Size = new System.Drawing.Size(152, 28);
            this.dateTimePickerNgayTao.TabIndex = 2;
            // 
            // labelNCC
            // 
            this.labelNCC.AutoSize = true;
            this.labelNCC.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNCC.Location = new System.Drawing.Point(14, 99);
            this.labelNCC.Name = "labelNCC";
            this.labelNCC.Size = new System.Drawing.Size(57, 22);
            this.labelNCC.TabIndex = 0;
            this.labelNCC.Text = "NCC:";
            // 
            // labelDiaChiNCC
            // 
            this.labelDiaChiNCC.AutoSize = true;
            this.labelDiaChiNCC.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDiaChiNCC.Location = new System.Drawing.Point(14, 133);
            this.labelDiaChiNCC.Name = "labelDiaChiNCC";
            this.labelDiaChiNCC.Size = new System.Drawing.Size(120, 22);
            this.labelDiaChiNCC.TabIndex = 0;
            this.labelDiaChiNCC.Text = "Địa chỉ NCC:";
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTongTien.Location = new System.Drawing.Point(341, 161);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(152, 28);
            this.textBoxTongTien.TabIndex = 6;
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTongTien.Location = new System.Drawing.Point(246, 167);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(93, 22);
            this.labelTongTien.TabIndex = 0;
            this.labelTongTien.Text = "Tổng tiền:";
            // 
            // buttonLuuPhieu
            // 
            this.buttonLuuPhieu.BackColor = System.Drawing.Color.Red;
            this.buttonLuuPhieu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonLuuPhieu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLuuPhieu.Location = new System.Drawing.Point(18, 487);
            this.buttonLuuPhieu.Name = "buttonLuuPhieu";
            this.buttonLuuPhieu.Size = new System.Drawing.Size(476, 47);
            this.buttonLuuPhieu.TabIndex = 8;
            this.buttonLuuPhieu.Text = "Lưu Phiếu";
            this.buttonLuuPhieu.UseVisualStyleBackColor = false;
            this.buttonLuuPhieu.Click += new System.EventHandler(this.buttonLuuPhieu_Click);
            // 
            // dataGridViewNhapHang
            // 
            this.dataGridViewNhapHang.AllowUserToOrderColumns = true;
            this.dataGridViewNhapHang.AllowUserToResizeColumns = false;
            this.dataGridViewNhapHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTenHang,
            this.ColumnSoLuong,
            this.ColumnDonViTinh,
            this.ColumnDonGia,
            this.ColumnThanhTien});
            this.dataGridViewNhapHang.Location = new System.Drawing.Point(18, 195);
            this.dataGridViewNhapHang.Name = "dataGridViewNhapHang";
            this.dataGridViewNhapHang.RowHeadersVisible = false;
            this.dataGridViewNhapHang.RowHeadersWidth = 51;
            this.dataGridViewNhapHang.RowTemplate.Height = 24;
            this.dataGridViewNhapHang.Size = new System.Drawing.Size(476, 286);
            this.dataGridViewNhapHang.TabIndex = 7;
            // 
            // ColumnTenHang
            // 
            this.ColumnTenHang.HeaderText = "Tên hàng";
            this.ColumnTenHang.MinimumWidth = 6;
            this.ColumnTenHang.Name = "ColumnTenHang";
            this.ColumnTenHang.Width = 150;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.HeaderText = "Số Lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.Width = 125;
            // 
            // ColumnDonViTinh
            // 
            this.ColumnDonViTinh.HeaderText = "Đơn vị tính";
            this.ColumnDonViTinh.Items.AddRange(new object[] {
            "thùng (24 lon)",
            "hộp",
            "kg",
            "gam"});
            this.ColumnDonViTinh.MinimumWidth = 6;
            this.ColumnDonViTinh.Name = "ColumnDonViTinh";
            this.ColumnDonViTinh.Width = 125;
            // 
            // ColumnDonGia
            // 
            this.ColumnDonGia.HeaderText = "Đơn giá";
            this.ColumnDonGia.MinimumWidth = 6;
            this.ColumnDonGia.Name = "ColumnDonGia";
            this.ColumnDonGia.Width = 165;
            // 
            // ColumnThanhTien
            // 
            this.ColumnThanhTien.HeaderText = "Thành Tiền";
            this.ColumnThanhTien.MinimumWidth = 6;
            this.ColumnThanhTien.Name = "ColumnThanhTien";
            this.ColumnThanhTien.Width = 125;
            // 
            // dataGridViewDanhSachPhieuNhap
            // 
            this.dataGridViewDanhSachPhieuNhap.AllowUserToAddRows = false;
            this.dataGridViewDanhSachPhieuNhap.AllowUserToDeleteRows = false;
            this.dataGridViewDanhSachPhieuNhap.AllowUserToResizeColumns = false;
            this.dataGridViewDanhSachPhieuNhap.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDanhSachPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDanhSachPhieuNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDanhSachPhieuNhap.Location = new System.Drawing.Point(568, 149);
            this.dataGridViewDanhSachPhieuNhap.Name = "dataGridViewDanhSachPhieuNhap";
            this.dataGridViewDanhSachPhieuNhap.ReadOnly = true;
            this.dataGridViewDanhSachPhieuNhap.RowHeadersVisible = false;
            this.dataGridViewDanhSachPhieuNhap.RowHeadersWidth = 51;
            this.dataGridViewDanhSachPhieuNhap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDanhSachPhieuNhap.RowTemplate.Height = 24;
            this.dataGridViewDanhSachPhieuNhap.Size = new System.Drawing.Size(476, 385);
            this.dataGridViewDanhSachPhieuNhap.TabIndex = 14;
            this.dataGridViewDanhSachPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachPhieuNhap_CellClick);
            // 
            // comboBoxNCC
            // 
            this.comboBoxNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNCC.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxNCC.FormattingEnabled = true;
            this.comboBoxNCC.Items.AddRange(new object[] {
            "--",
            "Cty TNHH Tân Hiệp Phát",
            "Cty Cung Cấp Rau Quả Hoàng Anh",
            "Cty Cung Cấp Trứng Gà D&M",
            "Cty TNHH MegaFood (NCC các loại cá viên)",
            "Cty TNHH AceCook (NCC các loại mì,nui,gạo)",
            "Cty Cung Cấp Gia Vị Tiêu Dùng GiaVi"});
            this.comboBoxNCC.Location = new System.Drawing.Point(137, 93);
            this.comboBoxNCC.Name = "comboBoxNCC";
            this.comboBoxNCC.Size = new System.Drawing.Size(356, 28);
            this.comboBoxNCC.TabIndex = 3;
            this.comboBoxNCC.SelectedIndexChanged += new System.EventHandler(this.comboBoxNCC_SelectedIndexChanged);
            // 
            // labelDanhSachPhieuNhap
            // 
            this.labelDanhSachPhieuNhap.AutoSize = true;
            this.labelDanhSachPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDanhSachPhieuNhap.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDanhSachPhieuNhap.Location = new System.Drawing.Point(562, 9);
            this.labelDanhSachPhieuNhap.Name = "labelDanhSachPhieuNhap";
            this.labelDanhSachPhieuNhap.Size = new System.Drawing.Size(285, 32);
            this.labelDanhSachPhieuNhap.TabIndex = 0;
            this.labelDanhSachPhieuNhap.Text = "Danh sách phiếu nhập";
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(609, 56);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(152, 28);
            this.dateTimePickerTuNgay.TabIndex = 9;
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(892, 56);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(152, 28);
            this.dateTimePickerDenNgay.TabIndex = 10;
            // 
            // labelTuNgay
            // 
            this.labelTuNgay.AutoSize = true;
            this.labelTuNgay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTuNgay.Location = new System.Drawing.Point(564, 62);
            this.labelTuNgay.Name = "labelTuNgay";
            this.labelTuNgay.Size = new System.Drawing.Size(39, 22);
            this.labelTuNgay.TabIndex = 0;
            this.labelTuNgay.Text = "Từ:";
            // 
            // labelDenNgay
            // 
            this.labelDenNgay.AutoSize = true;
            this.labelDenNgay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDenNgay.Location = new System.Drawing.Point(838, 62);
            this.labelDenNgay.Name = "labelDenNgay";
            this.labelDenNgay.Size = new System.Drawing.Size(48, 22);
            this.labelDenNgay.TabIndex = 0;
            this.labelDenNgay.Text = "Đến:";
            // 
            // buttonHienPhieuNhap
            // 
            this.buttonHienPhieuNhap.BackColor = System.Drawing.Color.Red;
            this.buttonHienPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonHienPhieuNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHienPhieuNhap.Location = new System.Drawing.Point(566, 87);
            this.buttonHienPhieuNhap.Name = "buttonHienPhieuNhap";
            this.buttonHienPhieuNhap.Size = new System.Drawing.Size(157, 57);
            this.buttonHienPhieuNhap.TabIndex = 11;
            this.buttonHienPhieuNhap.Text = "Danh sách phiếu nhập";
            this.buttonHienPhieuNhap.UseVisualStyleBackColor = false;
            this.buttonHienPhieuNhap.Click += new System.EventHandler(this.buttonHienPhieuNhap_Click);
            // 
            // buttonChiTietPhieuNhap
            // 
            this.buttonChiTietPhieuNhap.BackColor = System.Drawing.Color.Red;
            this.buttonChiTietPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonChiTietPhieuNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChiTietPhieuNhap.Location = new System.Drawing.Point(727, 87);
            this.buttonChiTietPhieuNhap.Name = "buttonChiTietPhieuNhap";
            this.buttonChiTietPhieuNhap.Size = new System.Drawing.Size(157, 57);
            this.buttonChiTietPhieuNhap.TabIndex = 12;
            this.buttonChiTietPhieuNhap.Text = "Chi tiết phiếu nhập";
            this.buttonChiTietPhieuNhap.UseVisualStyleBackColor = false;
            this.buttonChiTietPhieuNhap.Click += new System.EventHandler(this.buttonChiTietPhieuNhap_Click);
            // 
            // textBoxNVLapPhieu
            // 
            this.textBoxNVLapPhieu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNVLapPhieu.Location = new System.Drawing.Point(137, 161);
            this.textBoxNVLapPhieu.Name = "textBoxNVLapPhieu";
            this.textBoxNVLapPhieu.ReadOnly = true;
            this.textBoxNVLapPhieu.Size = new System.Drawing.Size(103, 28);
            this.textBoxNVLapPhieu.TabIndex = 5;
            // 
            // labelNVLapPhieu
            // 
            this.labelNVLapPhieu.AutoSize = true;
            this.labelNVLapPhieu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNVLapPhieu.Location = new System.Drawing.Point(13, 167);
            this.labelNVLapPhieu.Name = "labelNVLapPhieu";
            this.labelNVLapPhieu.Size = new System.Drawing.Size(121, 22);
            this.labelNVLapPhieu.TabIndex = 0;
            this.labelNVLapPhieu.Text = "NV lập phiếu:";
            // 
            // textBoxDiaChiNCC
            // 
            this.textBoxDiaChiNCC.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxDiaChiNCC.Location = new System.Drawing.Point(137, 127);
            this.textBoxDiaChiNCC.Name = "textBoxDiaChiNCC";
            this.textBoxDiaChiNCC.ReadOnly = true;
            this.textBoxDiaChiNCC.Size = new System.Drawing.Size(356, 28);
            this.textBoxDiaChiNCC.TabIndex = 4;
            // 
            // buttonXoaPhieuNhap
            // 
            this.buttonXoaPhieuNhap.BackColor = System.Drawing.Color.Red;
            this.buttonXoaPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoaPhieuNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXoaPhieuNhap.Location = new System.Drawing.Point(887, 87);
            this.buttonXoaPhieuNhap.Name = "buttonXoaPhieuNhap";
            this.buttonXoaPhieuNhap.Size = new System.Drawing.Size(157, 57);
            this.buttonXoaPhieuNhap.TabIndex = 13;
            this.buttonXoaPhieuNhap.Text = "Xóa phiếu nhập";
            this.buttonXoaPhieuNhap.UseVisualStyleBackColor = false;
            this.buttonXoaPhieuNhap.Click += new System.EventHandler(this.buttonXoaPhieuNhap_Click);
            // 
            // formNhapHang
            // 
            this.AcceptButton = this.buttonLuuPhieu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 544);
            this.Controls.Add(this.buttonXoaPhieuNhap);
            this.Controls.Add(this.textBoxDiaChiNCC);
            this.Controls.Add(this.textBoxNVLapPhieu);
            this.Controls.Add(this.labelNVLapPhieu);
            this.Controls.Add(this.buttonChiTietPhieuNhap);
            this.Controls.Add(this.buttonHienPhieuNhap);
            this.Controls.Add(this.labelDenNgay);
            this.Controls.Add(this.labelTuNgay);
            this.Controls.Add(this.dateTimePickerDenNgay);
            this.Controls.Add(this.dateTimePickerTuNgay);
            this.Controls.Add(this.labelDanhSachPhieuNhap);
            this.Controls.Add(this.comboBoxNCC);
            this.Controls.Add(this.dataGridViewDanhSachPhieuNhap);
            this.Controls.Add(this.dataGridViewNhapHang);
            this.Controls.Add(this.buttonLuuPhieu);
            this.Controls.Add(this.textBoxTongTien);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.labelDiaChiNCC);
            this.Controls.Add(this.labelNCC);
            this.Controls.Add(this.dateTimePickerNgayTao);
            this.Controls.Add(this.labelNgayTao);
            this.Controls.Add(this.textBoxMaPhieu);
            this.Controls.Add(this.labelMaPhieu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMaPhieu;
        private System.Windows.Forms.TextBox textBoxMaPhieu;
        private System.Windows.Forms.Label labelNgayTao;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTao;
        private System.Windows.Forms.Label labelNCC;
        private System.Windows.Forms.Label labelDiaChiNCC;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Button buttonLuuPhieu;
        private System.Windows.Forms.DataGridView dataGridViewNhapHang;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachPhieuNhap;
        private System.Windows.Forms.ComboBox comboBoxNCC;
        private System.Windows.Forms.Label labelDanhSachPhieuNhap;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private System.Windows.Forms.Label labelTuNgay;
        private System.Windows.Forms.Label labelDenNgay;
        private System.Windows.Forms.Button buttonHienPhieuNhap;
        private System.Windows.Forms.Button buttonChiTietPhieuNhap;
        private System.Windows.Forms.TextBox textBoxNVLapPhieu;
        private System.Windows.Forms.Label labelNVLapPhieu;
        private System.Windows.Forms.TextBox textBoxDiaChiNCC;
        private System.Windows.Forms.Button buttonXoaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnThanhTien;
    }
}