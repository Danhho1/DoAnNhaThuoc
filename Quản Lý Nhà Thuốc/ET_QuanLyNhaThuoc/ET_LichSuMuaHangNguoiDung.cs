using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QuanLyNhaThuoc
{
  public class ET_LichSuMuaHangNguoiDung
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
        public ET_LichSuMuaHangNguoiDung() { }

        public ET_LichSuMuaHangNguoiDung(int id, int idDon, int idLoai, int idThuoc, int idKhachHang, int idNhanVien, int soLuong, decimal giaTien, DateTime? ngayTao, string trangThai)
        {
            this.Id = id;
            this.IdDon = idDon;
            this.IdLoai = idLoai;
            this.IdThuoc = idThuoc;
            this.IdKhachHang = idKhachHang;
            this.IdNhanVien = idNhanVien;
            this.SoLuong = soLuong;
            this.GiaTien = giaTien;
            this.NgayTao = ngayTao;
            this.TrangThai = trangThai;
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
