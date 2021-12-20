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
    public partial class futbolcu : Form
    {
        public futbolcu()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");
        

        private void futbolcu_Load(object sender, EventArgs e)
        {
           
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from sehir", baglanti);
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from takim", baglanti);
            DataTable dt2 = new DataTable();            
            da.Fill(dt);
            da2.Fill(dt2);
            
            cmbfutbolcuDyeri.DisplayMember = "isim";
            cmbfutbolcuDyeri.ValueMember = "id";
            cmbfutbolcuDyeri.DataSource = dt;
            
            
            cmbfutbolcuTakim.DisplayMember = "ad";
            cmbfutbolcuTakim.ValueMember = "id";
            cmbfutbolcuTakim.DataSource = dt2;

            baglanti.Close();
        }

        private void btnfutbolcuEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into futbolcu(id,ad,takimid,dyeri,dtarihi) values(@id,@ad,@takimid,@dyeri,@dtarihi)", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtfutbolcuId.Text));
            komut.Parameters.AddWithValue("@ad", txtfutbolcuAdSoyad.Text);
            komut.Parameters.AddWithValue("@takimid", int.Parse(cmbfutbolcuTakim.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@dyeri", int.Parse(cmbfutbolcuDyeri.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@dtarihi", dtpfutbolcuDtarihi.Value);
            komut.ExecuteNonQuery();
            MessageBox.Show("Oyuncu Eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnfutbolcuSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from futbolcu where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtfutbolcuId.Text));          
            komut.ExecuteNonQuery();
            MessageBox.Show("Oyuncu Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnfutbolcuGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update futbolcu set takimid=@takimid where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", int.Parse(txtfutbolcuId.Text));
            komut.Parameters.AddWithValue("@takimid", int.Parse(cmbfutbolcuTakim.SelectedValue.ToString()));            
            komut.ExecuteNonQuery();
            MessageBox.Show("Oyuncu Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnfutbolcuListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select futbolcu.id,futbolcu.ad,futbolcu.dtarihi,sehir.isim as şehir,takim.ad as takım from futbolcu inner join sehir on futbolcu.dyeri=sehir.id inner join takim on futbolcu.takimid=takim.id order by id asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwfutbolcuListe.DataSource = ds.Tables[0];
            dgwfutbolcuListe.Columns[0].Width = 30;
            dgwfutbolcuListe.Columns[4].Width = 80;
        }

        
    }
}
