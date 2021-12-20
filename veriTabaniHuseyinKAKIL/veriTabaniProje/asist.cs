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
    public partial class asist : Form
    {
        public asist()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        private void asist_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from futbolcu", baglanti);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from mac", baglanti);
            DataTable dt2 = new DataTable();
            da.Fill(dt);
            da2.Fill(dt2);

            cmbasistAsistiYapanId.DisplayMember = "ad";
            cmbasistAsistiYapanId.ValueMember = "id";
            cmbasistAsistiYapanId.DataSource = dt;


            cmbasistMacId.DisplayMember = "id";
            cmbasistMacId.ValueMember = "id";
            cmbasistMacId.DataSource = dt2;

            baglanti.Close();
        }

        private void btnasistEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into asist(id,futbolcuid,macid) values(@id,@futbolcuid,@macid)", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtasistId.Text));
            komut.Parameters.AddWithValue("@futbolcuid", int.Parse(cmbasistAsistiYapanId.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@macid", int.Parse(cmbasistMacId.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Asist Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnasistGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update asist set futbolcuid=@futbolcuid where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtasistId.Text));
            komut.Parameters.AddWithValue("@futbolcuid", int.Parse(cmbasistAsistiYapanId.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            MessageBox.Show("Asist Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnasistListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select id,futbolcuid,macid from asist";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwasistListe.DataSource = ds.Tables[0];
        }

        private void btnasistSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from asist where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtasistId.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Asist Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
