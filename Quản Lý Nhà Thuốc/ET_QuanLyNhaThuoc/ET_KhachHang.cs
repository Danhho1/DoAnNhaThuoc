using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QuanLyNhaThuoc
{
    public class ET_KhachHang
    {
        public int IdKhachHang { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime? NgaySinh { get; set; }
        public DateTime? NgayTao { get; set; }

        public ET_KhachHang() { }

        public ET_KhachHang(int idKhachHang, string hoTen, string soDienThoai, DateTime? ngaySinh, DateTime? ngayTao)
        {
            IdKhachHang = idKhachHang;
            HoTen = hoTen;
            SoDienThoai = soDienThoai;
            NgaySinh = ngaySinh;
            NgayTao = ngayTao;
        }
    }
}
