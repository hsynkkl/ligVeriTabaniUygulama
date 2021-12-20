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
    public partial class rekor : Form
    {
        public rekor()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void rekor_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from rekorturufutbolcu", baglanti);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from futbolcu", baglanti);
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);

            cmbrekorId.DisplayMember = "ad";
            cmbrekorId.ValueMember = "id";
            cmbrekorId.DataSource = dt;


            cmbrekorFutbolcuId.DisplayMember = "ad";
            cmbrekorFutbolcuId.ValueMember = "id";
            cmbrekorFutbolcuId.DataSource = dt2;

            baglanti.Close();
        }

        private void btnfutbolcuEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into rekorsahibifutbolcu(rekorid,futbolcuid) values(@rekorid,@futbolcuid)", baglanti);
            
            komut.Parameters.AddWithValue("@rekorid", int.Parse(cmbrekorId.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@futbolcuid", int.Parse(cmbrekorFutbolcuId.SelectedValue.ToString()));
            
            komut.ExecuteNonQuery();
            MessageBox.Show("Rekor Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnfutbolcuGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update rekorsahibifutbolcu set futbolcuid=@futbolcuid where rekorid=@rekorid", baglanti);
            komut.Parameters.AddWithValue("@rekorid", int.Parse(cmbrekorId.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@futbolcuid", int.Parse(cmbrekorFutbolcuId.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Rekor Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnfutbolcuListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select rekorturufutbolcu.ad as Rekor_türü,futbolcu.ad as futbolcu_ismi from rekorsahibifutbolcu inner join futbolcu on rekorsahibifutbolcu.futbolcuid=futbolcu.id inner join rekorturufutbolcu on rekorsahibifutbolcu.rekorid=rekorturufutbolcu.id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwfutbolcuListe.DataSource = ds.Tables[0];
            
        }

        private void btnfutbolcuSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from rekorsahibifutbolcu where rekorid=@rekorid", baglanti);
            komut.Parameters.AddWithValue("@rekorid", int.Parse(cmbrekorId.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Rekor Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
