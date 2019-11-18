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
	public partial class testi_bitenler : Form
	{
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);
		public testi_bitenler()
		{
			InitializeComponent();
		}

		private void testi_bitenler_Load(object sender, EventArgs e)
		{
			bitenlerigetir();
		}

		private void bitenlerigetir()
		{
			baglanti.Open();
			string sorgu = "select * from laboratuvar_musteri where numune_durum='3'";
			SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			grdbitenler.DataSource = dt;
			baglanti.Close();

			grdbitenler.Columns[0].Visible = false;
			grdbitenler.Columns[15].Visible = false;
		}

		private void grdbitenler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			LaboratuvarModulu.detayNumune detaysayfasi = new LaboratuvarModulu.detayNumune();
			detaysayfasi.txtfirmaid.Text = this.grdbitenler.CurrentRow.Cells[0].Value.ToString();
			detaysayfasi.txtistekno.Text = this.grdbitenler.CurrentRow.Cells[1].Value.ToString();
			detaysayfasi.txtfirmaad.Text = this.grdbitenler.CurrentRow.Cells[2].Value.ToString();
			detaysayfasi.txtfirmatel.Text = this.grdbitenler.CurrentRow.Cells[3].Value.ToString();
			detaysayfasi.txtyetkilikisi.Text = this.grdbitenler.CurrentRow.Cells[4].Value.ToString();
			detaysayfasi.txtfirmamail.Text = this.grdbitenler.CurrentRow.Cells[5].Value.ToString();
			detaysayfasi.txtgiristeteslimalan.Text = this.grdbitenler.CurrentRow.Cells[6].Value.ToString();
			detaysayfasi.txtgiristeteslimeden.Text = this.grdbitenler.CurrentRow.Cells[7].Value.ToString();
			detaysayfasi.txtcikistateslimalan.Text = this.grdbitenler.CurrentRow.Cells[8].Value.ToString();
			detaysayfasi.txtcikistateslimeden.Text = this.grdbitenler.CurrentRow.Cells[9].Value.ToString();
			detaysayfasi.txtfirmaadres.Text = this.grdbitenler.CurrentRow.Cells[10].Value.ToString();
			detaysayfasi.txtnotlar.Text = this.grdbitenler.CurrentRow.Cells[11].Value.ToString();
			detaysayfasi.dtgiristarihi.Text = this.grdbitenler.CurrentRow.Cells[12].Value.ToString();
			detaysayfasi.dttesttarihi.Text = this.grdbitenler.CurrentRow.Cells[13].Value.ToString();
			detaysayfasi.dtbitistarihi.Text = this.grdbitenler.CurrentRow.Cells[14].Value.ToString();
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
			bitenlerigetir();
		}
	}
}
