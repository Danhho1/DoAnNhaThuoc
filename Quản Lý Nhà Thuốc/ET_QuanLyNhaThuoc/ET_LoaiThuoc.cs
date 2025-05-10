using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QuanLyNhaThuoc
{
    public class ET_LoaiThuoc
    {
        private int idLoai;
        private string tenLoai;

        public ET_LoaiThuoc(int idLoai, string tenLoai)
        {
            this.idLoai = idLoai;
            this.tenLoai = tenLoai;
        }

        public int IdLoai { get => idLoai; set => idLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
