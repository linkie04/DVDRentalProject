namespace Thelele_Mosebjadi_Project2
{
    partial class UpdateDVD
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
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAgeRes = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDVDname = new System.Windows.Forms.TextBox();
            this.lblDVDname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboRestriction = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(126, 12);
            this.lblUpdate.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(200, 30);
            this.lblUpdate.TabIndex = 0;
            this.lblUpdate.Text = "Update DVDs";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.DarkOrange;
            this.lblGenre.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGenre.Location = new System.Drawing.Point(87, 175);
            this.lblGenre.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(100, 20);
            this.lblGenre.TabIndex = 36;
            this.lblGenre.Text = "Genre";
            // 
            // lblAgeRes
            // 
            this.lblAgeRes.AutoSize = true;
            this.lblAgeRes.BackColor = System.Drawing.Color.DarkOrange;
            this.lblAgeRes.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeRes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgeRes.Location = new System.Drawing.Point(86, 138);
            this.lblAgeRes.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblAgeRes.Name = "lblAgeRes";
            this.lblAgeRes.Size = new System.Drawing.Size(101, 20);
            this.lblAgeRes.TabIndex = 34;
            this.lblAgeRes.Text = "Age Restriction";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(266, 101);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(149, 20);
            this.txtDuration.TabIndex = 33;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.DarkOrange;
            this.lblLength.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLength.Location = new System.Drawing.Point(85, 101);
            this.lblLength.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(100, 20);
            this.lblLength.TabIndex = 32;
            this.lblLength.Text = "Duration";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBack.Location = new System.Drawing.Point(43, 418);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(414, 34);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDVDname
            // 
            this.txtDVDname.Location = new System.Drawing.Point(266, 64);
            this.txtDVDname.Name = "txtDVDname";
            this.txtDVDname.Size = new System.Drawing.Size(149, 20);
            this.txtDVDname.TabIndex = 29;
            // 
            // lblDVDname
            // 
            this.lblDVDname.AutoSize = true;
            this.lblDVDname.BackColor = System.Drawing.Color.DarkOrange;
            this.lblDVDname.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVDname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDVDname.Location = new System.Drawing.Point(85, 64);
            this.lblDVDname.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblDVDname.Name = "lblDVDname";
            this.lblDVDname.Size = new System.Drawing.Size(100, 20);
            this.lblDVDname.TabIndex = 27;
            this.lblDVDname.Text = "DVD Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.Location = new System.Drawing.Point(161, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 31);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboRestriction
            // 
            this.cboRestriction.FormattingEnabled = true;
            this.cboRestriction.Items.AddRange(new object[] {
            "ALL",
            "FAM",
            "PG10",
            "PG13",
            "PG13V",
            "PG13VL",
            "PG13SNV",
            "P13SNVL",
            "16",
            "16V",
            "16VL",
            "16SVL",
            "16SNVL",
            "18",
            "18V",
            "18VL",
            "18NVL",
            "18SNVL"});
            this.cboRestriction.Location = new System.Drawing.Point(266, 137);
            this.cboRestriction.Name = "cboRestriction";
            this.cboRestriction.Size = new System.Drawing.Size(149, 21);
            this.cboRestriction.TabIndex = 35;
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Drama",
            "Horror",
            "Romance",
            "Sci-Fi",
            "Thriller",
            "True-Life Drama"});
            this.cboGenre.Location = new System.Drawing.Point(266, 175);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboGenre.Size = new System.Drawing.Size(149, 21);
            this.cboGenre.TabIndex = 37;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.DarkOrange;
            this.lblPrice.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(87, 213);
            this.lblPrice.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 20);
            this.lblPrice.TabIndex = 38;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(266, 213);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(149, 20);
            this.txtPrice.TabIndex = 39;
            this.txtPrice.Text = "55";
            // 
            // UpdateDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(501, 501);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cboRestriction);
            this.Controls.Add(this.lblAgeRes);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDVDname);
            this.Controls.Add(this.lblDVDname);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUpdate);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "UpdateDVD";
            this.Text = "UpdateDVD";
            this.Load += new System.EventHandler(this.UpdateDVD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAgeRes;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDVDname;
        private System.Windows.Forms.Label lblDVDname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboRestriction;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
    }
}