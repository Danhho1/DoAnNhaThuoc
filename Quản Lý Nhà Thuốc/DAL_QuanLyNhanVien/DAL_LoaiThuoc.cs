using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Thêm thư viện
using ET_QuanLyNhaThuoc;
namespace DAL_QuanLyNhanVien
{
    public class DAL_LoaiThuoc
    {
        private DataQuanLyNhaThuocDataContext db;

        public DAL_LoaiThuoc()
        {
            db = new DataQuanLyNhaThuocDataContext();
        }

        // Lấy Danh Sách Loại
        public List<ET_LoaiThuoc> LayDanhSachLoai()
        {
            var dsloai = db.LoaiThuocs
                           .Where(tl => tl.trang_thai == "Hoạt động")
                           .Select(tl => new ET_LoaiThuoc(tl.id_loai, tl.ten_loai))
                           .ToList();
            return dsloai;
        }

        // Lấy Loại Theo ID
        public string LayTenLoaiTheoId(int idLoai)
        {
            var tenLoai = db.LoaiThuocs
                            .Where(lt => lt.id_loai == idLoai && lt.trang_thai == "Hoạt động")
                            .Select(lt => lt.ten_loai)
                            .FirstOrDefault();
            return tenLoai ?? string.Empty;
        }
    }
}
