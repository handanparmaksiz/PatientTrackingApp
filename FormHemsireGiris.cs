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
    public partial class FormHemsireGiris : Form
    {
        public FormHemsireGiris()
        {
            InitializeComponent();
        }

        private void btnHemsireGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtHemsireKullaniciAdi.Text;
            string sifre = txtHemsireSifre.Text;

            if (kullaniciAdi == "hemsire" && sifre == "1234")
            {
                FormHemsirePanel hemsirePanel = new FormHemsirePanel();
                hemsirePanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreGoster.Checked)
            {
                txtHemsireSifre.PasswordChar = '\0'; // Şifreyi göster
            }
            else
            {
                txtHemsireSifre.PasswordChar = '*'; // Şifreyi gizle
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormRolSecim rolSecimForm = new FormRolSecim();
            rolSecimForm.Show();
            this.Hide();
        }

        private void FormHemsireGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
