using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

// thêm thư viện
using DAL_QuanLyNhanVien;
using ET_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
    public class BUS_LoaiThuoc
    {
        private DAL_LoaiThuoc dalLoaiThuoc;

        public BUS_LoaiThuoc()
        {
            dalLoaiThuoc = new DAL_LoaiThuoc();
        }

        // Lấy danh sách thuốc
        public List<ET_LoaiThuoc> LayDanhSachLoaiThuoc()
        {
            return dalLoaiThuoc.LayDanhSachLoai();
        }

        // Lấy loại theo id
        public string LayTenLoaiTheoId(int idLoai)
        {
            return dalLoaiThuoc.LayTenLoaiTheoId(idLoai);
        }
    }
}
