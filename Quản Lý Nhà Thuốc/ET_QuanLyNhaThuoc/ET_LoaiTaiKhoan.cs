using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QuanLyNhaThuoc
{
    public class ET_LoaiTaiKhoan
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public ET_LoaiTaiKhoan(int maLoai, string tenLoai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
        }
    }
}
