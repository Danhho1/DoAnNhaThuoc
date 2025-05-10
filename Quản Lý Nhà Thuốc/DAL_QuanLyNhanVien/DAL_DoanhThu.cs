using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET_QuanLyNhaThuoc;

namespace DAL_QuanLyNhanVien
{
   public class DAL_DoanhThu
    {
        private DataQuanLyNhaThuocDataContext db;
        public DAL_DoanhThu()
        {
            db = new DataQuanLyNhaThuocDataContext(); // ← Quan trọng: khởi tạo ở đây
        }
        public bool KiemTraTonTai(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return db.DoanhThus.Any(dt => dt.ngay_bat_dau == ngayBatDau && dt.ngay_ket_thuc == ngayKetThuc);
        }

        public bool ThemDoanhThu(ET_DoanhThu dtET)
        {
            try
            {
                DoanhThu dt = new DoanhThu
                {

                    ngay_bat_dau = (DateTime)dtET.NgayBatDau,
                    ngay_ket_thuc = (DateTime)dtET.NgayKetThuc,
                    tong_so_luong_ban = dtET.TongSoLuongBan,
                    tong_tien = dtET.TongTien
                };
                db.DoanhThus.InsertOnSubmit(dt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi thêm đơn thuốc: " + ex.Message);
                return false;
            }
           
        }

        public List<DonThuoc> LayDonThuocTheoNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return db.DonThuocs
                     .Where(d => d.ngay_tao >= ngayBatDau && d.ngay_tao <= ngayKetThuc)
                     .ToList();
        }
        public bool XoaDoanhTHu(int idDoanhThu)
        {
            try
            {
                // Tìm đơn thuốc theo khóa chính id
                var xoa = db.DoanhThus.FirstOrDefault(x => x.id_doanh_thu == idDoanhThu);
                if (xoa != null)
                {
                    db.DoanhThus.DeleteOnSubmit(xoa);  // Xóa khỏi cơ sở dữ liệu
                    db.SubmitChanges();  // Lưu thay đổi
                    return true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy doanh thu với ID này.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa doanh thu: " + ex.Message);
                return false;
            }
        }
        public List<object> ThongKeChiTietThuoc(DateTime tuNgay, DateTime denNgay)
        {
            var donThuoc = db.DonThuocs
                             .Where(d => d.ngay_tao >= tuNgay && d.ngay_tao <= denNgay);

            return donThuoc
                .GroupBy(d => d.id_thuoc)
                .Join(db.Thuocs, g => g.Key, t => t.id_thuoc, (g, t) => new
                {
                    TenThuoc = t.ten_thuoc,
                    SoLuongDaBan = g.Sum(x => x.so_luong)
                })
                .OrderByDescending(x => x.SoLuongDaBan)
                .Cast<object>()
                .ToList();
        }
        public List<object> LayThuocDaBanHoanThanh()
        {
           
                var danhSach = db.DonThuocs
                    .Where(d => d.trang_thai == "Hoàn thành")
                    .GroupBy(d => d.id_thuoc)
                    .Join(db.Thuocs,
                        don => don.Key,
                        thuoc => thuoc.id_thuoc,
                        (don, thuoc) => new
                        {
                            TenThuoc = thuoc.ten_thuoc,
                            SoLuongBan = don.Sum(x => x.so_luong)
                        })
                    .OrderByDescending(x => x.SoLuongBan)
                    .ToList<object>();

                return danhSach;
            
        }
        public ET_DoanhThu TinhDoanhThuHoanThanh(DateTime tuNgay, DateTime denNgay)
        {

            using (var db = new DataQuanLyNhaThuocDataContext()) // ← Bắt buộc phải có dòng này
            {
                
                var donThuocHoanThanh = db.DonThuocs
                    .Where(d => d.ngay_tao >= tuNgay
                             && d.ngay_tao <= denNgay
                             && d.trang_thai == "Hoàn thành");

                int tongSoLuong = donThuocHoanThanh.Sum(d => (int?)d.so_luong) ?? 0;
                decimal tongTien = donThuocHoanThanh.Sum(d => (decimal?)(d.so_luong * d.gia_tien)) ?? 0;

                return new ET_DoanhThu
                {
                 
                    NgayBatDau = tuNgay,
                    NgayKetThuc = denNgay,
                    TongSoLuongBan = tongSoLuong,
                    TongTien = tongTien
                };
            }

        }

        public List<ET_DoanhThu> LayDanhSachDoanhThu()
        {
            return db.DoanhThus
            .Select(d => new ET_DoanhThu
            {
                Id_DoanhThu = d.id_doanh_thu,
                NgayBatDau = d.ngay_bat_dau,
                NgayKetThuc = d.ngay_ket_thuc,
                TongSoLuongBan = d.tong_so_luong_ban,
                TongTien = d.tong_tien
            })
            .ToList();
        }
    }
}
