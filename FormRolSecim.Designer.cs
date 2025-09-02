namespace PatientTrackingApp
{
    partial class FormRolSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRolSecim));
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pbDoktor = new System.Windows.Forms.PictureBox();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnHemsire = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(122, 35);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(569, 36);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Lütfen Kim Olarak Giriş Yapacağınızı Seçin";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // pbDoktor
            // 
            this.pbDoktor.Image = ((System.Drawing.Image)(resources.GetObject("pbDoktor.Image")));
            this.pbDoktor.Location = new System.Drawing.Point(160, 161);
            this.pbDoktor.Name = "pbDoktor";
            this.pbDoktor.Size = new System.Drawing.Size(122, 121);
            this.pbDoktor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoktor.TabIndex = 1;
            this.pbDoktor.TabStop = false;
            // 
            // btnDoktor
            // 
            this.btnDoktor.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoktor.Location = new System.Drawing.Point(160, 309);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(110, 47);
            this.btnDoktor.TabIndex = 3;
            this.btnDoktor.Text = "Doktor Girişi";
            this.btnDoktor.UseVisualStyleBackColor = true;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // btnHemsire
            // 
            this.btnHemsire.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHemsire.Location = new System.Drawing.Point(522, 309);
            this.btnHemsire.Name = "btnHemsire";
            this.btnHemsire.Size = new System.Drawing.Size(110, 47);
            this.btnHemsire.TabIndex = 4;
            this.btnHemsire.Text = "Hemşire Girişi";
            this.btnHemsire.UseVisualStyleBackColor = true;
            this.btnHemsire.Click += new System.EventHandler(this.btnHemsire_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormRolSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHemsire);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.pbDoktor);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRolSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol Seçimi";
            this.Load += new System.EventHandler(this.FormRolSecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.PictureBox pbDoktor;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnHemsire;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

