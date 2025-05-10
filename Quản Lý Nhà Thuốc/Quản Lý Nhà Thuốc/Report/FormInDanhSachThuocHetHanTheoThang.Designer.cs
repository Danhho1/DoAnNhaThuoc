namespace Quản_Lý_Nhà_Thuốc.Report
{
    partial class FormInDanhSachThuocHetHanTheoThang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrpInDanhSachThuocHetHanTheoThang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptInDanhSachThuocHetHanTheoThang1 = new Quản_Lý_Nhà_Thuốc.Report.rptInDanhSachThuocHetHanTheoThang();
            this.SuspendLayout();
            // 
            // ctrpInDanhSachThuocHetHanTheoThang
            // 
            this.ctrpInDanhSachThuocHetHanTheoThang.ActiveViewIndex = 0;
            this.ctrpInDanhSachThuocHetHanTheoThang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrpInDanhSachThuocHetHanTheoThang.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrpInDanhSachThuocHetHanTheoThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrpInDanhSachThuocHetHanTheoThang.Location = new System.Drawing.Point(0, 0);
            this.ctrpInDanhSachThuocHetHanTheoThang.Name = "ctrpInDanhSachThuocHetHanTheoThang";
            this.ctrpInDanhSachThuocHetHanTheoThang.ReportSource = this.rptInDanhSachThuocHetHanTheoThang1;
            this.ctrpInDanhSachThuocHetHanTheoThang.Size = new System.Drawing.Size(1217, 706);
            this.ctrpInDanhSachThuocHetHanTheoThang.TabIndex = 0;
            // 
            // FormInDanhSachThuocHetHanTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 706);
            this.Controls.Add(this.ctrpInDanhSachThuocHetHanTheoThang);
            this.Name = "FormInDanhSachThuocHetHanTheoThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormInDanhSachThuocHetHanTheoThang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer ctrpInDanhSachThuocHetHanTheoThang;
        private rptInDanhSachThuocHetHanTheoThang rptInDanhSachThuocHetHanTheoThang1;
    }
}