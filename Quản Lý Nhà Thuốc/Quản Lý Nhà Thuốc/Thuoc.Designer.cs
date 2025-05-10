namespace Quản_Lý_Nhà_Thuốc
{
    partial class Thuoc
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
            this.btnDenDonThuoc = new System.Windows.Forms.Button();
            this.btnThemVaoDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemThuocTheoTen = new System.Windows.Forms.Button();
            this.txtTimKiemThuocTheoTen = new System.Windows.Forms.TextBox();
            this.txtGiaTienThuoc = new System.Windows.Forms.TextBox();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.txtThanhPhan = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachThuoc = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoiSanXuat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboTimKiemTheoLoai = new System.Windows.Forms.ComboBox();
            this.btnDanhSachTheoLoai = new System.Windows.Forms.Button();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoDienThoaiNguoiMua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNguoiMua = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxHinhAnh = new System.Windows.Forms.PictureBox();
            this.lblDonThuoc = new System.Windows.Forms.Label();
            this.txtIdDon = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuoc)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDenDonThuoc
            // 
            this.btnDenDonThuoc.BackColor = System.Drawing.Color.LightCyan;
            this.btnDenDonThuoc.Location = new System.Drawing.Point(9, 382);
            this.btnDenDonThuoc.Name = "btnDenDonThuoc";
            this.btnDenDonThuoc.Size = new System.Drawing.Size(293, 47);
            this.btnDenDonThuoc.TabIndex = 25;
            this.btnDenDonThuoc.Text = "Đến đơn thuốc";
            this.btnDenDonThuoc.UseVisualStyleBackColor = false;
            this.btnDenDonThuoc.Click += new System.EventHandler(this.btnDenDonThuoc_Click);
            // 
            // btnThemVaoDon
            // 
            this.btnThemVaoDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemVaoDon.Location = new System.Drawing.Point(310, 383);
            this.btnThemVaoDon.Name = "btnThemVaoDon";
            this.btnThemVaoDon.Size = new System.Drawing.Size(536, 47);
            this.btnThemVaoDon.TabIndex = 15;
            this.btnThemVaoDon.Text = "Thêm vào đơn thuốc";
            this.btnThemVaoDon.UseVisualStyleBackColor = false;
            this.btnThemVaoDon.Click += new System.EventHandler(this.btnThemVaoDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemThuocTheoTen);
            this.groupBox1.Controls.Add(this.txtTimKiemThuocTheoTen);
            this.groupBox1.Location = new System.Drawing.Point(574, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 76);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thuốc theo tên thuốc";
            // 
            // btnTimKiemThuocTheoTen
            // 
            this.btnTimKiemThuocTheoTen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiemThuocTheoTen.Location = new System.Drawing.Point(194, 46);
            this.btnTimKiemThuocTheoTen.Name = "btnTimKiemThuocTheoTen";
            this.btnTimKiemThuocTheoTen.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemThuocTheoTen.TabIndex = 2;
            this.btnTimKiemThuocTheoTen.Text = "Tìm kiếm";
            this.btnTimKiemThuocTheoTen.UseVisualStyleBackColor = false;
            this.btnTimKiemThuocTheoTen.Click += new System.EventHandler(this.btnTimKiemThuocTheoTen_Click);
            // 
            // txtTimKiemThuocTheoTen
            // 
            this.txtTimKiemThuocTheoTen.Location = new System.Drawing.Point(7, 20);
            this.txtTimKiemThuocTheoTen.Name = "txtTimKiemThuocTheoTen";
            this.txtTimKiemThuocTheoTen.Size = new System.Drawing.Size(262, 20);
            this.txtTimKiemThuocTheoTen.TabIndex = 0;
            // 
            // txtGiaTienThuoc
            // 
            this.txtGiaTienThuoc.Location = new System.Drawing.Point(77, 281);
            this.txtGiaTienThuoc.Name = "txtGiaTienThuoc";
            this.txtGiaTienThuoc.Size = new System.Drawing.Size(226, 20);
            this.txtGiaTienThuoc.TabIndex = 23;
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Location = new System.Drawing.Point(79, 115);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(226, 160);
            this.rtbMoTa.TabIndex = 22;
            this.rtbMoTa.Text = "";
            // 
            // txtThanhPhan
            // 
            this.txtThanhPhan.Location = new System.Drawing.Point(79, 82);
            this.txtThanhPhan.Name = "txtThanhPhan";
            this.txtThanhPhan.Size = new System.Drawing.Size(226, 20);
            this.txtThanhPhan.TabIndex = 21;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(79, 49);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(226, 20);
            this.txtTenThuoc.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giá tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mô tả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thành phần :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên thuốc :";
            // 
            // dgvDanhSachThuoc
            // 
            this.dgvDanhSachThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachThuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachThuoc.Location = new System.Drawing.Point(0, 456);
            this.dgvDanhSachThuoc.Name = "dgvDanhSachThuoc";
            this.dgvDanhSachThuoc.RowHeadersWidth = 51;
            this.dgvDanhSachThuoc.Size = new System.Drawing.Size(855, 145);
            this.dgvDanhSachThuoc.TabIndex = 13;
            this.dgvDanhSachThuoc.Click += new System.EventHandler(this.dgvDanhSachThuoc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nơi sản xuất :";
            // 
            // txtNoiSanXuat
            // 
            this.txtNoiSanXuat.Location = new System.Drawing.Point(77, 317);
            this.txtNoiSanXuat.Name = "txtNoiSanXuat";
            this.txtNoiSanXuat.Size = new System.Drawing.Size(226, 20);
            this.txtNoiSanXuat.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Loại :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.dtpNgayHetHan);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dtpNgaySanXuat);
            this.groupBox3.Location = new System.Drawing.Point(572, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 115);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hạn sử dụng của thuốc";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(87, 76);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(182, 20);
            this.dtpNgayHetHan.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "Ngày sản xuất :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "Ngày hết hạng :";
            // 
            // dtpNgaySanXuat
            // 
            this.dtpNgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySanXuat.Location = new System.Drawing.Point(87, 33);
            this.dtpNgaySanXuat.Name = "dtpNgaySanXuat";
            this.dtpNgaySanXuat.Size = new System.Drawing.Size(182, 20);
            this.dtpNgaySanXuat.TabIndex = 53;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboTimKiemTheoLoai);
            this.groupBox4.Controls.Add(this.btnDanhSachTheoLoai);
            this.groupBox4.Location = new System.Drawing.Point(571, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 86);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm thuốc theo loại thuốc";
            // 
            // cboTimKiemTheoLoai
            // 
            this.cboTimKiemTheoLoai.FormattingEnabled = true;
            this.cboTimKiemTheoLoai.Location = new System.Drawing.Point(7, 28);
            this.cboTimKiemTheoLoai.Name = "cboTimKiemTheoLoai";
            this.cboTimKiemTheoLoai.Size = new System.Drawing.Size(268, 21);
            this.cboTimKiemTheoLoai.TabIndex = 38;
            // 
            // btnDanhSachTheoLoai
            // 
            this.btnDanhSachTheoLoai.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDanhSachTheoLoai.Location = new System.Drawing.Point(199, 54);
            this.btnDanhSachTheoLoai.Name = "btnDanhSachTheoLoai";
            this.btnDanhSachTheoLoai.Size = new System.Drawing.Size(75, 23);
            this.btnDanhSachTheoLoai.TabIndex = 1;
            this.btnDanhSachTheoLoai.Text = "Tìm kiếm";
            this.btnDanhSachTheoLoai.UseVisualStyleBackColor = false;
            this.btnDanhSachTheoLoai.Click += new System.EventHandler(this.btnDanhSachTheoLoai_Click);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(80, 14);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(226, 20);
            this.txtTenLoai.TabIndex = 60;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLamMoi.Location = new System.Drawing.Point(310, 347);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(255, 32);
            this.btnLamMoi.TabIndex = 61;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.lblDonThuoc);
            this.groupBox2.Controls.Add(this.txtIdDon);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSoDienThoaiNguoiMua);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNguoiMua);
            this.groupBox2.Location = new System.Drawing.Point(310, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(255, 127);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin người mua và đơn thuốc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Số điện thoại :";
            // 
            // txtSoDienThoaiNguoiMua
            // 
            this.txtSoDienThoaiNguoiMua.Location = new System.Drawing.Point(83, 63);
            this.txtSoDienThoaiNguoiMua.Name = "txtSoDienThoaiNguoiMua";
            this.txtSoDienThoaiNguoiMua.Size = new System.Drawing.Size(167, 20);
            this.txtSoDienThoaiNguoiMua.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Họ và tên :";
            // 
            // txtNguoiMua
            // 
            this.txtNguoiMua.Location = new System.Drawing.Point(83, 26);
            this.txtNguoiMua.Name = "txtNguoiMua";
            this.txtNguoiMua.Size = new System.Drawing.Size(167, 20);
            this.txtNguoiMua.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox5.Controls.Add(this.pictureBoxHinhAnh);
            this.groupBox5.Location = new System.Drawing.Point(312, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 192);
            this.groupBox5.TabIndex = 63;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hình thuốc";
            // 
            // pictureBoxHinhAnh
            // 
            this.pictureBoxHinhAnh.Location = new System.Drawing.Point(6, 20);
            this.pictureBoxHinhAnh.Name = "pictureBoxHinhAnh";
            this.pictureBoxHinhAnh.Size = new System.Drawing.Size(247, 166);
            this.pictureBoxHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHinhAnh.TabIndex = 0;
            this.pictureBoxHinhAnh.TabStop = false;
            // 
            // lblDonThuoc
            // 
            this.lblDonThuoc.AutoSize = true;
            this.lblDonThuoc.Location = new System.Drawing.Point(28, 97);
            this.lblDonThuoc.Name = "lblDonThuoc";
            this.lblDonThuoc.Size = new System.Drawing.Size(49, 15);
            this.lblDonThuoc.TabIndex = 26;
            this.lblDonThuoc.Text = "ID đơn :";
            // 
            // txtIdDon
            // 
            this.txtIdDon.Location = new System.Drawing.Point(83, 95);
            this.txtIdDon.Name = "txtIdDon";
            this.txtIdDon.Size = new System.Drawing.Size(167, 20);
            this.txtIdDon.TabIndex = 27;
            // 
            // Thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 601);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoiSanXuat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDenDonThuoc);
            this.Controls.Add(this.btnThemVaoDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtGiaTienThuoc);
            this.Controls.Add(this.rtbMoTa);
            this.Controls.Add(this.txtThanhPhan);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachThuoc);
            this.Name = "Thuoc";
            this.Text = "Thuoc";
            this.Load += new System.EventHandler(this.Thuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuoc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDenDonThuoc;
        private System.Windows.Forms.Button btnThemVaoDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiemThuocTheoTen;
        private System.Windows.Forms.TextBox txtGiaTienThuoc;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.TextBox txtThanhPhan;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachThuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoiSanXuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgaySanXuat;
        private System.Windows.Forms.Button btnTimKiemThuocTheoTen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboTimKiemTheoLoai;
        private System.Windows.Forms.Button btnDanhSachTheoLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoDienThoaiNguoiMua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNguoiMua;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBoxHinhAnh;
        private System.Windows.Forms.Label lblDonThuoc;
        private System.Windows.Forms.TextBox txtIdDon;
    }
}