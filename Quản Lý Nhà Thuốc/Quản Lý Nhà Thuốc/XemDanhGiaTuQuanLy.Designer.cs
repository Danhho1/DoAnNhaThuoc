namespace Quản_Lý_Nhà_Thuốc
{
    partial class XemDanhGiaTuQuanLy
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
            this.txtGuiDen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdaRatTot = new System.Windows.Forms.RadioButton();
            this.rdaTot = new System.Windows.Forms.RadioButton();
            this.rdaBinhThuong = new System.Windows.Forms.RadioButton();
            this.rdaTe = new System.Windows.Forms.RadioButton();
            this.rdaRatTe = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.txtTenNguoiGui = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhGia = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGuiDen
            // 
            this.txtGuiDen.Location = new System.Drawing.Point(167, 23);
            this.txtGuiDen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuiDen.Name = "txtGuiDen";
            this.txtGuiDen.Size = new System.Drawing.Size(284, 22);
            this.txtGuiDen.TabIndex = 93;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(167, 132);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(284, 22);
            this.txtSoDienThoai.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 91;
            this.label2.Text = "Số điện thoại :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdaRatTot);
            this.groupBox2.Controls.Add(this.rdaTot);
            this.groupBox2.Controls.Add(this.rdaBinhThuong);
            this.groupBox2.Controls.Add(this.rdaTe);
            this.groupBox2.Controls.Add(this.rdaRatTe);
            this.groupBox2.Location = new System.Drawing.Point(24, 181);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(428, 62);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đánh giá";
            // 
            // rdaRatTot
            // 
            this.rdaRatTot.AutoSize = true;
            this.rdaRatTot.Location = new System.Drawing.Point(344, 23);
            this.rdaRatTot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdaRatTot.Name = "rdaRatTot";
            this.rdaRatTot.Size = new System.Drawing.Size(66, 20);
            this.rdaRatTot.TabIndex = 4;
            this.rdaRatTot.TabStop = true;
            this.rdaRatTot.Text = "Rất tốt";
            this.rdaRatTot.UseVisualStyleBackColor = true;
            // 
            // rdaTot
            // 
            this.rdaTot.AutoSize = true;
            this.rdaTot.Location = new System.Drawing.Point(276, 23);
            this.rdaTot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdaTot.Name = "rdaTot";
            this.rdaTot.Size = new System.Drawing.Size(48, 20);
            this.rdaTot.TabIndex = 3;
            this.rdaTot.TabStop = true;
            this.rdaTot.Text = "Tốt";
            this.rdaTot.UseVisualStyleBackColor = true;
            // 
            // rdaBinhThuong
            // 
            this.rdaBinhThuong.AutoSize = true;
            this.rdaBinhThuong.Location = new System.Drawing.Point(152, 23);
            this.rdaBinhThuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdaBinhThuong.Name = "rdaBinhThuong";
            this.rdaBinhThuong.Size = new System.Drawing.Size(97, 20);
            this.rdaBinhThuong.TabIndex = 2;
            this.rdaBinhThuong.TabStop = true;
            this.rdaBinhThuong.Text = "Bình thường";
            this.rdaBinhThuong.UseVisualStyleBackColor = true;
            // 
            // rdaTe
            // 
            this.rdaTe.AutoSize = true;
            this.rdaTe.Location = new System.Drawing.Point(88, 23);
            this.rdaTe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdaTe.Name = "rdaTe";
            this.rdaTe.Size = new System.Drawing.Size(45, 20);
            this.rdaTe.TabIndex = 1;
            this.rdaTe.TabStop = true;
            this.rdaTe.Text = "Tệ";
            this.rdaTe.UseVisualStyleBackColor = true;
            // 
            // rdaRatTe
            // 
            this.rdaRatTe.AutoSize = true;
            this.rdaRatTe.Location = new System.Drawing.Point(8, 23);
            this.rdaRatTe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdaRatTe.Name = "rdaRatTe";
            this.rdaRatTe.Size = new System.Drawing.Size(63, 20);
            this.rdaRatTe.TabIndex = 0;
            this.rdaRatTe.TabStop = true;
            this.rdaRatTe.Text = "Rất tệ";
            this.rdaRatTe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbNoiDung);
            this.groupBox1.Location = new System.Drawing.Point(552, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(572, 404);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Góp ý";
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Location = new System.Drawing.Point(8, 23);
            this.rtbNoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(555, 372);
            this.rtbNoiDung.TabIndex = 0;
            this.rtbNoiDung.Text = "";
            // 
            // txtTenNguoiGui
            // 
            this.txtTenNguoiGui.Location = new System.Drawing.Point(167, 78);
            this.txtTenNguoiGui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNguoiGui.Name = "txtTenNguoiGui";
            this.txtTenNguoiGui.Size = new System.Drawing.Size(284, 22);
            this.txtTenNguoiGui.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Tên người gửi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Gửi đến :";
            // 
            // dgvDanhGia
            // 
            this.dgvDanhGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhGia.Location = new System.Drawing.Point(0, 430);
            this.dgvDanhGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhGia.Name = "dgvDanhGia";
            this.dgvDanhGia.RowHeadersWidth = 51;
            this.dgvDanhGia.Size = new System.Drawing.Size(1140, 310);
            this.dgvDanhGia.TabIndex = 85;
            this.dgvDanhGia.Click += new System.EventHandler(this.dgvDanhGia_Click);
            // 
            // XemDanhGiaTuQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 740);
            this.Controls.Add(this.txtGuiDen);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTenNguoiGui);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhGia);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "XemDanhGiaTuQuanLy";
            this.Text = "XemDanhGiaTuQuanLy";
            this.Load += new System.EventHandler(this.XemDanhGiaTuQuanLy_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuiDen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdaRatTot;
        private System.Windows.Forms.RadioButton rdaTot;
        private System.Windows.Forms.RadioButton rdaBinhThuong;
        private System.Windows.Forms.RadioButton rdaTe;
        private System.Windows.Forms.RadioButton rdaRatTe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.TextBox txtTenNguoiGui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhGia;
    }
}