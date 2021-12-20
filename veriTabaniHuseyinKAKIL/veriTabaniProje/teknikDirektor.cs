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
    public partial class teknikDirektor : Form
    {
        public teknikDirektor()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void teknikDirektor_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from sehir", baglanti);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from takim", baglanti);
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);

            cmbteknikDirektorDyeri.DisplayMember = "isim";
            cmbteknikDirektorDyeri.ValueMember = "id";
            cmbteknikDirektorDyeri.DataSource = dt;


            cmbteknikDirektorTakim.DisplayMember = "ad";
            cmbteknikDirektorTakim.ValueMember = "id";
            cmbteknikDirektorTakim.DataSource = dt2;

            baglanti.Close();
        }

        private void btnteknikDirektorEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into teknikdirektor(id,ad,takimid,dyeri,dtarihi) values(@id,@ad,@takimid,@dyeri,@dtarihi)", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtteknikDirektorId.Text));
            komut.Parameters.AddWithValue("@ad", txtteknikDirektorAdSoyad.Text);
            komut.Parameters.AddWithValue("@takimid", int.Parse(cmbteknikDirektorTakim.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@dyeri", int.Parse(cmbteknikDirektorDyeri.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@dtarihi", dtpteknikDirektorDtarihi.Value);
            komut.ExecuteNonQuery();
            MessageBox.Show("Teknik Direktör Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnteknikDirektorGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update teknikdirektor set takimid=@takimid where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtteknikDirektorId.Text));
            komut.Parameters.AddWithValue("@takimid", int.Parse(cmbteknikDirektorTakim.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Teknik Direktor Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnteknikDirektorSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from teknikdirektor where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtteknikDirektorId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Teknik Direktör Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnteknikDirektorListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select teknikdirektor.id,teknikdirektor.ad,sehir.isim as dogum_yeri,dtarihi as Dogum_tarihi,takim.ad as takım from teknikdirektor inner join takim on teknikdirektor.takimid=takim.id inner join sehir on teknikdirektor.dyeri=sehir.id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwteknikDirektorListe.DataSource = ds.Tables[0];
            dgwteknikDirektorListe.Columns[3].Width = 80;
            dgwteknikDirektorListe.Columns[4].Width = 50;
        }
    }
}
