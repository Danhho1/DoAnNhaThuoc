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

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class Thuoc : Form
    {

        private BUS_Thuoc busThuoc = new BUS_Thuoc();
        private BUS_LoaiThuoc busLoaiThuoc = new BUS_LoaiThuoc();
        private BUS_DonThuoc busDonThuoc = new BUS_DonThuoc();

        // Luu file ảnh
        private string tenFileAnh = "";
        private string thuMucHinhAnh = Application.StartupPath + @"\HinhAnhThuoc\";

        private Panel _panelMain;

        public Thuoc(Panel panelMain)
        {
            InitializeComponent();
            _panelMain = panelMain;
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void LoadDanhSachThuoc()
        {
            // Lấy danh sách thuốc từ BUS
            List<ET_Thuoc> danhSachThuoc = busThuoc.LayDanhSachThuoc();

            // Hiển thị danh sách lên DatagridView
            dgvDanhSachThuoc.DataSource = danhSachThuoc;

            // Ẩn các cột như
            dgvDanhSachThuoc.Columns["TrangThai"].Visible = false;
            //dgvDanhSachThuoc.Columns["HinhAnh"].Visible = false;
            //dgvDanhSachThuoc.Columns["IdThuoc"].Visible = false;
            //dgvDanhSachThuoc.Columns["IdLoai"].Visible = false;
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

        private void Thuoc_Load(object sender, EventArgs e)
        {
            
            LoadDanhSachThuoc(); // Load Danh Sách lên Form khi Form mở lên
            LoadDanhSachLoai(); // Load Danh sách Loại 

            


            txtTenLoai.Enabled = false;
            txtTenThuoc.Enabled = false;
            txtThanhPhan.Enabled = false;
            rtbMoTa.Enabled = false;
            txtGiaTienThuoc.Enabled = false;
            txtNoiSanXuat.Enabled = false;
            dtpNgaySanXuat.Enabled = false;
            dtpNgayHetHan.Enabled = false;
            dtpNgaySanXuat.Enabled = false ;
            dtpNgayHetHan.Enabled= false;

        }

        private void dgvDanhSachThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvDanhSachThuoc.CurrentRow != null)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvDanhSachThuoc.CurrentRow;

                    // Gián dữ liệu vào các TextBox và Datetimepicker , Combobox 
                    txtTenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                    txtThanhPhan.Text = row.Cells["ThanhPhan"].Value.ToString();
                    rtbMoTa.Text = row.Cells["MoTa"].Value.ToString();
                    txtGiaTienThuoc.Text = row.Cells["GiaTien"].Value.ToString();
                    txtNoiSanXuat.Text =  row.Cells["NoiSanXuat"].Value.ToString();
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

        private void btnDanhSachTheoLoai_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên loại được chọn
                string tenLoai = cboTimKiemTheoLoai.Text;

                // Lấy danh sách thuốc theo loại
                List<ET_Thuoc> danhSachTheoLoai = busThuoc.LayDanhSachThuocTheoTenLoai(tenLoai);

                // Gán vào DataGridView
                dgvDanhSachThuoc.DataSource = danhSachTheoLoai;

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
            txtTenLoai.Clear();
            txtTenThuoc.Clear();
            txtGiaTienThuoc.Clear();
            txtNoiSanXuat.Clear();
            txtThanhPhan.Clear();
            txtTimKiemThuocTheoTen.Clear();
            DateTime ngayhientai = DateTime.Now;
            dtpNgaySanXuat.Value = ngayhientai;
            dtpNgayHetHan.Value = ngayhientai;

            rtbMoTa.Clear();

            cboTimKiemTheoLoai.SelectedIndex = 0;

            pictureBoxHinhAnh.Image = null;
            tenFileAnh = "";


            LoadDanhSachThuoc();
        }

        private void btnTimKiemThuocTheoTen_Click(object sender, EventArgs e)
        {
            string tenTimKiem = txtTimKiemThuocTheoTen.Text.Trim();

            if (string.IsNullOrEmpty(tenTimKiem))
            {
                MessageBox.Show("Vui lòng nhập tên để tìm kiếm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<ET_Thuoc> danhSachKetQua = busThuoc.TimDanhSachThuocTheoTen(tenTimKiem);

            if (danhSachKetQua != null && danhSachKetQua.Any())
            {
                dgvDanhSachThuoc.DataSource = danhSachKetQua;
            }
            else
            {
                dgvDanhSachThuoc.DataSource = null;
                MessageBox.Show("Không tìm thấy thuốc có tên chứa: " + tenTimKiem, "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDenDonThuoc_Click(object sender, EventArgs e)
        {
            _panelMain.Controls.Clear();

            DonThuoc frmDonThuoc = new DonThuoc(_panelMain);
            frmDonThuoc.TopLevel = false;
            frmDonThuoc.Dock = DockStyle.Fill;

            _panelMain.Controls.Add(frmDonThuoc);
            frmDonThuoc.Show();


            cboTimKiemTheoLoai.SelectedIndex = 0;
            txtTenLoai.Clear();
            txtTenThuoc.Clear();
            txtGiaTienThuoc.Clear();
            txtNoiSanXuat.Clear();
            txtThanhPhan.Clear();
            txtTimKiemThuocTheoTen.Clear();
            DateTime ngayhientai = DateTime.Now;
            dtpNgaySanXuat.Value = ngayhientai;
            dtpNgayHetHan.Value = ngayhientai;

            rtbMoTa.Clear();

            cboTimKiemTheoLoai.SelectedIndex = 0;

            pictureBoxHinhAnh.Image = null;
            tenFileAnh = "";
            LoadDanhSachThuoc();
        }


        private void btnThemVaoDon_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra người dùng đã chọn dòng thuốc trong DataGridView hay chưa
                if (dgvDanhSachThuoc.CurrentRow != null)
                {
                    // Lấy dữ liệu từ dòng được chọn
                    DataGridViewRow row = dgvDanhSachThuoc.CurrentRow;

                    int idThuoc = Convert.ToInt32(row.Cells[1].Value);   // Mã thuốc
                    int idLoai = Convert.ToInt32(row.Cells[2].Value);    // Mã loại thuốc
                    decimal giaTien = Convert.ToDecimal(row.Cells[6].Value); // Giá tiền

                    int idNhanVien = ManHinhDangNhap.TaiKhoanDangNhap.IdTaiKhoan; // Lấy ID nhân viên đăng nhập

                    // Lấy thông tin người mua từ textbox
                    string hoTenKhach = txtNguoiMua.Text.Trim();
                    string sdtKhach = txtSoDienThoaiNguoiMua.Text.Trim();

                    // Kiểm tra nếu thông tin người mua chưa được nhập
                    if (string.IsNullOrEmpty(hoTenKhach) || string.IsNullOrEmpty(sdtKhach))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin người mua!");
                        return;
                    }

                    // Xử lý khách hàng: lấy ID nếu tồn tại, hoặc thêm mới
                    BUS_KhachHang busKH = new BUS_KhachHang();
                    int idKhachHang = busKH.LayHoacThemKhachHang(hoTenKhach, sdtKhach);

                    int idDon;

                    // Nếu người dùng đã nhập ID đơn thuốc
                    if (!string.IsNullOrEmpty(txtIdDon.Text))
                    {
                        idDon = int.Parse(txtIdDon.Text);

                        // Kiểm tra ID đơn đã tồn tại trong DB hay chưa
                        if (busDonThuoc.KiemTraIdDonTonTai(idDon))
                        {
                            // Hỏi người dùng có muốn tiếp tục dùng đơn này hay không
                            DialogResult result = MessageBox.Show(
                                $"Đơn thuốc với ID {idDon} đã tồn tại. Bạn có muốn tiếp tục thêm thuốc vào đơn này không?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (result == DialogResult.No)
                            {
                                // Nếu người dùng không muốn dùng đơn cũ, gợi ý ID đơn mới
                                int goiY = busDonThuoc.LayIdDonCuoiCung() + 1;
                                MessageBox.Show($"Bạn có thể dùng ID đơn mới là {goiY}");
                                txtIdDon.Text = goiY.ToString();
                                return; // Thoát không thêm thuốc nữa
                            }
                        }
                    }
                    else
                    {
                        // Nếu chưa nhập ID đơn, tự động tạo mới ID đơn kế tiếp
                        idDon = busDonThuoc.LayIdDonCuoiCung() + 1;
                        txtIdDon.Text = idDon.ToString();
                    }

                    int soLuong = 1; // Mặc định số lượng mỗi lần thêm là 1

                    // Tạo đối tượng đơn thuốc để thêm vào DB
                    ET_DonThuoc don = new ET_DonThuoc
                    {
                        IdDon = idDon,
                        IdLoai = idLoai,
                        IdThuoc = idThuoc,
                        IdKhachHang = idKhachHang,
                        IdNhanVien = idNhanVien,
                        SoLuong = soLuong,
                        GiaTien = giaTien,
                        NgayTao = DateTime.Now,
                        TrangThai = "Chưa hoàn thành"
                    };

                    // Gọi BUS để thêm hoặc cập nhật số lượng thuốc trong đơn
                    if (busDonThuoc.ThemHoacTangSoLuongThuoc(don))
                    {
                        MessageBox.Show("Đã thêm hoặc cập nhật thuốc trong đơn!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
                else
                {
                    // Nếu chưa chọn thuốc
                    MessageBox.Show("Vui lòng chọn thuốc trong danh sách!");
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có exception
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
