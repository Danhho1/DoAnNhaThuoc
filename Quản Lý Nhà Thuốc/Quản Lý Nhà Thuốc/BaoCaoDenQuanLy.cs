using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Windows.Forms;
using BUS_QuanLyNhaThuoc;
using ET_QuanLyNhaThuoc;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class BaoCaoDenQuanLy : Form
    {
        private BUS_BaoCao busBaoCao = new BUS_BaoCao();
        private BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private Panel _panelMain;
        public BaoCaoDenQuanLy(Panel panelMain)
        {
            InitializeComponent();
            _panelMain = panelMain;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void HienThiThongTinNguoiBan()
        {
            txtTenNguoiGui.Text = ManHinhDangNhap.TaiKhoanDangNhap.HoTenTaiKhoan;
            txtSoDienThoai.Text = ManHinhDangNhap.TaiKhoanDangNhap.SoDienThoaiTaiKhoan;
            txtEmail.Text = ManHinhDangNhap.TaiKhoanDangNhap.Email;
        }

        private void BaoCaoDenQuanLy_Load(object sender, EventArgs e)
        {
            HienThiThongTinNguoiBan();
            txtTenNguoiGui.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtEmail.Enabled = false;

            rdaRatIt.Checked = true;
            rdaRatTe.Checked = true;
            rda0_10.Checked = true;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                int id_nhanvien = 1; // hoặc lấy từ combobox, textbox, v.v.
                DateTime ngayBaoCao = DateTime.Now;
                // Lấy tình hình cửa hàng từ RadioButton
                int tinhHinhCuaHang = 3; // Mặc định là bình thường
                if (rdaRatTe.Checked) tinhHinhCuaHang = 1;
                else if (rdaTe.Checked) tinhHinhCuaHang = 2;
                else if (rdaBinhThuong.Checked) tinhHinhCuaHang = 3;
                else if (rdaTot.Checked) tinhHinhCuaHang = 4;
                else if (rdaRatTot.Checked) tinhHinhCuaHang = 5;

                // Lấy lượng khách từ RadioButton
                int luongKhach = 3; // Mặc định là bình thường
                if (rdaRatIt.Checked) luongKhach = 1;
                else if (rdaIt.Checked) luongKhach = 2;
                else if (rdaBinhThuongKhach.Checked) luongKhach = 3;
                else if (rdaNhieu.Checked) luongKhach = 4;
                else if (rdaRatNhieu.Checked) luongKhach = 5;

                // Lấy độ tuổi bệnh nhân từ RadioButton
                int doTuoiBenhNhan = 3; // Mặc định là 20-30
                if (rda0_10.Checked) doTuoiBenhNhan = 1;
                else if (rda10_20.Checked) doTuoiBenhNhan = 2;
                else if (rda20_30.Checked) doTuoiBenhNhan = 3;
                else if (rda30_40.Checked) doTuoiBenhNhan = 4;
                else if (rda40_100.Checked) doTuoiBenhNhan = 5;

                // Tạo đối tượng DTO
                ET_BaoCao baoCao = new ET_BaoCao(0,
                    id_nhanvien,
                    tinhHinhCuaHang,
                    rtbCacBenhHayGap.Text.Trim(),
                    luongKhach,
                    doTuoiBenhNhan,
                    rtbNoiDung.Text.Trim(),
                    ngayBaoCao
                );

                // Gọi lớp BLL để xử lý
                if (busBaoCao.ThemBaoCao(baoCao))
                {
                    MessageBox.Show("Gửi báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Gửi báo cáo thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
