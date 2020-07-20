namespace Thelele_Mosebjadi_Project2
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
            this.lblBanner = new System.Windows.Forms.Label();
            this.txtAdPassword = new System.Windows.Forms.TextBox();
            this.txtAdname = new System.Windows.Forms.TextBox();
            this.lblAdPassword = new System.Windows.Forms.Label();
            this.lblAdName = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBanner.Font = new System.Drawing.Font("Kristen ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.Gold;
            this.lblBanner.Location = new System.Drawing.Point(1, -1);
            this.lblBanner.MinimumSize = new System.Drawing.Size(438, 50);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(438, 50);
            this.lblBanner.TabIndex = 6;
            this.lblBanner.Text = "JIBA\'S MOVIE RENTALS";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdPassword
            // 
            this.txtAdPassword.Location = new System.Drawing.Point(235, 189);
            this.txtAdPassword.Name = "txtAdPassword";
            this.txtAdPassword.PasswordChar = '*';
            this.txtAdPassword.Size = new System.Drawing.Size(149, 20);
            this.txtAdPassword.TabIndex = 11;
            // 
            // txtAdname
            // 
            this.txtAdname.Location = new System.Drawing.Point(235, 142);
            this.txtAdname.Name = "txtAdname";
            this.txtAdname.Size = new System.Drawing.Size(149, 20);
            this.txtAdname.TabIndex = 10;
            // 
            // lblAdPassword
            // 
            this.lblAdPassword.AutoSize = true;
            this.lblAdPassword.BackColor = System.Drawing.Color.DarkOrange;
            this.lblAdPassword.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdPassword.Location = new System.Drawing.Point(54, 189);
            this.lblAdPassword.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblAdPassword.Name = "lblAdPassword";
            this.lblAdPassword.Size = new System.Drawing.Size(100, 20);
            this.lblAdPassword.TabIndex = 9;
            this.lblAdPassword.Text = "Password";
            // 
            // lblAdName
            // 
            this.lblAdName.AutoSize = true;
            this.lblAdName.BackColor = System.Drawing.Color.DarkOrange;
            this.lblAdName.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdName.Location = new System.Drawing.Point(54, 144);
            this.lblAdName.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblAdName.Name = "lblAdName";
            this.lblAdName.Size = new System.Drawing.Size(100, 20);
            this.lblAdName.TabIndex = 8;
            this.lblAdName.Text = "Name";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAdminLogin.Location = new System.Drawing.Point(129, 263);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(154, 31);
            this.btnAdminLogin.TabIndex = 7;
            this.btnAdminLogin.Text = "LOGIN";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBack.Location = new System.Drawing.Point(12, 462);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(414, 34);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(438, 501);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtAdPassword);
            this.Controls.Add(this.txtAdname);
            this.Controls.Add(this.lblAdPassword);
            this.Controls.Add(this.lblAdName);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.lblBanner);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.TextBox txtAdPassword;
        private System.Windows.Forms.TextBox txtAdname;
        private System.Windows.Forms.Label lblAdPassword;
        private System.Windows.Forms.Label lblAdName;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnBack;
    }
}