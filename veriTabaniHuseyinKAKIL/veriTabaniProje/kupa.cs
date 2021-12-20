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
    public partial class kupa : Form
    {
        public kupa()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void btnkupaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into kazanilankupa(kupaid,kazanantakimid,kupaturu,tarih) values(@kupaid,@kazanantakimid,@kupaturu,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@kupaid", int.Parse(txtkupaId.Text));
            komut.Parameters.AddWithValue("@kazanantakimid", int.Parse(cmbkupaKazananTakimId.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@kupaturu", int.Parse(cmbkupaTur.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@tarih", dtpkupaTarih.Value);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kupa Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void kupa_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from kupa", baglanti);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from takim", baglanti);
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);

            cmbkupaTur.DisplayMember = "ad";
            cmbkupaTur.ValueMember = "id";
            cmbkupaTur.DataSource = dt;


            cmbkupaKazananTakimId.DisplayMember = "ad";
            cmbkupaKazananTakimId.ValueMember = "id";
            cmbkupaKazananTakimId.DataSource = dt2;

            baglanti.Close();
        }

        
        private void btnkupaListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select kazanilankupa.kupaid as id,kupa.ad as kupa_adı,takim.ad as takım_adı,kazanilankupa.tarih from kazanilankupa inner join takim on kazanilankupa.kazanantakimid=takim.id inner join kupa on kazanilankupa.kupaid=kupa.id order by kupaid asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwkupaListe.DataSource = ds.Tables[0];
            dgwkupaListe.Columns[0].Width = 30;

        }

        private void btnkupaSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from kazanilankupa where kupaid=@kupaid", baglanti);
            komut.Parameters.AddWithValue("@kupaid", int.Parse(txtkupaId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Kupa Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
