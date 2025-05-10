using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Thêm thư viện
using BUS_QuanLyNhaThuoc;
using ET_QuanLyNhaThuoc;

// thêm thư viện cho report
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Quản_Lý_Nhà_Thuốc.Report;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class DonThuoc : Form
    {
        private BUS_DonThuoc busDonThuoc = new BUS_DonThuoc();

        private BUS_Thuoc busThuoc = new BUS_Thuoc();

        private BUS_LoaiThuoc busLoaiThuoc = new BUS_LoaiThuoc();

        private BUS_KhachHang busKhachHang = new BUS_KhachHang();

        private BUS_NhanVien busNhanVien = new BUS_NhanVien();

        private int selectedIdDon = -1;

       

        private Panel _panelMain;
        public DonThuoc(Panel panelMain)
        {
            InitializeComponent();
            _panelMain = panelMain;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void LoadDonThuoc()
        {
            var danhSach = busDonThuoc.LayDanhSachDonThuoc()
                           .FindAll(x => x.TrangThai == "Chưa hoàn thành");
            dgvDonThuoc.DataSource = danhSach;
            TinhTongTien(danhSach);
        }
        private void TinhTongTien(List<ET_DonThuoc> danhSach)
        {
            int tongSL = 0;
            decimal tongTien = 0;
            foreach (var item in danhSach)
            {
                tongSL += item.SoLuong;
                tongTien += item.GiaTien * item.SoLuong;
            }
            txtTongSoLuong.Text = tongSL.ToString();
            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }

        private void HienThiThongTinNguoiBan()
        {
            txtNguoiBan.Text = ManHinhDangNhap.TaiKhoanDangNhap.HoTenTaiKhoan;
            txtSdtNguoiBan.Text = ManHinhDangNhap.TaiKhoanDangNhap.SoDienThoaiTaiKhoan;
            txtEmailNguoiBan.Text = ManHinhDangNhap.TaiKhoanDangNhap.Email;
        }
        private void LoadDanhSachLoai()
        {
            // Lấy danh sách loại thuốc
            List<ET_LoaiThuoc> danhSachLoai = busLoaiThuoc.LayDanhSachLoaiThuoc();

            // Thiết lập cho ComboBox
            cboTimKiemTheoLoai.DataSource = danhSachLoai;
            cboTimKiemTheoLoai.DisplayMember = "TenLoai";  // Hiển thị tên loại
            cboTimKiemTheoLoai.ValueMember = "IdLoai";     // Lưu ID loại làm giá trị
        }

        private void DonThuoc_Load(object sender, EventArgs e)
        {
            LoadDonThuoc();
            HienThiThongTinNguoiBan();
            LoadDanhSachLoai();

            txtNguoiBanBenTongHop.Text = ManHinhDangNhap.TaiKhoanDangNhap.HoTenTaiKhoan;
            txtSdtNguoiBanTopHop.Text = ManHinhDangNhap.TaiKhoanDangNhap.SoDienThoaiTaiKhoan;
            txtEmailNguoiBanTopHop.Text = ManHinhDangNhap.TaiKhoanDangNhap.Email;

            txtLoaiThuoc.Enabled = false;
            txtTenThuoc.Enabled = false;
            txtGiaTien.Enabled = false;
            txtNguoiMua.Enabled = false;
            txtSoDienThoaiNguoiMua.Enabled = false;

            txtTongSoLuong.Enabled = false;
            txtTongTien.Enabled = false;
            txtNguoiBanBenTongHop.Enabled = false;
            txtEmailNguoiBanTopHop.Enabled = false;
            txtSdtNguoiBanTopHop.Enabled = false;

            txtNguoiBan.Enabled = false;
            txtSdtNguoiBan.Enabled = false;
            txtEmailNguoiBan.Enabled = false;
            txtIdDon.Enabled = false;

            txtNguoiMuaBenTongHop.Enabled = false;
        }


        // Luu file ảnh
        private string tenFileAnh = "";
        private string thuMucHinhAnh = Application.StartupPath + @"\HinhAnhThuoc\";
        private void dgvDonThuoc_Click(object sender, EventArgs e)
        {
            if (dgvDonThuoc.CurrentRow != null)
            {
                selectedIdDon = Convert.ToInt32(dgvDonThuoc.CurrentRow.Cells["Id"].Value);

                txtIdDon.Text = dgvDonThuoc.CurrentRow.Cells["IdDon"].Value.ToString();


                int idLoai = Convert.ToInt32(dgvDonThuoc.CurrentRow.Cells["IdLoai"].Value);
                string tenLoai = busLoaiThuoc.LayTenLoaiTheoId(idLoai);
                txtLoaiThuoc.Text = tenLoai;


                // Lấy IdThuoc
                int idThuoc = Convert.ToInt32(dgvDonThuoc.CurrentRow.Cells["IdThuoc"].Value);
                // Gọi phương thức từ lớp DAL để lấy tên thuốc
                string tenThuoc = busThuoc.LayTenThuocTheoId(idThuoc);
                txtTenThuoc.Text = tenThuoc;

                // Lấy hình ảnh theo id
                // Gọi phương thức từ BUS để lấy tên file hình ảnh
                tenFileAnh = busThuoc.LayHinhAnhTheoIdThuoc(idThuoc); // <-- Gọi qua BUS
                // Tạo đường dẫn đến hình ảnh
                string duongDanAnh = Path.Combine(thuMucHinhAnh, tenFileAnh);
                // Kiểm tra và hiển thị ảnh
                if (!string.IsNullOrEmpty(tenFileAnh) && File.Exists(duongDanAnh))
                {
                    pictureBoxHinhAnh.Image = Image.FromFile(duongDanAnh);
                    pictureBoxHinhAnh.SizeMode = PictureBoxSizeMode.Zoom; // Hiển thị vừa vặn nếu PictureBox nhỏ
                }
                else
                {
                    pictureBoxHinhAnh.Image = null;
                }


                txtSoLuong.Text = dgvDonThuoc.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtGiaTien.Text = dgvDonThuoc.CurrentRow.Cells["GiaTien"].Value.ToString();

                // Lấy thông tin khách hàng theo ID
                int idKhachHang = Convert.ToInt32(dgvDonThuoc.CurrentRow.Cells["IdKhachHang"].Value);
                var khachHang = busKhachHang.LayKhachHangTheoId(idKhachHang);
                if (khachHang != null)
                {
                    txtNguoiMua.Text = khachHang.HoTen;
                    txtSoDienThoaiNguoiMua.Text = khachHang.SoDienThoai;

                    txtNguoiMuaBenTongHop.Text = khachHang.HoTen;
                }

                // Lấy thông tin nhân viên theo ID
                int idNhanVien = Convert.ToInt32(dgvDonThuoc.CurrentRow.Cells["IdNhanVien"].Value);
                var nhanVien = busNhanVien.LayNhanVienTheoId(idNhanVien);
                if (nhanVien != null)
                {
                    txtNguoiBan.Text = nhanVien.HoTenTaiKhoan;
                    txtSdtNguoiBan.Text = nhanVien.SoDienThoaiTaiKhoan;
                    txtEmailNguoiBan.Text = nhanVien.Email;
                }

                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedIdDon == -1)
            {
                MessageBox.Show("Vui lòng chọn thuốc cần sửa trong đơn hàng");
                return;
            }

            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            decimal giaTien = Convert.ToDecimal(txtGiaTien.Text);

            // Gọi phương thức sửa đơn thuốc với id được chọn từ DataGridView
            ET_DonThuoc don = new ET_DonThuoc
            {

                Id = selectedIdDon,
                SoLuong = Convert.ToInt32(txtSoLuong.Text),
                GiaTien = Convert.ToDecimal(txtGiaTien.Text),
                TrangThai = "Chưa hoàn thành"
            };

            if (busDonThuoc.SuaDonThuoc(don))
            {
                MessageBox.Show("Đã cập nhật thuốc trong đơn hàng");
                txtLoaiThuoc.Clear();
                txtTenThuoc.Clear();
                txtSoLuong.Clear();
                txtGiaTien.Clear();
                txtNguoiMuaBenTongHop.Clear();
                txtTimKiemTheoTenThuoc.Clear();

                cboTimKiemTheoLoai.SelectedIndex = 0;


                pictureBoxHinhAnh.Image = null;
                tenFileAnh = "";

                LoadDonThuoc();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedIdDon == -1)
               
            {
                MessageBox.Show("Vui lòng chọn thuốc cần xóa trong đơn hàng");
                return;
            }

            if (busDonThuoc.XoaDonThuoc(selectedIdDon))  // Xóa theo id
            {
                MessageBox.Show("Đã xóa thuốc khỏi đơn hàng");
                LoadDonThuoc();
                txtLoaiThuoc.Clear();
                txtTenThuoc.Clear();
                txtSoLuong.Clear();
                txtGiaTien.Clear();
                txtNguoiMuaBenTongHop.Clear();
                txtTimKiemTheoTenThuoc.Clear();

                cboTimKiemTheoLoai.SelectedIndex = 0;


                pictureBoxHinhAnh.Image = null;
                tenFileAnh = "";

            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy id đơn từ textbox
                int idDon = int.Parse(txtIdDon.Text);

                

                // Cập nhật trạng thái đơn thuốc
                if (busDonThuoc.CapNhatTrangThaiDon(idDon))
                {
                    MessageBox.Show("Thanh toán thành công. Đơn thuốc đã hoàn thành.");
                    LoadDonThuoc(); // Load lại danh sách

                    // Tạo report
                    rptInHoaDonThanhToan rp = new rptInHoaDonThanhToan();

                    // Khai báo và gán giá trị tham số
                    ParameterValues para = new ParameterValues();
                    ParameterDiscreteValue paraValue = new ParameterDiscreteValue();
                    paraValue.Value = idDon;
                    para.Add(paraValue);

                    // Gán tham số cho report 
                    rp.DataDefinition.ParameterFields["@id_don"].ApplyCurrentValues(para);

                    // Hiển thị form in hóa đơn
                    FormInHoaDonThanhToan formIn = new FormInHoaDonThanhToan();
                    formIn.ctrpInHoaDonThanhToan.ReportSource = rp;
                    formIn.ctrpInHoaDonThanhToan.Refresh();
                    formIn.ShowDialog();

                    txtLoaiThuoc.Clear();
                    txtTenThuoc.Clear();
                    txtSoLuong.Clear();
                    txtGiaTien.Clear();
                    txtNguoiMuaBenTongHop.Clear();
                    txtTimKiemTheoTenThuoc.Clear();

                    cboTimKiemTheoLoai.SelectedIndex = 0;


                    pictureBoxHinhAnh.Image = null;
                    tenFileAnh = "";

                    LoadDonThuoc();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại hoặc không tìm thấy đơn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTimKiemTheoLoai_Click(object sender, EventArgs e)
        {
            if (cboTimKiemTheoLoai.SelectedValue != null)
            {
                int idLoai = Convert.ToInt32(cboTimKiemTheoLoai.SelectedValue);
                List<ET_DonThuoc> ketQua = busDonThuoc.LayDonThuocTheoIdLoai(idLoai);
                dgvDonThuoc.DataSource = ketQua;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại thuốc cần tìm.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtLoaiThuoc.Clear();
            txtTenThuoc.Clear();
            txtSoLuong.Clear();
            txtGiaTien.Clear();
            txtNguoiMuaBenTongHop.Clear();
            txtTimKiemTheoTenThuoc.Clear();

            cboTimKiemTheoLoai.SelectedIndex = 0;


            pictureBoxHinhAnh.Image = null;
            tenFileAnh = "";

            LoadDonThuoc();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            _panelMain.Controls.Clear();

            Thuoc frmThuoc = new Thuoc(_panelMain);
            frmThuoc.TopLevel = false;
            frmThuoc.Dock = DockStyle.Fill;

            _panelMain.Controls.Add(frmThuoc);
            frmThuoc.Show();

            txtLoaiThuoc.Clear();
            txtTenThuoc.Clear();
            txtSoLuong.Clear();
            txtGiaTien.Clear();
            txtNguoiMuaBenTongHop.Clear();
            txtTimKiemTheoTenThuoc.Clear();

            cboTimKiemTheoLoai.SelectedIndex = 0;


            pictureBoxHinhAnh.Image = null;
            tenFileAnh = "";

            LoadDonThuoc();
        }

        private void btnTimKiemTheoTen_Click(object sender, EventArgs e)
        {
            string tenThuoc = txtTimKiemTheoTenThuoc.Text;
            var ketQua = busDonThuoc.TimKiemDonThuocTheoTenThuoc(tenThuoc);
            dgvDonThuoc.DataSource = ketQua;
        }
    }
}
