using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyNhaThuoc;
using ET_QuanLyNhaThuoc;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class DanhGiaNhanVien : Form
    {
        BUS_DanhGia busDanhGia = new BUS_DanhGia();
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        ET_NhanVien etNhanVien = new ET_NhanVien();
        private Panel _panelMain;
        public DanhGiaNhanVien(Panel panelMain)
        {
            InitializeComponent();
            _panelMain = panelMain;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void HienThiThongTinNguoiBan()
        {
            txtTenNguoiGui.Text = ManHinhDangNhap.TaiKhoanDangNhap.HoTenTaiKhoan;
            txtSoDienThoai.Text = ManHinhDangNhap.TaiKhoanDangNhap.SoDienThoaiTaiKhoan;
            
        }
        private void LoadDanhSachNhanVien()
        {
            // Lấy danh sách loại thuốc
            List<ET_NhanVien> danhSachNhanVien= busNhanVien.LayDanhSachNhanVienTheoTenLoai("nhan_vien");

            // Thiết lập cho ComboBox
            cboNhanVien.DataSource = danhSachNhanVien;
            cboNhanVien.DisplayMember = "hoTenTaiKhoan";  // Hiển thị tên loại
            cboNhanVien.ValueMember = "idTaiKhoan";     // Lưu ID loại làm giá trị
        }

        private void DanhGiaNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            HienThiThongTinNguoiBan();
            txtTenNguoiGui.Enabled = false;
            txtSoDienThoai.Enabled = false;
            rdaRatTe.Checked = true;

        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                int idNhanVien = 1;
                 // hoặc lấy từ combobox, textbox, v.v.
                DateTime ngayDanhGia = DateTime.Now;
                // Lấy tình hình cửa hàng từ RadioButton
                int danhGiaNhanVien = 3; // Mặc định là bình thường
                if (rdaRatTe.Checked) danhGiaNhanVien = 1;
                else if (rdaTe.Checked) danhGiaNhanVien = 2;
                else if (rdaBinhThuong.Checked) danhGiaNhanVien = 3;
                else if (rdaTot.Checked) danhGiaNhanVien = 4;
                else if (rdaRatTot.Checked) danhGiaNhanVien = 5;



                // Tạo đối tượng DTO
                ET_DanhGia danhGia = new ET_DanhGia(0,
                     Convert.ToInt32(cboNhanVien.SelectedValue),
                     idNhanVien,
                     danhGiaNhanVien,
                     rtbNoiDung.Text.Trim(),
                     ngayDanhGia
                );

                // Gọi lớp BLL để xử lý
                if (busDanhGia.ThemDanhGia(danhGia))
                {
                    MessageBox.Show("Gửi danh gia thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Gửi danh gia thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
           rdaRatTe.Checked = true;
            rtbNoiDung.Clear();
          

            cboNhanVien.SelectedIndex = 0;


           

           

        }
    }
}
