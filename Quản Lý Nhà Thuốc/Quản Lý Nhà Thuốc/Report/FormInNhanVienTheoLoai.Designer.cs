namespace Quản_Lý_Nhà_Thuốc.Report
{
    partial class FormInNhanVienTheoLoai
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
            this.ctrpInNhanVienTheoLoai = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptInNhanVienTheoLoai1 = new Quản_Lý_Nhà_Thuốc.Report.rptInNhanVienTheoLoai();
            this.SuspendLayout();
            // 
            // ctrpInNhanVienTheoLoai
            // 
            this.ctrpInNhanVienTheoLoai.ActiveViewIndex = 0;
            this.ctrpInNhanVienTheoLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrpInNhanVienTheoLoai.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrpInNhanVienTheoLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrpInNhanVienTheoLoai.Location = new System.Drawing.Point(0, 0);
            this.ctrpInNhanVienTheoLoai.Name = "ctrpInNhanVienTheoLoai";
            this.ctrpInNhanVienTheoLoai.ReportSource = this.rptInNhanVienTheoLoai1;
            this.ctrpInNhanVienTheoLoai.Size = new System.Drawing.Size(1162, 691);
            this.ctrpInNhanVienTheoLoai.TabIndex = 0;
            // 
            // FormInNhanVienTheoLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 691);
            this.Controls.Add(this.ctrpInNhanVienTheoLoai);
            this.Name = "FormInNhanVienTheoLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormInNhanVienTheoLoai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInNhanVienTheoLoai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer ctrpInNhanVienTheoLoai;
        private rptInNhanVienTheoLoai rptInNhanVienTheoLoai1;
    }
}