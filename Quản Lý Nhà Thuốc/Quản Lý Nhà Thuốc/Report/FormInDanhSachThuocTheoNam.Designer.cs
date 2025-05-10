namespace Quản_Lý_Nhà_Thuốc.Report
{
    partial class FormInDanhSachThuocTheoNam
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
            this.ctrpInDanhSachThuocTheoNam = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptInDanhSachThuocHetHanTheoNam1 = new Quản_Lý_Nhà_Thuốc.Report.rptInDanhSachThuocHetHanTheoNam();
            this.SuspendLayout();
            // 
            // ctrpInDanhSachThuocTheoNam
            // 
            this.ctrpInDanhSachThuocTheoNam.ActiveViewIndex = 0;
            this.ctrpInDanhSachThuocTheoNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrpInDanhSachThuocTheoNam.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrpInDanhSachThuocTheoNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrpInDanhSachThuocTheoNam.Location = new System.Drawing.Point(0, 0);
            this.ctrpInDanhSachThuocTheoNam.Name = "ctrpInDanhSachThuocTheoNam";
            this.ctrpInDanhSachThuocTheoNam.ReportSource = this.rptInDanhSachThuocHetHanTheoNam1;
            this.ctrpInDanhSachThuocTheoNam.Size = new System.Drawing.Size(1209, 705);
            this.ctrpInDanhSachThuocTheoNam.TabIndex = 0;
            // 
            // FormInDanhSachThuocTheoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 705);
            this.Controls.Add(this.ctrpInDanhSachThuocTheoNam);
            this.Name = "FormInDanhSachThuocTheoNam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInDanhSachThuocTheoNam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer ctrpInDanhSachThuocTheoNam;
        private rptInDanhSachThuocHetHanTheoNam rptInDanhSachThuocHetHanTheoNam1;
    }
}