using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Thêm thư viện
using ET_QuanLyNhaThuoc;

namespace DAL_QuanLyNhanVien
{
    public class DAL_TaiKhoan
    {
        private DataQuanLyNhaThuocDataContext db;

        // Hàm tạo ( constructor ) để khởi tạo db
        public DAL_TaiKhoan()
        {
            db = new DataQuanLyNhaThuocDataContext();
        }

        // Lấy Số điện thoại và mật khẩu để đăng nhập
        public ET_TaiKhoan LaySDTvaMKdeDangNhap(string soDienThoai , string matKhau)
        {
            var dn = db.Users
                .Where(t => t.so_dien_thoai == soDienThoai && t.mat_khau == matKhau)
                .Select(t => new ET_TaiKhoan(
                    t.id,
                    t.ho_ten,
                    t.email,
                    t.mat_khau,
                    t.so_dien_thoai,
                    t.dia_chi,
                    t.ngay_sinh ?? DateTime.Now,
                    t.ma_loai, 
                    t.ngay_tao ?? DateTime.Now
                ))
                .FirstOrDefault();

            return dn;
        }
    }
}
