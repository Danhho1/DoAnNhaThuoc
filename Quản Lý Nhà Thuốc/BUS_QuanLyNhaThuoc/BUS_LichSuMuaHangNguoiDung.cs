using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QuanLyNhanVien;
using ET_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
   public class BUS_LichSuMuaHangNguoiDung
    {
        private DAL_LichSuMuaHangNguoiDung dalLichSuMuaHangNguoiDung = new DAL_LichSuMuaHangNguoiDung();

        public List<ET_LichSuMuaHangNguoiDung> LayDanhSachLichSuMuaHangNguoiDung()
        {
            return dalLichSuMuaHangNguoiDung.LayDanhSachLichSuMuaHangNguoiDung();
        }
        
       

        public List<ET_LichSuMuaHangNguoiDung> TimKiemDonTheoTenKhach(string khachHang)
        {
            return dalLichSuMuaHangNguoiDung.TimKiemDonTheoTenKhach(khachHang);
        }
        public ET_LichSuMuaHangNguoiDung LayTongTheoKhachHang(int idKhachHang)
        {
            return dalLichSuMuaHangNguoiDung.LayTongTheoKhachHang(idKhachHang);
        }
    }
}
