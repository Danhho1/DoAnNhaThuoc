namespace Quản_Lý_Nhà_Thuốc
{
    partial class NhanVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTimKiemTheoLoai = new System.Windows.Forms.ComboBox();
            this.btnLayNhanVienTheoLoai = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemNhanVien = new System.Windows.Forms.Button();
            this.txtTimKiemNhanVienTheoTen = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.btnInNhanVienTheoLoai = new System.Windows.Forms.Button();
            this.btnInDanhSachTatCaNhanVien = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInNhanVienTheoLoai);
            this.groupBox2.Controls.Add(this.cboTimKiemTheoLoai);
            this.groupBox2.Controls.Add(this.btnLayNhanVienTheoLoai);
            this.groupBox2.Location = new System.Drawing.Point(580, 94);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(264, 81);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "In nhân viên theo vai trò";
            // 
            // cboTimKiemTheoLoai
            // 
            this.cboTimKiemTheoLoai.FormattingEnabled = true;
            this.cboTimKiemTheoLoai.Location = new System.Drawing.Point(5, 24);
            this.cboTimKiemTheoLoai.Margin = new System.Windows.Forms.Padding(2);
            this.cboTimKiemTheoLoai.Name = "cboTimKiemTheoLoai";
            this.cboTimKiemTheoLoai.Size = new System.Drawing.Size(255, 21);
            this.cboTimKiemTheoLoai.TabIndex = 64;
            // 
            // btnLayNhanVienTheoLoai
            // 
            this.btnLayNhanVienTheoLoai.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLayNhanVienTheoLoai.Location = new System.Drawing.Point(184, 49);
            this.btnLayNhanVienTheoLoai.Name = "btnLayNhanVienTheoLoai";
            this.btnLayNhanVienTheoLoai.Size = new System.Drawing.Size(75, 23);
            this.btnLayNhanVienTheoLoai.TabIndex = 2;
            this.btnLayNhanVienTheoLoai.Text = "Tìm kiếm";
            this.btnLayNhanVienTheoLoai.UseVisualStyleBackColor = false;
            this.btnLayNhanVienTheoLoai.Click += new System.EventHandler(this.btnLayNhanVienTheoLoai_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(78, 19);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(180, 20);
            this.txtMaNV.TabIndex = 87;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(36, 25);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(28, 13);
            this.lable.TabIndex = 85;
            this.lable.Text = "Mã :";
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Location = new System.Drawing.Point(352, 158);
            this.cboVaiTro.Margin = new System.Windows.Forms.Padding(2);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(200, 21);
            this.cboVaiTro.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Vai trò :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTimKiemNhanVien);
            this.groupBox5.Controls.Add(this.txtTimKiemNhanVienTheoTen);
            this.groupBox5.Location = new System.Drawing.Point(581, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 77);
            this.groupBox5.TabIndex = 81;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm nhân viên";
            // 
            // btnTimKiemNhanVien
            // 
            this.btnTimKiemNhanVien.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiemNhanVien.Location = new System.Drawing.Point(184, 48);
            this.btnTimKiemNhanVien.Name = "btnTimKiemNhanVien";
            this.btnTimKiemNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemNhanVien.TabIndex = 1;
            this.btnTimKiemNhanVien.Text = "Tìm kiếm";
            this.btnTimKiemNhanVien.UseVisualStyleBackColor = false;
            this.btnTimKiemNhanVien.Click += new System.EventHandler(this.btnTimKiemNhanVien_Click);
            // 
            // txtTimKiemNhanVienTheoTen
            // 
            this.txtTimKiemNhanVienTheoTen.Location = new System.Drawing.Point(5, 20);
            this.txtTimKiemNhanVienTheoTen.Name = "txtTimKiemNhanVienTheoTen";
            this.txtTimKiemNhanVienTheoTen.Size = new System.Drawing.Size(254, 20);
            this.txtTimKiemNhanVienTheoTen.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Cyan;
            this.btnLamMoi.Location = new System.Drawing.Point(717, 242);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(126, 55);
            this.btnLamMoi.TabIndex = 80;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Cyan;
            this.btnSua.Location = new System.Drawing.Point(719, 180);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 56);
            this.btnSua.TabIndex = 79;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(580, 242);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 55);
            this.btnXoa.TabIndex = 78;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Cyan;
            this.btnThem.Location = new System.Drawing.Point(580, 180);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 56);
            this.btnThem.TabIndex = 77;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Ngày sinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Sđt :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Mật khẩu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Họ và tên :";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(352, 110);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 70;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(352, 65);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 69;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(352, 20);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 20);
            this.txtSoDienThoai.TabIndex = 68;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(78, 158);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(180, 20);
            this.txtMatKhau.TabIndex = 67;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 66;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(78, 64);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 20);
            this.txtHoTen.TabIndex = 65;
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(0, 303);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.RowHeadersWidth = 51;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(855, 298);
            this.dgvDanhSachNhanVien.TabIndex = 64;
            this.dgvDanhSachNhanVien.Click += new System.EventHandler(this.dgvDanhSachNhanVien_Click);
            // 
            // btnInNhanVienTheoLoai
            // 
            this.btnInNhanVienTheoLoai.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInNhanVienTheoLoai.Location = new System.Drawing.Point(103, 49);
            this.btnInNhanVienTheoLoai.Name = "btnInNhanVienTheoLoai";
            this.btnInNhanVienTheoLoai.Size = new System.Drawing.Size(75, 23);
            this.btnInNhanVienTheoLoai.TabIndex = 65;
            this.btnInNhanVienTheoLoai.Text = "In";
            this.btnInNhanVienTheoLoai.UseVisualStyleBackColor = false;
            this.btnInNhanVienTheoLoai.Click += new System.EventHandler(this.btnInNhanVienTheoLoai_Click);
            // 
            // btnInDanhSachTatCaNhanVien
            // 
            this.btnInDanhSachTatCaNhanVien.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInDanhSachTatCaNhanVien.Location = new System.Drawing.Point(12, 188);
            this.btnInDanhSachTatCaNhanVien.Name = "btnInDanhSachTatCaNhanVien";
            this.btnInDanhSachTatCaNhanVien.Size = new System.Drawing.Size(552, 109);
            this.btnInDanhSachTatCaNhanVien.TabIndex = 88;
            this.btnInDanhSachTatCaNhanVien.Text = "In danh sách tất cả nhân viên hiện có";
            this.btnInDanhSachTatCaNhanVien.UseVisualStyleBackColor = false;
            this.btnInDanhSachTatCaNhanVien.Click += new System.EventHandler(this.btnInDanhSachTatCaNhanVien_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 601);
            this.Controls.Add(this.btnInDanhSachTatCaNhanVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.cboVaiTro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.dgvDanhSachNhanVien);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboTimKiemTheoLoai;
        private System.Windows.Forms.Button btnLayNhanVienTheoLoai;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnTimKiemNhanVien;
        private System.Windows.Forms.TextBox txtTimKiemNhanVienTheoTen;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.Button btnInNhanVienTheoLoai;
        private System.Windows.Forms.Button btnInDanhSachTatCaNhanVien;
    }
}