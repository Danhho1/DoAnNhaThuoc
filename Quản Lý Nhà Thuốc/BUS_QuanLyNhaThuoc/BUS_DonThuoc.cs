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
    public class BUS_DonThuoc
    {
        private DAL_DonThuoc dalDonThuoc = new DAL_DonThuoc();

        public List<ET_DonThuoc> LayDanhSachDonThuoc()
        {
            return dalDonThuoc.LayDanhSachDonThuoc();
        }

        public bool ThemDonThuoc(ET_DonThuoc don)
        {
            return dalDonThuoc.ThemDonThuoc(don);
        }

        public bool SuaDonThuoc(ET_DonThuoc don)
        {
            return dalDonThuoc.SuaDonThuoc(don);
        }

        public bool XoaDonThuoc(int id)
        {
            return dalDonThuoc.XoaDonThuoc(id);
        }
        // Lấy đơn thuốc theo id loại
        public List<ET_DonThuoc> LayDonThuocTheoIdLoai(int idLoai)
        {
            return dalDonThuoc.LayDonThuocTheoIdLoai(idLoai);
        }
        public bool KiemTraIdDonTonTai(int idDon)
        {
            return dalDonThuoc.KiemTraIdDonTonTai(idDon);
        }
        public int LayIdDonCuoiCung()
        {
            return dalDonThuoc.LayIdDonCuoiCung();
        }
        public bool CapNhatTrangThaiDon(int idDon)
        {
            return dalDonThuoc.CapNhatTrangThaiDon(idDon);
        }
        public bool ThemHoacTangSoLuongThuoc(ET_DonThuoc don)
        {
            return dalDonThuoc.ThemHoacTangSoLuongThuoc(don);
        }

        public List<ET_DonThuoc> TimKiemDonThuocTheoTenThuoc(string tenThuoc)
        {
            return dalDonThuoc.TimKiemDonThuocTheoTenThuoc(tenThuoc);
        }

      
    }
}
