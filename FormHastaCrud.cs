using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace PatientTrackingApp
{
    public partial class FormHastaCrud : Form
    {
        int seciliHastaId = -1;

        private void TemizleForm()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtBoy.Clear();
            txtKilo.Clear();
            cmbCinsiyet.SelectedIndex = -1;
            dtpDogumTarihi.Value = DateTime.Today;
        }

        private void HastalariYukle()
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HastaTakip.db;Version=3;"))
            {
                con.Open();

                string query = "SELECT * FROM Hasta";

                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHastalar.DataSource = dt;
                }

                con.Close();
            }
        }

        public FormHastaCrud()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // 1. Kullanıcıdan verileri al
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string cinsiyet = cmbCinsiyet.SelectedItem?.ToString();
            string dogumTarihi = dtpDogumTarihi.Value.ToString("yyyy-MM-dd");
            string telefon = txtTelefon.Text.Trim();
            string kayitTarihi = DateTime.Now.ToString("yyyy-MM-dd");

            // 2. Gerekli alanları kontrol et
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(cinsiyet))
            {
                MessageBox.Show("Lütfen Ad, Soyad ve Cinsiyet alanlarını doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Veritabanına ekleme işlemi
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=HastaTakip.db;Version=3;"))
                {
                    con.Open();

                    string query = "INSERT INTO Hasta (Ad, Soyad, Cinsiyet, DogumTarihi, Telefon, KayitTarihi) " +
                                   "VALUES (@Ad, @Soyad, @Cinsiyet, @DogumTarihi, @Telefon, @KayitTarihi)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                        cmd.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);

                        // Eğer telefon boşsa null olarak ekle
                        if (string.IsNullOrWhiteSpace(telefon))
                            cmd.Parameters.AddWithValue("@Telefon", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Telefon", telefon);

                        cmd.Parameters.AddWithValue("@KayitTarihi", kayitTarihi);

                        cmd.ExecuteNonQuery();
                    }

                    con.Close();
                }

                MessageBox.Show("Hasta başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                txtAd.Clear();
                txtSoyad.Clear();
                txtTelefon.Clear();
                cmbCinsiyet.SelectedIndex = -1;
                dtpDogumTarihi.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormDoktorPanel doktorPanel = new FormDoktorPanel();
            doktorPanel.Show();
            this.Close(); // 
        }

        private void dgvHastalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer tıklanan satır geçerliyse (başlık satırı değilse)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dgvHastalar.Rows[e.RowIndex];

                // Satırdaki hücrelerden form kontrollerine değer aktar
                txtAd.Text = satir.Cells["Ad"].Value?.ToString();
                txtSoyad.Text = satir.Cells["Soyad"].Value?.ToString();
                cmbCinsiyet.Text = satir.Cells["Cinsiyet"].Value?.ToString();
                dtpDogumTarihi.Value = Convert.ToDateTime(satir.Cells["DogumTarihi"].Value);
                txtTelefon.Text = satir.Cells["Telefon"].Value?.ToString();
                txtBoy.Text = satir.Cells["Boy"].Value?.ToString();
                txtKilo.Text = satir.Cells["Kilo"].Value?.ToString();

                // Seçilen hastayı güncelleme veya silme işleminde kullanmak için ID saklayabilirsin
                seciliHastaId = Convert.ToInt32(satir.Cells["Id"].Value); // Eğer Id sütunun varsa
            }   
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // 1. Seçili bir hasta var mı kontrol et
            if (seciliHastaId == -1)
            {
                MessageBox.Show("Lütfen güncellenecek bir hastayı listeden seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Formdan verileri al
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string cinsiyet = cmbCinsiyet.SelectedItem?.ToString();
            string dogumTarihi = dtpDogumTarihi.Value.ToString("yyyy-MM-dd");
            string telefon = txtTelefon.Text.Trim();
            string boy = txtBoy.Text.Trim();
            string kilo = txtKilo.Text.Trim();

            // 3. Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(cinsiyet))
            {
                MessageBox.Show("Lütfen Ad, Soyad ve Cinsiyet alanlarını doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=HastaTakip.db;Version=3;"))
                {
                    con.Open();

                    string query = "UPDATE Hasta SET Ad = @Ad, Soyad = @Soyad, Cinsiyet = @Cinsiyet, " +
                                   "DogumTarihi = @DogumTarihi, Telefon = @Telefon, Boy = @Boy, Kilo = @Kilo " +
                                   "WHERE Id = @Id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                        cmd.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                        cmd.Parameters.AddWithValue("@Telefon", string.IsNullOrWhiteSpace(telefon) ? DBNull.Value : (object)telefon);
                        cmd.Parameters.AddWithValue("@Boy", boy);
                        cmd.Parameters.AddWithValue("@Kilo", kilo);
                        cmd.Parameters.AddWithValue("@Id", seciliHastaId);

                        cmd.ExecuteNonQuery();
                    }

                    con.Close();
                }

                MessageBox.Show("Hasta bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Alanları temizle ve listeyi yenile
                TemizleForm();
                seciliHastaId = -1;
                HastalariYukle(); // dgvHastalar'ı yeniden doldur

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormHastaCrud_Load(object sender, EventArgs e)
        {
            HastalariYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliHastaId != -1)
            {
                DialogResult sonuc = MessageBox.Show("Bu hastayı silmek istediğinizden emin misiniz?", "Hasta Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    VeritabaniHelper.HastaSil(seciliHastaId);

                    MessageBox.Show("Hasta başarıyla silindi.", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Güncel listeyi yeniden yükle
                    HastalariYukle();

                    // Formdaki alanları temizle
                    txtAd.Clear();
                    txtSoyad.Clear();
                    cmbCinsiyet.SelectedIndex = -1;
                    dtpDogumTarihi.Value = DateTime.Now;
                    txtTelefon.Clear();
                    txtBoy.Clear();
                    txtKilo.Clear();

                    // Seçili hasta id'sini sıfırla
                    seciliHastaId = -1;
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce listeden bir hasta seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }

