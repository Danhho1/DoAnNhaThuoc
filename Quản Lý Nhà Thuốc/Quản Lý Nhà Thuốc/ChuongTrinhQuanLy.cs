    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Quản_Lý_Nhà_Thuốc
    {
        public partial class ChuongTrinhQuanLy : Form
        {
            public ChuongTrinhQuanLy()
            {
                InitializeComponent();
            }

            private void btnThuoc_Click(object sender, EventArgs e)
            {
                panelChuongTrinhQuanLy.Controls.Clear();

                Thuoc frmThuoc = new Thuoc(panelChuongTrinhQuanLy);
                frmThuoc.TopLevel = false;
                frmThuoc.Dock = DockStyle.Fill;

                panelChuongTrinhQuanLy.Controls.Add(frmThuoc);
                frmThuoc.Show();
            }

            private void btnDonThuoc_Click(object sender, EventArgs e)
            {
                panelChuongTrinhQuanLy.Controls.Clear();

                DonThuoc frmThuoc = new DonThuoc(panelChuongTrinhQuanLy);
                frmThuoc.TopLevel = false;
                frmThuoc.Dock = DockStyle.Fill;

                panelChuongTrinhQuanLy.Controls.Add(frmThuoc);
                frmThuoc.Show();
            }

            private void btnNhanVien_Click(object sender, EventArgs e)
            {
                panelChuongTrinhQuanLy.Controls.Clear();

                NhanVien frmNhanVien = new NhanVien();
                frmNhanVien.TopLevel = false;
                frmNhanVien.Dock = DockStyle.Fill;

                panelChuongTrinhQuanLy.Controls.Add(frmNhanVien);
                frmNhanVien.Show();
               
            }

        private void btnKho_Click(object sender, EventArgs e)
        {

            panelChuongTrinhQuanLy.Controls.Clear();

            Kho frmKho = new Kho();
            frmKho.TopLevel = false;
            frmKho.Dock = DockStyle.Fill;

            panelChuongTrinhQuanLy.Controls.Add(frmKho);
            frmKho.Show();
        }

        private void btnDanhGiaNhanVien_Click(object sender, EventArgs e)
        {
            panelChuongTrinhQuanLy.Controls.Clear();

            DanhGiaNhanVien frmDanhGiaNhanVien = new DanhGiaNhanVien(panelChuongTrinhQuanLy);
            frmDanhGiaNhanVien.TopLevel = false;
            frmDanhGiaNhanVien.Dock = DockStyle.Fill;

            panelChuongTrinhQuanLy.Controls.Add(frmDanhGiaNhanVien);
            frmDanhGiaNhanVien.Show();
        }

        private void btnKhoThuocBiXoa_Click(object sender, EventArgs e)
        {
            panelChuongTrinhQuanLy.Controls.Clear();

            KhoThuocBiXoa frmKhoThuocBiXoa = new KhoThuocBiXoa();
            frmKhoThuocBiXoa.TopLevel = false;
            frmKhoThuocBiXoa.Dock = DockStyle.Fill;

            panelChuongTrinhQuanLy.Controls.Add(frmKhoThuocBiXoa);
            frmKhoThuocBiXoa.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            panelChuongTrinhQuanLy.Controls.Clear();

            DoanhThu frmKhoThuocBiXoa = new DoanhThu(panelChuongTrinhQuanLy);
            frmKhoThuocBiXoa.TopLevel = false;
            frmKhoThuocBiXoa.Dock = DockStyle.Fill;

            panelChuongTrinhQuanLy.Controls.Add(frmKhoThuocBiXoa);
            frmKhoThuocBiXoa.Show();
        }

        private void btnLichSuBanHangNhanVien_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLichSuMuaHangCuaNguoiDung_Click(object sender, EventArgs e)
        {
            panelChuongTrinhQuanLy.Controls.Clear();

            LichSuMuaHang frmThuoc = new LichSuMuaHang(panelChuongTrinhQuanLy); // gọi đúng constructor

            frmThuoc.TopLevel = false;                  // Quan trọng: cho phép nhúng vào panel
            frmThuoc.FormBorderStyle = FormBorderStyle.None; // Ẩn viền
            frmThuoc.Dock = DockStyle.Fill;             // Lấp đầy panel

            panelChuongTrinhQuanLy.Controls.Add(frmThuoc);
            frmThuoc.Show();
           
        }
        

        private void btnXemBaoCaoTuNhanVien_Click(object sender, EventArgs e)
        {
            panelChuongTrinhQuanLy.Controls.Clear();

            XemBaoCaoTuNhanVien frmKhoThuocBiXoa = new XemBaoCaoTuNhanVien(panelChuongTrinhQuanLy);
            frmKhoThuocBiXoa.TopLevel = false;
            frmKhoThuocBiXoa.Dock = DockStyle.Fill;

            panelChuongTrinhQuanLy.Controls.Add(frmKhoThuocBiXoa);
            frmKhoThuocBiXoa.Show();
        }
    }
    }
