using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QuanLyNhaThuoc
{
   public class ET_DoanhThu
    {
        private int id_DoanhThu;
       
        private DateTime? ngayBatDau;
        private DateTime? ngayKetThuc;
        private int tongSoLuongBan;
        private decimal tongTien;

        public ET_DoanhThu() { }
        public ET_DoanhThu( DateTime? ngayBatDau, DateTime? ngayKetThuc, int tongSoLuongBan, decimal tongTien)
        {
            
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.TongSoLuongBan = tongSoLuongBan;
            this.TongTien = tongTien;
        }

        public int Id_DoanhThu { get => id_DoanhThu; set => id_DoanhThu = value; }
        public DateTime? NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime? NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public int TongSoLuongBan { get => tongSoLuongBan; set => tongSoLuongBan = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
    }
}
