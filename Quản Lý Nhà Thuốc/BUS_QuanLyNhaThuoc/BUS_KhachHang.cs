using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhanVien;
using ET_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang dalKhachHang = new DAL_KhachHang();

        public ET_KhachHang LayKhachHangTheoId(int id)
        {
            return dalKhachHang.LayKhachHangTheoId(id);
        }

        public bool ThemKhachHang(ET_KhachHang kh)
        {
            return dalKhachHang.ThemKhachHang(kh);
        }

        public int LayHoacThemKhachHang(string hoTen, string soDienThoai)
        {
            var khach = dalKhachHang.TimKhachHangTheoSoDienThoai(soDienThoai);
            if (khach != null)
            {
                return khach.IdKhachHang;
            }

            ET_KhachHang khachMoi = new ET_KhachHang
            {
                HoTen = hoTen,
                SoDienThoai = soDienThoai,
                NgayTao = DateTime.Now
            };
            return dalKhachHang.ThemVaTraVeId(khachMoi);
        }
    }
}
