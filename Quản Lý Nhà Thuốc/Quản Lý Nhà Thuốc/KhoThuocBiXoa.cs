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
using BUS_QuanLyNhaThuoc;
using ET_QuanLyNhaThuoc;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class KhoThuocBiXoa : Form
    {
        private BUS_Thuoc busThuoc = new BUS_Thuoc();

        private BUS_LoaiThuoc busLoaiThuoc = new BUS_LoaiThuoc();
        

        // Luu file ảnh
        private string tenFileAnh = "";
        private string thuMucHinhAnh = Application.StartupPath + @"\HinhAnhThuoc\";
        public KhoThuocBiXoa()
        {
            InitializeComponent();
        }

        private void KhoThuocBiXoa_Load(object sender, EventArgs e)
        {
            LoadDanhSachThuocBiXoa();
            LoadDanhSachLoai();
        }

        private void LoadDanhSachThuocBiXoa()
        {
            // Lấy danh sách thuốc từ BUS
            List<ET_Thuoc> danhSachThuoc = busThuoc.LayDanhSachThuocBiXoa();

            // Hiển thị danh sách lên DatagridView
            dgvDanhSachThuoc.DataSource = danhSachThuoc;
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

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachThuoc.CurrentRow != null)
                {
                    int idThuoc = Convert.ToInt32(dgvDanhSachThuoc.CurrentRow.Cells["IdThuoc"].Value);

                    DialogResult result = MessageBox.Show("Bạn có chắc muốn chuyển thuốc này sang trạng thái 'Hoạt động' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (busThuoc.ChuyenDoiTrangThaiThuocBiXoa(idThuoc)) // Gọi BUS để chuyển trạng thái
                        {
                            MessageBox.Show("Khôi phục thuốc thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachThuocBiXoa();

                            cboTimKiemTheoLoai.SelectedIndex = 0;
                            
                            txtTenThuoc.Clear();
                            txtGiaTienThuoc.Clear();
                            txtNoiSanXuat.Clear();
                            txtThanhPhan.Clear();
                            DateTime ngayhientai = DateTime.Now;
                            dtpNgaySanXuat.Value = ngayhientai;
                            dtpNgayHetHan.Value = ngayhientai;
                            TxtTimKiemThuocTheoTen.Clear();
                            tenFileAnh = "";
                            rtbMoTa.Clear();


                            pictureBoxHinhAnh.Image = null;
                           
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật trạng thái thuốc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnDanhSachTheoLoai_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên loại được chọn
                string tenLoai = cboTimKiemTheoLoai.Text;

                // Lấy danh sách thuốc theo loại
                List<ET_Thuoc> danhSachTheoLoai = busThuoc.LayDanhSachThuocTheoTenLoaioKhoBiXoa(tenLoai);

                // Gán vào DataGridView
                dgvDanhSachThuoc.DataSource = danhSachTheoLoai;

                txtTenThuoc.Clear();
                txtGiaTienThuoc.Clear();
                txtNoiSanXuat.Clear();
                txtThanhPhan.Clear();
                DateTime ngayhientai = DateTime.Now;
                dtpNgaySanXuat.Value = ngayhientai;
                dtpNgayHetHan.Value = ngayhientai;
                TxtTimKiemThuocTheoTen.Clear();
                rtbMoTa.Clear();


                // Ẩn các cột không cần hiển thị
                //dgvDanhSachThuoc.Columns["HinhAnh"].Visible = false;
                //dgvDanhSachThuoc.Columns["IdThuoc"].Visible = false;
                //dgvDanhSachThuoc.Columns["IdLoai"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboTimKiemTheoLoai.SelectedIndex = 0;
          
            txtTenThuoc.Clear();
            txtGiaTienThuoc.Clear();
            txtNoiSanXuat.Clear();
            txtThanhPhan.Clear();
            DateTime ngayhientai = DateTime.Now;
            dtpNgaySanXuat.Value = ngayhientai;
            dtpNgayHetHan.Value = ngayhientai;
            TxtTimKiemThuocTheoTen.Clear();
            rtbMoTa.Clear();

          
            cboTimKiemTheoLoai.SelectedIndex = 0;

            pictureBoxHinhAnh.Image = null;
            tenFileAnh = "";

            LoadDanhSachThuocBiXoa();
        }

        private void btnTimKiemThuoc_Click(object sender, EventArgs e)
        {
            string tenTimKiem = TxtTimKiemThuocTheoTen.Text.Trim();

            if (string.IsNullOrEmpty(tenTimKiem))
            {
                MessageBox.Show("Vui lòng nhập tên để tìm kiếm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<ET_Thuoc> danhSachKetQua = busThuoc.TimDanhSachThuocTheoTenKhoBiXoa(tenTimKiem);

            if (danhSachKetQua != null && danhSachKetQua.Any())
            {
                dgvDanhSachThuoc.DataSource = danhSachKetQua;

                txtTenThuoc.Clear();
                txtGiaTienThuoc.Clear();
                txtNoiSanXuat.Clear();
                txtThanhPhan.Clear();
                DateTime ngayhientai = DateTime.Now;
                dtpNgaySanXuat.Value = ngayhientai;
                dtpNgayHetHan.Value = ngayhientai;
                TxtTimKiemThuocTheoTen.Clear();
                rtbMoTa.Clear();


                cboTimKiemTheoLoai.SelectedIndex = 0;

                pictureBoxHinhAnh.Image = null;
                tenFileAnh = "";
            }
            else
            {
                dgvDanhSachThuoc.DataSource = null;
                MessageBox.Show("Không tìm thấy thuốc có tên chứa: " + tenTimKiem, "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaVinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachThuoc.CurrentRow != null)
                {
                    int idThuoc = Convert.ToInt32(dgvDanhSachThuoc.CurrentRow.Cells["IdThuoc"].Value);

                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thuốc vĩnh viễn luôn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (busThuoc.XoaThuoc(idThuoc)) // Gọi BUS để chuyển trạng thái
                        {
                            MessageBox.Show("Xóa thuốc thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachThuocBiXoa();

                            cboTimKiemTheoLoai.SelectedIndex = 0;

                            txtTenThuoc.Clear();
                            txtGiaTienThuoc.Clear();
                            txtNoiSanXuat.Clear();
                            txtThanhPhan.Clear();
                            DateTime ngayhientai = DateTime.Now;
                            dtpNgaySanXuat.Value = ngayhientai;
                            dtpNgayHetHan.Value = ngayhientai;
                            TxtTimKiemThuocTheoTen.Clear();
                            tenFileAnh = "";
                            rtbMoTa.Clear();


                            pictureBoxHinhAnh.Image = null;

                        }
                        else
                        {
                            MessageBox.Show("Cập nhật trạng thái thuốc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDanhSachThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachThuoc.CurrentRow != null)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvDanhSachThuoc.CurrentRow;

                    // Gián dữ liệu vào các TextBox và Datetimepicker , Combobox 
                    txtTenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                    txtThanhPhan.Text = row.Cells["ThanhPhan"].Value.ToString();
                    rtbMoTa.Text = row.Cells["MoTa"].Value.ToString();
                    txtGiaTienThuoc.Text = row.Cells["GiaTien"].Value.ToString();
                    txtNoiSanXuat.Text = row.Cells["NoiSanXuat"].Value.ToString();
                    dtpNgaySanXuat.Value = Convert.ToDateTime(row.Cells["NgaySanXuat"].Value);
                    dtpNgayHetHan.Value = Convert.ToDateTime(row.Cells["NgayHetHan"].Value);

                    // Lấy id_loai từ DataGridView
                    int idLoai = Convert.ToInt32(row.Cells["IdLoai"].Value);
                    // Gọi BUS để lấy tên loại thuốc
                    string tenLoai = busLoaiThuoc.LayTenLoaiTheoId(idLoai);
                    // Gán tên loại vào TextBox
                    txtTenLoai.Text = tenLoai;

                    // Truyền ảnh lên
                    tenFileAnh = row.Cells["HinhAnh"].Value?.ToString();
                    string duongDanAnh = Path.Combine(thuMucHinhAnh, tenFileAnh);
                    if (!string.IsNullOrEmpty(tenFileAnh) && File.Exists(duongDanAnh))
                    {
                        pictureBoxHinhAnh.Image = Image.FromFile(duongDanAnh);
                    }
                    else
                    {
                        pictureBoxHinhAnh.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }
    }
}
