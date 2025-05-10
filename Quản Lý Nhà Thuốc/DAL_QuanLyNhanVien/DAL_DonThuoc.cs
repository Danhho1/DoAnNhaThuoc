using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET_QuanLyNhaThuoc;

namespace DAL_QuanLyNhanVien
{
    public class DAL_DonThuoc
    {
        private DataQuanLyNhaThuocDataContext db;

        public DAL_DonThuoc()
        {
            db = new DataQuanLyNhaThuocDataContext();
        }

        // Lấy danh sách đơn thuốc
        public List<ET_DonThuoc> LayDanhSachDonThuoc()
        {
            return db.DonThuocs
                   .Select(x => new ET_DonThuoc(
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

        // Thêm đơn thuốc
        public bool ThemDonThuoc(ET_DonThuoc don)
        {
            try
            {
                DonThuoc newDon = new DonThuoc
                {
                    id_don = don.IdDon,
                    id_loai = don.IdLoai,
                    id_thuoc = don.IdThuoc,
                    id_khach_hang = don.IdKhachHang,
                    id_nhan_vien = don.IdNhanVien,
                    so_luong = don.SoLuong,
                    gia_tien = don.GiaTien,
                    ngay_tao = don.NgayTao,
                    trang_thai = don.TrangThai
                };

                db.DonThuocs.InsertOnSubmit(newDon);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn thuốc: " + ex.Message); 
                return false;
            }
        }
        // Kiểm tra xem một id_don đã tồn tại trong bảng DonThuoc hay chưa
        public bool KiemTraIdDonTonTai(int idDon)
        {
            try
            {
                return db.DonThuocs.Any(x => x.id_don == idDon);
            }
            catch
            {
                return false;
            }
        }
        // Lấy id_don lớn nhất trong bảng DonThuoc
        public int LayIdDonCuoiCung()
        {
            try
            {
                int maxId = db.DonThuocs.Max(x => (int?)x.id_don) ?? 0;
                return maxId;
            }
            catch
            {
                return 0;
            }
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

        // Nếu đơn đã có thuốc đó rồi thì tăng số lượng thay vì thêm mới
        public bool ThemHoacTangSoLuongThuoc(ET_DonThuoc don)
        {
            try
            {
                var thuocTrongDon = db.DonThuocs.FirstOrDefault(x => x.id_don == don.IdDon && x.id_thuoc == don.IdThuoc);

                if (thuocTrongDon != null)
                {
                    thuocTrongDon.so_luong += don.SoLuong;
                }
                else
                {
                    DonThuoc newDon = new DonThuoc
                    {
                        id_don = don.IdDon,
                        id_loai = don.IdLoai,
                        id_thuoc = don.IdThuoc,
                        id_khach_hang = don.IdKhachHang,
                        id_nhan_vien = don.IdNhanVien,
                        so_luong = don.SoLuong,
                        gia_tien = don.GiaTien,
                        ngay_tao = don.NgayTao,
                        trang_thai = don.TrangThai
                    };

                    db.DonThuocs.InsertOnSubmit(newDon);
                }

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm/tăng số lượng thuốc trong đơn: " + ex.Message);
                return false;
            }
        }

        // Sửa đơn thuốc
        public bool SuaDonThuoc(ET_DonThuoc don)
        {
            try
            {
                // Tìm đơn thuốc theo khóa chính id
                var sua = db.DonThuocs.FirstOrDefault(x => x.id == don.Id);
                if (sua != null)
                {
                    sua.so_luong = don.SoLuong;  // Cập nhật số lượng
                    sua.trang_thai = don.TrangThai;  // Cập nhật trạng thái

                    db.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                    return true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn thuốc với ID này.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa đơn thuốc: " + ex.Message);
                return false;
            }
        }

        // Xóa đơn thuốc
        public bool XoaDonThuoc(int id)
        {
            try
            {
                // Tìm đơn thuốc theo khóa chính id
                var xoa = db.DonThuocs.FirstOrDefault(x => x.id == id);
                if (xoa != null)
                {
                    db.DonThuocs.DeleteOnSubmit(xoa);  // Xóa đơn thuốc khỏi cơ sở dữ liệu
                    db.SubmitChanges();  // Lưu thay đổi
                    return true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn thuốc với ID này.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa đơn thuốc: " + ex.Message);
                return false;
            }
        }

        // Lấy danh sách đơn thuốc theo IdLoai
        public List<ET_DonThuoc> LayDonThuocTheoIdLoai(int idLoai)
        {
            return db.DonThuocs
                .Where(x => x.id_loai == idLoai && x.trang_thai == "Chưa hoàn thành")
                .Select(x => new ET_DonThuoc(
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

        public List<ET_DonThuoc> TimKiemDonThuocTheoIdThuoc(int idThuoc)
        {
            return db.DonThuocs
                .Where(x => x.id_thuoc == idThuoc && x.trang_thai == "Chưa hoàn thành")
                .Select(x => new ET_DonThuoc(
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

        public List<ET_DonThuoc> TimKiemDonThuocTheoTenThuoc(string tenThuoc)
        {
            var query = from don in db.DonThuocs
                        join thuoc in db.Thuocs on don.id_thuoc equals thuoc.id_thuoc
                        where thuoc.ten_thuoc.Contains(tenThuoc) && don.trang_thai == "Chưa hoàn thành"
                        select new ET_DonThuoc
                        {
                            IdDon = don.id_don,
                            IdThuoc = don.id_thuoc,

                            SoLuong = don.so_luong,
                            TrangThai = don.trang_thai,
                            NgayTao = don.ngay_tao,
                        };

            return query.ToList();
        }

    }
}
