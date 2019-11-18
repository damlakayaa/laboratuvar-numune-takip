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

namespace yonetim_sistemi
{
	public partial class yeniNot : Form
	{
		public static ListView _notlar = null;
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);
		public yeniNot(ListView notlar)
		{
			_notlar = notlar;
			InitializeComponent();
		}

		private void btnNotKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				if (baglanti.State == ConnectionState.Closed)
				{
					baglanti.Open();
					string kayit = "insert into notlar(user_id, notlar) values (@user_id, @notlar)";
					SqlCommand komut = new SqlCommand(kayit, baglanti);
					komut.Parameters.AddWithValue("@user_id", SistemdekiKullanici.LoginOlanKullanici.user_id);
					komut.Parameters.AddWithValue("@notlar", txtNot.Text);
					komut.ExecuteNonQuery();
					baglanti.Close();

					if (MessageBox.Show("Notunuz Başarılı Bir Şekilde Eklenmiştir") == DialogResult.OK)
					{
						anaSayfa ana = new anaSayfa();
						_notlar.Items.Insert(0, new ListViewItem(txtNot.Text));
						this.Close();
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
