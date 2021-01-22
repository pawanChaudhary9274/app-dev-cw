namespace Application_Development_Coursework
{
    partial class RecordsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReportHead = new System.Windows.Forms.Label();
            this.pnlReportHead = new System.Windows.Forms.Panel();
            this.btnSort = new System.Windows.Forms.Button();
            this.dataGvReports = new System.Windows.Forms.DataGridView();
            this.dashboardControl1 = new Application_Development_Coursework.DashboardControl();
            this.pnlReportHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportHead
            // 
            this.lblReportHead.AutoSize = true;
            this.lblReportHead.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportHead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReportHead.Location = new System.Drawing.Point(168, 27);
            this.lblReportHead.Name = "lblReportHead";
            this.lblReportHead.Size = new System.Drawing.Size(238, 19);
            this.lblReportHead.TabIndex = 3;
            this.lblReportHead.Text = "Customer Feedbacks Report";
            // 
            // pnlReportHead
            // 
            this.pnlReportHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlReportHead.Controls.Add(this.lblReportHead);
            this.pnlReportHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportHead.Location = new System.Drawing.Point(0, 0);
            this.pnlReportHead.Name = "pnlReportHead";
            this.pnlReportHead.Size = new System.Drawing.Size(636, 64);
            this.pnlReportHead.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(188, 375);
            this.btnSort.Margin = new System.Windows.Forms.Padding(0);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(166, 57);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort By Date";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // dataGvReports
            // 
            this.dataGvReports.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvReports.Location = new System.Drawing.Point(0, 62);
            this.dataGvReports.Name = "dataGvReports";
            this.dataGvReports.Size = new System.Drawing.Size(636, 290);
            this.dataGvReports.TabIndex = 9;
            // 
            // dashboardControl1
            // 
            this.dashboardControl1.Location = new System.Drawing.Point(444, 385);
            this.dashboardControl1.Name = "dashboardControl1";
            this.dashboardControl1.Size = new System.Drawing.Size(498, 378);
            this.dashboardControl1.TabIndex = 10;
            // 
            // RecordsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.dashboardControl1);
            this.Controls.Add(this.dataGvReports);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.pnlReportHead);
            this.Name = "RecordsControl";
            this.Size = new System.Drawing.Size(636, 453);
            this.pnlReportHead.ResumeLayout(false);
            this.pnlReportHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReportHead;
        private System.Windows.Forms.Panel pnlReportHead;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.DataGridView dataGvReports;
        private DashboardControl dashboardControl1;
    }
}
