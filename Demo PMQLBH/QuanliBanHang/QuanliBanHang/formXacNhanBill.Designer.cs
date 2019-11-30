namespace QuanliBanHang
{
    partial class formXacNhanBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formXacNhanBill));
            this.listViewXacNhanBill = new System.Windows.Forms.ListView();
            this.columnHeaderMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelIdBill = new System.Windows.Forms.Label();
            this.labelNgayLapBil = new System.Windows.Forms.Label();
            this.labelNhanVienLapBill = new System.Windows.Forms.Label();
            this.labelIdBill_Text = new System.Windows.Forms.Label();
            this.labelNgayLapBill_Text = new System.Windows.Forms.Label();
            this.labelNhanVienLapBill_Text = new System.Windows.Forms.Label();
            this.labelHinhThucThanhToan_Text = new System.Windows.Forms.Label();
            this.labelHinhThucThanhToan = new System.Windows.Forms.Label();
            this.labelTongBill_Text = new System.Windows.Forms.Label();
            this.labelTongBill = new System.Windows.Forms.Label();
            this.labelGiamGia_Text = new System.Windows.Forms.Label();
            this.labelGiamGia = new System.Windows.Forms.Label();
            this.buttonInBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewXacNhanBill
            // 
            this.listViewXacNhanBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMonAn,
            this.columnHeaderSoLuong,
            this.columnHeaderDonGia,
            this.columnHeaderThanhTien,
            this.columnHeaderGhiChu});
            this.listViewXacNhanBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listViewXacNhanBill.HideSelection = false;
            this.listViewXacNhanBill.Location = new System.Drawing.Point(12, 154);
            this.listViewXacNhanBill.Name = "listViewXacNhanBill";
            this.listViewXacNhanBill.Size = new System.Drawing.Size(730, 367);
            this.listViewXacNhanBill.TabIndex = 0;
            this.listViewXacNhanBill.UseCompatibleStateImageBehavior = false;
            this.listViewXacNhanBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderMonAn
            // 
            this.columnHeaderMonAn.Text = "Món ăn";
            this.columnHeaderMonAn.Width = 184;
            // 
            // columnHeaderSoLuong
            // 
            this.columnHeaderSoLuong.Text = "Số lượng";
            this.columnHeaderSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSoLuong.Width = 80;
            // 
            // columnHeaderDonGia
            // 
            this.columnHeaderDonGia.Text = "Đơn giá";
            this.columnHeaderDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderDonGia.Width = 80;
            // 
            // columnHeaderThanhTien
            // 
            this.columnHeaderThanhTien.Text = "Thành tiền";
            this.columnHeaderThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderThanhTien.Width = 110;
            // 
            // columnHeaderGhiChu
            // 
            this.columnHeaderGhiChu.Text = "Ghi chú";
            this.columnHeaderGhiChu.Width = 90;
            // 
            // labelIdBill
            // 
            this.labelIdBill.AutoSize = true;
            this.labelIdBill.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelIdBill.Location = new System.Drawing.Point(7, 9);
            this.labelIdBill.Name = "labelIdBill";
            this.labelIdBill.Size = new System.Drawing.Size(83, 25);
            this.labelIdBill.TabIndex = 0;
            this.labelIdBill.Text = "ID Bill:";
            // 
            // labelNgayLapBil
            // 
            this.labelNgayLapBil.AutoSize = true;
            this.labelNgayLapBil.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNgayLapBil.Location = new System.Drawing.Point(440, 9);
            this.labelNgayLapBil.Name = "labelNgayLapBil";
            this.labelNgayLapBil.Size = new System.Drawing.Size(141, 25);
            this.labelNgayLapBil.TabIndex = 0;
            this.labelNgayLapBil.Text = "Ngày lập Bill:";
            // 
            // labelNhanVienLapBill
            // 
            this.labelNhanVienLapBill.AutoSize = true;
            this.labelNhanVienLapBill.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNhanVienLapBill.Location = new System.Drawing.Point(7, 45);
            this.labelNhanVienLapBill.Name = "labelNhanVienLapBill";
            this.labelNhanVienLapBill.Size = new System.Drawing.Size(151, 25);
            this.labelNhanVienLapBill.TabIndex = 0;
            this.labelNhanVienLapBill.Text = "Nhân viên lập:";
            // 
            // labelIdBill_Text
            // 
            this.labelIdBill_Text.AutoSize = true;
            this.labelIdBill_Text.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelIdBill_Text.Location = new System.Drawing.Point(87, 7);
            this.labelIdBill_Text.MinimumSize = new System.Drawing.Size(160, 30);
            this.labelIdBill_Text.Name = "labelIdBill_Text";
            this.labelIdBill_Text.Size = new System.Drawing.Size(160, 30);
            this.labelIdBill_Text.TabIndex = 0;
            this.labelIdBill_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNgayLapBill_Text
            // 
            this.labelNgayLapBill_Text.AutoSize = true;
            this.labelNgayLapBill_Text.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNgayLapBill_Text.Location = new System.Drawing.Point(587, 7);
            this.labelNgayLapBill_Text.MinimumSize = new System.Drawing.Size(160, 30);
            this.labelNgayLapBill_Text.Name = "labelNgayLapBill_Text";
            this.labelNgayLapBill_Text.Size = new System.Drawing.Size(160, 30);
            this.labelNgayLapBill_Text.TabIndex = 0;
            this.labelNgayLapBill_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNhanVienLapBill_Text
            // 
            this.labelNhanVienLapBill_Text.AutoSize = true;
            this.labelNhanVienLapBill_Text.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNhanVienLapBill_Text.Location = new System.Drawing.Point(161, 43);
            this.labelNhanVienLapBill_Text.MinimumSize = new System.Drawing.Size(350, 30);
            this.labelNhanVienLapBill_Text.Name = "labelNhanVienLapBill_Text";
            this.labelNhanVienLapBill_Text.Size = new System.Drawing.Size(350, 30);
            this.labelNhanVienLapBill_Text.TabIndex = 0;
            this.labelNhanVienLapBill_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHinhThucThanhToan_Text
            // 
            this.labelHinhThucThanhToan_Text.AutoSize = true;
            this.labelHinhThucThanhToan_Text.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHinhThucThanhToan_Text.Location = new System.Drawing.Point(244, 115);
            this.labelHinhThucThanhToan_Text.MinimumSize = new System.Drawing.Size(350, 30);
            this.labelHinhThucThanhToan_Text.Name = "labelHinhThucThanhToan_Text";
            this.labelHinhThucThanhToan_Text.Size = new System.Drawing.Size(350, 30);
            this.labelHinhThucThanhToan_Text.TabIndex = 0;
            this.labelHinhThucThanhToan_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHinhThucThanhToan
            // 
            this.labelHinhThucThanhToan.AutoSize = true;
            this.labelHinhThucThanhToan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHinhThucThanhToan.Location = new System.Drawing.Point(7, 117);
            this.labelHinhThucThanhToan.Name = "labelHinhThucThanhToan";
            this.labelHinhThucThanhToan.Size = new System.Drawing.Size(221, 25);
            this.labelHinhThucThanhToan.TabIndex = 0;
            this.labelHinhThucThanhToan.Text = "Hình thức thanh toán:";
            // 
            // labelTongBill_Text
            // 
            this.labelTongBill_Text.AutoSize = true;
            this.labelTongBill_Text.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTongBill_Text.Location = new System.Drawing.Point(116, 80);
            this.labelTongBill_Text.MinimumSize = new System.Drawing.Size(180, 30);
            this.labelTongBill_Text.Name = "labelTongBill_Text";
            this.labelTongBill_Text.Size = new System.Drawing.Size(180, 30);
            this.labelTongBill_Text.TabIndex = 0;
            this.labelTongBill_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTongBill
            // 
            this.labelTongBill.AutoSize = true;
            this.labelTongBill.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTongBill.Location = new System.Drawing.Point(7, 82);
            this.labelTongBill.Name = "labelTongBill";
            this.labelTongBill.Size = new System.Drawing.Size(107, 25);
            this.labelTongBill.TabIndex = 0;
            this.labelTongBill.Text = "Tổng Bill:";
            // 
            // labelGiamGia_Text
            // 
            this.labelGiamGia_Text.AutoSize = true;
            this.labelGiamGia_Text.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelGiamGia_Text.Location = new System.Drawing.Point(549, 80);
            this.labelGiamGia_Text.MinimumSize = new System.Drawing.Size(180, 30);
            this.labelGiamGia_Text.Name = "labelGiamGia_Text";
            this.labelGiamGia_Text.Size = new System.Drawing.Size(180, 30);
            this.labelGiamGia_Text.TabIndex = 0;
            this.labelGiamGia_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGiamGia
            // 
            this.labelGiamGia.AutoSize = true;
            this.labelGiamGia.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelGiamGia.Location = new System.Drawing.Point(440, 82);
            this.labelGiamGia.Name = "labelGiamGia";
            this.labelGiamGia.Size = new System.Drawing.Size(105, 25);
            this.labelGiamGia.TabIndex = 0;
            this.labelGiamGia.Text = "Giảm giá:";
            // 
            // buttonInBill
            // 
            this.buttonInBill.BackColor = System.Drawing.Color.Red;
            this.buttonInBill.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonInBill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInBill.Location = new System.Drawing.Point(614, 527);
            this.buttonInBill.Name = "buttonInBill";
            this.buttonInBill.Size = new System.Drawing.Size(129, 44);
            this.buttonInBill.TabIndex = 1;
            this.buttonInBill.Text = "Xác nhận";
            this.buttonInBill.UseVisualStyleBackColor = false;
            this.buttonInBill.Click += new System.EventHandler(this.buttonInBill_Click);
            // 
            // formXacNhanBill
            // 
            this.AcceptButton = this.buttonInBill;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 583);
            this.Controls.Add(this.buttonInBill);
            this.Controls.Add(this.labelGiamGia_Text);
            this.Controls.Add(this.labelGiamGia);
            this.Controls.Add(this.labelTongBill_Text);
            this.Controls.Add(this.labelTongBill);
            this.Controls.Add(this.labelHinhThucThanhToan_Text);
            this.Controls.Add(this.labelHinhThucThanhToan);
            this.Controls.Add(this.labelNhanVienLapBill_Text);
            this.Controls.Add(this.labelNgayLapBill_Text);
            this.Controls.Add(this.labelIdBill_Text);
            this.Controls.Add(this.labelNhanVienLapBill);
            this.Controls.Add(this.labelNgayLapBil);
            this.Controls.Add(this.labelIdBill);
            this.Controls.Add(this.listViewXacNhanBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formXacNhanBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewXacNhanBill;
        private System.Windows.Forms.Label labelIdBill;
        private System.Windows.Forms.Label labelNgayLapBil;
        private System.Windows.Forms.Label labelNhanVienLapBill;
        private System.Windows.Forms.Label labelIdBill_Text;
        private System.Windows.Forms.Label labelNgayLapBill_Text;
        private System.Windows.Forms.Label labelNhanVienLapBill_Text;
        private System.Windows.Forms.Label labelHinhThucThanhToan_Text;
        private System.Windows.Forms.Label labelHinhThucThanhToan;
        private System.Windows.Forms.Label labelTongBill_Text;
        private System.Windows.Forms.Label labelTongBill;
        private System.Windows.Forms.Label labelGiamGia_Text;
        private System.Windows.Forms.Label labelGiamGia;
        private System.Windows.Forms.Button buttonInBill;
        private System.Windows.Forms.ColumnHeader columnHeaderMonAn;
        private System.Windows.Forms.ColumnHeader columnHeaderSoLuong;
        private System.Windows.Forms.ColumnHeader columnHeaderDonGia;
        private System.Windows.Forms.ColumnHeader columnHeaderThanhTien;
        private System.Windows.Forms.ColumnHeader columnHeaderGhiChu;
    }
}