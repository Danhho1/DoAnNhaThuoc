using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhà_Thuốc
{
    public partial class ManHinhXinChao : Form
    {
        public ManHinhXinChao()
        {
            InitializeComponent();
            // Tắt đi thanh trên cùng có các nút thu nhỏ , tắt tạm , tắt
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ManHinhXinChao_Load(object sender, EventArgs e)
        {
            // Đặt thời gian chờ 3 giây, sau đó chuyển sang Form2
            Timer timer = new Timer();
            timer.Interval = 3000; // 3000 milliseconds = 3 giây
            timer.Tick += (s, args) =>
            {
                timer.Stop(); // Dừng timer

                this.Hide();
                // Hiển thị Form Đăng nhập
                ManHinhDangNhap manHinhDangNhap = new ManHinhDangNhap();
                manHinhDangNhap.ShowDialog();

                this.Close();
            };
            timer.Start();
        }
    }
}
