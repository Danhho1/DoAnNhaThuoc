using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Thêm thư viện
using DAL_QuanLyNhanVien;
using ET_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
    public class BUS_Thuoc
    {
        private DAL_Thuoc dalThuoc = new DAL_Thuoc();

        // Lấy danh sách thuốc 
        public List<ET_Thuoc> LayDanhSachThuoc()
        {
            return dalThuoc.LayDanhSachThuoc();
        }

        // Lấy danh sách thuốc bị xóa
        public List<ET_Thuoc> LayDanhSachThuocBiXoa()
        {
            return dalThuoc.LayDanhSachThuocBiXoa();
        }

        // Lấy danh sách thuốc theo Tên loại 
        public List<ET_Thuoc> LayDanhSachThuocTheoTenLoai(string tenLoai)
        {
            return dalThuoc.LayThuocTheoLoai(tenLoai);
        }

        // Lấy danh sách thuốc theo Tên loại ở kho bị xóa
        public List<ET_Thuoc> LayDanhSachThuocTheoTenLoaioKhoBiXoa(string tenLoai)
        {
            return dalThuoc.LayThuocTheoLoaioThuocBiXoa(tenLoai);
        }

        // Lấy thuốc theo theo ID
        public string LayTenThuocTheoId(int idThuoc)
        {
            return dalThuoc.LayTenThuocTheoId(idThuoc);
        }


        // Lấy hình ảnh theo Id loại 
        public string LayHinhAnhTheoIdThuoc(int idThuoc)
        {
            return dalThuoc.LayHinhAnhTheoID(idThuoc);
        }


        // Tìm thuốc theo tên thuốc
        public List<ET_Thuoc> TimDanhSachThuocTheoTen(string tenThuoc)
        {
            return dalThuoc.TimDanhSachThuocTheoTen(tenThuoc);
        }
        // Tìm thuốc theo tên thuốc ở kho bị xóa
        public List<ET_Thuoc> TimDanhSachThuocTheoTenKhoBiXoa(string tenThuoc)
        {
            return dalThuoc.TimDanhSachThuocTheoTenKhoBiXoa(tenThuoc);
        }

        // Thêm thuốc
        public bool ThemThuoc(ET_Thuoc thuoc)
        {
            return dalThuoc.ThemThuoc(thuoc);
        }

        // Xóa thuốc
        public bool XoaThuoc(int idThuoc)
        {
            return dalThuoc.XoaThuoc(idThuoc);
        }

        // Sửa thuốc
        public bool SuaThuoc(ET_Thuoc thuoc)
        {
            return dalThuoc.SuaThuoc(thuoc);
        }
        // Lấy danh sách thuốc theo hạn sử dụng Tháng
        public List<ET_Thuoc> LayThuocTheoHanSuDungThang(int soThang)
        {
            return dalThuoc.LayThuocTheoHanSuDungThang(soThang);
        }
        // Lấy danh sách thuốc theo hạn sử dụng Năm
        public List<ET_Thuoc> LayThuocTheoHanSuDungNam(int soNam)
        {
            return dalThuoc.LayThuocTheoHanSuDungNam(soNam);
        }

        // Xóa thuốc bằng các chuyển trạng thái thuốc
        // Chuyển đổi trạng thái thuốc
        public bool ChuyenDoiTrangThaiThuoc(int idThuoc)
        {
            return dalThuoc.ChuyenDoiTrangThaiThuoc(idThuoc);
        }

        // Khôi phục thuốc bằng các chuyển trạng thái thuốc
        // Chuyển đổi trạng thái thuốc
        public bool ChuyenDoiTrangThaiThuocBiXoa(int idThuoc)
        {
            return dalThuoc.ChuyenDoiTrangThaiThuocBiXoa(idThuoc);
        }
    }
}
