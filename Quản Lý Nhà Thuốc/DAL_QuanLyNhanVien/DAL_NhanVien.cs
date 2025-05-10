using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Thêm thư viện
using ET_QuanLyNhaThuoc;

namespace DAL_QuanLyNhanVien
{
    public class DAL_NhanVien
    {
        private DataQuanLyNhaThuocDataContext db;

        public DAL_NhanVien()
        {
            db = new DataQuanLyNhaThuocDataContext();
        }

        // Lấy Danh Sách Nhân Viên
        public List<ET_NhanVien> LayDanhSachNhanVien()
        {
            var dsnhanvien = db.Users
                              .Select(nv => new ET_NhanVien(
                                  nv.id,
                                  nv.ho_ten,
                                  nv.email,
                                  nv.mat_khau,
                                  nv.so_dien_thoai,
                                  nv.dia_chi,
                                  nv.ngay_sinh ?? DateTime.Now,
                                  nv.ma_loai,
                                  nv.ngay_tao ?? DateTime.Now))
                              .ToList();
            return dsnhanvien;
        }

        // Lấy nhân viên theo id
        public ET_NhanVien LayNhanVienTheoId(int id)
        {
            var nv = db.Users.FirstOrDefault(u => u.id == id);
            if (nv != null)
            {
                return new ET_NhanVien(
                    nv.id,
                    nv.ho_ten,
                    nv.email,
                    nv.mat_khau,
                    nv.so_dien_thoai,
                    nv.dia_chi,
                    nv.ngay_sinh ?? DateTime.Now,
                    nv.ma_loai,
                    nv.ngay_tao ?? DateTime.Now
                );
            }
            return null;
        }

        // Lấy Danh Sách Nhân Viên Theo Loại
        public List<ET_NhanVien> LayNhanVienTheoLoai(int maLoai)
        {
            var dsnhanvientheoloai = db.Users
                                      .Where(nv => nv.ma_loai == maLoai)
                                      .Select(nv => new ET_NhanVien(
                                           nv.id,
                                  nv.ho_ten,
                                  nv.email,
                                  nv.mat_khau,
                                  nv.so_dien_thoai,
                                  nv.dia_chi,
                                  nv.ngay_sinh ?? DateTime.Now,
                                  nv.ma_loai,
                                  nv.ngay_tao ?? DateTime.Now))
                                      .ToList();
            return dsnhanvientheoloai;
        }

        // Lấy Nhân Viên Theo Tên Loại
        public List<ET_NhanVien> LayNhanVienTheoTenLoai(string tenLoai)
        {
            var dsnhanvientheotenloai = db.Users
                                         .Join(db.LoaiUsers, nv => nv.ma_loai, lt => lt.ma_loai, (nv, lt) => new { User = nv, LoaiUser = lt })
                                         .Where(x => x.LoaiUser.ten_loai == tenLoai)
                                         .Select(x => new ET_NhanVien(
                                             x.User.id,
                                             x.User.ho_ten,
                                             x.User.email,
                                             x.User.mat_khau,
                                             x.User.so_dien_thoai,
                                             x.User.dia_chi,
                                             x.User.ngay_sinh ?? DateTime.Now,
                                             x.User.ma_loai,
                                             x.User.ngay_tao ?? DateTime.Now))
                                         .ToList();
            return dsnhanvientheotenloai;
        }

        // Thêm Nhân Viên
        public bool ThemNhanVien(ET_NhanVien nhanVien)
        {
            try
            {
                var user = new User
                {
                    ho_ten = nhanVien.HoTenTaiKhoan,
                    email = nhanVien.Email,
                    mat_khau = nhanVien.MatKhau,
                    so_dien_thoai = nhanVien.SoDienThoaiTaiKhoan,
                    dia_chi = nhanVien.DiaChi,
                    ngay_sinh = nhanVien.NgaySinh,
                    ma_loai = nhanVien.MaLoai,
                    ngay_tao = DateTime.Now
                };

                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Lưu log lỗi nếu cần thiết
                return false;
            }
        }

        // Cập Nhật Nhân Viên
        public bool CapNhatNhanVien(ET_NhanVien nhanVien)
        {
            try
            {
                var user = db.Users.SingleOrDefault(u => u.id == nhanVien.IdTaiKhoan);
                if (user != null)
                {
                    user.ho_ten = nhanVien.HoTenTaiKhoan;
                    user.email = nhanVien.Email;
                    user.mat_khau = nhanVien.MatKhau;
                    user.so_dien_thoai = nhanVien.SoDienThoaiTaiKhoan;
                    user.dia_chi = nhanVien.DiaChi;
                    user.ngay_sinh = nhanVien.NgaySinh;
                    user.ma_loai = nhanVien.MaLoai;

                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                // Lưu log lỗi nếu cần thiết
                return false;
            }
        }

        // Xóa Nhân Viên
        public bool XoaNhanVien(int idNhanVien)
        {
            try
            {
                var user = db.Users.SingleOrDefault(u => u.id == idNhanVien);
                if (user != null)
                {
                    db.Users.DeleteOnSubmit(user);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                // Lưu log lỗi nếu cần thiết
                return false;
            }
        }

        // Tìm Nhân Viên Theo Tên
        public List<ET_NhanVien> TimNhanVienTheoTen(string ten)
        {
            var dsNhanVien = db.Users
                               .Where(nv => nv.ho_ten.Contains(ten))//nv => nv.ho_ten.StartsWith(ten) || nv.ho_ten.EndsWith(ten) || nv.ho_ten == ten)
                               .Select(nv => new ET_NhanVien(
                                   nv.id,
                                   nv.ho_ten,
                                   nv.email,
                                   nv.mat_khau,
                                   nv.so_dien_thoai,
                                   nv.dia_chi,
                                   nv.ngay_sinh ?? DateTime.Now,
                                   nv.ma_loai,
                                   nv.ngay_tao ?? DateTime.Now))
                               .ToList();
            return dsNhanVien;
        }

    }
}