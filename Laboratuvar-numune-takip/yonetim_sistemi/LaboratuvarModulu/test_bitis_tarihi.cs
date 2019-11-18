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
	public partial class test_bitis_tarihi : Form
	{
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);

		public test_bitis_tarihi()
		{
			InitializeComponent();
		}

		private void btntestbitir_Click(object sender, EventArgs e)
		{
			numuneTakip takipForm = new numuneTakip();
			devam_eden_testler takipsayfasi = new devam_eden_testler(takipForm);
			baglanti.Open();
			string guncelle = "Update laboratuvar_musteri set numune_durum=3,bitis_tarihi=@bitis_tarihi where firma_id=@firma_id";
			SqlCommand komut = new SqlCommand(guncelle, baglanti);
			komut.Parameters.AddWithValue("@firma_id", txtbitisid.Text);
			komut.Parameters.AddWithValue("@bitis_tarihi", dtbitistarihi.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Testi Sonlandırmak İstediğinize Emin misiniz?");
			this.Close();
			takipsayfasi.testiDevamEdenleriGetir();
		}
	}
}
