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
    public partial class ChuongTrinhNhanVien : Form
    {
        public ChuongTrinhNhanVien()
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

        private void btnLichSuMuaHang_Click(object sender, EventArgs e)
        {
            panelChuongTrinhQuanLy.Controls.Clear();

            LichSuMuaHang frmThuoc = new LichSuMuaHang(panelChuongTrinhQuanLy); // gọi đúng constructor

            frmThuoc.TopLevel = false;                  // Quan trọng: cho phép nhúng vào panel
            frmThuoc.FormBorderStyle = FormBorderStyle.None; // Ẩn viền
            frmThuoc.Dock = DockStyle.Fill;             // Lấp đầy panel

            panelChuongTrinhQuanLy.Controls.Add(frmThuoc);
            frmThuoc.Show();
        }

        private void btnBaoCaoDenQuanLy_Click(object sender, EventArgs e)
        {
            panelChuongTrinhQuanLy.Controls.Clear();
            BaoCaoDenQuanLy frmThuoc = new BaoCaoDenQuanLy(panelChuongTrinhQuanLy); 
            frmThuoc.TopLevel = false;
            frmThuoc.Dock = DockStyle.Fill;

           
            panelChuongTrinhQuanLy.Controls.Add(frmThuoc);
            frmThuoc.Show();
        }

        private void btnXemDanhGiaTuQuanLy_Click(object sender, EventArgs e)
        {
            panelChuongTrinhQuanLy.Controls.Clear();
            XemDanhGiaTuQuanLy frmThuoc = new XemDanhGiaTuQuanLy(panelChuongTrinhQuanLy);  // Bỏ đối số nếu không cần
            frmThuoc.TopLevel = false;
            frmThuoc.Dock = DockStyle.Fill;

           
            panelChuongTrinhQuanLy.Controls.Add(frmThuoc);
            frmThuoc.Show();
        }
    }
}
