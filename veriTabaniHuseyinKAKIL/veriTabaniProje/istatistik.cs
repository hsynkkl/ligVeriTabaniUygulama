using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace veriTabaniProje
{
    public partial class istatistik : Form
    {
        public istatistik()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void istatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from futbolcu", baglanti);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
           
            cmbistatistikFutbolcuId.DisplayMember = "ad";
            cmbistatistikFutbolcuId.ValueMember = "id";
            cmbistatistikFutbolcuId.DataSource = dt;

            
            baglanti.Close();
        }
        private void btnistatistikGolSayisi_Click(object sender, EventArgs e)
        {
            int i = int.Parse(cmbistatistikFutbolcuId.SelectedValue.ToString());
            string sorgu = "select futbolcuToplamGol(" +i+")";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwistatistikListe.DataSource = ds.Tables[0];
        }

        private void btnistatistikAsistSayisi_Click(object sender, EventArgs e)
        {
            int i = int.Parse(cmbistatistikFutbolcuId.SelectedValue.ToString());
            string sorgu = "select futbolcuToplamAsist(" + i + ")";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwistatistikListe.DataSource = ds.Tables[0];
        }

        private void btnistatistikToplamGoleKatki_Click(object sender, EventArgs e)
        {
            int i = int.Parse(cmbistatistikFutbolcuId.SelectedValue.ToString());
            string sorgu = "select futbolcuToplamGoleKatki(" + i + ")";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwistatistikListe.DataSource = ds.Tables[0];
        }

        private void btnistatistikKirmiziKartSayisi_Click(object sender, EventArgs e)
        {
            int i = int.Parse(cmbistatistikFutbolcuId.SelectedValue.ToString());
            string sorgu = "select futbolcuToplamKirmiziKart(" + i + ")";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwistatistikListe.DataSource = ds.Tables[0];
        }

        private void btnistatistikSariKartSayisi_Click(object sender, EventArgs e)
        {
            int i = int.Parse(cmbistatistikFutbolcuId.SelectedValue.ToString());
            string sorgu = "select futbolcuToplamSariKart(" + i + ")";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwistatistikListe.DataSource = ds.Tables[0];
        }

        private void btnistatistikFutbolcuSayisi_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from  futbolcusayi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwistatistikListe.DataSource = ds.Tables[0];
        }

        private void btnistatistikTakimSayisi_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from takimsayi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwistatistikListe.DataSource = ds.Tables[0];
        }

        private void btnistatistikHakemSayisi_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from hakemsayi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwistatistikListe.DataSource = ds.Tables[0];
        }
    }
}
