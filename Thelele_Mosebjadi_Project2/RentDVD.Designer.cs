namespace Thelele_Mosebjadi_Project2
{
    partial class RentDVD
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitRent = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgMovies = new System.Windows.Forms.DataGridView();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtAgeRes = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkExRental = new System.Windows.Forms.CheckBox();
            this.rchInvoice = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExitRentDvd = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.MinimumSize = new System.Drawing.Size(735, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rent a DVD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExitRent
            // 
            this.btnExitRent.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnExitRent.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitRent.Location = new System.Drawing.Point(20, 748);
            this.btnExitRent.Name = "btnExitRent";
            this.btnExitRent.Size = new System.Drawing.Size(192, 32);
            this.btnExitRent.TabIndex = 22;
            this.btnExitRent.Text = "Exit";
            this.btnExitRent.UseVisualStyleBackColor = false;
            this.btnExitRent.Click += new System.EventHandler(this.btnExitRent_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnClear.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(611, 748);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 32);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(125, 50);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(157, 20);
            this.txtMovie.TabIndex = 24;
            this.txtMovie.TextChanged += new System.EventHandler(this.txtMovie_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.MinimumSize = new System.Drawing.Size(100, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Movie Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.MinimumSize = new System.Drawing.Size(100, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Date  :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(125, 94);
            this.dtpDate.MinDate = new System.DateTime(2018, 10, 11, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(157, 20);
            this.dtpDate.TabIndex = 27;
            // 
            // dgMovies
            // 
            this.dgMovies.AllowUserToAddRows = false;
            this.dgMovies.AllowUserToDeleteRows = false;
            this.dgMovies.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovies.Location = new System.Drawing.Point(376, 86);
            this.dgMovies.Name = "dgMovies";
            this.dgMovies.ReadOnly = true;
            this.dgMovies.Size = new System.Drawing.Size(527, 256);
            this.dgMovies.TabIndex = 28;
            this.dgMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMovies_CellClick);
            this.dgMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(420, 60);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(42, 20);
            this.txtDuration.TabIndex = 29;
            // 
            // txtAgeRes
            // 
            this.txtAgeRes.Location = new System.Drawing.Point(586, 61);
            this.txtAgeRes.Name = "txtAgeRes";
            this.txtAgeRes.Size = new System.Drawing.Size(67, 20);
            this.txtAgeRes.TabIndex = 30;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(786, 60);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(117, 20);
            this.txtGenre.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(17, 140);
            this.label5.MinimumSize = new System.Drawing.Size(100, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Price :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(125, 140);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(157, 20);
            this.txtPrice.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(16, 182);
            this.label6.MinimumSize = new System.Drawing.Size(95, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Extended Rental ? :";
            // 
            // chkExRental
            // 
            this.chkExRental.AutoSize = true;
            this.chkExRental.Location = new System.Drawing.Point(125, 181);
            this.chkExRental.Name = "chkExRental";
            this.chkExRental.Size = new System.Drawing.Size(100, 17);
            this.chkExRental.TabIndex = 37;
            this.chkExRental.Text = "Extended rental";
            this.chkExRental.UseVisualStyleBackColor = true;
            // 
            // rchInvoice
            // 
            this.rchInvoice.BackColor = System.Drawing.Color.Bisque;
            this.rchInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchInvoice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rchInvoice.Location = new System.Drawing.Point(15, 450);
            this.rchInvoice.Name = "rchInvoice";
            this.rchInvoice.Size = new System.Drawing.Size(424, 171);
            this.rchInvoice.TabIndex = 38;
            this.rchInvoice.Text = "";
            this.rchInvoice.TextChanged += new System.EventHandler(this.rchInvoice_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(14, 428);
            this.label7.MinimumSize = new System.Drawing.Size(95, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Your Invoice :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(511, 38);
            this.label8.MinimumSize = new System.Drawing.Size(95, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Select Your movie here :";
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGenerateInvoice.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInvoice.Location = new System.Drawing.Point(695, 466);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(208, 32);
            this.btnGenerateInvoice.TabIndex = 42;
            this.btnGenerateInvoice.Text = "Get Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = false;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(17, 361);
            this.label9.MinimumSize = new System.Drawing.Size(95, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(837, 19);
            this.label9.TabIndex = 43;
            this.label9.Text = "_________________________________________________________________________________" +
    "___________";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.CadetBlue;
            this.label10.Location = new System.Drawing.Point(12, 392);
            this.label10.MinimumSize = new System.Drawing.Size(95, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "Generate Invoice  and save your booking";
            // 
            // btnExitRentDvd
            // 
            this.btnExitRentDvd.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExitRentDvd.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitRentDvd.Location = new System.Drawing.Point(695, 589);
            this.btnExitRentDvd.Name = "btnExitRentDvd";
            this.btnExitRentDvd.Size = new System.Drawing.Size(208, 32);
            this.btnExitRentDvd.TabIndex = 45;
            this.btnExitRentDvd.Text = "Exit";
            this.btnExitRentDvd.UseVisualStyleBackColor = false;
            this.btnExitRentDvd.Click += new System.EventHandler(this.btnExitRentDvd_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClearAll.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(695, 515);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(208, 32);
            this.btnClearAll.TabIndex = 46;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(492, 61);
            this.label11.MinimumSize = new System.Drawing.Size(70, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 47;
            this.label11.Text = "Age Restriction :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(344, 63);
            this.label12.MinimumSize = new System.Drawing.Size(70, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 48;
            this.label12.Text = "Duration :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(701, 63);
            this.label13.MinimumSize = new System.Drawing.Size(70, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 18);
            this.label13.TabIndex = 49;
            this.label13.Text = "Genre :";
            // 
            // RentDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(954, 687);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnExitRentDvd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rchInvoice);
            this.Controls.Add(this.chkExRental);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAgeRes);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.dgMovies);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExitRent);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(970, 700);
            this.Name = "RentDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RentDVD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitRent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgMovies;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtAgeRes;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkExRental;
        private System.Windows.Forms.RichTextBox rchInvoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExitRentDvd;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}