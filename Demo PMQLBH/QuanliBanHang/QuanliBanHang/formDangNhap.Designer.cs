namespace QuanliBanHang
{
    partial class formDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelTaiKhoan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLogoDangNhap = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.buttonDangNhap);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 207);
            this.panel1.MaximumSize = new System.Drawing.Size(385, 180);
            this.panel1.MinimumSize = new System.Drawing.Size(385, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 180);
            this.panel1.TabIndex = 0;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThoat.Location = new System.Drawing.Point(266, 108);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(116, 41);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.ButtonThoat_Click);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDangNhap.Location = new System.Drawing.Point(145, 108);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(115, 41);
            this.buttonDangNhap.TabIndex = 3;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.ButtonDangNhap_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMatKhau);
            this.panel4.Controls.Add(this.labelMatKhau);
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(385, 39);
            this.panel4.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(157, 0);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(225, 34);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.Text = "1";
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMatKhau.Location = new System.Drawing.Point(-2, 5);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(125, 29);
            this.labelMatKhau.TabIndex = 0;
            this.labelMatKhau.Text = "Mật khẩu:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTaiKhoan);
            this.panel3.Controls.Add(this.labelTaiKhoan);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 39);
            this.panel3.TabIndex = 0;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(157, 0);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(225, 33);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.Text = "hieu";
            // 
            // labelTaiKhoan
            // 
            this.labelTaiKhoan.AutoSize = true;
            this.labelTaiKhoan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTaiKhoan.Location = new System.Drawing.Point(-2, 3);
            this.labelTaiKhoan.Name = "labelTaiKhoan";
            this.labelTaiKhoan.Size = new System.Drawing.Size(133, 29);
            this.labelTaiKhoan.TabIndex = 0;
            this.labelTaiKhoan.Text = "Tài khoản:";
            this.labelTaiKhoan.Click += new System.EventHandler(this.LabelTaiKhoan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picLogoDangNhap);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 192);
            this.panel2.TabIndex = 1;
            // 
            // picLogoDangNhap
            // 
            this.picLogoDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoDangNhap.Image = global::QuanliBanHang.Properties.Resources.logoLogin;
            this.picLogoDangNhap.Location = new System.Drawing.Point(3, 3);
            this.picLogoDangNhap.MaximumSize = new System.Drawing.Size(379, 189);
            this.picLogoDangNhap.MinimumSize = new System.Drawing.Size(379, 189);
            this.picLogoDangNhap.Name = "picLogoDangNhap";
            this.picLogoDangNhap.Size = new System.Drawing.Size(379, 189);
            this.picLogoDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoDangNhap.TabIndex = 0;
            this.picLogoDangNhap.TabStop = false;
            // 
            // formDangNhap
            // 
            this.AcceptButton = this.buttonDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(427, 445);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(427, 445);
            this.Name = "formDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formDangNhap_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoDangNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.PictureBox picLogoDangNhap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label labelTaiKhoan;
    }
}

