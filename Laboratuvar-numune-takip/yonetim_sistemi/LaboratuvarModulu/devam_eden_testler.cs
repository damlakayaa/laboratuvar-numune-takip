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
	public partial class devam_eden_testler : Form
	{
		numuneTakip numuneTakipForm = null;
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);

		public devam_eden_testler(numuneTakip _numuneTakipForm)
		{
			numuneTakipForm = _numuneTakipForm;
			InitializeComponent();
		}

		private void devam_eden_testler_Load(object sender, EventArgs e)
		{
			testiDevamEdenleriGetir();
		}

		public void testiDevamEdenleriGetir()
		{
			baglanti.Open();
			string sorgu = "select * from laboratuvar_musteri where numune_durum='2'";
			SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			grdDevamEdenleriGetir.DataSource = dt;
			numuneTakipForm.tumVerileriGuncelle();
			baglanti.Close();
			grdDevamEdenleriGetir.Columns[0].Visible = false;
			grdDevamEdenleriGetir.Columns[15].Visible = false;
		}

		private void btnbitir_Click(object sender, EventArgs e)
		{
			string Durum = txtdurumtexti.Text;
			if (Durum == "2")
			{
				test_bitis_tarihi form = new test_bitis_tarihi();
				form.txtbitisid.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[0].Value.ToString();
				form.ShowDialog();
				testiDevamEdenleriGetir();
			}
		}
		private void firmaidal()
		{
			int SelectValue = grdDevamEdenleriGetir.CurrentRow.Index;
			txtid.Text = grdDevamEdenleriGetir.Rows[SelectValue].Cells["firma_id"].Value.ToString();
			txtdurumtexti.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[15].Value.ToString();
		}

		private void grdDevamEdenleriGetir_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			firmaidal();
		}



		private void btnyenile_Click(object sender, EventArgs e)
		{
			testiDevamEdenleriGetir();
		}

		private void grdDevamEdenleriGetir_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			LaboratuvarModulu.detayNumune detaysayfasi = new LaboratuvarModulu.detayNumune();
			detaysayfasi.txtfirmaid.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[0].Value.ToString();
			detaysayfasi.txtistekno.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[1].Value.ToString();
			detaysayfasi.txtfirmaad.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[2].Value.ToString();
			detaysayfasi.txtfirmatel.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[3].Value.ToString();
			detaysayfasi.txtyetkilikisi.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[4].Value.ToString();
			detaysayfasi.txtfirmamail.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[5].Value.ToString();
			detaysayfasi.txtgiristeteslimalan.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[6].Value.ToString();
			detaysayfasi.txtgiristeteslimeden.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[7].Value.ToString();
			detaysayfasi.txtcikistateslimalan.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[8].Value.ToString();
			detaysayfasi.txtcikistateslimeden.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[9].Value.ToString();
			detaysayfasi.txtfirmaadres.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[10].Value.ToString();
			detaysayfasi.txtnotlar.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[11].Value.ToString();
			detaysayfasi.dtgiristarihi.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[12].Value.ToString();
			detaysayfasi.dttesttarihi.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[13].Value.ToString();
			detaysayfasi.dtbitistarihi.Text = this.grdDevamEdenleriGetir.CurrentRow.Cells[14].Value.ToString();
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
	}
}
