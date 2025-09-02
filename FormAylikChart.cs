using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientTrackingApp.Helpers;

namespace PatientTrackingApp
{
    public partial class FormAylikChart : Form
    {
        public FormAylikChart()
        {
            InitializeComponent();
        }

        private void FormAylikChart_Load(object sender, EventArgs e)
        {
            cmbHastalar.Items.Clear();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=HastaTakip.db;Version=3;"))
            {
                conn.Open();

                string sql = "SELECT Id, Ad || ' ' || Soyad AS AdSoyad FROM Hasta";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbHastalar.Items.Add(new ComboBoxItem
                            {
                                Text = reader["AdSoyad"].ToString(),
                                Value = Convert.ToInt32(reader["Id"])
                            });
                        }
                    }
                }

                conn.Close();
            }

            if (cmbHastalar.Items.Count > 0)
                cmbHastalar.SelectedIndex = 0;
        }

        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            if (cmbHastalar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir hasta seçiniz.");
                return;
            }

            if (!(cmbHastalar.SelectedItem is ComboBoxItem selectedHasta))
                return;

            int hastaId = selectedHasta.Value;

            DateTime secilenAy = dtpAySec.Value;
            DateTime ayBaslangic = new DateTime(secilenAy.Year, secilenAy.Month, 1);
            DateTime ayBitis = ayBaslangic.AddMonths(1).AddDays(-1);

            // Grafiklerin verileri temizleniyor
            chartSu.Series["seriesSu"].Points.Clear();
            chartTuz.Series["seriesTuz"].Points.Clear();
            chartAdim.Series["seriesAdim"].Points.Clear();
            chartUyku.Series["seriesUyku"].Points.Clear();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=HastaTakip.db;Version=3;"))
            {
                conn.Open();

                // Hasta bilgilerini al
                string hastaSql = "SELECT Ad, Soyad, Cinsiyet, DogumTarihi, Boy, Kilo FROM Hasta WHERE Id = @Id";
                using (SQLiteCommand cmd = new SQLiteCommand(hastaSql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", hastaId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string adSoyad = reader["Ad"] + " " + reader["Soyad"];
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            DateTime dogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]);
                            int yas = DateTime.Now.Year - dogumTarihi.Year;
                            if (DateTime.Now.DayOfYear < dogumTarihi.DayOfYear) yas--;

                            int boy = reader["Boy"] != DBNull.Value ? Convert.ToInt32(reader["Boy"]) : 0;
                            int kilo = reader["Kilo"] != DBNull.Value ? Convert.ToInt32(reader["Kilo"]) : 0;

                            lblAdSoyad.Text = adSoyad;
                            lblCinsiyet.Text = cinsiyet;
                            lblDogumTarihi.Text = dogumTarihi.ToShortDateString();
                            lblYas.Text = yas.ToString();
                            lblBoy.Text = boy.ToString();
                            lblKilo.Text = kilo.ToString();
                        }
                    }
                }

                // 1–30 (veya 31) gün arası için her günün verisi çekilir
                for (DateTime gun = ayBaslangic; gun <= ayBitis; gun = gun.AddDays(1))
                {
                    string tarihStr = gun.ToString("yyyy-MM-dd");

                    string sql = "SELECT Su, Tuz, Adım, Uyku FROM GunlukVeri WHERE HastaId = @HastaId AND Tarih = @Tarih";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@HastaId", hastaId);
                        cmd.Parameters.AddWithValue("@Tarih", tarihStr);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            int su = 0, tuz = 0, Adım = 0;
                            double uyku = 0;

                            if (reader.Read())
                            {
                                su = reader["Su"] != DBNull.Value ? Convert.ToInt32(reader["Su"]) : 0;
                                tuz = reader["Tuz"] != DBNull.Value ? Convert.ToInt32(reader["Tuz"]) : 0;
                                Adım = reader["Adım"] != DBNull.Value ? Convert.ToInt32(reader["Adım"]) : 0;
                                uyku = reader["Uyku"] != DBNull.Value ? Convert.ToDouble(reader["Uyku"]) : 0;
                            }

                            string gunStr = gun.ToString("dd");

                            chartSu.Series["seriesSu"].Points.AddXY(gunStr, su);
                            chartTuz.Series["seriesTuz"].Points.AddXY(gunStr, tuz);
                            chartAdim.Series["seriesAdim"].Points.AddXY(gunStr, Adım);
                            chartUyku.Series["seriesUyku"].Points.AddXY(gunStr, uyku);
                        }
                    }
                }

                conn.Close();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormDoktorPanel doktorPanel = new FormDoktorPanel();
            doktorPanel.Show();
            this.Close(); // 
        }
    }
}