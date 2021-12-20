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
    public partial class mac : Form
    {
        public mac()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");


        private void mac_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from takim", baglanti);
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from takim", baglanti);
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("select * from hakem", baglanti);
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter("select * from stadyum", baglanti);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);
            da3.Fill(dt3);
            da4.Fill(dt4);

            cmbmacTakim1Id.DisplayMember = "ad";
            cmbmacTakim1Id.ValueMember = "id";
            cmbmacTakim1Id.DataSource = dt;


            cmbmacTakim2Id.DisplayMember = "ad";
            cmbmacTakim2Id.ValueMember = "id";
            cmbmacTakim2Id.DataSource = dt2;

            cmbmacHakemId.DisplayMember = "ad";
            cmbmacHakemId.ValueMember = "id";
            cmbmacHakemId.DataSource = dt3;

            cmbmacStadyumId.DisplayMember = "ad";
            cmbmacStadyumId.ValueMember = "id";
            cmbmacStadyumId.DataSource = dt4;


            baglanti.Close();
        }

        private void btnmacEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into mac(dtid,estid,hid,id,sonuc,stadyumid,tarih) values(@dtid,@estid,@hid,@id,@sonuc,@stadyumid,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@dtid", int.Parse(cmbmacTakim2Id.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@estid", int.Parse(cmbmacTakim1Id.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@hid", int.Parse(cmbmacHakemId.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@id", int.Parse(txtmacId.Text));
            komut.Parameters.AddWithValue("@sonuc", int.Parse(txtmacSonuc.Text));
            komut.Parameters.AddWithValue("@stadyumid", int.Parse(cmbmacStadyumId.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@tarih", dtpmacTarih.Value);
            if (int.Parse(cmbmacTakim2Id.SelectedValue.ToString()) == int.Parse(cmbmacTakim1Id.SelectedValue.ToString()))
            {
                MessageBox.Show("Maç Eklenemedi. Farklı Takım Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
            else
            {
                if (int.Parse(txtmacSonuc.Text)==0 || int.Parse(txtmacSonuc.Text) == 1 || int.Parse(txtmacSonuc.Text) == 2)
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Maç Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Maç Eklenemedi. Sonuç (1-0-2) Olmalıdır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            
            }
        }

        private void btnmacListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select mac.id as mac_id,mac.estid as ev_sahibi,mac.dtid as deplasman,sonuc,stadyum.ad as stadyum_ad,tarih,hakem.ad as hakem_ad from mac inner join stadyum on stadyum.id=mac.stadyumid inner join hakem on hakem.id=mac.hid ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwmacListe.DataSource = ds.Tables[0];
            
        }

        private void btnmacGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update mac set sonuc=@sonuc where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtmacId.Text));
            komut.Parameters.AddWithValue("@sonuc", int.Parse(txtmacSonuc.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Maç Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnmacSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from mac where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtmacId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Maç Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
