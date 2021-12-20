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
    public partial class ligYoneticisi : Form
    {
        public ligYoneticisi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void btnligYoneticisiEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into ligyonetici(id,ad,dyeri,dtarihi) values(@id,@ad,@dyeri,@dtarihi)", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtligYoneticisiId.Text));
            komut.Parameters.AddWithValue("@ad", txtligYoneticisiAdSoyad.Text);     
            komut.Parameters.AddWithValue("@dyeri", int.Parse(cmbligYoneticisiDyeri.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@dtarihi", dtpligYoneticisiDtarihi.Value);
            komut.ExecuteNonQuery();
            MessageBox.Show("Lig Yöneticisi Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void ligYoneticisi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from sehir", baglanti);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            

            cmbligYoneticisiDyeri.DisplayMember = "isim";
            cmbligYoneticisiDyeri.ValueMember = "id";
            cmbligYoneticisiDyeri.DataSource = dt;
            

            baglanti.Close();
        }

        private void btnligYoneticisiListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select ligyonetici.id,ad,sehir.isim as dogum_yeri,dtarihi as Dogum_tarihi from ligyonetici inner join sehir on ligyonetici.dyeri=sehir.id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwligYoneticisiListe.DataSource = ds.Tables[0];
            dgwligYoneticisiListe.Columns[3].Width = 80;           
        }

        private void btnligYoneticisiSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from ligyonetici where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtligYoneticisiId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("lig Yöneticisi Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
