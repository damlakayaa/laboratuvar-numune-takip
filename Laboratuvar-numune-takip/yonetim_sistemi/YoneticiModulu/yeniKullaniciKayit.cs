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

namespace yonetim_sistemi.YoneticiModulu
{
	public partial class yeniKullaniciKayit : Form
	{
		static string conString = "Data Source=mssql.sislan.net;Initial Catalog=yeni_crm;Persist Security Info=True;User ID=sa;Password=q1w2E3r4@!";
		SqlConnection baglanti = new SqlConnection(conString);
		public yeniKullaniciKayit()
		{
			InitializeComponent();
		}

		private void btnkaydet_Click(object sender, EventArgs e)
		{
			try
			{
				if (baglanti.State == ConnectionState.Closed)
				{
					baglanti.Open();
					string kayit = "insert into kullanicilar(ad_soyad,username,password,yetki) values (@ad_soyad,@username,@password,@yetki)";
					SqlCommand komut = new SqlCommand(kayit, baglanti);
					komut.Parameters.AddWithValue("@ad_soyad", txtisimsoyisim.Text);
					komut.Parameters.AddWithValue("@username", txtkullaniciad.Text);
					komut.Parameters.AddWithValue("@password", txtsifre.Text);
					komut.Parameters.AddWithValue("@yetki", cmbyetki.Text);
					komut.ExecuteNonQuery();
					baglanti.Close();

					if (MessageBox.Show("Personel Başarılı Bir Şekilde Kaydedilmiştir") == DialogResult.OK)
					{
						txtisimsoyisim.Clear();
						txtkullaniciad.Clear();
						txtsifre.Clear();
					}
				}
			}
			catch (Exception hata)
			{

				MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
			}
		}
	}
}
