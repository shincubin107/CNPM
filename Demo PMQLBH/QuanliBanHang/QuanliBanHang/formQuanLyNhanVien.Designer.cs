namespace QuanliBanHang
{
    partial class formQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLyNhanVien));
            this.tabControlQLNV = new System.Windows.Forms.TabControl();
            this.tabPageGioCongNV = new System.Windows.Forms.TabPage();
            this.textBoxLuongTheoGio = new System.Windows.Forms.TextBox();
            this.buttonLuongTheoGio = new System.Windows.Forms.Button();
            this.buttonRefeshThang = new System.Windows.Forms.Button();
            this.buttonHienLuongDK = new System.Windows.Forms.Button();
            this.textBoxLuongDK = new System.Windows.Forms.TextBox();
            this.labelThang = new System.Windows.Forms.Label();
            this.labelGioCong = new System.Windows.Forms.Label();
            this.textBoxGioLam = new System.Windows.Forms.TextBox();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.dataGridViewLichLam = new System.Windows.Forms.DataGridView();
            this.tabControlQLNV.SuspendLayout();
            this.tabPageGioCongNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichLam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlQLNV
            // 
            this.tabControlQLNV.Controls.Add(this.tabPageGioCongNV);
            this.tabControlQLNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlQLNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControlQLNV.Location = new System.Drawing.Point(0, 0);
            this.tabControlQLNV.Name = "tabControlQLNV";
            this.tabControlQLNV.SelectedIndex = 0;
            this.tabControlQLNV.Size = new System.Drawing.Size(1147, 474);
            this.tabControlQLNV.TabIndex = 0;
            // 
            // tabPageGioCongNV
            // 
            this.tabPageGioCongNV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageGioCongNV.Controls.Add(this.textBoxLuongTheoGio);
            this.tabPageGioCongNV.Controls.Add(this.buttonLuongTheoGio);
            this.tabPageGioCongNV.Controls.Add(this.buttonRefeshThang);
            this.tabPageGioCongNV.Controls.Add(this.buttonHienLuongDK);
            this.tabPageGioCongNV.Controls.Add(this.textBoxLuongDK);
            this.tabPageGioCongNV.Controls.Add(this.labelThang);
            this.tabPageGioCongNV.Controls.Add(this.labelGioCong);
            this.tabPageGioCongNV.Controls.Add(this.textBoxGioLam);
            this.tabPageGioCongNV.Controls.Add(this.buttonCapNhat);
            this.tabPageGioCongNV.Controls.Add(this.dataGridViewLichLam);
            this.tabPageGioCongNV.Location = new System.Drawing.Point(4, 32);
            this.tabPageGioCongNV.Name = "tabPageGioCongNV";
            this.tabPageGioCongNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGioCongNV.Size = new System.Drawing.Size(1139, 438);
            this.tabPageGioCongNV.TabIndex = 1;
            this.tabPageGioCongNV.Text = "Giờ công nhân viên";
            // 
            // textBoxLuongTheoGio
            // 
            this.textBoxLuongTheoGio.Location = new System.Drawing.Point(885, 224);
            this.textBoxLuongTheoGio.MinimumSize = new System.Drawing.Size(240, 30);
            this.textBoxLuongTheoGio.Name = "textBoxLuongTheoGio";
            this.textBoxLuongTheoGio.Size = new System.Drawing.Size(250, 30);
            this.textBoxLuongTheoGio.TabIndex = 5;
            // 
            // buttonLuongTheoGio
            // 
            this.buttonLuongTheoGio.BackColor = System.Drawing.Color.Red;
            this.buttonLuongTheoGio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLuongTheoGio.Location = new System.Drawing.Point(883, 161);
            this.buttonLuongTheoGio.Name = "buttonLuongTheoGio";
            this.buttonLuongTheoGio.Size = new System.Drawing.Size(255, 57);
            this.buttonLuongTheoGio.TabIndex = 4;
            this.buttonLuongTheoGio.Text = "Cập nhật lương theo giờ";
            this.buttonLuongTheoGio.UseVisualStyleBackColor = false;
            this.buttonLuongTheoGio.Click += new System.EventHandler(this.buttonLuongTheoGio_Click);
            // 
            // buttonRefeshThang
            // 
            this.buttonRefeshThang.BackColor = System.Drawing.Color.Red;
            this.buttonRefeshThang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRefeshThang.Location = new System.Drawing.Point(1036, 62);
            this.buttonRefeshThang.Name = "buttonRefeshThang";
            this.buttonRefeshThang.Size = new System.Drawing.Size(102, 57);
            this.buttonRefeshThang.TabIndex = 2;
            this.buttonRefeshThang.Text = "Refesh";
            this.buttonRefeshThang.UseVisualStyleBackColor = false;
            this.buttonRefeshThang.Click += new System.EventHandler(this.buttonRefeshThang_Click);
            // 
            // buttonHienLuongDK
            // 
            this.buttonHienLuongDK.BackColor = System.Drawing.Color.Red;
            this.buttonHienLuongDK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHienLuongDK.Location = new System.Drawing.Point(883, 260);
            this.buttonHienLuongDK.Name = "buttonHienLuongDK";
            this.buttonHienLuongDK.Size = new System.Drawing.Size(255, 57);
            this.buttonHienLuongDK.TabIndex = 6;
            this.buttonHienLuongDK.Text = "Lương tháng dự kiến";
            this.buttonHienLuongDK.UseVisualStyleBackColor = false;
            this.buttonHienLuongDK.Click += new System.EventHandler(this.buttonHienLuongDK_Click);
            // 
            // textBoxLuongDK
            // 
            this.textBoxLuongDK.Location = new System.Drawing.Point(885, 323);
            this.textBoxLuongDK.MinimumSize = new System.Drawing.Size(240, 30);
            this.textBoxLuongDK.Name = "textBoxLuongDK";
            this.textBoxLuongDK.Size = new System.Drawing.Size(250, 30);
            this.textBoxLuongDK.TabIndex = 7;
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThang.ForeColor = System.Drawing.Color.DarkRed;
            this.labelThang.Location = new System.Drawing.Point(333, 17);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(0, 32);
            this.labelThang.TabIndex = 5;
            // 
            // labelGioCong
            // 
            this.labelGioCong.AutoSize = true;
            this.labelGioCong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelGioCong.ForeColor = System.Drawing.Color.DarkRed;
            this.labelGioCong.Location = new System.Drawing.Point(1, 17);
            this.labelGioCong.Name = "labelGioCong";
            this.labelGioCong.Size = new System.Drawing.Size(326, 32);
            this.labelGioCong.TabIndex = 0;
            this.labelGioCong.Text = "Giờ công nhân viên tháng";
            // 
            // textBoxGioLam
            // 
            this.textBoxGioLam.Location = new System.Drawing.Point(885, 125);
            this.textBoxGioLam.MinimumSize = new System.Drawing.Size(240, 30);
            this.textBoxGioLam.Name = "textBoxGioLam";
            this.textBoxGioLam.Size = new System.Drawing.Size(250, 30);
            this.textBoxGioLam.TabIndex = 3;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.Red;
            this.buttonCapNhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCapNhat.Location = new System.Drawing.Point(883, 62);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(154, 57);
            this.buttonCapNhat.TabIndex = 1;
            this.buttonCapNhat.Text = "Cập nhật giờ";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // dataGridViewLichLam
            // 
            this.dataGridViewLichLam.AllowUserToAddRows = false;
            this.dataGridViewLichLam.AllowUserToDeleteRows = false;
            this.dataGridViewLichLam.AllowUserToOrderColumns = true;
            this.dataGridViewLichLam.AllowUserToResizeColumns = false;
            this.dataGridViewLichLam.AllowUserToResizeRows = false;
            this.dataGridViewLichLam.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewLichLam.ColumnHeadersHeight = 35;
            this.dataGridViewLichLam.Location = new System.Drawing.Point(6, 63);
            this.dataGridViewLichLam.MultiSelect = false;
            this.dataGridViewLichLam.Name = "dataGridViewLichLam";
            this.dataGridViewLichLam.ReadOnly = true;
            this.dataGridViewLichLam.RowHeadersVisible = false;
            this.dataGridViewLichLam.RowHeadersWidth = 45;
            this.dataGridViewLichLam.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLichLam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewLichLam.Size = new System.Drawing.Size(874, 372);
            this.dataGridViewLichLam.TabIndex = 0;
            this.dataGridViewLichLam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLichLam_CellClick);
            // 
            // formQuanLyNhanVien
            // 
            this.AcceptButton = this.buttonCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 474);
            this.Controls.Add(this.tabControlQLNV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1165, 521);
            this.MinimumSize = new System.Drawing.Size(1165, 521);
            this.Name = "formQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.tabControlQLNV.ResumeLayout(false);
            this.tabPageGioCongNV.ResumeLayout(false);
            this.tabPageGioCongNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichLam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlQLNV;
        private System.Windows.Forms.TabPage tabPageGioCongNV;
        private System.Windows.Forms.DataGridView dataGridViewLichLam;
        private System.Windows.Forms.TextBox textBoxGioLam;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Label labelGioCong;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.TextBox textBoxLuongDK;
        private System.Windows.Forms.Button buttonHienLuongDK;
        private System.Windows.Forms.Button buttonRefeshThang;
        private System.Windows.Forms.TextBox textBoxLuongTheoGio;
        private System.Windows.Forms.Button buttonLuongTheoGio;
    }
}