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

namespace yonetim_sistemi.LaboratuvarModulu
{
	public partial class onay_bekleyen_testler : Form
	{
		numuneTakip numuneTakipForm = null;
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);
		public onay_bekleyen_testler(numuneTakip _numuneTakipForm)
		{
			numuneTakipForm = _numuneTakipForm;
			InitializeComponent();
		}

		private void onay_bekleyen_testler_Load(object sender, EventArgs e)
		{
						
			onayBekleyenleriGetir();

		}
		public void onayBekleyenleriGetir()
		{
			baglanti.Open();
			string sorgu = "select * from laboratuvar_musteri where numune_durum='1'";
			SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			grdOnayBekleyenler.DataSource = dt;
			numuneTakipForm.tumVerileriGuncelle();
			baglanti.Close();
			grdOnayBekleyenler.Columns[0].Visible = false;
			grdOnayBekleyenler.Columns[15].Visible = false;
		}

		private void btnOnayla_Click(object sender, EventArgs e)
		{
			
			string Durum = txtdurumtexti.Text;
			if (Durum=="1")
			{
				test_baslangic_tarihi form = new test_baslangic_tarihi();
				form.txtidbaslangicid.Text = this.grdOnayBekleyenler.CurrentRow.Cells[0].Value.ToString();
				form.ShowDialog();
				onayBekleyenleriGetir();
								
			}
		}

		private void firmaidvedurumal()
		{
			int SelectValue = grdOnayBekleyenler.CurrentRow.Index;
			txtid.Text = grdOnayBekleyenler.Rows[SelectValue].Cells["firma_id"].Value.ToString();
			txtdurumtexti.Text = this.grdOnayBekleyenler.CurrentRow.Cells[15].Value.ToString();
		}

		private void grdOnayBekleyenler_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			firmaidvedurumal();
		}

		private void grdOnayBekleyenler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			LaboratuvarModulu.detayNumune detaysayfasi = new LaboratuvarModulu.detayNumune();
			detaysayfasi.txtfirmaid.Text = this.grdOnayBekleyenler.CurrentRow.Cells[0].Value.ToString();
			detaysayfasi.txtistekno.Text = this.grdOnayBekleyenler.CurrentRow.Cells[1].Value.ToString();
			detaysayfasi.txtfirmaad.Text = this.grdOnayBekleyenler.CurrentRow.Cells[2].Value.ToString();
			detaysayfasi.txtfirmatel.Text = this.grdOnayBekleyenler.CurrentRow.Cells[3].Value.ToString();
			detaysayfasi.txtyetkilikisi.Text = this.grdOnayBekleyenler.CurrentRow.Cells[4].Value.ToString();
			detaysayfasi.txtfirmamail.Text = this.grdOnayBekleyenler.CurrentRow.Cells[5].Value.ToString();
			detaysayfasi.txtgiristeteslimalan.Text = this.grdOnayBekleyenler.CurrentRow.Cells[6].Value.ToString();
			detaysayfasi.txtgiristeteslimeden.Text = this.grdOnayBekleyenler.CurrentRow.Cells[7].Value.ToString();
			detaysayfasi.txtcikistateslimalan.Text = this.grdOnayBekleyenler.CurrentRow.Cells[8].Value.ToString();
			detaysayfasi.txtcikistateslimeden.Text = this.grdOnayBekleyenler.CurrentRow.Cells[9].Value.ToString();
			detaysayfasi.txtfirmaadres.Text = this.grdOnayBekleyenler.CurrentRow.Cells[10].Value.ToString();
			detaysayfasi.txtnotlar.Text = this.grdOnayBekleyenler.CurrentRow.Cells[11].Value.ToString();
			detaysayfasi.dtgiristarihi.Text = this.grdOnayBekleyenler.CurrentRow.Cells[12].Value.ToString();
			detaysayfasi.dttesttarihi.Text = this.grdOnayBekleyenler.CurrentRow.Cells[13].Value.ToString();
			detaysayfasi.dtbitistarihi.Text = this.grdOnayBekleyenler.CurrentRow.Cells[14].Value.ToString();
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
			onayBekleyenleriGetir();
		}
	}
}
