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
    public partial class arama : Form
    {
        public arama()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbLigler; userid=postgres; password=x8n43iwif");

        private void arama_Load(object sender, EventArgs e)
        {
            cmbaramaAranacakGrup.Items.Add("Futbolcu");
            cmbaramaAranacakGrup.Items.Add("Takım");
            cmbaramaAranacakGrup.Items.Add("Teknik Direktör");
            cmbaramaAranacakGrup.Items.Add("Başkan");
            cmbaramaAranacakGrup.Items.Add("Hakem");
            cmbaramaAranacakGrup.Items.Add("Lig Yönetici");
            cmbaramaAranacakGrup.Items.Add("Stadyum");
            cmbaramaAranacakGrup.Text = cmbaramaAranacakGrup.Items[0].ToString();
        }

        private void btnaramaListele_Click(object sender, EventArgs e)
        {
            string sorgu=string.Empty;
            if (cmbaramaAranacakGrup.SelectedIndex == 0)      { sorgu = "select * from futbolcu where id="+txtaramaId.Text;}
            else if (cmbaramaAranacakGrup.SelectedIndex == 1) { sorgu = "select *from takim where id=" + txtaramaId.Text; }
            else if(cmbaramaAranacakGrup.SelectedIndex == 2)  { sorgu = "select *from teknikdirektor where id=" + txtaramaId.Text; }
            else if (cmbaramaAranacakGrup.SelectedIndex == 3) { sorgu = "select *from baskan where id=" + txtaramaId.Text; }
            else if (cmbaramaAranacakGrup.SelectedIndex == 4) { sorgu = "select *from hakem where id=" + txtaramaId.Text; }
            else if (cmbaramaAranacakGrup.SelectedIndex == 5) { sorgu = "select *from ligyonetici where id=" + txtaramaId.Text; }
            else if (cmbaramaAranacakGrup.SelectedIndex == 6) { sorgu = "select *from stadyum where id=" + txtaramaId.Text; }
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwaramaListe.DataSource = ds.Tables[0];
        }
    }
}
