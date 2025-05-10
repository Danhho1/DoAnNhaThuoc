using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Thêm thư viện
using ET_QuanLyNhaThuoc;

namespace DAL_QuanLyNhanVien
{
    public class DAL_Thuoc
    {
        private DataQuanLyNhaThuocDataContext db;

        public DAL_Thuoc()
        {
            db = new DataQuanLyNhaThuocDataContext();
        }

        // Lấy Danh Sách Thuốc
        public List<ET_Thuoc> LayDanhSachThuoc()
        {
            var dsthuoc = db.Thuocs
                            .Where(x => x.trang_thai == "Hoạt động")
                            .Select(x => new ET_Thuoc(
                                                        x.id_thuoc,
                                                        x.id_loai,
                                                        x.ten_thuoc,
                                                        x.thanh_phan,
                                                        x.mo_ta,
                                                        x.gia_tien,
                                                        x.noi_san_xuat,
                                                        x.trang_thai,
                                                        x.hinh_anh,
                                                        x.ngay_san_xuat ?? DateTime.Now,
                                                        x.ngay_het_han ?? DateTime.Now))
                                                    .ToList();
            return dsthuoc;
        }
        // Lấy Danh Sách Thuốc Bị Xóa
        public List<ET_Thuoc> LayDanhSachThuocBiXoa()
        {
            var dsthuoc = db.Thuocs
                            .Where(x => x.trang_thai == "Không hoạt động ")
                            .Select(x => new ET_Thuoc(
                                                        x.id_thuoc,
                                                        x.id_loai,
                                                        x.ten_thuoc,
                                                        x.thanh_phan,
                                                        x.mo_ta,
                                                        x.gia_tien,
                                                        x.noi_san_xuat,
                                                        x.trang_thai,
                                                        x.hinh_anh,
                                                        x.ngay_san_xuat ?? DateTime.Now,
                                                        x.ngay_het_han ?? DateTime.Now))
                                                    .ToList();
            return dsthuoc;
        }
        // Tìm danh sách thuốc theo tên 
        public List<ET_Thuoc> TimDanhSachThuocTheoTen(string tenThuoc)
        {
            var ketQua = db.Thuocs
                .Where(t => t.ten_thuoc.Contains(tenThuoc) && t.trang_thai == "Hoạt động")
                .Select(x => new ET_Thuoc(
                    x.id_thuoc,
                    x.id_loai,
                    x.ten_thuoc,
                    x.thanh_phan,
                    x.mo_ta,
                    x.gia_tien,
                    x.noi_san_xuat,
                    x.trang_thai,
                    x.hinh_anh,
                    x.ngay_san_xuat ?? DateTime.Now,
                    x.ngay_het_han ?? DateTime.Now))
                .ToList();

            return ketQua;
        }
        // Tìm danh sách thuốc theo tên trong kho bị xóa
        public List<ET_Thuoc> TimDanhSachThuocTheoTenKhoBiXoa(string tenThuoc)
        {
            var ketQua = db.Thuocs
                .Where(t => t.ten_thuoc.Contains(tenThuoc) && t.trang_thai == "Không hoạt động")
                .Select(x => new ET_Thuoc(
                    x.id_thuoc,
                    x.id_loai,
                    x.ten_thuoc,
                    x.thanh_phan,
                    x.mo_ta,
                    x.gia_tien,
                    x.noi_san_xuat,
                    x.trang_thai,
                    x.hinh_anh,
                    x.ngay_san_xuat ?? DateTime.Now,
                    x.ngay_het_han ?? DateTime.Now))
                .ToList();

            return ketQua;
        }

        public List<ET_Thuoc> LayThuocTheoLoai(string tenLoai)
        {
            var dsthuoctheotenloai = db.Thuocs
                      .Join(db.LoaiThuocs, t => t.id_loai, lt => lt.id_loai, (t, lt) => new { Thuoc = t, LoaiThuoc = lt })
                .Where(x => x.LoaiThuoc.ten_loai == tenLoai && x.Thuoc.trang_thai == "Hoạt động")
                .Select(x => new ET_Thuoc(
                    x.Thuoc.id_thuoc,
                    x.Thuoc.id_loai,
                    x.Thuoc.ten_thuoc,
                    x.Thuoc.thanh_phan,
                    x.Thuoc.mo_ta,
                    x.Thuoc.gia_tien,
                    x.Thuoc.noi_san_xuat,
                    x.Thuoc.hinh_anh,

                    x.Thuoc.trang_thai,

                    x.Thuoc.ngay_san_xuat ?? DateTime.Now,
                    x.Thuoc.ngay_het_han ?? DateTime.Now))
                .ToList();
            return dsthuoctheotenloai;
        }

        public List<ET_Thuoc> LayThuocTheoLoaioThuocBiXoa(string tenLoai)
        {
            var dsthuoctheotenloai = db.Thuocs
                      .Join(db.LoaiThuocs, t => t.id_loai, lt => lt.id_loai, (t, lt) => new { Thuoc = t, LoaiThuoc = lt })
                .Where(x => x.LoaiThuoc.ten_loai == tenLoai && x.Thuoc.trang_thai == "Không hoạt động")
                .Select(x => new ET_Thuoc(
                    x.Thuoc.id_thuoc,
                    x.Thuoc.id_loai,
                    x.Thuoc.ten_thuoc,
                    x.Thuoc.thanh_phan,
                    x.Thuoc.mo_ta,
                    x.Thuoc.gia_tien,
                    x.Thuoc.noi_san_xuat,
                    x.Thuoc.hinh_anh,

                    x.Thuoc.trang_thai,

                    x.Thuoc.ngay_san_xuat ?? DateTime.Now,
                    x.Thuoc.ngay_het_han ?? DateTime.Now))
                .ToList();
            return dsthuoctheotenloai;
        }

        // Lấy tên thuốc theo ID
        public string LayTenThuocTheoId(int idThuoc)
        {
            try
            {
                var thuoc = db.Thuocs.FirstOrDefault(x => x.id_thuoc == idThuoc && x.trang_thai == "Hoạt động");
                if (thuoc != null)
                {
                    return thuoc.ten_thuoc;
                }
                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        // Thêm thuốc
        public bool ThemThuoc(ET_Thuoc thuoc)
        {
            try
            {
                Thuoc newThuoc = new Thuoc
                {
                    id_loai = thuoc.IdLoai,
                    ten_thuoc = thuoc.TenThuoc,
                    thanh_phan = thuoc.ThanhPhan,
                    mo_ta = thuoc.MoTa,
                    gia_tien = thuoc.GiaTien,
                    noi_san_xuat = thuoc.NoiSanXuat,
                    hinh_anh = thuoc.HinhAnh,
                    trang_thai = "Hoạt động",
                    ngay_san_xuat = thuoc.NgaySanXuat,
                    ngay_het_han = thuoc.NgayHetHan
                };

                db.Thuocs.InsertOnSubmit(newThuoc);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa thuốc
        public bool XoaThuoc(int idThuoc)
        {
            try
            {
                var thuocXoa = db.Thuocs.FirstOrDefault(x => x.id_thuoc == idThuoc);
                if (thuocXoa != null)
                {
                    db.Thuocs.DeleteOnSubmit(thuocXoa);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Xóa thuốc bằng cách chuyển đổi Hoạt động thành không hoạt động
        public bool ChuyenDoiTrangThaiThuoc(int idThuoc)
        {
            try
            {
                var thuoc = db.Thuocs.FirstOrDefault(x => x.id_thuoc == idThuoc);
                if (thuoc != null)
                {
                    thuoc.trang_thai = (thuoc.trang_thai == "Hoạt động") ? "Không hoạt động" : "Hoạt động";
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Khôi phục thuốc bằng cách chuyển đổi không hoạt động thành Hoạt động
        public bool ChuyenDoiTrangThaiThuocBiXoa(int idThuoc)
        {
            try
            {
                var thuoc = db.Thuocs.FirstOrDefault(x => x.id_thuoc == idThuoc);
                if (thuoc != null)
                {
                    thuoc.trang_thai = (thuoc.trang_thai == "Không hoạt động") ? "Hoạt động" : "Không hoạt động";
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Sửa thuốc
        public bool SuaThuoc(ET_Thuoc thuoc)
        {
            try
            {
                var thuocSua = db.Thuocs.FirstOrDefault(x => x.id_thuoc == thuoc.IdThuoc);
                if (thuocSua != null)
                {
                    thuocSua.id_loai = thuoc.IdLoai;
                    thuocSua.ten_thuoc = thuoc.TenThuoc;
                    thuocSua.thanh_phan = thuoc.ThanhPhan;
                    thuocSua.mo_ta = thuoc.MoTa;
                    thuocSua.gia_tien = thuoc.GiaTien;
                    thuocSua.noi_san_xuat = thuoc.NoiSanXuat;
                    thuocSua.hinh_anh = thuoc.HinhAnh;
                    thuocSua.ngay_san_xuat = thuoc.NgaySanXuat;
                    thuocSua.ngay_het_han = thuoc.NgayHetHan;

                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Lấy tên hình ảnh theo ID thuốc
        public string LayHinhAnhTheoID(int idThuoc)
        {
            try
            {
                var hinhAnh = db.Thuocs
                                .FirstOrDefault(t => t.id_thuoc == idThuoc)?
                                .hinh_anh;

                return hinhAnh ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
        // Lấy danh sách thuốc theo số tháng hạn sử dụng
        public List<ET_Thuoc> LayThuocTheoHanSuDungThang(int soThang)
        {
            // Lấy toàn bộ dữ liệu ra bộ nhớ trước
            var dsthuoc = db.Thuocs
                .Where(t => t.ngay_san_xuat != null && t.ngay_het_han != null && t.trang_thai == "Hoạt động")
                .ToList()
                .Where(t =>
                {
                    DateTime nsx = t.ngay_san_xuat.Value;
                    DateTime hsd = t.ngay_het_han.Value;

                    int months = (hsd.Year - nsx.Year) * 12 + hsd.Month - nsx.Month;

                    if (hsd.Day < nsx.Day)
                        months--; // Nếu ngày hết hạn nhỏ hơn ngày sản xuất thì chưa tròn tháng

                    return months == soThang;
                })
                .Select(x => new ET_Thuoc(
                    x.id_thuoc,
                    x.id_loai,
                    x.ten_thuoc,
                    x.thanh_phan,
                    x.mo_ta,
                    x.gia_tien,
                    x.noi_san_xuat, 
                    x.trang_thai,
                    x.hinh_anh,
                    x.ngay_san_xuat ?? DateTime.Now,
                    x.ngay_het_han ?? DateTime.Now))
                .ToList();

            return dsthuoc;
        }

        // Lấy danh sách thuốc theo số năm hạn sử dụng
        public List<ET_Thuoc> LayThuocTheoHanSuDungNam(int soNam)
        {
            var dsthuoc = db.Thuocs
                 .Where(t => t.ngay_san_xuat != null && t.ngay_het_han != null && t.trang_thai == "Hoạt động")
                 .ToList()
                 .Where(t =>
                 {
                     DateTime nsx = t.ngay_san_xuat.Value;
                     DateTime hsd = t.ngay_het_han.Value;

                     int years = hsd.Year - nsx.Year;

                     if ((hsd.Month < nsx.Month) || (hsd.Month == nsx.Month && hsd.Day < nsx.Day))
                         years--; // Chưa đủ 1 năm tròn

                     return years == soNam;
                 })
                 .Select(x => new ET_Thuoc(
                     x.id_thuoc,
                     x.id_loai,
                     x.ten_thuoc,
                     x.thanh_phan,
                     x.mo_ta,
                     x.gia_tien,
                     x.noi_san_xuat,
                     x.trang_thai,
                     x.hinh_anh,
                     x.ngay_san_xuat ?? DateTime.Now,
                     x.ngay_het_han ?? DateTime.Now))
                 .ToList();

                    return dsthuoc;
        }

    }
}
