namespace Application_Development_Coursework
{
    partial class App
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.picBoxAdmin = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnNewFeedback = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblrestaurantName = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.picBoxInsta = new System.Windows.Forms.PictureBox();
            this.picBoxFace = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLocatioin = new System.Windows.Forms.Label();
            this.dashboardControl = new Application_Development_Coursework.DashboardControl();
            this.recordsControl = new Application_Development_Coursework.RecordsControl();
            this.dashboardUserControl1 = new Application_Development_Coursework.DashboardControl();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFace)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSideMenu.Controls.Add(this.lblAdmin);
            this.pnlSideMenu.Controls.Add(this.picBoxAdmin);
            this.pnlSideMenu.Controls.Add(this.btnLogOut);
            this.pnlSideMenu.Controls.Add(this.btnNewFeedback);
            this.pnlSideMenu.Controls.Add(this.btnRecords);
            this.pnlSideMenu.Controls.Add(this.btnDashboard);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(171, 530);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAdmin.Location = new System.Drawing.Point(40, 229);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(96, 22);
            this.lblAdmin.TabIndex = 6;
            this.lblAdmin.Text = "Hi, Admin";
            // 
            // picBoxAdmin
            // 
            this.picBoxAdmin.Image = global::Application_Development_Coursework.Properties.Resources.user;
            this.picBoxAdmin.Location = new System.Drawing.Point(44, 151);
            this.picBoxAdmin.Name = "picBoxAdmin";
            this.picBoxAdmin.Size = new System.Drawing.Size(86, 75);
            this.picBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAdmin.TabIndex = 3;
            this.picBoxAdmin.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gray;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogOut.Location = new System.Drawing.Point(3, 461);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(165, 63);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnNewFeedback
            // 
            this.btnNewFeedback.BackColor = System.Drawing.Color.Gray;
            this.btnNewFeedback.FlatAppearance.BorderSize = 0;
            this.btnNewFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFeedback.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFeedback.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNewFeedback.Location = new System.Drawing.Point(3, 392);
            this.btnNewFeedback.Name = "btnNewFeedback";
            this.btnNewFeedback.Size = new System.Drawing.Size(165, 63);
            this.btnNewFeedback.TabIndex = 4;
            this.btnNewFeedback.Text = "New Feedback";
            this.btnNewFeedback.UseVisualStyleBackColor = false;
            this.btnNewFeedback.Click += new System.EventHandler(this.btnNewFeedback_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.Gray;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRecords.Location = new System.Drawing.Point(3, 323);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(165, 63);
            this.btnRecords.TabIndex = 3;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Gray;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDashboard.Location = new System.Drawing.Point(3, 254);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(165, 63);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlLogo.Controls.Add(this.lblrestaurantName);
            this.pnlLogo.Controls.Add(this.picBoxLogo);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(171, 145);
            this.pnlLogo.TabIndex = 2;
            // 
            // lblrestaurantName
            // 
            this.lblrestaurantName.AutoSize = true;
            this.lblrestaurantName.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrestaurantName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblrestaurantName.Location = new System.Drawing.Point(3, 109);
            this.lblrestaurantName.Name = "lblrestaurantName";
            this.lblrestaurantName.Size = new System.Drawing.Size(160, 28);
            this.lblrestaurantName.TabIndex = 2;
            this.lblrestaurantName.Text = "Yummy Foods";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::Application_Development_Coursework.Properties.Resources.Yummy_Foods;
            this.picBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(171, 106);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 2;
            this.picBoxLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblSlogan);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(171, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(625, 44);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Application_Development_Coursework.Properties.Resources.cross1;
            this.btnClose.Location = new System.Drawing.Point(593, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 33);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSlogan.Location = new System.Drawing.Point(119, 9);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(380, 19);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Customer\'s Satisfaction is our major priority";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlFooter.Controls.Add(this.picBoxInsta);
            this.pnlFooter.Controls.Add(this.picBoxFace);
            this.pnlFooter.Controls.Add(this.lblEmail);
            this.pnlFooter.Controls.Add(this.lblPhone);
            this.pnlFooter.Controls.Add(this.lblLocatioin);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlFooter.Location = new System.Drawing.Point(171, 486);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(625, 44);
            this.pnlFooter.TabIndex = 2;
            // 
            // picBoxInsta
            // 
            this.picBoxInsta.Image = global::Application_Development_Coursework.Properties.Resources.instagram;
            this.picBoxInsta.Location = new System.Drawing.Point(568, 6);
            this.picBoxInsta.Name = "picBoxInsta";
            this.picBoxInsta.Size = new System.Drawing.Size(45, 35);
            this.picBoxInsta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxInsta.TabIndex = 4;
            this.picBoxInsta.TabStop = false;
            // 
            // picBoxFace
            // 
            this.picBoxFace.Image = global::Application_Development_Coursework.Properties.Resources.facebook;
            this.picBoxFace.Location = new System.Drawing.Point(517, 6);
            this.picBoxFace.Name = "picBoxFace";
            this.picBoxFace.Size = new System.Drawing.Size(45, 35);
            this.picBoxFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFace.TabIndex = 3;
            this.picBoxFace.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(335, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(147, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "yummy.foods@mail.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(200, 16);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(108, 13);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "+977-9876543210";
            // 
            // lblLocatioin
            // 
            this.lblLocatioin.AutoSize = true;
            this.lblLocatioin.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocatioin.Location = new System.Drawing.Point(16, 16);
            this.lblLocatioin.Name = "lblLocatioin";
            this.lblLocatioin.Size = new System.Drawing.Size(165, 13);
            this.lblLocatioin.TabIndex = 0;
            this.lblLocatioin.Text = "Kamal Pokhari, Kathmandu";
            // 
            // dashboardControl
            // 
            this.dashboardControl.BackColor = System.Drawing.Color.Teal;
            this.dashboardControl.Location = new System.Drawing.Point(171, 43);
            this.dashboardControl.Name = "dashboardControl";
            this.dashboardControl.Size = new System.Drawing.Size(625, 443);
            this.dashboardControl.TabIndex = 3;
            // 
            // recordsControl
            // 
            this.recordsControl.Location = new System.Drawing.Point(171, 43);
            this.recordsControl.Name = "recordsControl";
            this.recordsControl.Size = new System.Drawing.Size(625, 443);
            this.recordsControl.TabIndex = 4;
            // 
            // dashboardUserControl1
            // 
            this.dashboardUserControl1.Location = new System.Drawing.Point(171, 42);
            this.dashboardUserControl1.Name = "dashboardUserControl1";
            this.dashboardUserControl1.Size = new System.Drawing.Size(625, 382);
            this.dashboardUserControl1.TabIndex = 3;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 530);
            this.Controls.Add(this.dashboardControl);
            this.Controls.Add(this.recordsControl);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerFeedback";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFace)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblrestaurantName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnNewFeedback;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLocatioin;
        private System.Windows.Forms.PictureBox picBoxFace;
        private System.Windows.Forms.PictureBox picBoxInsta;
        private DashboardControl dashboardUserControl1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox picBoxAdmin;
        private DashboardControl dashboardControl;
        private RecordsControl recordsControl;
        private System.Windows.Forms.Button btnClose;
    }
}