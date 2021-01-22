namespace Application_Development_Coursework
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.loadingScreen = new CircularProgressBar.CircularProgressBar();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadingScreen
            // 
            this.loadingScreen.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("loadingScreen.AnimationFunction")));
            this.loadingScreen.AnimationSpeed = 500;
            this.loadingScreen.BackColor = System.Drawing.Color.Teal;
            this.loadingScreen.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadingScreen.InnerColor = System.Drawing.Color.Teal;
            this.loadingScreen.InnerMargin = 2;
            this.loadingScreen.InnerWidth = -1;
            this.loadingScreen.Location = new System.Drawing.Point(77, 158);
            this.loadingScreen.MarqueeAnimationSpeed = 2000;
            this.loadingScreen.Name = "loadingScreen";
            this.loadingScreen.OuterColor = System.Drawing.Color.Gray;
            this.loadingScreen.OuterMargin = -25;
            this.loadingScreen.OuterWidth = 26;
            this.loadingScreen.ProgressColor = System.Drawing.Color.DimGray;
            this.loadingScreen.ProgressWidth = 6;
            this.loadingScreen.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.loadingScreen.Size = new System.Drawing.Size(150, 150);
            this.loadingScreen.StartAngle = 270;
            this.loadingScreen.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingScreen.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingScreen.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.loadingScreen.SubscriptText = "";
            this.loadingScreen.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingScreen.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.loadingScreen.SuperscriptText = "";
            this.loadingScreen.TabIndex = 0;
            this.loadingScreen.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.loadingScreen.Value = 68;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeading.Location = new System.Drawing.Point(12, 62);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(294, 28);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Service is Getting Ready";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFooter.Location = new System.Drawing.Point(43, 427);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(225, 16);
            this.lblFooter.TabIndex = 2;
            this.lblFooter.Text = "Developed by P@wan Chaudhary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(87, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loading...........";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(310, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.loadingScreen);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar loadingScreen;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}