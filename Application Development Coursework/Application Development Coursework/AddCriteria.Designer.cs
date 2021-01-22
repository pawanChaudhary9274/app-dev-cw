
namespace Application_Development_Coursework
{
    partial class AddCriteria
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
            this.lblCriteriaName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblCriteriaHead = new System.Windows.Forms.Label();
            this.txtBoxCriteriaName = new System.Windows.Forms.TextBox();
            this.btnAddCriteria = new System.Windows.Forms.Button();
            this.pnlCriteriaList = new System.Windows.Forms.Panel();
            this.lblCriteriaList = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCriteriaName
            // 
            this.lblCriteriaName.AutoSize = true;
            this.lblCriteriaName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteriaName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCriteriaName.Location = new System.Drawing.Point(15, 120);
            this.lblCriteriaName.Name = "lblCriteriaName";
            this.lblCriteriaName.Size = new System.Drawing.Size(158, 19);
            this.lblCriteriaName.TabIndex = 0;
            this.lblCriteriaName.Text = "Enter Criteria Name";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlHeader.Controls.Add(this.lblCriteriaHead);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(586, 64);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblCriteriaHead
            // 
            this.lblCriteriaHead.AutoSize = true;
            this.lblCriteriaHead.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteriaHead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCriteriaHead.Location = new System.Drawing.Point(210, 28);
            this.lblCriteriaHead.Name = "lblCriteriaHead";
            this.lblCriteriaHead.Size = new System.Drawing.Size(173, 19);
            this.lblCriteriaHead.TabIndex = 3;
            this.lblCriteriaHead.Text = "Create New Criteria";
            // 
            // txtBoxCriteriaName
            // 
            this.txtBoxCriteriaName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCriteriaName.Location = new System.Drawing.Point(195, 116);
            this.txtBoxCriteriaName.Margin = new System.Windows.Forms.Padding(0);
            this.txtBoxCriteriaName.Name = "txtBoxCriteriaName";
            this.txtBoxCriteriaName.Size = new System.Drawing.Size(235, 27);
            this.txtBoxCriteriaName.TabIndex = 6;
            // 
            // btnAddCriteria
            // 
            this.btnAddCriteria.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddCriteria.FlatAppearance.BorderSize = 0;
            this.btnAddCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCriteria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCriteria.ForeColor = System.Drawing.Color.White;
            this.btnAddCriteria.Location = new System.Drawing.Point(465, 116);
            this.btnAddCriteria.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCriteria.Name = "btnAddCriteria";
            this.btnAddCriteria.Size = new System.Drawing.Size(102, 27);
            this.btnAddCriteria.TabIndex = 8;
            this.btnAddCriteria.Text = "Add";
            this.btnAddCriteria.UseVisualStyleBackColor = false;
            this.btnAddCriteria.Click += new System.EventHandler(this.btnAddCriteria_Click);
            // 
            // pnlCriteriaList
            // 
            this.pnlCriteriaList.AutoScroll = true;
            this.pnlCriteriaList.BackColor = System.Drawing.Color.DimGray;
            this.pnlCriteriaList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCriteriaList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCriteriaList.Location = new System.Drawing.Point(45, 233);
            this.pnlCriteriaList.Name = "pnlCriteriaList";
            this.pnlCriteriaList.Size = new System.Drawing.Size(453, 214);
            this.pnlCriteriaList.TabIndex = 9;
            // 
            // lblCriteriaList
            // 
            this.lblCriteriaList.AutoSize = true;
            this.lblCriteriaList.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteriaList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCriteriaList.Location = new System.Drawing.Point(48, 211);
            this.lblCriteriaList.Name = "lblCriteriaList";
            this.lblCriteriaList.Size = new System.Drawing.Size(110, 19);
            this.lblCriteriaList.TabIndex = 4;
            this.lblCriteriaList.Text = "Criteria List";
            // 
            // AddCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.lblCriteriaList);
            this.Controls.Add(this.pnlCriteriaList);
            this.Controls.Add(this.btnAddCriteria);
            this.Controls.Add(this.txtBoxCriteriaName);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblCriteriaName);
            this.Name = "AddCriteria";
            this.Size = new System.Drawing.Size(586, 514);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriteriaName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCriteriaHead;
        private System.Windows.Forms.TextBox txtBoxCriteriaName;
        private System.Windows.Forms.Button btnAddCriteria;
        private System.Windows.Forms.Panel pnlCriteriaList;
        private System.Windows.Forms.Label lblCriteriaList;
    }
}
