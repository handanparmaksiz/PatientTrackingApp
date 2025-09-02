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
    public partial class FormRolSecim : Form
    {
        public FormRolSecim()
        {
            InitializeComponent();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            // Doktor giriş formunu aç
            FormDoktorGiris doktorGirisForm = new FormDoktorGiris();
            doktorGirisForm.Show();

            // Mevcut formu gizle (isteğe bağlı)
            this.Hide();
        }

        private void btnHemsire_Click(object sender, EventArgs e)
        {
            FormHemsireGiris hemsireGirisForm = new FormHemsireGiris();
            hemsireGirisForm.Show();

            
            this.Hide();
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void FormRolSecim_Load(object sender, EventArgs e)
        {

        }
    }
}
