using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// thêm thư viện
using BUS_QuanLyNhaThuoc;
using CrystalDecisions.Shared;
using ET_QuanLyNhaThuoc;
using Quản_Lý_Nhà_Thuốc.Report;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class NhanVien : Form
    {
        private BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private BUS_LoaiTaiKhoan busLoaiTaiKhoan = new BUS_LoaiTaiKhoan();
        public NhanVien()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            txtMaNV.Enabled = false;

        }

        private void LoadDanhSachNhanVien()
        {
            // Load danh sách loại tài khoản vào ComboBox
            LoadLoaiTaiKhoanToComboBox();

            // Mặc định hiển thị tất cả nhân viên
            dgvDanhSachNhanVien.DataSource = busNhanVien.LayDanhSachNhanVien();
        }

        // Hiển thị loại lên combobox
        private void LoadLoaiTaiKhoanToComboBox()
        {
            // Lấy danh sách loại tài khoản
            List<ET_LoaiTaiKhoan> dsLoaiTaiKhoan = busLoaiTaiKhoan.LayDanhSachLoaiTaiKhoan();

            // Đặt DataSource cho ComboBox
            cboVaiTro.DataSource = dsLoaiTaiKhoan;
            cboVaiTro.DisplayMember = "TenLoai";
            cboVaiTro.ValueMember = "MaLoai";

            // Đặt DataSource cho ComboBox
            cboTimKiemTheoLoai.DataSource = dsLoaiTaiKhoan;
            cboTimKiemTheoLoai.DisplayMember = "TenLoai";
            cboTimKiemTheoLoai.ValueMember = "MaLoai";
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();

            // Ẩn các cột như
            //dgvDanhSachNhanVien.Columns["Id"].Visible = false;
            dgvDanhSachNhanVien.Columns["MaLoai"].Visible = false;

            dgvDanhSachNhanVien.Columns["MatKhau"].Visible = false;
            dgvDanhSachNhanVien.Columns["NgayTao"].Visible = false;
        }

        private void dgvDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachNhanVien.CurrentRow != null)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvDanhSachNhanVien.CurrentRow;

                    // Gán dữ liệu vào các thanh textbox
                    txtMaNV.Text = row.Cells["IdTaiKhoan"].Value.ToString();
                    txtHoTen.Text = row.Cells["HoTenTaiKhoan"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                    txtSoDienThoai.Text = row.Cells["SoDienThoaiTaiKhoan"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();

                    // Xử lý ngày sinh
                    dtpNgaySinh.Value = row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value
                        ? Convert.ToDateTime(row.Cells["NgaySinh"].Value)
                        : DateTime.Now;


                    // Đặt giá trị cho combobox vai trò dựa vào mã loại
                    int maLoai = Convert.ToInt32(row.Cells["MaLoai"].Value);
                    cboVaiTro.SelectedValue = maLoai;

                    txtMaNV.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLayNhanVienTheoLoai_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên loại được chọn
                string tenLoai = cboTimKiemTheoLoai.Text;

                // Lấy danh sách thuốc theo loại
                List<ET_NhanVien> danhSachTheoLoai = busNhanVien.LayDanhSachNhanVienTheoTenLoai(tenLoai);

                // Gán vào DataGridView
                dgvDanhSachNhanVien.DataSource = danhSachTheoLoai;

                // Ẩn các cột không cần hiển thị
                dgvDanhSachNhanVien.Columns["MaLoai"].Visible = false;

                dgvDanhSachNhanVien.Columns["MatKhau"].Visible = false;
                dgvDanhSachNhanVien.Columns["NgayTao"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            DateTime ngayhientai = DateTime.Now;
            dtpNgaySinh.Value = ngayhientai;

            txtTimKiemNhanVienTheoTen.Clear();

            cboVaiTro.SelectedIndex = 0;
            cboTimKiemTheoLoai.SelectedIndex = 0;

            LoadDanhSachNhanVien();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Cảnh báo",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy loại tài khoản được chọn
                ET_LoaiTaiKhoan loaiTaiKhoan = (ET_LoaiTaiKhoan)cboVaiTro.SelectedItem;

                // Tạo đối tượng nhân viên mới
                ET_NhanVien nhanVien = new ET_NhanVien();
                nhanVien.HoTenTaiKhoan = txtHoTen.Text;
                nhanVien.Email = txtEmail.Text;
                nhanVien.MatKhau = txtMatKhau.Text;
                nhanVien.SoDienThoaiTaiKhoan = txtSoDienThoai.Text;
                nhanVien.DiaChi = txtDiaChi.Text;
                nhanVien.NgaySinh = dtpNgaySinh.Value;
                nhanVien.MaLoai = loaiTaiKhoan.MaLoai;
                nhanVien.NgayTao = DateTime.Now;

                // Thêm nhân viên vào cơ sở dữ liệu
                if (busNhanVien.ThemNhanVien(nhanVien))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại danh sách và làm mới form
                    LoadDanhSachNhanVien();


                    txtMaNV.Clear();
                    txtHoTen.Clear();
                    txtEmail.Clear();
                    txtMatKhau.Clear();
                    txtDiaChi.Clear();
                    txtSoDienThoai.Clear();
                    DateTime ngayhientai = DateTime.Now;
                    dtpNgaySinh.Value = ngayhientai;

                    txtTimKiemNhanVienTheoTen.Clear();

                    cboVaiTro.SelectedIndex = 0;
                    cboTimKiemTheoLoai.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn nhân viên chưa
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Cảnh báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Cảnh báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy loại tài khoản được chọn
                ET_LoaiTaiKhoan loaiTaiKhoan = (ET_LoaiTaiKhoan)cboVaiTro.SelectedItem;

                // Tạo đối tượng nhân viên với thông tin cập nhật
                ET_NhanVien nhanVien = new ET_NhanVien();
                nhanVien.IdTaiKhoan = int.Parse(txtMaNV.Text);
                nhanVien.HoTenTaiKhoan = txtHoTen.Text;
                nhanVien.Email = txtEmail.Text;
                nhanVien.MatKhau = txtMatKhau.Text;
                nhanVien.SoDienThoaiTaiKhoan = txtSoDienThoai.Text;
                nhanVien.DiaChi = txtDiaChi.Text;
                nhanVien.NgaySinh = dtpNgaySinh.Value;
                nhanVien.MaLoai = loaiTaiKhoan.MaLoai;

                if (busNhanVien.CapNhatNhanVien(nhanVien))
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNV.Clear();
                    txtHoTen.Clear();
                    txtEmail.Clear();
                    txtMatKhau.Clear();
                    txtDiaChi.Clear();
                    txtSoDienThoai.Clear();
                    DateTime ngayhientai = DateTime.Now;
                    dtpNgaySinh.Value = ngayhientai;

                    txtTimKiemNhanVienTheoTen.Clear();

                    cboVaiTro.SelectedIndex = 0;
                    cboTimKiemTheoLoai.SelectedIndex = 0;

                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thất bại!", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn nhân viên chưa
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?",
                                                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int maNhanVien = int.Parse(txtMaNV.Text);
                
                    if (busNhanVien.XoaNhanVien(maNhanVien))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaNV.Clear();
                        txtHoTen.Clear();
                        txtEmail.Clear();
                        txtMatKhau.Clear();
                        txtDiaChi.Clear();
                        txtSoDienThoai.Clear();
                        DateTime ngayhientai = DateTime.Now;
                        dtpNgaySinh.Value = ngayhientai;

                        txtTimKiemNhanVienTheoTen.Clear();

                        cboVaiTro.SelectedIndex = 0;
                        cboTimKiemTheoLoai.SelectedIndex = 0;

                        LoadDanhSachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiemNhanVienTheoTen.Text.Trim();

                if (string.IsNullOrEmpty(tuKhoa))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm!", "Cảnh báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<ET_NhanVien> ketQua = busNhanVien.TimNhanVienTheoTen(tuKhoa);

                if (ketQua != null && ketQua.Any())
                {
                    dgvDanhSachNhanVien.DataSource = ketQua;

                    // Ẩn các cột không cần hiển thị
                    dgvDanhSachNhanVien.Columns["MaLoai"].Visible = false;
                    dgvDanhSachNhanVien.Columns["MatKhau"].Visible = false;
                    dgvDanhSachNhanVien.Columns["NgayTao"].Visible = false;
                }
                else
                {
                    dgvDanhSachNhanVien.DataSource = null;
                    MessageBox.Show("Không tìm thấy nhân viên nào có tên chứa: " + tuKhoa, "Kết Quả",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInNhanVienTheoLoai_Click(object sender, EventArgs e)
        {

            int maLoai = Convert.ToInt32(cboTimKiemTheoLoai.SelectedValue);
            // Tạo report
            rptInNhanVienTheoLoai rp = new rptInNhanVienTheoLoai();

            // Khai báo và gán giá trị tham số
            ParameterValues para = new ParameterValues();
            ParameterDiscreteValue paraValue = new ParameterDiscreteValue();
            paraValue.Value = maLoai;
            para.Add(paraValue);

            // Gán tham số cho report
            rp.DataDefinition.ParameterFields["@ma_loai"].ApplyCurrentValues(para);

           
            FormInNhanVienTheoLoai formIn = new FormInNhanVienTheoLoai();
            formIn.ctrpInNhanVienTheoLoai.ReportSource = rp;
            formIn.ctrpInNhanVienTheoLoai.Refresh();
            formIn.ShowDialog();

            txtMaNV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            DateTime ngayhientai = DateTime.Now;
            dtpNgaySinh.Value = ngayhientai;

            txtTimKiemNhanVienTheoTen.Clear();

            cboVaiTro.SelectedIndex = 0;
            cboTimKiemTheoLoai.SelectedIndex = 0;

            LoadDanhSachNhanVien();
        }

        private void btnInDanhSachTatCaNhanVien_Click(object sender, EventArgs e)
        {
            
            FormInDanhSachTatCaNhanVien formIn = new FormInDanhSachTatCaNhanVien();
            formIn.ShowDialog();

            txtMaNV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            DateTime ngayhientai = DateTime.Now;
            dtpNgaySinh.Value = ngayhientai;

            txtTimKiemNhanVienTheoTen.Clear();

            cboVaiTro.SelectedIndex = 0;
            cboTimKiemTheoLoai.SelectedIndex = 0;

            LoadDanhSachNhanVien();
        }
    }
}
