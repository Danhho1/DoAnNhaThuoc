using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ET_QuanLyNhaThuoc
{
    public class ET_NhanVien
    {
        private int idTaiKhoan;
        private string hoTenTaiKhoan;
        private string email;
        private string matKhau;
        private string soDienThoaiTaiKhoan;
        private string diaChi;
        private DateTime? ngaySinh;
        private int maLoai;
        private DateTime ngayTao;

        public ET_NhanVien(int idTaiKhoan, string hoTenTaiKhoan, string email, string matKhau, string soDienThoaiTaiKhoan, string diaChi, DateTime? ngaySinh, int maLoai, DateTime ngayTao)
        {
            this.idTaiKhoan = idTaiKhoan;
            this.hoTenTaiKhoan = hoTenTaiKhoan;
            this.email = email;
            this.matKhau = matKhau;
            this.soDienThoaiTaiKhoan = soDienThoaiTaiKhoan;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.maLoai = maLoai;
            this.ngayTao = ngayTao;
        }

        public int IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public string HoTenTaiKhoan { get => hoTenTaiKhoan; set => hoTenTaiKhoan = value; }
        public string Email { get => email; set => email = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string SoDienThoaiTaiKhoan { get => soDienThoaiTaiKhoan; set => soDienThoaiTaiKhoan = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }

        public ET_NhanVien() { }
    }
}
