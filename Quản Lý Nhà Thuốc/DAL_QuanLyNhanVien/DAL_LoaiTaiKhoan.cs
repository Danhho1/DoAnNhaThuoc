using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_QuanLyNhaThuoc;

namespace DAL_QuanLyNhanVien
{
    public class DAL_LoaiTaiKhoan
    {
        private DataQuanLyNhaThuocDataContext db;

        public DAL_LoaiTaiKhoan()
        {
            db = new DataQuanLyNhaThuocDataContext();
        }

        public List<ET_LoaiTaiKhoan> LayDanhSachLoaiTaiKhoan()
        {
            return db.LoaiUsers
                .Select(l => new ET_LoaiTaiKhoan(l.ma_loai, l.ten_loai))
                .ToList();
        }

        public string LayTenLoaiTheoId(int maLoai)
        {
            return db.LoaiUsers
                .Where(l => l.ma_loai == maLoai)
                .Select(l => l.ten_loai)
                .FirstOrDefault() ?? string.Empty;
        }

        public int LayIdLoaiTheoTen(string tenLoai)
        {
            return db.LoaiUsers
                .Where(l => l.ten_loai == tenLoai)
                .Select(l => l.ma_loai)
                .FirstOrDefault();
        }
    }
}
