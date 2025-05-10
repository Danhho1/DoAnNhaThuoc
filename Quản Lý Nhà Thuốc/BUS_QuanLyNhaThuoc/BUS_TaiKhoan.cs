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
    public class BUS_TaiKhoan
    {
        private DAL_TaiKhoan dalTaiKhoan;
        public BUS_TaiKhoan() 
        {
            dalTaiKhoan = new DAL_TaiKhoan();
        }

        // Kiểm tra tài khoản bằng cách lấy số điện thoại và mật khẩu
        public ET_TaiKhoan KiemTraTaiKhoan(string soDienThoai , string matKhau)
        {
            return dalTaiKhoan.LaySDTvaMKdeDangNhap(soDienThoai, matKhau);
        }
    }
}
