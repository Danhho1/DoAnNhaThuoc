using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Thêm thư viện 
using BUS_QuanLyNhaThuoc;
using ET_QuanLyNhaThuoc;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class ManHinhDangNhap : Form
    {
        private BUS_TaiKhoan busDangNhap;
        private BUS_LoaiTaiKhoan busLoaiTaiKhoan;
        public ManHinhDangNhap()
        {
            InitializeComponent();
            busDangNhap = new BUS_TaiKhoan();
            busLoaiTaiKhoan = new BUS_LoaiTaiKhoan();
        }


        public static ET_TaiKhoan TaiKhoanDangNhap;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Kiểm tra nếu người dùng không nhập thì hiển thị thông báo
            if(string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hoặc mật khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ET_TaiKhoan dn = busDangNhap.KiemTraTaiKhoan(soDienThoai, matKhau);

            // Kiểm tra nếu khác null thì hiển thị ra thông báo đăng nhập thành công và vào màn hình theo vai trò của tài khoản
            if(dn != null)
            {
                TaiKhoanDangNhap = dn; // 👈 Gán tài khoản vào biến tĩnh

                MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string vaiTro = busLoaiTaiKhoan.LayTenLoaiTaiKhoanTheoId(dn.MaLoai); // Lấy tên vai trò từ id

                Form mainForm = null;
                switch (vaiTro)
                {
                    case "quan_ly":
                        mainForm = new ChuongTrinhQuanLy();
                        break;
                    case "nhan_vien":
                        mainForm = new ChuongTrinhNhanVien();
                        break;
                }


                // Nếu Form sau có dữ liệu thì ẩn Form đăng nhập hiện tại và hiển thị Form tiếp theo
                if (mainForm != null)
                {
                    // Ẩn form hiện tại
                    this.Hide();
                    // Mở form tiếp theo
                    mainForm.ShowDialog();
                    // Đóng form lúc nảy ẩn
                    this.Close();
                }
            }
            // Nếu tài khoản không = null thì hiển thị thông báo đăng nhập sai và yêu cầu người dùng đăng nhập lại
            else
            {
                MessageBox.Show("Số điện thoại hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ManHinhDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
