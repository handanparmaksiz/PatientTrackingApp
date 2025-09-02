using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientTrackingApp
{
    public partial class FormDoktorGiris : Form
    {
        public FormDoktorGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre TextBox'lardan alınır
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            // Doktorun sabit kullanıcı adı ve şifresi
            string dogruKullaniciAdi = "doktor";
            string dogruSifre = "1234";

            // Giriş doğrulama kontrolü
            if (kullaniciAdi == dogruKullaniciAdi && sifre == dogruSifre)
            {
                // Giriş başarılıysa doktor paneline yönlendir
                FormDoktorPanel doktorPanel = new FormDoktorPanel();
                doktorPanel.Show();

                this.Hide(); // Giriş formunu gizle
            }
            else
            {
                // Hatalı giriş uyarısı
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox işaretliyse şifre görünür, değilse gizli gösterilir
            txtSifre.UseSystemPasswordChar = !chkSifreyiGoster.Checked;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            // Yeni rol seçme formu oluşturuluyor
            FormRolSecim rolSecim = new FormRolSecim();

            // Yeni form gösteriliyor
            rolSecim.Show();

            // Bu form gizleniyor
            this.Hide();
        }
    }
}
