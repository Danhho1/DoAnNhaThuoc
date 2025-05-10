using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET_QuanLyNhaThuoc;

namespace DAL_QuanLyNhanVien
{
  public class DAL_LichSuMuaHangNguoiDung
    {
        private DataQuanLyNhaThuocDataContext db;
        public DAL_LichSuMuaHangNguoiDung()
        {
            db = new DataQuanLyNhaThuocDataContext();
        }

        // Lấy danh sách đơn thuốc
        public List<ET_LichSuMuaHangNguoiDung> LayDanhSachLichSuMuaHangNguoiDung()
        {
            return db.DonThuocs
                   .Select(x => new ET_LichSuMuaHangNguoiDung(
                       x.id,
                       x.id_don,
                       x.id_loai,
                       x.id_thuoc,
                       x.id_khach_hang,
                       x.id_nhan_vien,
                       x.so_luong,
                       x.gia_tien,
                       x.ngay_tao ?? DateTime.Now,
                       x.trang_thai))
                   .ToList();
        }
        public ET_LichSuMuaHangNguoiDung LayTongTheoKhachHang(int idKhachHang)
        {
            var danhSach = db.DonThuocs
                             .Where(d => d.id_khach_hang == idKhachHang && d.trang_thai == "Hoàn thành")
                             .ToList();

            int tongSL = danhSach.Sum(d => d.so_luong);
            decimal tongTien = danhSach.Sum(d => d.so_luong * d.gia_tien);

            return new ET_LichSuMuaHangNguoiDung
            {
                SoLuong = tongSL,
                GiaTien = tongTien
            };
        }

        // Cập nhật trạng thái 'Hoàn thành' cho tất cả thuốc trong đơn
        public bool CapNhatTrangThaiDon(int idDon)
        {
            try
            {
                var don = db.DonThuocs.Where(x => x.id_don == idDon).ToList();
                if (don.Count > 0)
                {
                    foreach (var item in don)
                    {
                        item.trang_thai = "Hoàn thành";
                    }

                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message);
                return false;
            }
        }
       
        public List<ET_LichSuMuaHangNguoiDung> TimKiemDonTheoTenKhach(string hoTen)
        {
            var query = from don in db.DonThuocs
                        join KhachHang in db.KhachHangs on don.id_khach_hang equals KhachHang.id_khach_hang
                        where KhachHang.ho_ten.Contains(hoTen) && don.trang_thai == "Hoàn thành"
                        select new ET_LichSuMuaHangNguoiDung
                        {
                            IdDon = don.id_don,
                            IdThuoc = don.id_thuoc,
                            IdLoai=don.id_loai,
                            Id = don.id,
                            IdNhanVien=don.id_nhan_vien,
                            GiaTien = don.gia_tien,

                            SoLuong = don.so_luong,
                            TrangThai = don.trang_thai,
                            NgayTao = don.ngay_tao,
                            IdKhachHang = don.id_khach_hang,
                        };

            return query.ToList();
        }
       
    }
}
