using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yonetim_sistemi.Objeler;

namespace yonetim_sistemi.LaboratuvarModulu
{
	public partial class musteriTakip : Form
	{
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);

		public musteriTakip()
		{
			InitializeComponent();
		}

		private void btnotorumuKapat_Click(object sender, EventArgs e)
		{
			this.Close();
			laboratuvarAnaSayfa anasayfa = new laboratuvarAnaSayfa();
			anasayfa.Show();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void musteriTakip_Load(object sender, EventArgs e)
		{
			MusteriGetir();

		}
		private void MusteriGetir()
		{
			string sorgu = "select firma_id,istek_no,firma_adi,firma_tel,yetkili_kisi,firma_mail,giriste_teslim_alan,giriste_teslim_eden,cikista_teslim_alan,cikista_teslim_eden,firma_adres,firma_not,giris_tarihi,test_tarihi,bitis_tarihi,numune_durum,teknikDeger,yardimciEkipman,gozleKontrol,ambalajKontrol from laboratuvar_musteri";
			SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			grdlaboratuvarmusteri.DataSource = dt;
			grdlaboratuvarmusteri.Columns[0].Visible = false;
			grdlaboratuvarmusteri.Columns[5].Visible = false;
			grdlaboratuvarmusteri.Columns[6].Visible = false;
			grdlaboratuvarmusteri.Columns[7].Visible = false;
			grdlaboratuvarmusteri.Columns[8].Visible = false;
			grdlaboratuvarmusteri.Columns[9].Visible = false;
			grdlaboratuvarmusteri.Columns[10].Visible = false;
			grdlaboratuvarmusteri.Columns[15].Visible = false;


		}

		public void id_ad()
		{
			int SelectValue = grdlaboratuvarmusteri.CurrentRow.Index;
			txtfirmaid.Text = grdlaboratuvarmusteri.Rows[SelectValue].Cells["firma_id"].Value.ToString();

		}
		public void durumal()
		{
			int SelectValue = grdlaboratuvarmusteri.CurrentRow.Index;
			txtdurum.Text = grdlaboratuvarmusteri.Rows[SelectValue].Cells["numune_durum"].Value.ToString();
		}

		private void grdlaboratuvarmusteri_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id_ad();
			durumal();
			durumukontrolet();

		}
		public void durumukontrolet()

		{
			if (txtdurum.Text == "1")
			{
				lbldurum.Text = "Test İçin Sırada Bekliyor";
				lbldurum.ForeColor = Color.Red;
			}
			else if (txtdurum.Text == "2")
			{
				lbldurum.Text = "Test Aşamasında";
				lbldurum.ForeColor = Color.DarkOrange;
			}
			else if (txtdurum.Text == "3")
			{
				lbldurum.Text = "Test Tamamlandı";
				lbldurum.ForeColor = Color.Green;
			}
			else
			{
				lbldurum.Text = "";
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * from laboratuvar_musteri where firma_adi like '%" + txtara.Text + "%'", baglanti);
			SqlDataAdapter da = new SqlDataAdapter(komut);
			DataSet ds = new DataSet();
			da.Fill(ds);
			grdlaboratuvarmusteri.DataSource = ds.Tables[0];
			baglanti.Close();
			//kolonlariRenklendir(grdMusteri);
		}

		private void grdlaboratuvarmusteri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{


			LaboratuvarModulu.detayNumune detaysayfasi = new LaboratuvarModulu.detayNumune();
			detaysayfasi.txtfirmaid.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[0].Value.ToString();
			detaysayfasi.txtistekno.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[1].Value.ToString();
			detaysayfasi.txtfirmaad.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[2].Value.ToString();
			detaysayfasi.txtfirmatel.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[3].Value.ToString();
			detaysayfasi.txtyetkilikisi.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[4].Value.ToString();
			detaysayfasi.txtfirmamail.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[5].Value.ToString();
			detaysayfasi.txtgiristeteslimalan.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[6].Value.ToString();
			detaysayfasi.txtgiristeteslimeden.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[7].Value.ToString();
			detaysayfasi.txtcikistateslimalan.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[8].Value.ToString();
			detaysayfasi.txtcikistateslimeden.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[9].Value.ToString();
			detaysayfasi.txtfirmaadres.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[10].Value.ToString();
			detaysayfasi.txtnotlar.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[11].Value.ToString();
			detaysayfasi.dtgiristarihi.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[12].Value.ToString();
			detaysayfasi.dttesttarihi.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[13].Value.ToString();
			detaysayfasi.dtbitistarihi.Text = this.grdlaboratuvarmusteri.CurrentRow.Cells[14].Value.ToString();

			/* checkboxlar */
			detaysayfasi.cbteknikdeger.Checked = Convert.ToBoolean(this.grdlaboratuvarmusteri.CurrentRow.Cells[15].Value);
			detaysayfasi.cbyardimciekipman.Checked = Convert.ToBoolean(this.grdlaboratuvarmusteri.CurrentRow.Cells[16].Value);
			detaysayfasi.cbgozlekontrol.Checked = Convert.ToBoolean(this.grdlaboratuvarmusteri.CurrentRow.Cells[17].Value);
			detaysayfasi.cbambalaj.Checked = Convert.ToBoolean(this.grdlaboratuvarmusteri.CurrentRow.Cells[18].Value);



			baglanti.Open();
			DataTable urunlerTable = new DataTable();
			SqlCommand comm = new SqlCommand($"SELECT numune_id,numune_numarasi, numune_ad, deney_methodu FROM [numune_tablosu] where numune_numarasi LIKE '{detaysayfasi.txtistekno.Text}%'", baglanti);
			SqlDataAdapter adapter = new SqlDataAdapter(comm);
			adapter.Fill(urunlerTable);
			detaysayfasi.grdurun.DataSource = urunlerTable;
			detaysayfasi.grdurun.Columns[0].Visible = false;
			baglanti.Close();
			detaysayfasi.ShowDialog();
		}

		private void btnyenile_Click(object sender, EventArgs e)
		{
			MusteriGetir();
		}
	}
}
