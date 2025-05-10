using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QuanLyNhaThuoc
{
    public class ET_DonThuoc
    {
        private int id; 
        private int idDon;
        private int idLoai;
        private int idThuoc;
        private int idKhachHang;
        private int idNhanVien;
        private int soLuong;
        private decimal giaTien;
        private DateTime? ngayTao;
        private string trangThai;

        public ET_DonThuoc() { }

        public ET_DonThuoc(int id, int idDon, int idLoai, int idThuoc, int idKhachHang, int idNhanVien, int soLuong, decimal giaTien, DateTime? ngayTao, string trangThai)
        {
            this.id = id;
            this.idDon = idDon;
            this.idLoai = idLoai;
            this.idThuoc = idThuoc;
            this.idKhachHang = idKhachHang;
            this.idNhanVien = idNhanVien;
            this.soLuong = soLuong;
            this.giaTien = giaTien;
            this.ngayTao = ngayTao;
            this.trangThai = trangThai;
        }

        public int Id { get => id; set => id = value; }
        public int IdDon { get => idDon; set => idDon = value; }
        public int IdLoai { get => idLoai; set => idLoai = value; }
        public int IdThuoc { get => idThuoc; set => idThuoc = value; }
        public int IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal GiaTien { get => giaTien; set => giaTien = value; }
        public DateTime? NgayTao { get => ngayTao; set => ngayTao = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
