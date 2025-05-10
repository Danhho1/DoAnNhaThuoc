using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhanVien;
using ET_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
   public class BUS_DanhGia
    {
        private DAL_DanhGia dalDanhGia = new DAL_DanhGia();
        private DAL_LoaiTaiKhoan dalLoaiTaiKhoan;
        private DAL_NhanVien dalNhanVien;

        public List<ET_DanhGia> LayDanhSachDanhGia()
        {
            return dalDanhGia.LayDanhSachDanhGia();
        }

        public bool ThemDanhGia(ET_DanhGia danhGia)
        {
            return dalDanhGia.ThemDanhGia(danhGia);
        }
        public string LayTenLoaiTaiKhoanTheoId(int idLoai)
        {
            return dalLoaiTaiKhoan.LayTenLoaiTheoId(idLoai);
        }
        public List<ET_NhanVien> LayDanhSachNhanVienTheoMaLoai(int maLoai)
        {
            return dalNhanVien.LayNhanVienTheoLoai(maLoai);
        }
    }
}
