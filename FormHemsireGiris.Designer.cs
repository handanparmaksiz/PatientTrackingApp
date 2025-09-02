namespace PatientTrackingApp
{
    partial class FormHemsireGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHemsireGiris));
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtHemsireKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtHemsireSifre = new System.Windows.Forms.TextBox();
            this.cbSifreGoster = new System.Windows.Forms.CheckBox();
            this.btnHemsireGiris = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(209, 237);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(112, 23);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txtHemsireKullaniciAdi
            // 
            this.txtHemsireKullaniciAdi.Location = new System.Drawing.Point(342, 237);
            this.txtHemsireKullaniciAdi.Name = "txtHemsireKullaniciAdi";
            this.txtHemsireKullaniciAdi.Size = new System.Drawing.Size(100, 22);
            this.txtHemsireKullaniciAdi.TabIndex = 1;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(209, 290);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(47, 23);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre";
            // 
            // txtHemsireSifre
            // 
            this.txtHemsireSifre.Location = new System.Drawing.Point(342, 287);
            this.txtHemsireSifre.Name = "txtHemsireSifre";
            this.txtHemsireSifre.PasswordChar = '*';
            this.txtHemsireSifre.Size = new System.Drawing.Size(100, 22);
            this.txtHemsireSifre.TabIndex = 3;
            // 
            // cbSifreGoster
            // 
            this.cbSifreGoster.AutoSize = true;
            this.cbSifreGoster.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSifreGoster.Location = new System.Drawing.Point(469, 289);
            this.cbSifreGoster.Name = "cbSifreGoster";
            this.cbSifreGoster.Size = new System.Drawing.Size(142, 27);
            this.cbSifreGoster.TabIndex = 4;
            this.cbSifreGoster.Text = "Şifreyi Göster\n";
            this.cbSifreGoster.UseVisualStyleBackColor = true;
            this.cbSifreGoster.CheckedChanged += new System.EventHandler(this.cbSifreGoster_CheckedChanged);
            // 
            // btnHemsireGiris
            // 
            this.btnHemsireGiris.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHemsireGiris.Location = new System.Drawing.Point(248, 352);
            this.btnHemsireGiris.Name = "btnHemsireGiris";
            this.btnHemsireGiris.Size = new System.Drawing.Size(92, 39);
            this.btnHemsireGiris.TabIndex = 5;
            this.btnHemsireGiris.Text = "Giriş Yap\n\n";
            this.btnHemsireGiris.UseVisualStyleBackColor = true;
            this.btnHemsireGiris.Click += new System.EventHandler(this.btnHemsireGiris_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Location = new System.Drawing.Point(398, 352);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(80, 39);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(334, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormHemsireGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnHemsireGiris);
            this.Controls.Add(this.cbSifreGoster);
            this.Controls.Add(this.txtHemsireSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtHemsireKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormHemsireGiris";
            this.Text = "FormHemsireGiris";
            this.Load += new System.EventHandler(this.FormHemsireGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtHemsireKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtHemsireSifre;
        private System.Windows.Forms.CheckBox cbSifreGoster;
        private System.Windows.Forms.Button btnHemsireGiris;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}