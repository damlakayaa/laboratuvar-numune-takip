using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using yonetim_sistemi.Objeler;

namespace yonetim_sistemi
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);

		private void btnlogin_Click(object sender, EventArgs e)
		{
			string sorgu = "Select user_id, username, password, yetki, kullanici_image, ad_soyad from kullanicilar where username=@kullaniciAdi and password=@sifre";
			SqlCommand comm = new SqlCommand(sorgu, baglanti);
			comm.Parameters.AddWithValue("@kullaniciAdi", txtkullaniciAd.Text);
			comm.Parameters.AddWithValue("@sifre", txtSifre.Text);

			baglanti.Open(); Kullanicilar kullanici = null;
			SqlDataReader reader = comm.ExecuteReader();

			while (reader.Read())
			{
				kullanici = new Kullanicilar()
				{
					user_id = reader.GetInt32(0),
					username = reader.GetString(1),
					password = reader.GetString(2),
					yetki = (KullaniciYetkileri)reader.GetInt32(3),
					//kullanici_image = reader.GetValue(4) != null ? reader.GetByte(4) : (byte?)null,
					ad_soyad = reader.GetString(5)
				};
			}

			baglanti.Close();
			if (kullanici != null)
			{
				SistemdekiKullanici.LoginOlanKullanici = kullanici;
				anaSayfa anaSayfa = new anaSayfa();
				this.Hide();
				anaSayfa.Show();
			}
			else
			{
				MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlıştır..!");
				txtkullaniciAd.Clear();
				txtSifre.Clear();
			}
		}

		private void btnotorumuKapat_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
