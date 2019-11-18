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
	public partial class detayNumune : Form
	{
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);
		DialogResult guvenlik = System.Windows.Forms.DialogResult.No;
		private bool Kapatsorgu;

		public detayNumune()
		{
			InitializeComponent();
		}
		private void urunsil()

		{
			if (!Kapatsorgu)
			{
				guvenlik = MessageBox.Show("Ürünü Silmek İstediğinize Eminmisiniz?", "UYARI", MessageBoxButtons.YesNo);
				Kapatsorgu = guvenlik == System.Windows.Forms.DialogResult.Yes;
			}
			if (guvenlik == System.Windows.Forms.DialogResult.Yes)
			{
				if (Kapatsorgu)
				{
					baglanti.Open();
					string kayit = "delete from numune_tablosu where numune_id=@numune_id";
					SqlCommand komut = new SqlCommand(kayit, baglanti);
					komut.Parameters.AddWithValue("@numune_id", txturunid.Text);
					urunlistesigetir();
					komut.ExecuteNonQuery();
					baglanti.Close();
				}
				Kapatsorgu = false;
			}
			else
			{
				baglanti.Close();
			}
		}
		private void idal()
		{
			int SelectValue = grdurun.CurrentRow.Index;
			txturunid.Text = grdurun.Rows[SelectValue].Cells[0].Value.ToString();
		}
		private void urunveridoldur()
		{
			int SelectValue = grdurun.CurrentRow.Index;
			txturunid.Text = grdurun.Rows[SelectValue].Cells["numune_id"].Value.ToString();
			txtnumuneNo.Text = grdurun.Rows[SelectValue].Cells["numune_numarasi"].Value.ToString();
			txtnumuneAdi.Text = grdurun.Rows[SelectValue].Cells["numune_ad"].Value.ToString();
			cmbDeneyMethodu.Text = grdurun.Rows[SelectValue].Cells["deney_methodu"].Value.ToString();
		}

		private void grdurun_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			idal();
			urunveridoldur();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			urunsil();
		}
		public void urunlistesigetir()
		{
			DataTable urunlerTable = new DataTable();
			SqlCommand comm = new SqlCommand($"SELECT numune_id,numune_numarasi, numune_ad, deney_methodu FROM [numune_tablosu] where numune_numarasi LIKE '{txtistekno.Text}%'", baglanti);
			SqlDataAdapter adapter = new SqlDataAdapter(comm);
			adapter.Fill(urunlerTable);
			grdurun.DataSource = urunlerTable;
			grdurun.Columns[0].Visible = false;
		}

		private void btnnumunekaydet_Click(object sender, EventArgs e)
		{
			string x = txtnumuneNo.Text;
			if (x.StartsWith($"{txtistekno.Text}-") && !string.IsNullOrEmpty(x.Split('-')[1]))
			{
				baglanti.Open();
				string kayit = "insert into numune_tablosu(numune_numarasi,numune_ad,deney_methodu) values (@numune_numarasi,@numune_ad,@deney_methodu)";
				SqlCommand komut = new SqlCommand(kayit, baglanti);
				komut.Parameters.AddWithValue("@numune_numarasi", txtnumuneNo.Text);
				komut.Parameters.AddWithValue("@numune_ad", txtnumuneAdi.Text);
				komut.Parameters.AddWithValue("@deney_methodu", cmbDeneyMethodu.Text);
				komut.ExecuteNonQuery();
				baglanti.Close();
				MessageBox.Show("Ürün Eklemek İstediğinize Eminmisiniz?");
				urunlistesigetir();
			}
			else
			{
				MessageBox.Show("Lütfen Numune Numarasını Doğru Giriniz..!!");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!Kapatsorgu)
			{
				guvenlik = MessageBox.Show("Ürünü Güncellemek İstediğinize Eminmisiniz?", "UYARI", MessageBoxButtons.YesNo);
				Kapatsorgu = guvenlik == System.Windows.Forms.DialogResult.Yes;
			}
			if (guvenlik == System.Windows.Forms.DialogResult.Yes)
			{
				if (Kapatsorgu)
				{
					baglanti.Open();
					SqlCommand guncelle = new SqlCommand(" Update numune_tablosu set numune_numarasi='" + txtnumuneNo.Text + "',numune_ad='" + txtnumuneAdi.Text + "',deney_methodu='" + cmbDeneyMethodu.Text + "' where numune_id='" + txturunid.Text + "'", baglanti);
					guncelle.ExecuteNonQuery();
					urunlistesigetir();
					baglanti.Close();
				}
				Kapatsorgu = false;
			}
			else
			{
				baglanti.Close();
			}
		}

		private void btnMusteriGuncelle_Click(object sender, EventArgs e)
		{
			musteriTakip takipsayfasi = new musteriTakip();
			if (!Kapatsorgu)
			{
				guvenlik = MessageBox.Show("Firmayı Güncellemek İstediğinize Eminmisiniz?", "UYARI", MessageBoxButtons.YesNo);
				Kapatsorgu = guvenlik == System.Windows.Forms.DialogResult.Yes;
			}
			if (guvenlik == System.Windows.Forms.DialogResult.Yes)
			{
				if (Kapatsorgu)
				{
					baglanti.Open();
					string guncelle = " Update laboratuvar_musteri set " +
										 "istek_no='" + txtistekno.Text + "'," +
										 "firma_adi='" + txtfirmaad.Text + "'," +
										 "firma_tel='" + txtfirmatel.Text + "'," +
										 "yetkili_kisi='" + txtyetkilikisi.Text + "'," +
										 "firma_mail='" + txtfirmamail.Text + "'," +
									     "giriste_teslim_alan='" + txtgiristeteslimalan.Text + "'," +
										 "giriste_teslim_eden='" + txtgiristeteslimeden.Text + "'," +
										 "cikista_teslim_alan='" + txtcikistateslimalan.Text + "', " +
										 "cikista_teslim_eden='" + txtcikistateslimeden.Text + "', " +
										 "firma_adres='" + txtfirmaadres.Text + "', " +
									     "firma_not='" + txtnotlar.Text + "', " +
										 "giris_tarihi='" + dtgiristarihi.Text + "', " +
										 "test_tarihi='" + dttesttarihi.Text + "', " +
										 "bitis_tarihi='" + dtbitistarihi.Text + "' " +
										 "where firma_id=@firma_id";
					SqlCommand komut = new SqlCommand(guncelle, baglanti);
					komut.Parameters.AddWithValue("@firma_id", txtfirmaid.Text);
					komut.ExecuteNonQuery();
					baglanti.Close();
					this.Close();
					Kapatsorgu = false;
				}
				else
				{
					baglanti.Close();
				}
			}
		}
	}
}
