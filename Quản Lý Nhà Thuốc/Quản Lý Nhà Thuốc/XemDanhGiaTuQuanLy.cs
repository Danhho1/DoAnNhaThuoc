using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyNhaThuoc;
using ET_QuanLyNhaThuoc;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class XemDanhGiaTuQuanLy : Form
    {
        BUS_DanhGia busDanhGia = new BUS_DanhGia();
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private Panel _panelMain;
        public XemDanhGiaTuQuanLy(Panel panelMain)
        {
            InitializeComponent();
            _panelMain = panelMain;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void LoadDanhSachDanhGia()
        {
            // Lấy danh sách loại thuốc
            var danhSachDanhGia = busDanhGia.LayDanhSachDanhGia();
            dgvDanhGia.DataSource = danhSachDanhGia;
        }

        private void XemDanhGiaTuQuanLy_Load(object sender, EventArgs e)
        {
            LoadDanhSachDanhGia();
           


            txtTenNguoiGui.Enabled = false;
            txtSoDienThoai.Enabled = false;
          txtGuiDen.Enabled = false;
            rdaRatTe.Checked = true;
        }

        private void dgvDanhGia_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (dgvDanhGia.CurrentRow != null)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow row = dgvDanhGia.CurrentRow;


                int danhGia = Convert.ToInt32(row.Cells["muc_Danh_Gia"].Value);
                if (danhGia == 1) rdaRatTe.Checked = true;
                else if (danhGia == 2) rdaTe.Checked = true;
                else if (danhGia == 3) rdaBinhThuong.Checked = true;
                else if (danhGia == 4) rdaTot.Checked = true;
                else if (danhGia == 5) rdaRatTot.Checked = true;
             

                // Nội dung
                rtbNoiDung.Text = row.Cells["NoiDung"].Value.ToString();

                // Lấy thông tin nhân viên theo ID
                int idNhanVien = Convert.ToInt32(dgvDanhGia.CurrentRow.Cells["Id_NhanVien"].Value);
                int idNguoiGui= Convert.ToInt32(dgvDanhGia.CurrentRow.Cells["Id_NguoiGui"].Value);
                var nhanVien = busNhanVien.LayNhanVienTheoId(idNhanVien);
                var quanLy = busNhanVien.LayNhanVienTheoId(idNguoiGui);
                if (nhanVien != null &&quanLy !=null)
                {
                    txtGuiDen.Text = nhanVien.HoTenTaiKhoan;
                    txtTenNguoiGui.Text = quanLy.HoTenTaiKhoan;
                    txtSoDienThoai.Text = quanLy.SoDienThoaiTaiKhoan;
                    
                }
              
            }
        }
    }
}
