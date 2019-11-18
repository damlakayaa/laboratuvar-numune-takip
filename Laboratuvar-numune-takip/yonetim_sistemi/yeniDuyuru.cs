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

namespace yonetim_sistemi
{
	public partial class yeniDuyuru : Form
	{

		public static ListView _duyuruListesi = null;
		public yeniDuyuru(ListView duyuruListesi)
		{
			_duyuruListesi = duyuruListesi;
			InitializeComponent();
		}
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);
		private void btnDuyuruGonder_Click(object sender, EventArgs e)
		{
			try
			{
				if (baglanti.State == ConnectionState.Closed)
				{
					baglanti.Open();
					string kayit = "insert into duyurular(duyurular) values (@duyurular)";
					SqlCommand komut = new SqlCommand(kayit, baglanti);
					komut.Parameters.AddWithValue("@duyurular", txtDuyuru.Text);
					komut.ExecuteNonQuery();
					baglanti.Close();

					if (MessageBox.Show("Duyurunuz Başarılı Bir Şekilde Eklenmiştir") == DialogResult.OK)
					{
						anaSayfa ana = new anaSayfa();
						_duyuruListesi.Items.Insert(0, new ListViewItem(txtDuyuru.Text));
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
