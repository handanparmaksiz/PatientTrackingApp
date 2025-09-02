namespace PatientTrackingApp
{
    partial class FormAylikChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAylikChart));
            this.btnVerileriGoster = new System.Windows.Forms.Button();
            this.chartUyku = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAdim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTuz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpAySec = new System.Windows.Forms.DateTimePicker();
            this.lblTarihSec = new System.Windows.Forms.Label();
            this.cmbHastalar = new System.Windows.Forms.ComboBox();
            this.lblHastaSec = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartUyku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAdim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerileriGoster
            // 
            this.btnVerileriGoster.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerileriGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerileriGoster.Location = new System.Drawing.Point(491, 141);
            this.btnVerileriGoster.Name = "btnVerileriGoster";
            this.btnVerileriGoster.Size = new System.Drawing.Size(123, 43);
            this.btnVerileriGoster.TabIndex = 29;
            this.btnVerileriGoster.Text = "Verileri Göster";
            this.btnVerileriGoster.UseVisualStyleBackColor = false;
            this.btnVerileriGoster.Click += new System.EventHandler(this.btnVerileriGoster_Click);
            // 
            // chartUyku
            // 
            this.chartUyku.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea5.AxisX.Title = "Tarih";
            chartArea5.AxisY.Title = "Saat";
            chartArea5.Name = "areaUyku ";
            this.chartUyku.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartUyku.Legends.Add(legend5);
            this.chartUyku.Location = new System.Drawing.Point(507, 474);
            this.chartUyku.Name = "chartUyku";
            series5.ChartArea = "areaUyku ";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "seriesUyku";
            this.chartUyku.Series.Add(series5);
            this.chartUyku.Size = new System.Drawing.Size(350, 250);
            this.chartUyku.TabIndex = 28;
            this.chartUyku.Text = "chart2";
            title5.Name = "Title1";
            title5.Text = "Uyku Süresi";
            this.chartUyku.Titles.Add(title5);
            // 
            // chartAdim
            // 
            this.chartAdim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea6.AxisX.Title = "Tarih";
            chartArea6.AxisY.Title = "Adım";
            chartArea6.IsSameFontSizeForAllAxes = true;
            chartArea6.Name = "areaAdim";
            this.chartAdim.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartAdim.Legends.Add(legend6);
            this.chartAdim.Location = new System.Drawing.Point(71, 474);
            this.chartAdim.Name = "chartAdim";
            series6.ChartArea = "areaAdim";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "seriesAdim";
            this.chartAdim.Series.Add(series6);
            this.chartAdim.Size = new System.Drawing.Size(350, 250);
            this.chartAdim.TabIndex = 27;
            this.chartAdim.Text = "chart1";
            title6.Name = "Title1";
            title6.Text = "Adım Sayısı";
            this.chartAdim.Titles.Add(title6);
            // 
            // chartTuz
            // 
            this.chartTuz.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea7.AxisX.Title = "Tarih";
            chartArea7.AxisY.Title = "mg";
            chartArea7.Name = "areaTuz";
            this.chartTuz.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartTuz.Legends.Add(legend7);
            this.chartTuz.Location = new System.Drawing.Point(507, 205);
            this.chartTuz.Name = "chartTuz";
            series7.ChartArea = "areaTuz";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "seriesTuz";
            this.chartTuz.Series.Add(series7);
            this.chartTuz.Size = new System.Drawing.Size(350, 250);
            this.chartTuz.TabIndex = 26;
            this.chartTuz.Text = "chart1";
            title7.Name = "Title1";
            title7.Text = "Tuz Tüketimi (mg)";
            this.chartTuz.Titles.Add(title7);
            // 
            // chartSu
            // 
            this.chartSu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea8.AxisX.Title = "Tarih";
            chartArea8.AxisY.Title = "ml";
            chartArea8.Name = "areaSu";
            this.chartSu.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartSu.Legends.Add(legend8);
            this.chartSu.Location = new System.Drawing.Point(71, 205);
            this.chartSu.Name = "chartSu";
            series8.ChartArea = "areaSu";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "seriesSu";
            this.chartSu.Series.Add(series8);
            this.chartSu.Size = new System.Drawing.Size(350, 250);
            this.chartSu.TabIndex = 25;
            this.chartSu.Text = "Su Tüketimi";
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Title1";
            title8.Text = "Su Tüketimi (ml)";
            this.chartSu.Titles.Add(title8);
            // 
            // dtpAySec
            // 
            this.dtpAySec.Location = new System.Drawing.Point(261, 149);
            this.dtpAySec.Name = "dtpAySec";
            this.dtpAySec.Size = new System.Drawing.Size(200, 22);
            this.dtpAySec.TabIndex = 24;
            // 
            // lblTarihSec
            // 
            this.lblTarihSec.AutoSize = true;
            this.lblTarihSec.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarihSec.Location = new System.Drawing.Point(103, 149);
            this.lblTarihSec.Name = "lblTarihSec";
            this.lblTarihSec.Size = new System.Drawing.Size(121, 24);
            this.lblTarihSec.TabIndex = 23;
            this.lblTarihSec.Text = "Tarih Seçiniz:";
            // 
            // cmbHastalar
            // 
            this.cmbHastalar.FormattingEnabled = true;
            this.cmbHastalar.Location = new System.Drawing.Point(261, 105);
            this.cmbHastalar.Name = "cmbHastalar";
            this.cmbHastalar.Size = new System.Drawing.Size(121, 24);
            this.cmbHastalar.TabIndex = 22;
            // 
            // lblHastaSec
            // 
            this.lblHastaSec.AutoSize = true;
            this.lblHastaSec.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaSec.Location = new System.Drawing.Point(104, 107);
            this.lblHastaSec.Name = "lblHastaSec";
            this.lblHastaSec.Size = new System.Drawing.Size(113, 24);
            this.lblHastaSec.TabIndex = 21;
            this.lblHastaSec.Text = "İsim Seçiniz:";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKilo.Location = new System.Drawing.Point(503, 67);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(0, 20);
            this.lblKilo.TabIndex = 20;
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBoy.Location = new System.Drawing.Point(343, 67);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(0, 20);
            this.lblBoy.TabIndex = 19;
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblYas.Location = new System.Drawing.Point(193, 67);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(0, 20);
            this.lblYas.TabIndex = 18;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogumTarihi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDogumTarihi.Location = new System.Drawing.Point(444, 28);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(0, 20);
            this.lblDogumTarihi.TabIndex = 17;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinsiyet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCinsiyet.Location = new System.Drawing.Point(266, 28);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(0, 20);
            this.lblCinsiyet.TabIndex = 16;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdSoyad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdSoyad.Location = new System.Drawing.Point(67, 28);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 20);
            this.lblAdSoyad.TabIndex = 15;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Location = new System.Drawing.Point(641, 141);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(118, 43);
            this.btnGeri.TabIndex = 30;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(919, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormAylikChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(924, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnVerileriGoster);
            this.Controls.Add(this.chartUyku);
            this.Controls.Add(this.chartAdim);
            this.Controls.Add(this.chartTuz);
            this.Controls.Add(this.chartSu);
            this.Controls.Add(this.dtpAySec);
            this.Controls.Add(this.lblTarihSec);
            this.Controls.Add(this.cmbHastalar);
            this.Controls.Add(this.lblHastaSec);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblAdSoyad);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormAylikChart";
            this.Text = "FormAylikChart";
            this.Load += new System.EventHandler(this.FormAylikChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUyku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAdim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerileriGoster;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUyku;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAdim;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTuz;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSu;
        private System.Windows.Forms.DateTimePicker dtpAySec;
        private System.Windows.Forms.Label lblTarihSec;
        private System.Windows.Forms.ComboBox cmbHastalar;
        private System.Windows.Forms.Label lblHastaSec;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label1;
    }
}