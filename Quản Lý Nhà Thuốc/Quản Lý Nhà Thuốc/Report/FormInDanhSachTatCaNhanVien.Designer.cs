namespace Quản_Lý_Nhà_Thuốc.Report
{
    partial class FormInDanhSachTatCaNhanVien
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
            this.ctrpInDanhSachTatCaNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptInDanhSachTatCaNhanVien1 = new Quản_Lý_Nhà_Thuốc.Report.rptInDanhSachTatCaNhanVien();
            this.SuspendLayout();
            // 
            // ctrpInDanhSachTatCaNhanVien
            // 
            this.ctrpInDanhSachTatCaNhanVien.ActiveViewIndex = 0;
            this.ctrpInDanhSachTatCaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrpInDanhSachTatCaNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrpInDanhSachTatCaNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrpInDanhSachTatCaNhanVien.Location = new System.Drawing.Point(0, 0);
            this.ctrpInDanhSachTatCaNhanVien.Name = "ctrpInDanhSachTatCaNhanVien";
            this.ctrpInDanhSachTatCaNhanVien.ReportSource = this.rptInDanhSachTatCaNhanVien1;
            this.ctrpInDanhSachTatCaNhanVien.Size = new System.Drawing.Size(1176, 669);
            this.ctrpInDanhSachTatCaNhanVien.TabIndex = 0;
            // 
            // FormInDanhSachTatCaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 669);
            this.Controls.Add(this.ctrpInDanhSachTatCaNhanVien);
            this.Name = "FormInDanhSachTatCaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInDanhSachTatCaNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private rptInDanhSachTatCaNhanVien rptInDanhSachTatCaNhanVien1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer ctrpInDanhSachTatCaNhanVien;
    }
}