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
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using PatientTrackingApp.Helpers;



namespace PatientTrackingApp
{
    public partial class FormHaftalikChart : Form
    {
        public FormHaftalikChart()
        {
            InitializeComponent();
        }

        private void FormHaftalikChart_Load(object sender, EventArgs e)
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

            // Seçilen tarihi al
            DateTime secilenTarih = dtpGunSec.Value;

            // 🔹 1. Hasta bilgilerini label'lara yaz
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=HastaTakip.db;Version=3;"))
            {
                conn.Open();

                string sql = "SELECT Ad, Soyad, Cinsiyet, DogumTarihi, Boy, Kilo FROM Hasta WHERE Id = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", hastaId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string adSoyad = reader["Ad"] + " " + reader["Soyad"];
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            DateTime dogumTarihi = DateTime.Parse(reader["DogumTarihi"].ToString());
                            int boy = reader["Boy"] != DBNull.Value ? Convert.ToInt32(reader["Boy"]) : 0;
                            int kilo = reader["Kilo"] != DBNull.Value ? Convert.ToInt32(reader["Kilo"]) : 0;

                            int yas = DateTime.Now.Year - dogumTarihi.Year;
                            if (DateTime.Now < dogumTarihi.AddYears(yas)) yas--;

                            lblAdSoyad.Text = adSoyad;
                            lblCinsiyet.Text = cinsiyet;
                            lblDogumTarihi.Text = dogumTarihi.ToString("dd.MM.yyyy");
                            lblYas.Text = yas.ToString();
                            lblBoy.Text = boy + " cm";
                            lblKilo.Text = kilo + " kg";
                        }
                    }
                }

                conn.Close();
            }

            // 🔹 2. Haftalık aralık hesaplanır
            int diff = (7 + (secilenTarih.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime haftaninIlkGunu = secilenTarih.AddDays(-1 * diff).Date;

            // 🔹 3. Grafikler temizlenir
            chartSu.Series["seriesSu"].Points.Clear();
            chartTuz.Series["seriesTuz"].Points.Clear();
            chartAdim.Series["seriesAdim"].Points.Clear();
            chartUyku.Series["seriesUyku"].Points.Clear();

            // 🔹 4. 7 Günlük veriler çizilir
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=HastaTakip.db;Version=3;"))
            {
                conn.Open();

                for (int i = 0; i < 7; i++)
                {
                    DateTime gun = haftaninIlkGunu.AddDays(i);
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

                            string xDegeri = gun.ToString("dd.MM");

                            chartSu.Series["seriesSu"].Points.AddXY(xDegeri, su);
                            chartTuz.Series["seriesTuz"].Points.AddXY(xDegeri, tuz);
                            chartAdim.Series["seriesAdim"].Points.AddXY(xDegeri, Adım);
                            chartUyku.Series["seriesUyku"].Points.AddXY(xDegeri, uyku);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
