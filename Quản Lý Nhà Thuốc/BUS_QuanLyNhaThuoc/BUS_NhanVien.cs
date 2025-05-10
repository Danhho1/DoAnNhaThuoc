using System;
using System.Collections.Generic;
using DAL_QuanLyNhanVien;
using ET_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
    public class BUS_NhanVien
    {
        private DAL_NhanVien dalNhanVien;

        public BUS_NhanVien()
        {
            dalNhanVien = new DAL_NhanVien();
        }

        // Lấy danh sách nhân viên
        public List<ET_NhanVien> LayDanhSachNhanVien()
        {
            return dalNhanVien.LayDanhSachNhanVien();
        }

        // Lấy danh sách nhân viên theo mã loại
        public List<ET_NhanVien> LayDanhSachNhanVienTheoMaLoai(int maLoai)
        {
            return dalNhanVien.LayNhanVienTheoLoai(maLoai);
        }

        // Lấy danh sách nhân viên theo tên loại
        public List<ET_NhanVien> LayDanhSachNhanVienTheoTenLoai(string tenLoai)
        {
            return dalNhanVien.LayNhanVienTheoTenLoai(tenLoai);
        }

        // Thêm nhân viên mới
        public bool ThemNhanVien(ET_NhanVien nhanVien)
        {
            return dalNhanVien.ThemNhanVien(nhanVien);
        }

        // Cập nhật thông tin nhân viên
        public bool CapNhatNhanVien(ET_NhanVien nhanVien)
        {
            return dalNhanVien.CapNhatNhanVien(nhanVien);
        }

        // Xóa nhân viên
        public bool XoaNhanVien(int idNhanVien)
        {
            return dalNhanVien.XoaNhanVien(idNhanVien);
        }

        // Tìm Nhân Viên Theo Tên
        public List<ET_NhanVien> TimNhanVienTheoTen(string ten)
        {
            return dalNhanVien.TimNhanVienTheoTen(ten);
        }

        public ET_NhanVien LayNhanVienTheoId(int id)
        {
            return dalNhanVien.LayNhanVienTheoId(id);
        }
    }
}