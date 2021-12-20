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
    public partial class kulupBaskani : Form
    {
        public kulupBaskani()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");

        private void btnkulupBaskaniEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into baskan(id,ad,takimid,dyeri,dtarihi) values(@id,@ad,@takimid,@dyeri,@dtarihi)", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtkulupBaskaniId.Text));
            komut.Parameters.AddWithValue("@ad", txtkulupBaskaniAdSoyad.Text);
            komut.Parameters.AddWithValue("@takimid", int.Parse(cmbkulupBaskaniTakim.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@dyeri", int.Parse(cmbkulupBaskaniDyeri.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@dtarihi", dtpkulupBaskaniDtarihi.Value);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başkan Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void kulupBaskani_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from sehir", baglanti);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from takim", baglanti);
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);

            cmbkulupBaskaniDyeri.DisplayMember = "isim";
            cmbkulupBaskaniDyeri.ValueMember = "id";
            cmbkulupBaskaniDyeri.DataSource = dt;


            cmbkulupBaskaniTakim.DisplayMember = "ad";
            cmbkulupBaskaniTakim.ValueMember = "id";
            cmbkulupBaskaniTakim.DataSource = dt2;

            baglanti.Close();
        }

        private void btnkulupBaskaniSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from baskan where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtkulupBaskaniId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Başkan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnkulupBaskaniGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update baskan set takimid=@takimid where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtkulupBaskaniId.Text));
            komut.Parameters.AddWithValue("@takimid", int.Parse(cmbkulupBaskaniTakim.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Başkan Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnkulupBaskaniListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select baskan.id,baskan.ad,sehir.isim as dogum_yeri,dtarihi as Dogum_tarihi,takim.ad as takim_ad from baskan inner join takim on baskan.takimid=takim.id inner join sehir on baskan.dyeri=sehir.id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwkulupBaskaniListe.DataSource = ds.Tables[0];
            dgwkulupBaskaniListe.Columns[3].Width = 80;
            dgwkulupBaskaniListe.Columns[4].Width = 50;

        }

        
    }
}
