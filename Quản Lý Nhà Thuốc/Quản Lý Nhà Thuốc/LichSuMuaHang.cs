using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Thêm thư viện
using BUS_QuanLyNhaThuoc;
using ET_QuanLyNhaThuoc;

// thêm thư viện cho report
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Quản_Lý_Nhà_Thuốc.Report;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class LichSuMuaHang : Form
    {
        private BUS_DonThuoc busDonThuoc = new BUS_DonThuoc();
        private BUS_LichSuMuaHangNguoiDung busLichSuMuaHang = new BUS_LichSuMuaHangNguoiDung();

        private BUS_Thuoc busThuoc = new BUS_Thuoc();

        private BUS_LoaiThuoc busLoaiThuoc = new BUS_LoaiThuoc();

        private BUS_KhachHang busKhachHang = new BUS_KhachHang();

        private BUS_NhanVien busNhanVien = new BUS_NhanVien();

        private int selectedIdDon = -1;



        private Panel _panelMain;
        public LichSuMuaHang(Panel panelMain)
        {
            InitializeComponent();
            _panelMain = panelMain;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void LoadDonThuoc()
        {
            var danhSach = busDonThuoc.LayDanhSachDonThuoc()
                           .FindAll(x => x.TrangThai == "Hoàn thành");
            dgvLichSuMuaHang.DataSource = danhSach;
            //TinhTongTien(danhSach);
        }
        private void TinhTongTien(List<ET_DonThuoc> danhSach)
        {
            int tongSL = 0;
            decimal tongTien = 0;
            foreach (var item in danhSach)
            {
                tongSL += item.SoLuong;
                tongTien += item.GiaTien * item.SoLuong;
            }
            txtTongSoLuong.Text = tongSL.ToString();
            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }
        

        private void HienThiThongTinNguoiBan()
        {
            txtNguoiBan.Text = ManHinhDangNhap.TaiKhoanDangNhap.HoTenTaiKhoan;
            txtSdtNguoiBan.Text = ManHinhDangNhap.TaiKhoanDangNhap.SoDienThoaiTaiKhoan;
            txtEmailNguoiBan.Text = ManHinhDangNhap.TaiKhoanDangNhap.Email;
        }
        private void LoadDanhSachLoai()
        {
            // Lấy danh sách loại thuốc
            List<ET_LoaiThuoc> danhSachLoai = busLoaiThuoc.LayDanhSachLoaiThuoc();

        
        }


        // Luu file ảnh
        private string tenFileAnh = "";
        private string thuMucHinhAnh = Application.StartupPath + @"\HinhAnhThuoc\";
        private void dgvLichSuMuaHang_Click(object sender, EventArgs e)
        {
            if (dgvLichSuMuaHang.CurrentRow != null)
            {
                selectedIdDon = Convert.ToInt32(dgvLichSuMuaHang.CurrentRow.Cells["Id"].Value);

                txtIdDon.Text = dgvLichSuMuaHang.CurrentRow.Cells["IdDon"].Value.ToString();


                int idLoai = Convert.ToInt32(dgvLichSuMuaHang.CurrentRow.Cells["IdLoai"].Value);
                string tenLoai = busLoaiThuoc.LayTenLoaiTheoId(idLoai);
                txtLoaiThuoc.Text = tenLoai;


                // Lấy IdThuoc
                int idThuoc = Convert.ToInt32(dgvLichSuMuaHang.CurrentRow.Cells["IdThuoc"].Value);
                // Gọi phương thức từ lớp DAL để lấy tên thuốc
                string tenThuoc = busThuoc.LayTenThuocTheoId(idThuoc);
                txtTenThuoc.Text = tenThuoc;

                // Lấy hình ảnh theo id
                // Gọi phương thức từ BUS để lấy tên file hình ảnh
                tenFileAnh = busThuoc.LayHinhAnhTheoIdThuoc(idThuoc); // <-- Gọi qua BUS
                // Tạo đường dẫn đến hình ảnh
                string duongDanAnh = Path.Combine(thuMucHinhAnh, tenFileAnh);
                // Kiểm tra và hiển thị ảnh
                if (!string.IsNullOrEmpty(tenFileAnh) && File.Exists(duongDanAnh))
                {
                    pictureBoxHinhAnh.Image = Image.FromFile(duongDanAnh);
                    pictureBoxHinhAnh.SizeMode = PictureBoxSizeMode.Zoom; // Hiển thị vừa vặn nếu PictureBox nhỏ
                }
                else
                {
                    pictureBoxHinhAnh.Image = null;
                }
               

                txtSoLuong.Text = dgvLichSuMuaHang.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtGiaTien.Text = dgvLichSuMuaHang.CurrentRow.Cells["GiaTien"].Value.ToString();

                // Lấy thông tin khách hàng theo ID
                int idKhachHang = Convert.ToInt32(dgvLichSuMuaHang.CurrentRow.Cells["IdKhachHang"].Value);
                var khachHang = busKhachHang.LayKhachHangTheoId(idKhachHang);
                if (khachHang != null)
                {
                    txtNguoiMua.Text = khachHang.HoTen;
                    txtSoDienThoaiNguoiMua.Text = khachHang.SoDienThoai;

                    txtNguoiMua.Text = khachHang.HoTen;
                }
                var tongThongTin = busLichSuMuaHang.LayTongTheoKhachHang(idKhachHang);

                txtTongSoLuong.Text = tongThongTin.SoLuong.ToString();
                txtTongTien.Text = tongThongTin.GiaTien.ToString();
                // Lấy thông tin nhân viên theo ID
                int idNhanVien = Convert.ToInt32(dgvLichSuMuaHang.CurrentRow.Cells["IdNhanVien"].Value);
                var nhanVien = busNhanVien.LayNhanVienTheoId(idNhanVien);
                if (nhanVien != null)
                {
                    txtNguoiBan.Text = nhanVien.HoTenTaiKhoan;
                    txtSdtNguoiBan.Text = nhanVien.SoDienThoaiTaiKhoan;
                    txtEmailNguoiBan.Text = nhanVien.Email;
                }


            }
        }

       
       

       

        

        
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LichSuMuaHang_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        private void LichSuMuaHang_Load_1(object sender, EventArgs e)
        {
            LoadDonThuoc();
            HienThiThongTinNguoiBan();
            LoadDanhSachLoai();

            txtNguoiBan.Text = ManHinhDangNhap.TaiKhoanDangNhap.HoTenTaiKhoan;
            txtSdtNguoiBan.Text = ManHinhDangNhap.TaiKhoanDangNhap.SoDienThoaiTaiKhoan;
            txtEmailNguoiBan.Text = ManHinhDangNhap.TaiKhoanDangNhap.Email;

            txtLoaiThuoc.Enabled = false;
            txtTenThuoc.Enabled = false;
            txtGiaTien.Enabled = false;
            txtNguoiMua.Enabled = false;
            txtSoDienThoaiNguoiMua.Enabled = false;

            txtTongSoLuong.Enabled = false;
            txtTongTien.Enabled = false;
            txtNguoiBan.Enabled = false;
            txtEmailNguoiBan.Enabled = false;
            txtSdtNguoiBan.Enabled = false;


            txtIdDon.Enabled = false;

            txtNguoiMua.Enabled = false;
        }

        private void btnTimKiemTheoTenKhachi_Click(object sender, EventArgs e)
        {
            string tenKhach =txtTImKiemDonTHeoTenKhach.Text;
            var ketQua = busLichSuMuaHang.TimKiemDonTheoTenKhach(tenKhach);
            dgvLichSuMuaHang.DataSource = ketQua;
        }
    }
}
