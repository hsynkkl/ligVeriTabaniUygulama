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
    public partial class sehir : Form
    {
        public sehir()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void btnsehirEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into sehir(id,isim) values(@id,@isim)", baglanti);

            komut.Parameters.AddWithValue("@id", int.Parse(txtsehirId.Text));
            komut.Parameters.AddWithValue("@isim", txtsehirIsim.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Şehir Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnsehirSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from sehir where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtsehirId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Şehir Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnsehirGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update sehir set isim=@isim where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtsehirId.Text));
            komut.Parameters.AddWithValue("@isim", txtsehirIsim.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Şehir Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnsehirListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from sehir";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwsehirListe.DataSource = ds.Tables[0];
        }
    }
}
