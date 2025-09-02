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
    public partial class FormDoktorPanel : Form
    {
        public FormDoktorPanel()
        {
            InitializeComponent();
        }

        private void btnHastaCrud_Click(object sender, EventArgs e)
        {
            FormHastaCrud crudForm = new FormHastaCrud(); // Yeni form nesnesi oluşturuluyor
            crudForm.Show(); // Form gösteriliyor
            this.Close();
        }

        private void btnAylikChart_Click(object sender, EventArgs e)
        {
            FormAylikChart aylikForm = new FormAylikChart();
            aylikForm.Show();
            this.Close();
        }

        private void btnHaftalikChart_Click(object sender, EventArgs e)
        {
            FormHaftalikChart haftalikForm = new FormHaftalikChart();
            haftalikForm.Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FormRolSecim rolSecimFormu = new FormRolSecim(); // Giriş ekranı yeniden açılıyor
            rolSecimFormu.Show(); // Giriş ekranını göster
            this.Close(); // Doktor paneli kapatılıyor
        }
    }
}
