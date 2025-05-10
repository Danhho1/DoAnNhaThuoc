using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QuanLyNhanVien;
using ET_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
   public class BUS_DoanhThu
    {
        DAL_DoanhThu dalDoanhThu = new DAL_DoanhThu();
        public (int tongSoLuong, decimal tongTien) TinhDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            var ds = dalDoanhThu.LayDonThuocTheoNgay(tuNgay, denNgay);
            int tongSL = ds.Sum(x => x.so_luong);
            decimal tongTien = ds.Sum(x => x.so_luong * x.gia_tien);
            return (tongSL, tongTien);
        }

        public bool LuuDoanhThu(ET_DoanhThu dt)
        {
            if (dalDoanhThu.KiemTraTonTai((DateTime)dt.NgayBatDau, (DateTime)dt.NgayKetThuc))
                return false;

            dalDoanhThu.ThemDoanhThu(dt);
            return true;
        }
        public bool XoaDoanhThu(int id)
        {
           

           return dalDoanhThu.XoaDoanhTHu(id);
            
        }
        public List<object> LayChiTietThuoc(DateTime tuNgay, DateTime denNgay)
        {
            return dalDoanhThu.ThongKeChiTietThuoc(tuNgay, denNgay);
        }
        public List<ET_DoanhThu> LayTatCaDoanhThu()
        {
            return dalDoanhThu.LayDanhSachDoanhThu();
        }
        public List<object> LayThuocBanHoanThanh()
        {
            return dalDoanhThu.LayThuocDaBanHoanThanh();
        }
        public ET_DoanhThu TinhDoanhThuHoanThanh(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return dalDoanhThu.TinhDoanhThuHoanThanh(ngayBatDau, ngayKetThuc);
        }
      
    }
}
