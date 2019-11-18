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
using System.Windows.Forms.DataVisualization.Charting;

namespace yonetim_sistemi.LaboratuvarModulu
{
	public partial class numuneTakip : Form
	{
		static string veritabanibaglanti = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(veritabanibaglanti);
		public numuneTakip()
		{
			InitializeComponent();
		}

		private void numuneTakip_Load(object sender, EventArgs e)
		{
			tumVerileriGuncelle();
			chartiDoldur();
		}

		private void chartiDoldur()
		{
			//DataTable table = new DataTable();
			//SqlCommand komut = new SqlCommand("select firma_id, istek_no from laboratuvar_musteri ", baglanti);
			//SqlDataAdapter adapter = new SqlDataAdapter(komut);
			//adapter.Fill(table);
			//chartnumune.DataSource = table;
			//chartnumune.DataBind();

			int onaybekleyen = Convert.ToInt32(lblonaybekleyensayisi.Text.Replace("(", string.Empty).Replace(")", string.Empty));
			int devamEden = Convert.ToInt32(lbldevamedensayisi.Text.Replace("(", string.Empty).Replace(")", string.Empty));
			int tamamlanan = Convert.ToInt32(lbltamamlanmissayisi.Text.Replace("(", string.Empty).Replace(")", string.Empty));
			chartnumune.Series.Add(new Series());

			string[] seriesArray = { $"Onay Bekleyenler ({onaybekleyen})", $"Devam Eden Testler ({devamEden})", $"Tamamlanmış Testler ({tamamlanan})" };
			int[] pointsArray = { onaybekleyen, devamEden, tamamlanan };

			chartnumune.Series[0].ChartType = SeriesChartType.Pie;
			chartnumune.Series[0].Points.DataBindXY(seriesArray, pointsArray);
			chartnumune.Legends[0].Enabled = true;
			chartnumune.ChartAreas[0].Area3DStyle.Enable3D = true;
		}

		public void tumVerileriGuncelle()
		{
			onaybekleyeniletigoster();
			devamedeniletigoster();
			tamamlanmisiletigoster();
		}

		public void onaybekleyeniletigoster()
		{
			DataSet ds2 = new DataSet();
			SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM laboratuvar_musteri where numune_durum=1", baglanti);
			ds2.Clear();
			da2.Fill(ds2, "laboratuvar_musteri");
			lblonaybekleyensayisi.Text = "(" + ds2.Tables["laboratuvar_musteri"].Rows.Count.ToString() + ")";
			lblonaybekleyensayisi.ForeColor = Color.Red;
		}
		public void devamedeniletigoster()
		{
			DataSet ds = new DataSet();
			SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM laboratuvar_musteri where numune_durum=2", baglanti);
			ds.Clear();
			da.Fill(ds, "laboratuvar_musteri");
			lbldevamedensayisi.Text = "(" + ds.Tables["laboratuvar_musteri"].Rows.Count.ToString() + ")";
			lbldevamedensayisi.ForeColor = Color.Red;
		}
		public void tamamlanmisiletigoster()
		{
			DataSet ds1 = new DataSet();
			SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM laboratuvar_musteri where numune_durum=3", baglanti);
			ds1.Clear();
			da1.Fill(ds1, "laboratuvar_musteri");
			lbltamamlanmissayisi.Text = "(" + ds1.Tables["laboratuvar_musteri"].Rows.Count.ToString() + ")";
			lbltamamlanmissayisi.ForeColor = Color.Red;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			onay_bekleyen_testler form = new onay_bekleyen_testler(this);
			form.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			devam_eden_testler devam = new devam_eden_testler(this);
			devam.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			testi_bitenler biten = new testi_bitenler();
			biten.ShowDialog();
		}


	}
}
