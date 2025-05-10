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
    public partial class DoanhThu : Form
    {
        
        BUS_DoanhThu busDoanhThu = new BUS_DoanhThu();
        private Panel _panelMain;
        private int idDoanhThu = -1;
        public DoanhThu(Panel panelMain)
        {
            InitializeComponent();
            _panelMain = panelMain;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            var danhSach = busDoanhThu.LayTatCaDoanhThu();

            dgvChiTietThuoc.DataSource = danhSach;
            txtTongSoLuongBanRa.Enabled=false;
            txtTongTien.Enabled=false;
        }
        private void LoadLichSuDoanhThu()
        {
            
            var danhSach = busDoanhThu.LayTatCaDoanhThu();

            dgvChiTietThuoc.DataSource = danhSach;
        }
        private void LoadLayChiTietTHuoc()
        {

            DateTime tuNgay = dtpNgayBatDau.Value.Date;
            DateTime denNgay = dtpNgayKetThuc.Value.Date;
            var danhSach = busDoanhThu.LayChiTietThuoc(tuNgay, denNgay);

            dgvChiTietThuoc.DataSource = danhSach;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int tongSoLuong = int.Parse(txtTongSoLuongBanRa.Text);
                decimal tongTien = decimal.Parse(txtTongTien.Text);
                ET_DoanhThu doanhThu = new ET_DoanhThu(
                                        
                     dtpNgayBatDau.Value,
                     dtpNgayKetThuc.Value,
                     tongSoLuong,
                     tongTien
                 );

                if (busDoanhThu.LuuDoanhThu(doanhThu))
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLichSuDoanhThu();


                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }       

            // Load lại chi tiết/thống kê nếu cần
            LoadLichSuDoanhThu();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
            DateTime tuNgay = dtpNgayBatDau.Value.Date;
            DateTime denNgay = dtpNgayKetThuc.Value.Date;

            var dto = busDoanhThu.TinhDoanhThuHoanThanh(tuNgay, denNgay);

            txtTongSoLuongBanRa.Text = dto.TongSoLuongBan.ToString();
            txtTongTien.Text = dto.TongTien.ToString();



            // Load lại chi tiết/thống kê nếu cần
            LoadLayChiTietTHuoc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             
            if (idDoanhThu == -1)

            {
                MessageBox.Show("Vui lòng chọn thuốc cần xóa trong đơn hàng");
                return;
            }

            if (busDoanhThu.XoaDoanhThu(idDoanhThu))  // Xóa theo id
            {
                MessageBox.Show("Đã xóa thuốc khỏi đơn hàng");
                dgvChiTietThuoc.DataSource = busDoanhThu.LayTatCaDoanhThu();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dgvChiTietThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTietThuoc.CurrentRow != null)
                {
                    idDoanhThu = Convert.ToInt32(dgvChiTietThuoc.CurrentRow.Cells["Id_DoanhThu"].Value);
                    dtpNgayBatDau.Value = Convert.ToDateTime(dgvChiTietThuoc.CurrentRow.Cells["NgayBatDau"].Value);
                    dtpNgayKetThuc.Value = Convert.ToDateTime(dgvChiTietThuoc.CurrentRow.Cells["NgayKetThuc"].Value);

                    txtTongSoLuongBanRa.Text = dgvChiTietThuoc.CurrentRow.Cells["TongSoLuongBan"].Value.ToString();
                    txtTongTien.Text = dgvChiTietThuoc.CurrentRow.Cells["TongTien"].Value.ToString();




                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi : " + ex.Message);
            }
            
        }
    }
}
