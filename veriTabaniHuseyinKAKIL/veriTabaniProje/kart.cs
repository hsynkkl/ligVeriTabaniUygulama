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
    public partial class kart : Form
    {
        public kart()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void kart_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from futbolcu", baglanti);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from mac", baglanti);
            DataTable dt2 = new DataTable();
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("select * from hakem", baglanti);
            DataTable dt3 = new DataTable();
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter("select * from kartturu", baglanti);
            DataTable dt4 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);
            da3.Fill(dt3);
            da4.Fill(dt4);

            cmbkartFutbolcuId.DisplayMember = "ad";
            cmbkartFutbolcuId.ValueMember = "id";
            cmbkartFutbolcuId.DataSource = dt;


            cmbkartMacId.DisplayMember = "id";
            cmbkartMacId.ValueMember = "id";
            cmbkartMacId.DataSource = dt2;


            cmbkartHakemId.DisplayMember = "ad";
            cmbkartHakemId.ValueMember = "id";
            cmbkartHakemId.DataSource = dt3;


            cmbkartTur.DisplayMember = "ad";
            cmbkartTur.ValueMember = "id";
            cmbkartTur.DataSource = dt4;
            baglanti.Close();
        }

        private void btnkartEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into kart(id,tur,hakemid,futbolcuid,macid) values(@id,@tur,@hakemid,@futbolcuid,@macid)", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtkartId.Text));
            komut.Parameters.AddWithValue("@tur", int.Parse(cmbkartTur.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@hakemid", int.Parse(cmbkartHakemId.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@futbolcuid", int.Parse(cmbkartFutbolcuId.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@macid", int.Parse(cmbkartMacId.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Kart Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnkartListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select kart.id,kartturu.ad as kart_turu,futbolcu.ad as futbolcu,hakem.ad as hakem,macid from kart inner join futbolcu on futbolcu.id=kart.futbolcuid inner join hakem on hakem.id=kart.hakemid inner join kartturu on kartturu.id=kart.tur";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwkartListe.DataSource = ds.Tables[0];
            
        }

        private void btnkartSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from kart where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtkartId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Kart Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
