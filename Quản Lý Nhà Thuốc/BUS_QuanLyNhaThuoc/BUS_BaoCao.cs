using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhanVien;
using ET_QuanLyNhaThuoc;

namespace BUS_QuanLyNhaThuoc
{
   public class BUS_BaoCao
    {
        private DAL_BaoCao dalBaoCao = new DAL_BaoCao();

        public List<ET_BaoCao> LayDanhSachBaoCao()
        {
            return dalBaoCao.LayDanhSachBaoCao();
        }

        public bool ThemBaoCao(ET_BaoCao baoCao)
        {
            return dalBaoCao.ThemBaoCao(baoCao);
        }
    }
}
