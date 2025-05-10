using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Thêm thư viện
using DAL_QuanLyNhanVien;
using ET_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
    public class BUS_LoaiTaiKhoan
    {
        private DAL_LoaiTaiKhoan dalLoaiTaiKhoan;

        public BUS_LoaiTaiKhoan()
        {
            dalLoaiTaiKhoan = new DAL_LoaiTaiKhoan();
        }

        // Lấy danh sách loại tài khoản
        public List<ET_LoaiTaiKhoan> LayDanhSachLoaiTaiKhoan()
        {
            return dalLoaiTaiKhoan.LayDanhSachLoaiTaiKhoan();
        }

        // Lấy tên loại tài khoản theo id
        public string LayTenLoaiTaiKhoanTheoId(int idLoai)
        {
            return dalLoaiTaiKhoan.LayTenLoaiTheoId(idLoai);
        }
    }
}