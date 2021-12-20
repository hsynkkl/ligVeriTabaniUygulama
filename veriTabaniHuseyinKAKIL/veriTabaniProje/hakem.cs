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
    public partial class hakem : Form
    {
        public hakem()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        

        private void hakem_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from sehir", baglanti);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from hakemklasman", baglanti);
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);
            

            cmbhakemDyeri.DisplayMember = "isim";
            cmbhakemDyeri.ValueMember = "id";
            cmbhakemDyeri.DataSource = dt;
            
            cmbhakemKlasman.DisplayMember = "ad";
            cmbhakemKlasman.ValueMember = "id";
            cmbhakemKlasman.DataSource = dt2;


            baglanti.Close();
        }

        private void btnhakemEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into hakem(id,ad,dyeri,dtarihi,klasman) values(@id,@ad,@dyeri,@dtarihi,@klasman)", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txthakemId.Text));
            komut.Parameters.AddWithValue("@ad", txthakemAdSoyad.Text);  
            komut.Parameters.AddWithValue("@dyeri", int.Parse(cmbhakemDyeri.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@dtarihi", dtphakemDtarihi.Value);
            komut.Parameters.AddWithValue("@klasman", int.Parse(cmbhakemKlasman.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Hakem Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnhakemSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from hakem where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txthakemId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Hakem Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnhakemGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update hakem set klasman=@klasman where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txthakemId.Text));
            komut.Parameters.AddWithValue("@klasman", int.Parse(cmbhakemKlasman.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Hakem Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnhakemListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select hakem.id,hakem.ad,sehir.isim,hakem.dtarihi as Dogum_tarihi,hakemklasman.ad as klasman from hakem inner join hakemklasman on hakem.klasman=hakemklasman.id inner join sehir on hakem.dyeri=sehir.id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwhakemListe.DataSource = ds.Tables[0];
            dgwhakemListe.Columns[3].Width = 80;
            dgwhakemListe.Columns[4].Width = 50;
        }
    }
}
