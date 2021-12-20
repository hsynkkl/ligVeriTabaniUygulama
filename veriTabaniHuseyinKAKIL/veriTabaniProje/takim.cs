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
    public partial class takim : Form
    {
        public takim()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void takim_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from baskan", baglanti);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            

            cmbtakimBaskan.DisplayMember = "ad";
            cmbtakimBaskan.ValueMember = "id";
            cmbtakimBaskan.DataSource = dt;


            
            baglanti.Close();
        }

        private void btntakimEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into takim(id,ad,baskanid,ktarihi) values(@id,@ad,@baskanid,@ktarihi)", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txttakimId.Text));
            komut.Parameters.AddWithValue("@ad", txttakimIsim.Text);           
            komut.Parameters.AddWithValue("@baskanid", int.Parse(cmbtakimBaskan.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@ktarihi", dtptakimKurulusTarihi.Value);
            komut.ExecuteNonQuery();
            MessageBox.Show("Takım Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btntakimSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from takim where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txttakimId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Takım Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btntakimGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update takim set baskanid=@baskanid where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txttakimId.Text));
            komut.Parameters.AddWithValue("@baskanid", int.Parse(cmbtakimBaskan.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Takım Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btntakimListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select takim.id,takim.ad,baskan.ad as başkan_isim,ktarihi as kurulus_tarihi from takim inner join baskan on takim.baskanid=baskan.id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwfutbolcuListe.DataSource = ds.Tables[0];
            dgwfutbolcuListe.Columns[3].Width = 80;
            
        }
    }
}
