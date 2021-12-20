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
    public partial class gol : Form
    {
        public gol()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void btngolEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into gol(id,golcuid,macid) values(@id,@golcuid,@macid)", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtgolId.Text));
            komut.Parameters.AddWithValue("@golcuid", int.Parse(cmbgolGolcuId.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@macid", int.Parse(cmbgolMacId.SelectedValue.ToString()));   
            komut.ExecuteNonQuery();
            MessageBox.Show("Gol Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void gol_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from futbolcu", baglanti);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from mac", baglanti);
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);

            cmbgolGolcuId.DisplayMember = "ad";
            cmbgolGolcuId.ValueMember = "id";
            cmbgolGolcuId.DataSource = dt;
               
               
            cmbgolMacId.DisplayMember = "id";
            cmbgolMacId.ValueMember = "id";
            cmbgolMacId.DataSource = dt2;

            baglanti.Close();
        }

        private void btngolSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from gol where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtgolId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Gol Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btngolListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select id,golcuid,macid from gol";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwgolListe.DataSource = ds.Tables[0];
            
        }

        private void btngolGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update gol set golcuid=@golcuid where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtgolId.Text));
            komut.Parameters.AddWithValue("@golcuid", int.Parse(cmbgolGolcuId.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Gol Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
