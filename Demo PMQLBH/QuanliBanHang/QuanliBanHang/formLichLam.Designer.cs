namespace QuanliBanHang
{
    partial class formLichLam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLichLam));
            this.textBoxGioLam = new System.Windows.Forms.TextBox();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.dataGridViewLichLam = new System.Windows.Forms.DataGridView();
            this.groupBoxChuThich = new System.Windows.Forms.GroupBox();
            this.labelMDBC = new System.Windows.Forms.Label();
            this.labelEBC = new System.Windows.Forms.Label();
            this.labelGayBC = new System.Windows.Forms.Label();
            this.labelMBC = new System.Windows.Forms.Label();
            this.buttonRefesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichLam)).BeginInit();
            this.groupBoxChuThich.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxGioLam
            // 
            this.textBoxGioLam.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxGioLam.Location = new System.Drawing.Point(158, 366);
            this.textBoxGioLam.MinimumSize = new System.Drawing.Size(138, 30);
            this.textBoxGioLam.Name = "textBoxGioLam";
            this.textBoxGioLam.Size = new System.Drawing.Size(138, 39);
            this.textBoxGioLam.TabIndex = 1;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.Red;
            this.buttonCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCapNhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCapNhat.Location = new System.Drawing.Point(12, 361);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(140, 45);
            this.buttonCapNhat.TabIndex = 2;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // dataGridViewLichLam
            // 
            this.dataGridViewLichLam.AllowUserToAddRows = false;
            this.dataGridViewLichLam.AllowUserToDeleteRows = false;
            this.dataGridViewLichLam.AllowUserToResizeColumns = false;
            this.dataGridViewLichLam.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLichLam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLichLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLichLam.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLichLam.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLichLam.Name = "dataGridViewLichLam";
            this.dataGridViewLichLam.ReadOnly = true;
            this.dataGridViewLichLam.RowHeadersVisible = false;
            this.dataGridViewLichLam.RowHeadersWidth = 51;
            this.dataGridViewLichLam.RowTemplate.Height = 24;
            this.dataGridViewLichLam.Size = new System.Drawing.Size(848, 343);
            this.dataGridViewLichLam.TabIndex = 0;
            this.dataGridViewLichLam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLichLam_CellClick);
            // 
            // groupBoxChuThich
            // 
            this.groupBoxChuThich.Controls.Add(this.labelMDBC);
            this.groupBoxChuThich.Controls.Add(this.labelEBC);
            this.groupBoxChuThich.Controls.Add(this.labelGayBC);
            this.groupBoxChuThich.Controls.Add(this.labelMBC);
            this.groupBoxChuThich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxChuThich.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxChuThich.Location = new System.Drawing.Point(358, 361);
            this.groupBoxChuThich.Name = "groupBoxChuThich";
            this.groupBoxChuThich.Size = new System.Drawing.Size(502, 94);
            this.groupBoxChuThich.TabIndex = 10;
            this.groupBoxChuThich.TabStop = false;
            this.groupBoxChuThich.Text = "Chú thích ca làm:";
            // 
            // labelMDBC
            // 
            this.labelMDBC.AutoSize = true;
            this.labelMDBC.Location = new System.Drawing.Point(232, 70);
            this.labelMDBC.Name = "labelMDBC";
            this.labelMDBC.Size = new System.Drawing.Size(152, 22);
            this.labelMDBC.TabIndex = 0;
            this.labelMDBC.Text = "MDBC: 11h - 20h";
            // 
            // labelEBC
            // 
            this.labelEBC.AutoSize = true;
            this.labelEBC.Location = new System.Drawing.Point(6, 70);
            this.labelEBC.Name = "labelEBC";
            this.labelEBC.Size = new System.Drawing.Size(134, 22);
            this.labelEBC.TabIndex = 0;
            this.labelEBC.Text = "EBC: 13h - 22h";
            // 
            // labelGayBC
            // 
            this.labelGayBC.AutoSize = true;
            this.labelGayBC.Location = new System.Drawing.Point(232, 36);
            this.labelGayBC.Name = "labelGayBC";
            this.labelGayBC.Size = new System.Drawing.Size(244, 22);
            this.labelGayBC.TabIndex = 0;
            this.labelGayBC.Text = "GayBC: 8h - 13h && 18h - 22h";
            // 
            // labelMBC
            // 
            this.labelMBC.AutoSize = true;
            this.labelMBC.Location = new System.Drawing.Point(6, 36);
            this.labelMBC.Name = "labelMBC";
            this.labelMBC.Size = new System.Drawing.Size(129, 22);
            this.labelMBC.TabIndex = 0;
            this.labelMBC.Text = "MBC: 8h - 17h";
            // 
            // buttonRefesh
            // 
            this.buttonRefesh.BackColor = System.Drawing.Color.Red;
            this.buttonRefesh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonRefesh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRefesh.Location = new System.Drawing.Point(12, 408);
            this.buttonRefesh.Name = "buttonRefesh";
            this.buttonRefesh.Size = new System.Drawing.Size(284, 45);
            this.buttonRefesh.TabIndex = 3;
            this.buttonRefesh.Text = "Refesh";
            this.buttonRefesh.UseVisualStyleBackColor = false;
            this.buttonRefesh.Click += new System.EventHandler(this.buttonRefesh_Click);
            // 
            // formLichLam
            // 
            this.AcceptButton = this.buttonCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 459);
            this.Controls.Add(this.buttonRefesh);
            this.Controls.Add(this.groupBoxChuThich);
            this.Controls.Add(this.dataGridViewLichLam);
            this.Controls.Add(this.textBoxGioLam);
            this.Controls.Add(this.buttonCapNhat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(893, 506);
            this.MinimumSize = new System.Drawing.Size(893, 506);
            this.Name = "formLichLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch làm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichLam)).EndInit();
            this.groupBoxChuThich.ResumeLayout(false);
            this.groupBoxChuThich.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxGioLam;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.DataGridView dataGridViewLichLam;
        private System.Windows.Forms.GroupBox groupBoxChuThich;
        private System.Windows.Forms.Label labelMDBC;
        private System.Windows.Forms.Label labelEBC;
        private System.Windows.Forms.Label labelGayBC;
        private System.Windows.Forms.Label labelMBC;
        private System.Windows.Forms.Button buttonRefesh;
    }
}