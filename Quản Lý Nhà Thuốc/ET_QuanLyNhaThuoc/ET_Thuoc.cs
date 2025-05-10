using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QuanLyNhaThuoc
{
    public class ET_Thuoc
    {
        private int idThuoc;
        private int idLoai;
        private string tenThuoc;
        private string thanhPhan;
        private string moTa;
        private decimal giaTien;
        private string noiSanXuat;
        private string hinhAnh;

        public string TrangThai { get => trangThai; set => trangThai = value; }

        private DateTime? ngaySanXuat;
        private DateTime? ngayHetHan;
        private string trangThai;

        public ET_Thuoc(int idThuoc, int idLoai, string tenThuoc, string thanhPhan, string moTa,
            decimal giaTien, string noiSanXuat, string trangThai, string hinhAnh, DateTime? ngaySanXuat, DateTime? ngayHetHan)
        {
            this.idThuoc = idThuoc;
            this.idLoai = idLoai;
            this.tenThuoc = tenThuoc;
            this.thanhPhan = thanhPhan;
            this.moTa = moTa;
            this.giaTien = giaTien;
            this.noiSanXuat = noiSanXuat;

            this.TrangThai = trangThai;

            this.hinhAnh = hinhAnh;
            this.ngaySanXuat = ngaySanXuat;
            this.ngayHetHan = ngayHetHan;
        }

        public int IdThuoc { get => idThuoc; set => idThuoc = value; }
        public int IdLoai { get => idLoai; set => idLoai = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string ThanhPhan { get => thanhPhan; set => thanhPhan = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public decimal GiaTien { get => giaTien; set => giaTien = value; }
        public string NoiSanXuat { get => noiSanXuat; set => noiSanXuat = value; }

      

        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public DateTime? NgaySanXuat { get => ngaySanXuat; set => ngaySanXuat = value; }
        public DateTime? NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }

        public ET_Thuoc() { }
    }
}
