using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QuanLyNhaThuoc
{
    public class ET_DanhGia
    {
        private int id_DanhGia;
        private int id_NhanVien;
        private int id_NguoiGui;
        private int muc_Danh_Gia;
        private string noiDung;
        private DateTime? ngayDanhGia;
        public ET_DanhGia() { }

        public ET_DanhGia(int id_DanhGia, int id_NhanVien, int id_NguoiGui, int muc_Danh_Gia, string noiDung, DateTime? ngayDanhGia)
        {
            this.Id_DanhGia = id_DanhGia;
            this.Id_NhanVien = id_NhanVien;
            this.Id_NguoiGui = id_NguoiGui;
            this.Muc_Danh_Gia = muc_Danh_Gia;
            this.NoiDung = noiDung;
            this.NgayDanhGia = ngayDanhGia;
        }

        public int Id_DanhGia { get => id_DanhGia; set => id_DanhGia = value; }
        public int Id_NhanVien { get => id_NhanVien; set => id_NhanVien = value; }
        public int Id_NguoiGui { get => id_NguoiGui; set => id_NguoiGui = value; }
        public int Muc_Danh_Gia { get => muc_Danh_Gia; set => muc_Danh_Gia = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime? NgayDanhGia { get => ngayDanhGia; set => ngayDanhGia = value; }
    }
}
