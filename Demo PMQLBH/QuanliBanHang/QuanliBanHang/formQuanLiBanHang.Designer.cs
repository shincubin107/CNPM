namespace QuanliBanHang
{
    partial class formQuanLiBanHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLiBanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mucQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.mucQuanLiBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mucTaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mucThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mucBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mucDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.columnHeaderMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.buttonThanhToanCredit = new System.Windows.Forms.Button();
            this.labelGiaTamTinh = new System.Windows.Forms.Label();
            this.labelTamTinh = new System.Windows.Forms.Label();
            this.labelTienGiamGia = new System.Windows.Forms.Label();
            this.labelGiamGia = new System.Windows.Forms.Label();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.btnThanhToanCash = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefeshBill = new System.Windows.Forms.Button();
            this.SoLuongMonThem = new System.Windows.Forms.NumericUpDown();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.comboBoxDanhMucItems = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDanhMuc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongMonThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mucQuanly
            // 
            this.mucQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mucQuanLiBanHang});
            this.mucQuanly.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mucQuanly.Name = "mucQuanly";
            this.mucQuanly.Size = new System.Drawing.Size(142, 25);
            this.mucQuanly.Text = "Quản Lý SBTC";
            // 
            // mucQuanLiBanHang
            // 
            this.mucQuanLiBanHang.Name = "mucQuanLiBanHang";
            this.mucQuanLiBanHang.Size = new System.Drawing.Size(224, 26);
            this.mucQuanLiBanHang.Text = "Quản lý bán hàng";
            this.mucQuanLiBanHang.Click += new System.EventHandler(this.MucQuanLiBanHang_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mucQuanly,
            this.mucTaikhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1360, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mucTaikhoan
            // 
            this.mucTaikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mucThongTinTaiKhoan,
            this.mucBaoCao,
            this.mucDangXuat});
            this.mucTaikhoan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mucTaikhoan.Name = "mucTaikhoan";
            this.mucTaikhoan.Size = new System.Drawing.Size(102, 25);
            this.mucTaikhoan.Text = "Tài Khoản";
            // 
            // mucThongTinTaiKhoan
            // 
            this.mucThongTinTaiKhoan.Name = "mucThongTinTaiKhoan";
            this.mucThongTinTaiKhoan.Size = new System.Drawing.Size(238, 26);
            this.mucThongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.mucThongTinTaiKhoan.Click += new System.EventHandler(this.MucThongTinTaiKhoan_Click);
            // 
            // mucBaoCao
            // 
            this.mucBaoCao.Name = "mucBaoCao";
            this.mucBaoCao.Size = new System.Drawing.Size(238, 26);
            this.mucBaoCao.Text = "Báo cáo";
            this.mucBaoCao.Click += new System.EventHandler(this.mucBaoCao_Click);
            // 
            // mucDangXuat
            // 
            this.mucDangXuat.Name = "mucDangXuat";
            this.mucDangXuat.Size = new System.Drawing.Size(238, 26);
            this.mucDangXuat.Text = "Đăng xuất";
            this.mucDangXuat.Click += new System.EventHandler(this.MucDangXuat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewBill);
            this.panel2.Location = new System.Drawing.Point(725, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 506);
            this.panel2.TabIndex = 2;
            // 
            // listViewBill
            // 
            this.listViewBill.BackColor = System.Drawing.Color.Azure;
            this.listViewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMonAn,
            this.columnHeaderSoLuong,
            this.columnHeaderDonGia,
            this.columnHeaderThanhTien});
            this.listViewBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listViewBill.FullRowSelect = true;
            this.listViewBill.GridLines = true;
            this.listViewBill.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBill.HoverSelection = true;
            this.listViewBill.Location = new System.Drawing.Point(-1, 5);
            this.listViewBill.MaximumSize = new System.Drawing.Size(632, 502);
            this.listViewBill.MinimumSize = new System.Drawing.Size(632, 502);
            this.listViewBill.MultiSelect = false;
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(632, 502);
            this.listViewBill.TabIndex = 0;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            this.listViewBill.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewBill_ColumnWidthChanging);
            // 
            // columnHeaderMonAn
            // 
            this.columnHeaderMonAn.Text = "Món ăn";
            this.columnHeaderMonAn.Width = 206;
            // 
            // columnHeaderSoLuong
            // 
            this.columnHeaderSoLuong.Text = "Số lượng";
            this.columnHeaderSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSoLuong.Width = 80;
            // 
            // columnHeaderDonGia
            // 
            this.columnHeaderDonGia.Text = "Đơn Giá";
            this.columnHeaderDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDonGia.Width = 80;
            // 
            // columnHeaderThanhTien
            // 
            this.columnHeaderThanhTien.Text = "Thành tiền";
            this.columnHeaderThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderThanhTien.Width = 110;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.buttonThanhToanCredit);
            this.panel3.Controls.Add(this.labelGiaTamTinh);
            this.panel3.Controls.Add(this.labelTamTinh);
            this.panel3.Controls.Add(this.labelTienGiamGia);
            this.panel3.Controls.Add(this.labelGiamGia);
            this.panel3.Controls.Add(this.textBoxTongTien);
            this.panel3.Controls.Add(this.labelTongTien);
            this.panel3.Controls.Add(this.btnThanhToanCash);
            this.panel3.Location = new System.Drawing.Point(724, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 126);
            this.panel3.TabIndex = 3;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.BackColor = System.Drawing.Color.Red;
            this.btnGiamGia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiamGia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiamGia.Location = new System.Drawing.Point(-1, -1);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(120, 125);
            this.btnGiamGia.TabIndex = 6;
            this.btnGiamGia.Text = "HappyDay 10%";
            this.btnGiamGia.UseVisualStyleBackColor = false;
            this.btnGiamGia.Click += new System.EventHandler(this.btnGiamGia_Click);
            // 
            // buttonThanhToanCredit
            // 
            this.buttonThanhToanCredit.BackColor = System.Drawing.Color.Red;
            this.buttonThanhToanCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThanhToanCredit.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThanhToanCredit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonThanhToanCredit.Location = new System.Drawing.Point(535, 1);
            this.buttonThanhToanCredit.Name = "buttonThanhToanCredit";
            this.buttonThanhToanCredit.Size = new System.Drawing.Size(96, 123);
            this.buttonThanhToanCredit.TabIndex = 8;
            this.buttonThanhToanCredit.Text = "Credit Card";
            this.buttonThanhToanCredit.UseVisualStyleBackColor = false;
            this.buttonThanhToanCredit.Click += new System.EventHandler(this.buttonThanhToanCredit_Click);
            // 
            // labelGiaTamTinh
            // 
            this.labelGiaTamTinh.AutoSize = true;
            this.labelGiaTamTinh.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelGiaTamTinh.Location = new System.Drawing.Point(280, 13);
            this.labelGiaTamTinh.MinimumSize = new System.Drawing.Size(160, 30);
            this.labelGiaTamTinh.Name = "labelGiaTamTinh";
            this.labelGiaTamTinh.Size = new System.Drawing.Size(160, 30);
            this.labelGiaTamTinh.TabIndex = 12;
            this.labelGiaTamTinh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelTamTinh
            // 
            this.labelTamTinh.AutoSize = true;
            this.labelTamTinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTamTinh.Location = new System.Drawing.Point(118, 19);
            this.labelTamTinh.Name = "labelTamTinh";
            this.labelTamTinh.Size = new System.Drawing.Size(87, 23);
            this.labelTamTinh.TabIndex = 11;
            this.labelTamTinh.Text = "Tạm tính";
            // 
            // labelTienGiamGia
            // 
            this.labelTienGiamGia.AutoSize = true;
            this.labelTienGiamGia.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTienGiamGia.Location = new System.Drawing.Point(280, 48);
            this.labelTienGiamGia.MinimumSize = new System.Drawing.Size(160, 30);
            this.labelTienGiamGia.Name = "labelTienGiamGia";
            this.labelTienGiamGia.Size = new System.Drawing.Size(160, 30);
            this.labelTienGiamGia.TabIndex = 10;
            this.labelTienGiamGia.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelGiamGia
            // 
            this.labelGiamGia.AutoSize = true;
            this.labelGiamGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelGiamGia.Location = new System.Drawing.Point(118, 52);
            this.labelGiamGia.Name = "labelGiamGia";
            this.labelGiamGia.Size = new System.Drawing.Size(89, 23);
            this.labelGiamGia.TabIndex = 9;
            this.labelGiamGia.Text = "Giảm giá";
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTongTien.Location = new System.Drawing.Point(257, 87);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(176, 34);
            this.textBoxTongTien.TabIndex = 8;
            this.textBoxTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTongTien.Location = new System.Drawing.Point(116, 91);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(135, 33);
            this.labelTongTien.TabIndex = 7;
            this.labelTongTien.Text = "Tổng Bill";
            // 
            // btnThanhToanCash
            // 
            this.btnThanhToanCash.BackColor = System.Drawing.Color.Red;
            this.btnThanhToanCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToanCash.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToanCash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThanhToanCash.Location = new System.Drawing.Point(439, 1);
            this.btnThanhToanCash.Name = "btnThanhToanCash";
            this.btnThanhToanCash.Size = new System.Drawing.Size(96, 123);
            this.btnThanhToanCash.TabIndex = 7;
            this.btnThanhToanCash.Text = "Cash";
            this.btnThanhToanCash.UseVisualStyleBackColor = false;
            this.btnThanhToanCash.Click += new System.EventHandler(this.btnThanhToanCash_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.buttonRefeshBill);
            this.panel1.Controls.Add(this.SoLuongMonThem);
            this.panel1.Controls.Add(this.btnXoaMon);
            this.panel1.Controls.Add(this.btnThemMon);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 195);
            this.panel1.TabIndex = 9;
            // 
            // buttonRefeshBill
            // 
            this.buttonRefeshBill.BackColor = System.Drawing.Color.Red;
            this.buttonRefeshBill.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonRefeshBill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRefeshBill.Location = new System.Drawing.Point(587, 149);
            this.buttonRefeshBill.Name = "buttonRefeshBill";
            this.buttonRefeshBill.Size = new System.Drawing.Size(129, 45);
            this.buttonRefeshBill.TabIndex = 4;
            this.buttonRefeshBill.Text = "RefeshBill";
            this.buttonRefeshBill.UseVisualStyleBackColor = false;
            this.buttonRefeshBill.Click += new System.EventHandler(this.buttonRefeshBill_Click);
            // 
            // SoLuongMonThem
            // 
            this.SoLuongMonThem.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SoLuongMonThem.Location = new System.Drawing.Point(493, 150);
            this.SoLuongMonThem.Name = "SoLuongMonThem";
            this.SoLuongMonThem.Size = new System.Drawing.Size(60, 44);
            this.SoLuongMonThem.TabIndex = 3;
            this.SoLuongMonThem.ValueChanged += new System.EventHandler(this.SoLuongMonThem_ValueChanged);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.Red;
            this.btnXoaMon.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaMon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoaMon.Location = new System.Drawing.Point(356, 149);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(129, 45);
            this.btnXoaMon.TabIndex = 2;
            this.btnXoaMon.Text = "Xóa món";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.Red;
            this.btnThemMon.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemMon.Location = new System.Drawing.Point(226, 149);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(129, 45);
            this.btnThemMon.TabIndex = 1;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(226, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(489, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewMenu);
            this.panel4.Controls.Add(this.comboBoxDanhMucItems);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(719, 635);
            this.panel4.TabIndex = 11;
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AllowUserToAddRows = false;
            this.dataGridViewMenu.AllowUserToDeleteRows = false;
            this.dataGridViewMenu.AllowUserToOrderColumns = true;
            this.dataGridViewMenu.AllowUserToResizeColumns = false;
            this.dataGridViewMenu.AllowUserToResizeRows = false;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataGridViewMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMenu.DefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridViewMenu.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMenu.Location = new System.Drawing.Point(3, 248);
            this.dataGridViewMenu.MultiSelect = false;
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.ReadOnly = true;
            this.dataGridViewMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridViewMenu.RowHeadersVisible = false;
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.DividerHeight = 1;
            this.dataGridViewMenu.RowTemplate.Height = 35;
            this.dataGridViewMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenu.Size = new System.Drawing.Size(716, 386);
            this.dataGridViewMenu.TabIndex = 12;
            this.dataGridViewMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellClick);
            // 
            // comboBoxDanhMucItems
            // 
            this.comboBoxDanhMucItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDanhMucItems.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxDanhMucItems.FormattingEnabled = true;
            this.comboBoxDanhMucItems.Items.AddRange(new object[] {
            "Ticket",
            "Food",
            "Drink"});
            this.comboBoxDanhMucItems.Location = new System.Drawing.Point(229, 203);
            this.comboBoxDanhMucItems.Name = "comboBoxDanhMucItems";
            this.comboBoxDanhMucItems.Size = new System.Drawing.Size(489, 39);
            this.comboBoxDanhMucItems.TabIndex = 5;
            this.comboBoxDanhMucItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxDanhMucItems_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.labelDanhMuc);
            this.panel5.Location = new System.Drawing.Point(3, 196);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(716, 59);
            this.panel5.TabIndex = 13;
            // 
            // labelDanhMuc
            // 
            this.labelDanhMuc.AutoSize = true;
            this.labelDanhMuc.Font = new System.Drawing.Font("Magneto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhMuc.ForeColor = System.Drawing.Color.Teal;
            this.labelDanhMuc.Location = new System.Drawing.Point(-5, 10);
            this.labelDanhMuc.Name = "labelDanhMuc";
            this.labelDanhMuc.Size = new System.Drawing.Size(214, 44);
            this.labelDanhMuc.TabIndex = 11;
            this.labelDanhMuc.Text = "Danh Mục";
            // 
            // timer1
            // 
            this.timer1.Interval = 180;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formQuanLiBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1360, 672);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1378, 719);
            this.MinimumSize = new System.Drawing.Size(1378, 719);
            this.Name = "formQuanLiBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lí Bán Hàng SBTC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongMonThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mucQuanly;
        private System.Windows.Forms.ToolStripMenuItem mucQuanLiBanHang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThanhToanCash;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Label labelDanhMuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeaderMonAn;
        private System.Windows.Forms.ColumnHeader columnHeaderSoLuong;
        private System.Windows.Forms.ColumnHeader columnHeaderDonGia;
        private System.Windows.Forms.ColumnHeader columnHeaderThanhTien;
        private System.Windows.Forms.NumericUpDown SoLuongMonThem;
        private System.Windows.Forms.Label labelGiamGia;
        private System.Windows.Forms.Label labelTienGiamGia;
        private System.Windows.Forms.Label labelGiaTamTinh;
        private System.Windows.Forms.Label labelTamTinh;
        private System.Windows.Forms.Button buttonThanhToanCredit;
        private System.Windows.Forms.Button buttonRefeshBill;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripMenuItem mucTaikhoan;
        private System.Windows.Forms.ToolStripMenuItem mucThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mucDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mucBaoCao;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxDanhMucItems;
    }
}