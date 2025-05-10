namespace Quản_Lý_Nhà_Thuốc.Report
{
    partial class FormInHoaDonThanhToan
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
            this.ctrpInHoaDonThanhToan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptInHoaDonThanhToan1 = new Quản_Lý_Nhà_Thuốc.Report.rptInHoaDonThanhToan();
            this.SuspendLayout();
            // 
            // ctrpInHoaDonThanhToan
            // 
            this.ctrpInHoaDonThanhToan.ActiveViewIndex = 0;
            this.ctrpInHoaDonThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrpInHoaDonThanhToan.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrpInHoaDonThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrpInHoaDonThanhToan.Location = new System.Drawing.Point(0, 0);
            this.ctrpInHoaDonThanhToan.Name = "ctrpInHoaDonThanhToan";
            this.ctrpInHoaDonThanhToan.ReportSource = this.rptInHoaDonThanhToan1;
            this.ctrpInHoaDonThanhToan.Size = new System.Drawing.Size(1218, 680);
            this.ctrpInHoaDonThanhToan.TabIndex = 0;
            // 
            // FormInHoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 680);
            this.Controls.Add(this.ctrpInHoaDonThanhToan);
            this.Name = "FormInHoaDonThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInHoaDonThanhToan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInHoaDonThanhToan_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer ctrpInHoaDonThanhToan;
        private rptInHoaDonThanhToan rptInHoaDonThanhToan1;
    }
}