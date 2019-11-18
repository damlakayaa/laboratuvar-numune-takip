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
	public partial class test_baslangic_tarihi : Form
	{
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);

		public test_baslangic_tarihi()
		{
			InitializeComponent();
		}

		private void btnTestBaslat_Click(object sender, EventArgs e)
		{
			numuneTakip numuneform = new numuneTakip();
			onay_bekleyen_testler takipsayfasi = new onay_bekleyen_testler(numuneform);
			baglanti.Open();
			string guncelle = "Update laboratuvar_musteri set numune_durum=2,test_tarihi=@test_tarihi where firma_id=@firma_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@firma_id", txtidbaslangicid.Text);
			komut.Parameters.AddWithValue("@test_tarihi", dtbaslangictarihi.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Testi Başlatmak İstediğinize Emin misiniz?");
			this.Close();
			takipsayfasi.onayBekleyenleriGetir();
			numuneform.devamedeniletigoster();
		}

	}
}
