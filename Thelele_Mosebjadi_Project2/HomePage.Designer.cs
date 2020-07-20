namespace Thelele_Mosebjadi_Project2
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lblBanner = new System.Windows.Forms.Label();
            this.btnRentMovie = new System.Windows.Forms.Button();
            this.btnViewLatest = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBanner.Font = new System.Drawing.Font("Kristen ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.Gold;
            this.lblBanner.Location = new System.Drawing.Point(1, 1);
            this.lblBanner.MinimumSize = new System.Drawing.Size(430, 50);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(430, 50);
            this.lblBanner.TabIndex = 6;
            this.lblBanner.Text = "JIBA\'S MOVIE RENTALS";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBanner.Click += new System.EventHandler(this.lblBanner_Click);
            // 
            // btnRentMovie
            // 
            this.btnRentMovie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRentMovie.BackgroundImage")));
            this.btnRentMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRentMovie.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentMovie.ForeColor = System.Drawing.Color.Linen;
            this.btnRentMovie.Location = new System.Drawing.Point(92, 203);
            this.btnRentMovie.MinimumSize = new System.Drawing.Size(154, 35);
            this.btnRentMovie.Name = "btnRentMovie";
            this.btnRentMovie.Size = new System.Drawing.Size(242, 35);
            this.btnRentMovie.TabIndex = 8;
            this.btnRentMovie.Text = "Rent A Movie ";
            this.btnRentMovie.UseVisualStyleBackColor = true;
            this.btnRentMovie.Click += new System.EventHandler(this.btnRentMovie_Click);
            // 
            // btnViewLatest
            // 
            this.btnViewLatest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewLatest.BackgroundImage")));
            this.btnViewLatest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewLatest.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLatest.ForeColor = System.Drawing.Color.Linen;
            this.btnViewLatest.Location = new System.Drawing.Point(92, 271);
            this.btnViewLatest.MinimumSize = new System.Drawing.Size(154, 35);
            this.btnViewLatest.Name = "btnViewLatest";
            this.btnViewLatest.Size = new System.Drawing.Size(242, 35);
            this.btnViewLatest.TabIndex = 9;
            this.btnViewLatest.Text = "View Latest Releases";
            this.btnViewLatest.UseVisualStyleBackColor = true;
            this.btnViewLatest.Click += new System.EventHandler(this.btnViewLatest_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBack.Location = new System.Drawing.Point(6, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(414, 35);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thelele_Mosebjadi_Project2.Properties.Resources.woodwall;
            this.ClientSize = new System.Drawing.Size(434, 512);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewLatest);
            this.Controls.Add(this.btnRentMovie);
            this.Controls.Add(this.lblBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(909, 551);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Button btnRentMovie;
        private System.Windows.Forms.Button btnViewLatest;
        private System.Windows.Forms.Button btnBack;
    }
}