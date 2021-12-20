using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriTabaniProje
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void ekleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnanaFormKulupBaskani_Click(object sender, EventArgs e)
        {
            kulupBaskani kulupBaskani = new kulupBaskani();
            kulupBaskani.Show();
        }

        private void btnanaFormLigYoneticisi_Click(object sender, EventArgs e)
        {
            ligYoneticisi ligYoneticisi = new ligYoneticisi();
            ligYoneticisi.Show();
        }

        private void btnanaFormTakim_Click(object sender, EventArgs e)
        {
            takim takim = new takim();
            takim.Show();
        }

        private void btnanaFormFutbolcu_Click(object sender, EventArgs e)
        {
            futbolcu futbolcu = new futbolcu();
            futbolcu.Show();
        }

        private void btnanaFormTenikDirekor_Click(object sender, EventArgs e)
        {
            teknikDirektor teknikDirektor = new teknikDirektor();
            teknikDirektor.Show();
        }

        private void btnanaFormHakem_Click(object sender, EventArgs e)
        {
            hakem hakem = new hakem();
            hakem.Show();
        }

        private void btnanaFormStadyum_Click(object sender, EventArgs e)
        {
            stadyum stadyum = new stadyum();
            stadyum.Show();
        }

        private void btnanaFormKupa_Click(object sender, EventArgs e)
        {
            kupa kupa = new kupa();
            kupa.Show();
        }

        private void btnanaFormMac_Click(object sender, EventArgs e)
        {
            mac mac = new mac();
            mac.Show();
        }

        private void btnanaFormGol_Click(object sender, EventArgs e)
        {
            gol gol = new gol();
            gol.Show();
        }

        private void btnanaFormAsist_Click(object sender, EventArgs e)
        {
            asist asist = new asist();
            asist.Show();
        }

        private void btnanaFormKart_Click(object sender, EventArgs e)
        {
            kart kart = new kart();
            kart.Show();
        }

        private void btnanaFormRekor_Click(object sender, EventArgs e)
        {
            rekor rekor = new rekor();
            rekor.Show();
        }

        private void btnanaFormSehir_Click(object sender, EventArgs e)
        {
            sehir sehir = new sehir();
            sehir.Show();
        }

        private void btnanaFormIstatistikler_Click(object sender, EventArgs e)
        {
            istatistik istatistik = new istatistik();
            istatistik.Show();
        }

        private void btnanaFormArama_Click(object sender, EventArgs e)
        {
            arama arama = new arama();
            arama.Show();
        }
    }
}
