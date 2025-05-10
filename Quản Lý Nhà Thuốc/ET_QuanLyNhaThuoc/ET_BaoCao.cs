using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QuanLyNhaThuoc
{
   public class ET_BaoCao
    {
        private int id_bao_cao;
        private int id_nhanvien;
        private int tinhHinh;
        private string cacBenhHayGap;
        private int luongKhach;
        private int doTuoiBenhNhan;
        private string noiDung;
        private DateTime? ngayBaoCao;

        public ET_BaoCao()
        {
            
        }
        public ET_BaoCao(int id_bao_cao, int id_nhanvien, int tinhHinh, string cacBenhHayGap, int luongKhach, int doTuoiBenhNhan, string noiDung, DateTime? ngayBaoCao)
        {
            this.Id_bao_cao = id_bao_cao;
            this.Id_nhanvien = id_nhanvien;
            this.TinhHinh = tinhHinh;
            this.CacBenhHayGap = cacBenhHayGap;
            this.LuongKhach = luongKhach;
            this.DoTuoiBenhNhan = doTuoiBenhNhan;
            this.NoiDung = noiDung;
            this.NgayBaoCao = ngayBaoCao;
        }

        public int Id_bao_cao { get => id_bao_cao; set => id_bao_cao = value; }
        public int Id_nhanvien { get => id_nhanvien; set => id_nhanvien = value; }
        public int TinhHinh { get => tinhHinh; set => tinhHinh = value; }
        public string CacBenhHayGap { get => cacBenhHayGap; set => cacBenhHayGap = value; }
        public int LuongKhach { get => luongKhach; set => luongKhach = value; }
        public int DoTuoiBenhNhan { get => doTuoiBenhNhan; set => doTuoiBenhNhan = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime? NgayBaoCao { get => ngayBaoCao; set => ngayBaoCao = value; }
    }
}
