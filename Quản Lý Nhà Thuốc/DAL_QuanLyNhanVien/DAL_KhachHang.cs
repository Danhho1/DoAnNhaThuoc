using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_QuanLyNhaThuoc;

namespace DAL_QuanLyNhanVien
{
    public class DAL_KhachHang
    {
        private DataQuanLyNhaThuocDataContext db;

        public DAL_KhachHang()
        {
            db = new DataQuanLyNhaThuocDataContext();
        }

        public ET_KhachHang LayKhachHangTheoId(int id)
        {
            var kh = db.KhachHangs.FirstOrDefault(x => x.id_khach_hang == id);
            if (kh != null)
            {
                return new ET_KhachHang(
                    kh.id_khach_hang,
                    kh.ho_ten,
                    kh.so_dien_thoai,
                    kh.ngay_sinh,
                    kh.ngay_tao
                );
            }
            return null;
        }

        public bool ThemKhachHang(ET_KhachHang khachHang)
        {
            try
            {
                KhachHang newKH = new KhachHang
                {
                    ho_ten = khachHang.HoTen,
                    so_dien_thoai = khachHang.SoDienThoai,
                    ngay_sinh = khachHang.NgaySinh,
                    ngay_tao = khachHang.NgayTao ?? DateTime.Now
                };

                db.KhachHangs.InsertOnSubmit(newKH);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ET_KhachHang TimKhachHangTheoSoDienThoai(string sdt)
        {
            var k = db.KhachHangs.FirstOrDefault(kh => kh.so_dien_thoai == sdt);
            if (k != null)
            {
                return new ET_KhachHang
                {
                    IdKhachHang = k.id_khach_hang,
                    HoTen = k.ho_ten,
                    SoDienThoai = k.so_dien_thoai,
                    NgaySinh = k.ngay_sinh,
                    NgayTao = k.ngay_tao ?? DateTime.Now
                };
            }
            return null;
        }

        public int ThemVaTraVeId(ET_KhachHang kh)
        {
            KhachHang k = new KhachHang
            {
                ho_ten = kh.HoTen,
                so_dien_thoai = kh.SoDienThoai,
                ngay_sinh = kh.NgaySinh,
                ngay_tao = kh.NgayTao
            };
            db.KhachHangs.InsertOnSubmit(k);
            db.SubmitChanges();
            return k.id_khach_hang;
        }
    }
}
