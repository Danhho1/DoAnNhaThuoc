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

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class XemBaoCaoTuNhanVien: Form

    {
        private BUS_BaoCao busBaoCao = new BUS_BaoCao();
        private BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private Panel _panelMain;
        public XemBaoCaoTuNhanVien(Panel panelMain)
        {
            InitializeComponent();
            _panelMain = panelMain;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void LoadBaoCao()
        {
            var danhSach = busBaoCao.LayDanhSachBaoCao();
                           
            dgvBaoCao.DataSource = danhSach;
            
        }

        private void HienThiThongTinNguoiBan()
        {
            txtTenNguoiGui.Text = ManHinhDangNhap.TaiKhoanDangNhap.HoTenTaiKhoan;
            txtSoDienThoai.Text = ManHinhDangNhap.TaiKhoanDangNhap.SoDienThoaiTaiKhoan;
            txtEmail.Text = ManHinhDangNhap.TaiKhoanDangNhap.Email;
        }

        private void XemBaoCaoTuNhanVien_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
            HienThiThongTinNguoiBan();


            txtTenNguoiGui.Enabled = false ;
            txtSoDienThoai.Enabled = false;
            txtEmail.Enabled = false;


        }

        private void dgvBaoCao_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (dgvBaoCao.CurrentRow != null)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dgvBaoCao.CurrentRow;

                // Lấy thông tin từ bảng và đổ vào các control trên form

                // Tình hình cửa hàng
                int tinhHinh = Convert.ToInt32(row.Cells["TinhHinh"].Value);
                if (tinhHinh == 1) rdaRatTe.Checked = true;
                else if (tinhHinh == 2) rdaTe.Checked = true;
                else if (tinhHinh == 3) rdaBinhThuong.Checked = true;
                else if (tinhHinh == 4) rdaTot.Checked = true;
                else if (tinhHinh == 5) rdaRatTot.Checked = true;

                // Các bệnh hay gặp
                rtbCacBenhHayGap.Text = row.Cells["CacBenhHayGap"].Value.ToString();

                // Lượng khách
                int luongKhach = Convert.ToInt32(row.Cells["LuongKhach"].Value);
                if (luongKhach == 1) rdaRatIt.Checked = true;
                else if (luongKhach == 2) rdaIt.Checked = true;
                else if (luongKhach == 3) rdaBinhThuongKhach.Checked = true;
                else if (luongKhach == 4) rdaNhieu.Checked = true;
                else if (luongKhach == 5) rdaRatNhieu.Checked = true;

                // Độ tuổi bệnh nhân
                int doTuoi = Convert.ToInt32(row.Cells["DoTuoiBenhNhan"].Value);
                if (doTuoi == 1) rda0_10.Checked = true;
                else if (doTuoi == 2) rda10_20.Checked = true;
                else if (doTuoi == 3) rda20_30.Checked = true;
                else if (doTuoi == 4) rda30_40.Checked = true;
                else if (doTuoi == 5) rda40_100.Checked = true;

                // Nội dung
                rtbNoiDung.Text = row.Cells["NoiDung"].Value.ToString();

                // Lấy thông tin nhân viên theo ID
                int idNhanVien = Convert.ToInt32(dgvBaoCao.CurrentRow.Cells["Id_NhanVien"].Value);
                var nhanVien = busNhanVien.LayNhanVienTheoId(idNhanVien);
                if (nhanVien != null)
                {
                    txtTenNguoiGui.Text = nhanVien.HoTenTaiKhoan;
                    txtSoDienThoai.Text = nhanVien.SoDienThoaiTaiKhoan;
                    txtEmail.Text = nhanVien.Email;
                }
            }
        }
       
    }
}
