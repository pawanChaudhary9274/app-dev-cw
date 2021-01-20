namespace Application_Development_Coursework
{
    partial class AdminLogin
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.txtBoxAdminName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picAdminUser = new System.Windows.Forms.PictureBox();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.txtBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.BtnCustomerReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(65, 104);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(177, 32);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin Login";
            // 
            // txtBoxAdminName
            // 
            this.txtBoxAdminName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAdminName.Location = new System.Drawing.Point(70, 172);
            this.txtBoxAdminName.Margin = new System.Windows.Forms.Padding(0);
            this.txtBoxAdminName.Name = "txtBoxAdminName";
            this.txtBoxAdminName.Size = new System.Drawing.Size(201, 27);
            this.txtBoxAdminName.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(45, 297);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(226, 49);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Application_Development_Coursework.Properties.Resources.cross1;
            this.btnClose.Location = new System.Drawing.Point(278, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 33);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.Teal;
            this.picPassword.Image = global::Application_Development_Coursework.Properties.Resources.password;
            this.picPassword.Location = new System.Drawing.Point(45, 229);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(25, 25);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 3;
            this.picPassword.TabStop = false;
            // 
            // picAdminUser
            // 
            this.picAdminUser.BackColor = System.Drawing.Color.Teal;
            this.picAdminUser.Image = global::Application_Development_Coursework.Properties.Resources.user;
            this.picAdminUser.Location = new System.Drawing.Point(45, 172);
            this.picAdminUser.Margin = new System.Windows.Forms.Padding(0);
            this.picAdminUser.Name = "picAdminUser";
            this.picAdminUser.Size = new System.Drawing.Size(25, 25);
            this.picAdminUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdminUser.TabIndex = 2;
            this.picAdminUser.TabStop = false;
            // 
            // picAdmin
            // 
            this.picAdmin.Image = global::Application_Development_Coursework.Properties.Resources.admin;
            this.picAdmin.Location = new System.Drawing.Point(108, 30);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(87, 71);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin.TabIndex = 0;
            this.picAdmin.TabStop = false;
            // 
            // txtBoxAdminPassword
            // 
            this.txtBoxAdminPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAdminPassword.Location = new System.Drawing.Point(70, 227);
            this.txtBoxAdminPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtBoxAdminPassword.Name = "txtBoxAdminPassword";
            this.txtBoxAdminPassword.Size = new System.Drawing.Size(201, 27);
            this.txtBoxAdminPassword.TabIndex = 10;
            // 
            // BtnCustomerReview
            // 
            this.BtnCustomerReview.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCustomerReview.FlatAppearance.BorderSize = 0;
            this.BtnCustomerReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomerReview.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerReview.ForeColor = System.Drawing.Color.White;
            this.BtnCustomerReview.Location = new System.Drawing.Point(45, 380);
            this.BtnCustomerReview.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCustomerReview.Name = "BtnCustomerReview";
            this.BtnCustomerReview.Size = new System.Drawing.Size(226, 49);
            this.BtnCustomerReview.TabIndex = 11;
            this.BtnCustomerReview.Text = "Customer Review";
            this.BtnCustomerReview.UseVisualStyleBackColor = false;
            this.BtnCustomerReview.Click += new System.EventHandler(this.BtnCustomerReview_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(310, 452);
            this.Controls.Add(this.BtnCustomerReview);
            this.Controls.Add(this.txtBoxAdminPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxAdminName);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.picAdminUser);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.picAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox picAdminUser;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.TextBox txtBoxAdminName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBoxAdminPassword;
        private System.Windows.Forms.Button BtnCustomerReview;
    }
}