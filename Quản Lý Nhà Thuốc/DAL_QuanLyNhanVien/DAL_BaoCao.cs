using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET_QuanLyNhaThuoc;

namespace DAL_QuanLyNhanVien
{
   public class DAL_BaoCao
    {
        private DataQuanLyNhaThuocDataContext db;

        public DAL_BaoCao()
        {
            db = new DataQuanLyNhaThuocDataContext();
        }

        public List<ET_BaoCao> LayDanhSachBaoCao()
        {
            return db.BaoCaos
                   .Select(x => new ET_BaoCao(
                       x.id_bao_cao,
                       x.id_nhan_vien,
                       x.tinh_hinh_cua_hang,
                       x.cac_benh_hay_gap,
                       x.luong_khach,
                       x.do_tuoi_benh_nhan,
                       x.noi_dung,
                       x.ngay_bao_cao ?? DateTime.Now))
                   .ToList();
        }

        public bool ThemBaoCao(ET_BaoCao baoCao)
        {
            try
            {
                BaoCao newBaoCao= new BaoCao
                {
                    id_bao_cao = baoCao.Id_bao_cao,
                    id_nhan_vien = baoCao.Id_nhanvien,
                    tinh_hinh_cua_hang = baoCao.TinhHinh,
                    cac_benh_hay_gap = baoCao.CacBenhHayGap,
                    luong_khach = baoCao.LuongKhach,
                    do_tuoi_benh_nhan = baoCao.DoTuoiBenhNhan,
                    noi_dung = baoCao.NoiDung,
                    ngay_bao_cao = baoCao.NgayBaoCao,
                    
                };

                db.BaoCaos.InsertOnSubmit(newBaoCao);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm Bao CAo: " + ex.Message);
                return false;
            }
        }
    }
}
