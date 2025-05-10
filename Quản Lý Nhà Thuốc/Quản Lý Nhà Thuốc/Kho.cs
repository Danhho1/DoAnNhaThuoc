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
using CrystalDecisions.Shared;
using ET_QuanLyNhaThuoc;
using Quản_Lý_Nhà_Thuốc.Report;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class Kho : Form
    {
        // Luu file ảnh
        private string tenFileAnh = "";
        private string thuMucHinhAnh = Application.StartupPath + @"\HinhAnhThuoc\";
        //private string thuMucHinhAnh = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\HinhAnhThuoc\"));

        private BUS_Thuoc busThuoc = new BUS_Thuoc();
        private BUS_LoaiThuoc busLoaiThuoc = new BUS_LoaiThuoc();
        public Kho()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void LoadDanhSachThuoc()
        {
            // Lấy danh sách thuốc từ BUS
            List<ET_Thuoc> danhSachThuoc = busThuoc.LayDanhSachThuoc();

            // Hiển thị danh sách lên DatagridView
            dgvDanhSachThuoc.DataSource = danhSachThuoc;

            // Ẩn các cột như
            
            dgvDanhSachThuoc.Columns["IdThuoc"].Visible = false;
            dgvDanhSachThuoc.Columns["IdLoai"].Visible = false;
        }
        private void LoadDanhSachLoai()
        {
            // Lấy danh sách loại thuốc
            List<ET_LoaiThuoc> danhSachLoai = busLoaiThuoc.LayDanhSachLoaiThuoc();

            // Thiết lập cho ComboBox
            cboTimKiemTheoLoai.DataSource = danhSachLoai;
            cboTimKiemTheoLoai.DisplayMember = "TenLoai";  // Hiển thị tên loại
            cboTimKiemTheoLoai.ValueMember = "IdLoai";     // Lưu ID loại làm giá trị

            // Thiết lập cho ComboBox
            cboTenLoai.DataSource = danhSachLoai;
            cboTenLoai.DisplayMember = "TenLoai";  // Hiển thị tên loại
            cboTenLoai.ValueMember = "IdLoai";     // Lưu ID loại làm giá trị
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            LoadDanhSachThuoc();
            LoadDanhSachLoai();



            for (int i = 1; i <= 11; i++)
            {
                cboTimKiemTheoThang.Items.Add(i);
            }

            for (int i = 1; i <= 11; i++)
            {
                cboTimKiemTheoNam.Items.Add(i);
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
               
                dgvDanhSachThuoc.Columns["IdThuoc"].Visible = false;
                dgvDanhSachThuoc.Columns["IdLoai"].Visible = false;
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
                    dtpNgayHetHan.Text = row.Cells["NgayHetHan"].Value.ToString();

                    // Lấy id_loai từ DataGridView
                    int idLoai = Convert.ToInt32(row.Cells["IdLoai"].Value);
                    // Gọi BUS để lấy tên loại thuốc
                    string tenLoai = busLoaiThuoc.LayTenLoaiTheoId(idLoai);
                    // Gán tên loại vào TextBox
                    cboTenLoai.SelectedValue = idLoai;

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

        private void btnTimKiemThuoc_Click(object sender, EventArgs e)
        {
            string tenTimKiem = TxtTimKiemThuocTheoTen.Text.Trim();

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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboTimKiemTheoLoai.SelectedIndex = 0;
            cboTenLoai.SelectedIndex = 0;
            txtTenThuoc.Clear();
            txtGiaTienThuoc.Clear();
            txtNoiSanXuat.Clear();
            txtThanhPhan.Clear();
            DateTime ngayhientai = DateTime.Now;
            dtpNgaySanXuat.Value = ngayhientai;
            dtpNgayHetHan.Value = ngayhientai;
            TxtTimKiemThuocTheoTen.Clear();
            rtbMoTa.Clear();

            cboTimKiemTheoNam.SelectedIndex = 0;
            cboTimKiemTheoThang.SelectedIndex = 0;

            cboTimKiemTheoLoai.SelectedIndex = 0;

            pictureBoxHinhAnh.Image = null;
            tenFileAnh = "";

            LoadDanhSachThuoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ET_Thuoc thuoc = new ET_Thuoc(
                     0,
                     Convert.ToInt32(cboTenLoai.SelectedValue),
                     txtTenThuoc.Text.Trim(),
                     txtThanhPhan.Text.Trim(),
                     rtbMoTa.Text.Trim(),
                     decimal.Parse(txtGiaTienThuoc.Text.Trim()),
                     txtNoiSanXuat.Text.Trim(),
                     "Hoạt động",
                     tenFileAnh,  // Lưu tên file ảnh
                     dtpNgaySanXuat.Value,
                     dtpNgayHetHan.Value
                 );

                if (busThuoc.ThemThuoc(thuoc))
                {
                    MessageBox.Show("Thêm thuốc thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachThuoc();

                    cboTimKiemTheoLoai.SelectedIndex = 0;
                    cboTenLoai.SelectedIndex = 0;
                    txtTenThuoc.Clear();
                    txtGiaTienThuoc.Clear();
                    txtNoiSanXuat.Clear();
                    txtThanhPhan.Clear();
                    DateTime ngayhientai = DateTime.Now;
                    dtpNgaySanXuat.Value = ngayhientai;
                    dtpNgayHetHan.Value = ngayhientai;
                    TxtTimKiemThuocTheoTen.Clear();
                    rtbMoTa.Clear();

                    cboTimKiemTheoNam.SelectedIndex = 0;
                    cboTimKiemTheoThang.SelectedIndex = 0;

                    cboTimKiemTheoLoai.SelectedIndex = 0;

                    pictureBoxHinhAnh.Image = null;
                    tenFileAnh = "";

                }
                else
                {
                    MessageBox.Show("Thêm thuốc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachThuoc.CurrentRow != null)
                {
                    int idThuoc = Convert.ToInt32(dgvDanhSachThuoc.CurrentRow.Cells["IdThuoc"].Value);

                    ET_Thuoc thuoc = new ET_Thuoc(
                        idThuoc,
                        Convert.ToInt32(cboTenLoai.SelectedValue),
                        txtTenThuoc.Text.Trim(),
                        txtThanhPhan.Text.Trim(),
                        rtbMoTa.Text.Trim(),
                        decimal.Parse(txtGiaTienThuoc.Text.Trim()),
                        txtNoiSanXuat.Text.Trim(),
                        "Hoạt động",
                        tenFileAnh, // thay đổi ảnh
                        dtpNgaySanXuat.Value,
                        dtpNgayHetHan.Value
                    );

                    if (busThuoc.SuaThuoc(thuoc))
                    {
                        MessageBox.Show("Sửa thuốc thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachThuoc();

                        cboTimKiemTheoLoai.SelectedIndex = 0;
                        cboTenLoai.SelectedIndex = 0;
                        txtTenThuoc.Clear();
                        txtGiaTienThuoc.Clear();
                        txtNoiSanXuat.Clear();
                        txtThanhPhan.Clear();
                        DateTime ngayhientai = DateTime.Now;
                        dtpNgaySanXuat.Value = ngayhientai;
                        dtpNgayHetHan.Value = ngayhientai;
                        TxtTimKiemThuocTheoTen.Clear();
                        rtbMoTa.Clear();

                        cboTimKiemTheoNam.SelectedIndex = 0;
                        cboTimKiemTheoThang.SelectedIndex = 0;

                        cboTimKiemTheoLoai.SelectedIndex = 0;

                        pictureBoxHinhAnh.Image = null;
                        tenFileAnh = "";

                    }
                    else
                    {
                        MessageBox.Show("Sửa thuốc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachThuoc.CurrentRow != null)
                {
                    int idThuoc = Convert.ToInt32(dgvDanhSachThuoc.CurrentRow.Cells["IdThuoc"].Value);

                    DialogResult result = MessageBox.Show("Bạn có chắc muốn chuyển thuốc này sang trạng thái 'Không hoạt động'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (busThuoc.ChuyenDoiTrangThaiThuoc(idThuoc)) // Gọi BUS để chuyển trạng thái
                        {
                            MessageBox.Show("Cập nhật trạng thái thuốc thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachThuoc();

                            cboTimKiemTheoLoai.SelectedIndex = 0;
                            cboTenLoai.SelectedIndex = 0;
                            txtTenThuoc.Clear();
                            txtGiaTienThuoc.Clear();
                            txtNoiSanXuat.Clear();
                            txtThanhPhan.Clear();
                            DateTime ngayhientai = DateTime.Now;
                            dtpNgaySanXuat.Value = ngayhientai;
                            dtpNgayHetHan.Value = ngayhientai;
                            TxtTimKiemThuocTheoTen.Clear();
                            rtbMoTa.Clear();

                            cboTimKiemTheoNam.SelectedIndex = 0;
                            cboTimKiemTheoThang.SelectedIndex = 0;

                            cboTimKiemTheoLoai.SelectedIndex = 0;

                            pictureBoxHinhAnh.Image = null;
                            tenFileAnh = "";
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

        private void btnTimKiemTheoThang_Click(object sender, EventArgs e)
        {

            try
            {
                if (cboTimKiemTheoThang.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn số tháng hạn sử dụng cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int soThang = int.Parse(cboTimKiemTheoThang.SelectedItem.ToString());

                // Gọi hàm trong BUS để lấy danh sách thuốc theo hạn sử dụng (tháng)
                var danhSachThuoc = busThuoc.LayThuocTheoHanSuDungThang(soThang);

                if (danhSachThuoc.Count == 0)
                {
                    dgvDanhSachThuoc.DataSource = null;
                    MessageBox.Show($"Không tìm thấy thuốc có hạn sử dụng đúng {soThang} tháng!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvDanhSachThuoc.DataSource = danhSachThuoc;
                    MessageBox.Show($"Tìm thấy {danhSachThuoc.Count} thuốc có hạn sử dụng đúng {soThang} tháng.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số tháng không hợp lệ. Vui lòng chọn lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemTheoNam_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTimKiemTheoNam.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn số năm hạn sử dụng cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int soNam = int.Parse(cboTimKiemTheoNam.SelectedItem.ToString());

                // Gọi hàm trong BUS để lấy danh sách thuốc theo hạn sử dụng (năm)
                var danhSachThuoc = busThuoc.LayThuocTheoHanSuDungNam(soNam);

                if (danhSachThuoc.Count == 0)
                {
                    dgvDanhSachThuoc.DataSource = null;
                    MessageBox.Show($"Không tìm thấy thuốc có hạn sử dụng đúng {soNam} năm!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvDanhSachThuoc.DataSource = danhSachThuoc;
                    MessageBox.Show($"Tìm thấy {danhSachThuoc.Count} thuốc có hạn sử dụng đúng {soNam} năm.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số năm không hợp lệ. Vui lòng chọn lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog.FileName;
                tenFileAnh = Path.GetFileName(sourceFile);  // Lưu tên file

                // Tạo thư mục nếu chưa có
                if (!Directory.Exists(thuMucHinhAnh))
                {
                    Directory.CreateDirectory(thuMucHinhAnh);
                }

                string destFile = Path.Combine(thuMucHinhAnh, tenFileAnh);

                // Nếu ảnh chưa tồn tại thì copy
                if (!File.Exists(destFile))
                {
                    File.Copy(sourceFile, destFile);
                }

                // Hiển thị lên PictureBox
                pictureBoxHinhAnh.Image = Image.FromFile(destFile);
            }
        }

        private void btnInDanhSachThuocHetHanTheoThang_Click(object sender, EventArgs e)
        {
            int soThang = Convert.ToInt32(cboTimKiemTheoThang.SelectedItem);
            // Tạo report
            rptInDanhSachThuocHetHanTheoThang rp = new rptInDanhSachThuocHetHanTheoThang();

            // Khai báo và gán giá trị tham số
            ParameterValues para = new ParameterValues();
            ParameterDiscreteValue paraValue = new ParameterDiscreteValue();
            paraValue.Value = soThang;
            para.Add(paraValue);

            // Gán tham số cho report
            rp.DataDefinition.ParameterFields["@so_thang"].ApplyCurrentValues(para);


            FormInDanhSachThuocHetHanTheoThang formIn = new FormInDanhSachThuocHetHanTheoThang();
            formIn.ctrpInDanhSachThuocHetHanTheoThang.ReportSource = rp;
            formIn.ctrpInDanhSachThuocHetHanTheoThang.Refresh();
            formIn.ShowDialog();

            cboTimKiemTheoLoai.SelectedIndex = 0;
            cboTenLoai.SelectedIndex = 0;
            txtTenThuoc.Clear();
            txtGiaTienThuoc.Clear();
            txtNoiSanXuat.Clear();
            txtThanhPhan.Clear();
            DateTime ngayhientai = DateTime.Now;
            dtpNgaySanXuat.Value = ngayhientai;
            dtpNgayHetHan.Value = ngayhientai;
            TxtTimKiemThuocTheoTen.Clear();
            rtbMoTa.Clear();

            cboTimKiemTheoNam.SelectedIndex = 0;
            cboTimKiemTheoThang.SelectedIndex = 0;

            cboTimKiemTheoLoai.SelectedIndex = 0;

            pictureBoxHinhAnh.Image = null;
            tenFileAnh = "";
        }

        private void btnInDanhSachThuocTheoNam_Click(object sender, EventArgs e)
        {
            int soNam = Convert.ToInt32(cboTimKiemTheoNam.SelectedItem);
            // Tạo report
            rptInDanhSachThuocHetHanTheoNam rp = new rptInDanhSachThuocHetHanTheoNam();

            // Khai báo và gán giá trị tham số
            ParameterValues para = new ParameterValues();
            ParameterDiscreteValue paraValue = new ParameterDiscreteValue();
            paraValue.Value = soNam;
            para.Add(paraValue);

            // Gán tham số cho report
            rp.DataDefinition.ParameterFields["@so_nam"].ApplyCurrentValues(para);


            FormInDanhSachThuocTheoNam formIn = new FormInDanhSachThuocTheoNam();
            formIn.ctrpInDanhSachThuocTheoNam.ReportSource = rp;
            formIn.ctrpInDanhSachThuocTheoNam.Refresh();
            formIn.ShowDialog();

            cboTimKiemTheoLoai.SelectedIndex = 0;
            cboTenLoai.SelectedIndex = 0;
            txtTenThuoc.Clear();
            txtGiaTienThuoc.Clear();
            txtNoiSanXuat.Clear();
            txtThanhPhan.Clear();
            DateTime ngayhientai = DateTime.Now;
            dtpNgaySanXuat.Value = ngayhientai;
            dtpNgayHetHan.Value = ngayhientai;
            TxtTimKiemThuocTheoTen.Clear();
            rtbMoTa.Clear();

            cboTimKiemTheoNam.SelectedIndex = 0;
            cboTimKiemTheoThang.SelectedIndex = 0;

            cboTimKiemTheoLoai.SelectedIndex = 0;

            pictureBoxHinhAnh.Image = null;
            tenFileAnh = "";
        }

        private void btnChonHinhMoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog.FileName;

                // Đảm bảo thư mục tồn tại
                if (!Directory.Exists(thuMucHinhAnh))
                {
                    Directory.CreateDirectory(thuMucHinhAnh);
                }

                // Tạo tên file mới tránh trùng tên (ví dụ dùng Guid hoặc timestamp)
                string fileName = Path.GetFileName(sourceFile);
                string destFile = Path.Combine(thuMucHinhAnh, fileName);

                // Nếu muốn tự động đổi tên nếu trùng
                int count = 1;

                // Nếu tên file đã tồn tại, thêm hậu tố _1, _2, ...
                while (File.Exists(destFile))
                {
                    string fileNameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
                    string extension = Path.GetExtension(fileName);
                    destFile = Path.Combine(thuMucHinhAnh, $"{fileNameWithoutExt}_{count}{extension}");
                    count++;
                }

                try
                {
                    // Hiển thị ảnh lên PictureBox

                    File.Copy(sourceFile, destFile);

                    pictureBoxHinhAnh.Image = Image.FromFile(destFile);

                    MessageBox.Show("Ảnh mới đã được thêm vào thư mục!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
