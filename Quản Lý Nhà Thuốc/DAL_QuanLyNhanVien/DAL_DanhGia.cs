using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET_QuanLyNhaThuoc;

namespace DAL_QuanLyNhanVien
{
   public class DAL_DanhGia
    {
        private DataQuanLyNhaThuocDataContext db;

        public DAL_DanhGia()
        {
            db = new DataQuanLyNhaThuocDataContext();
        }
        public List<ET_DanhGia> LayDanhSachDanhGia()
        {

            return db.DanhGias
                  .Select(x => new ET_DanhGia(
                      x.id_danh_gia,
                      x.id_nhan_vien,
                      x.id_nguoi_gui,
                      x.muc_danh_gia,
                      x.noi_dung,
                      x.ngay_danh_gia ?? DateTime.Now))
                  .ToList();
        }
        public bool ThemDanhGia(ET_DanhGia danhGia)
        {
            try
            {
                DanhGia newDanhGia = new DanhGia
                {
                    id_danh_gia = danhGia.Id_DanhGia,
                    id_nhan_vien = danhGia.Id_NhanVien,
                    id_nguoi_gui = danhGia.Id_NguoiGui,
                    muc_danh_gia = danhGia.Muc_Danh_Gia,          
                    noi_dung = danhGia.NoiDung,
                    ngay_danh_gia = danhGia.NgayDanhGia,

                };

                db.DanhGias.InsertOnSubmit(newDanhGia);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm danh gia: " + ex.Message);
                return false;
            }
        }
        public int LayIdLoaiTheoTen(string tenLoai)
        {
            return db.LoaiUsers
                .Where(l => l.ten_loai == tenLoai)
                .Select(l => l.ma_loai)
                .FirstOrDefault();
        }
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

    }
}
