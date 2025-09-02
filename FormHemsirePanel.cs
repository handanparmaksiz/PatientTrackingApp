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

namespace PatientTrackingApp
{
    public partial class FormHemsirePanel : Form
    {
        string connectionString = "Data Source=HastaTakip.db;Version=3;";

        public FormHemsirePanel()
        {
            InitializeComponent();
        }

        private void btnKaydetVeri_Click(object sender, EventArgs e)
        {
            // 1. Giriş kontrolü
            if (cmbHastaSec.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir hasta seçiniz.");
                return;
            }
            try
            {
                // 2. Değerleri al ve dönüştür
                int hastaId = Convert.ToInt32(cmbHastaSec.SelectedValue);
                string tarih = dtpTarih.Value.ToString("yyyy-MM-dd");

                int su = int.Parse(txtSu.Text);
                int tuz = int.Parse(txtTuz.Text);
                int adim = int.Parse(txtAdim.Text);
                float uyku = float.Parse(txtUyku.Text, System.Globalization.CultureInfo.GetCultureInfo("tr-TR"));

                string connectionString = "Data Source=HastaTakip.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // 3. Veri var mı kontrol et
                    string kontrolQuery = "SELECT COUNT(*) FROM GunlukVeri WHERE HastaId = @hastaId AND Tarih = @tarih";

                    using (SQLiteCommand kontrolCmd = new SQLiteCommand(kontrolQuery, connection))
                    {
                        kontrolCmd.Parameters.AddWithValue("@hastaId", hastaId);
                        kontrolCmd.Parameters.AddWithValue("@tarih", tarih);

                        int kayitSayisi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                        if (kayitSayisi > 0)
                        {
                            // 4. UPDATE işlemi
                            string updateQuery = @"UPDATE GunlukVeri 
                                       SET Su = @su, Tuz = @tuz, Adım = @adim, Uyku = @uyku 
                                       WHERE HastaId = @hastaId AND Tarih = @tarih";

                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@su", su);
                                updateCmd.Parameters.AddWithValue("@tuz", tuz);
                                updateCmd.Parameters.AddWithValue("@adim", adim);
                                updateCmd.Parameters.AddWithValue("@uyku", uyku);
                                updateCmd.Parameters.AddWithValue("@hastaId", hastaId);
                                updateCmd.Parameters.AddWithValue("@tarih", tarih);

                                updateCmd.ExecuteNonQuery();
                                MessageBox.Show("Veri güncellendi.");
                            }
                        }
                        else
                        {
                            // 5. INSERT işlemi
                            string insertQuery = @"INSERT INTO GunlukVeri (HastaId, Tarih, Su, Tuz, Adım, Uyku)
                                       VALUES (@hastaId, @tarih, @su, @tuz, @adim, @uyku)";

                            using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@hastaId", hastaId);
                                insertCmd.Parameters.AddWithValue("@tarih", tarih);
                                insertCmd.Parameters.AddWithValue("@su", su);
                                insertCmd.Parameters.AddWithValue("@tuz", tuz);
                                insertCmd.Parameters.AddWithValue("@adim", adim);
                                insertCmd.Parameters.AddWithValue("@uyku", uyku);

                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Veri eklendi.");
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen tüm değerleri doğru formatta (sayı olarak) giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:\n" + ex.Message);
            }
        }

        private void FormHemsirePanel_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HastaTakip.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, Ad || ' ' || Soyad AS AdSoyad FROM Hasta";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            cmbHastaSec.DataSource = table;
                            cmbHastaSec.DisplayMember = "AdSoyad";
                            cmbHastaSec.ValueMember = "Id";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hastalar yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormRolSecim frm = new FormRolSecim();
            frm.Show();
            this.Hide();
        }
    }
}