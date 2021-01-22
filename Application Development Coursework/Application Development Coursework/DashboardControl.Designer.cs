namespace Application_Development_Coursework
{
    partial class DashboardControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlReportHead = new System.Windows.Forms.Panel();
            this.lblGraphHead = new System.Windows.Forms.Label();
            this.chrtReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSelectCriteria = new System.Windows.Forms.Label();
            this.btnSelected = new System.Windows.Forms.Button();
            this.cbCriteriaList = new System.Windows.Forms.ComboBox();
            this.pnlReportHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReportHead
            // 
            this.pnlReportHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlReportHead.Controls.Add(this.lblGraphHead);
            this.pnlReportHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportHead.Location = new System.Drawing.Point(0, 0);
            this.pnlReportHead.Name = "pnlReportHead";
            this.pnlReportHead.Size = new System.Drawing.Size(636, 64);
            this.pnlReportHead.TabIndex = 4;
            // 
            // lblGraphHead
            // 
            this.lblGraphHead.AutoSize = true;
            this.lblGraphHead.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphHead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGraphHead.Location = new System.Drawing.Point(257, 26);
            this.lblGraphHead.Name = "lblGraphHead";
            this.lblGraphHead.Size = new System.Drawing.Size(123, 19);
            this.lblGraphHead.TabIndex = 3;
            this.lblGraphHead.Text = "Report Graph";
            // 
            // chrtReport
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtReport.Legends.Add(legend1);
            this.chrtReport.Location = new System.Drawing.Point(0, 62);
            this.chrtReport.Name = "chrtReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtReport.Series.Add(series1);
            this.chrtReport.Size = new System.Drawing.Size(636, 308);
            this.chrtReport.TabIndex = 5;
            this.chrtReport.Text = "chart1";
            // 
            // lblSelectCriteria
            // 
            this.lblSelectCriteria.AutoSize = true;
            this.lblSelectCriteria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCriteria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSelectCriteria.Location = new System.Drawing.Point(3, 406);
            this.lblSelectCriteria.Name = "lblSelectCriteria";
            this.lblSelectCriteria.Size = new System.Drawing.Size(114, 19);
            this.lblSelectCriteria.TabIndex = 6;
            this.lblSelectCriteria.Text = "Select Criteria";
            // 
            // btnSelected
            // 
            this.btnSelected.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSelected.FlatAppearance.BorderSize = 0;
            this.btnSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelected.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelected.ForeColor = System.Drawing.Color.White;
            this.btnSelected.Location = new System.Drawing.Point(306, 396);
            this.btnSelected.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(131, 38);
            this.btnSelected.TabIndex = 11;
            this.btnSelected.Text = "Submit";
            this.btnSelected.UseVisualStyleBackColor = false;
            // 
            // cbCriteriaList
            // 
            this.cbCriteriaList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCriteriaList.FormattingEnabled = true;
            this.cbCriteriaList.Location = new System.Drawing.Point(143, 402);
            this.cbCriteriaList.Name = "cbCriteriaList";
            this.cbCriteriaList.Size = new System.Drawing.Size(121, 29);
            this.cbCriteriaList.TabIndex = 12;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.cbCriteriaList);
            this.Controls.Add(this.btnSelected);
            this.Controls.Add(this.lblSelectCriteria);
            this.Controls.Add(this.chrtReport);
            this.Controls.Add(this.pnlReportHead);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(636, 453);
            this.pnlReportHead.ResumeLayout(false);
            this.pnlReportHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlReportHead;
        private System.Windows.Forms.Label lblGraphHead;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtReport;
        private System.Windows.Forms.Label lblSelectCriteria;
        private System.Windows.Forms.Button btnSelected;
        private System.Windows.Forms.ComboBox cbCriteriaList;
    }
}
