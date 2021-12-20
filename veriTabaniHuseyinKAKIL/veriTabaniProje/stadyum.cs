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
    public partial class stadyum : Form
    {
        public stadyum()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void stadyum_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from sehir", baglanti);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from takim", baglanti);
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);

            cmbstadyumSehir.DisplayMember = "isim";
            cmbstadyumSehir.ValueMember = "id";
            cmbstadyumSehir.DataSource = dt;


            cmbstadyumTakim.DisplayMember = "ad";
            cmbstadyumTakim.ValueMember = "id";
            cmbstadyumTakim.DataSource = dt2;

            baglanti.Close();
        }

        private void btnstadyumEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into stadyum(id,ad,takimid,sehirid,yapimyili) values(@id,@ad,@takimid,@sehirid,@yapimyili)", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtstadyumId.Text));
            komut.Parameters.AddWithValue("@ad", txtstadyumIsim.Text);
            komut.Parameters.AddWithValue("@takimid", int.Parse(cmbstadyumTakim.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@sehirid", int.Parse(cmbstadyumSehir.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@yapimyili", dtpstadyumYapimYili.Value);
            komut.ExecuteNonQuery();
            MessageBox.Show("Stadyum Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnstadyumListele_Click(object sender, EventArgs e)                                                                                                                    //
        {
            string sorgu = "select stadyum.id,stadyum.ad,sehir.isim as sehir_isim,stadyum.yapimyili as YapımYılı,takim.ad as Takım from stadyum inner join takim on stadyum.takimid=takim.id inner join sehir on stadyum.sehirid=sehir.id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwstadyumListe.DataSource = ds.Tables[0];
            dgwstadyumListe.Columns[0].Width = 30;
            dgwstadyumListe.Columns[1].Width = 80;
            dgwstadyumListe.Columns[2].Width = 30;
            dgwstadyumListe.Columns[3].Width = 50;
            dgwstadyumListe.Columns[4].Width = 50;
        }

        private void btnstadyumSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from stadyum where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtstadyumId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Stadyum Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnstadyumGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update stadyum set takimid=@takimid,ad=@ad where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtstadyumId.Text));
            komut.Parameters.AddWithValue("@ad", txtstadyumIsim.Text);
            komut.Parameters.AddWithValue("@takimid", int.Parse(cmbstadyumTakim.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Stadyum Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
