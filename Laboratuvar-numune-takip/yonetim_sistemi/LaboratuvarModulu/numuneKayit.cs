using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;

namespace yonetim_sistemi.LaboratuvarModulu
{
	public partial class numuneKayit : Form
	{
		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);
		DialogResult guvenlik = System.Windows.Forms.DialogResult.No;
		private bool Kapatsorgu;

		public numuneKayit()
		{
			InitializeComponent();

		}

		private bool KayitDahaOncedenVarMi(string istek_no)
		{
			bool kayitVarMi = true;
			if (!string.IsNullOrEmpty(istek_no))
			{
				SqlCommand komut = new SqlCommand("select count(distinct(istek_no)) from laboratuvar_musteri where LOWER(istek_no) = @istek_no", baglanti);
				komut.Parameters.AddWithValue("@istek_no", istek_no.ToLower());

				baglanti.Open();
				kayitVarMi = Convert.ToBoolean(komut.ExecuteScalar());
				baglanti.Close();
			}

			return kayitVarMi;
		}

		private void numuneKayit_Load(object sender, EventArgs e)
		{


		}

		private void btnkaydet_Click(object sender, EventArgs e)
		{
			try
			{
				if (baglanti.State == ConnectionState.Closed)
				{
					if (!KayitDahaOncedenVarMi(txtistekno.Text))
					{
						baglanti.Open();
						string kayit = "insert into laboratuvar_musteri(istek_no,firma_adi,firma_tel,yetkili_kisi,firma_mail,giriste_teslim_alan,giriste_teslim_eden,cikista_teslim_alan,cikista_teslim_eden,firma_adres,firma_not,giris_tarihi,test_tarihi,bitis_tarihi,teknikDeger,yardimciEkipman,gozleKontrol,ambalajKontrol) values (@istek_no,@firma_adi,@firma_tel,@yetkili_kisi,@firma_mail,@giriste_teslim_alan,@giriste_teslim_eden,@cikista_teslim_alan,@cikista_teslim_eden,@firma_adres,@firma_not,@giris_tarihi,@test_tarihi,@bitis_tarihi,@teknikDeger,@yardimciEkipman,@gozleKontrol,@ambalajKontrol)";
						SqlCommand komut = new SqlCommand(kayit, baglanti);
						komut.Parameters.AddWithValue("@istek_no", txtistekno.Text);
						komut.Parameters.AddWithValue("@firma_adi", txtfirmaad.Text);
						komut.Parameters.AddWithValue("@firma_tel", txtfirmatel.Text);
						komut.Parameters.AddWithValue("@yetkili_kisi", txtyetkilikisi.Text);
						komut.Parameters.AddWithValue("@firma_mail", txtfirmamail.Text);
						komut.Parameters.AddWithValue("@giriste_teslim_alan", txtgiristeteslimalan.Text);
						komut.Parameters.AddWithValue("@giriste_teslim_eden", txtgiristeteslimeden.Text);
						komut.Parameters.AddWithValue("@cikista_teslim_alan", txtcikistateslimalan.Text);
						komut.Parameters.AddWithValue("@cikista_teslim_eden", txtcikistateslimeden.Text);
						komut.Parameters.AddWithValue("@firma_adres", txtfirmaadres.Text);
						komut.Parameters.AddWithValue("@firma_not", txtnotlar.Text);
						komut.Parameters.AddWithValue("@giris_tarihi", dtgiristarihi.Text);
						komut.Parameters.AddWithValue("@test_tarihi", dttesttarihi.Text);
						komut.Parameters.AddWithValue("@bitis_tarihi", dtbitistarihi.Text);
						komut.Parameters.AddWithValue("@teknikDeger", cbteknikdeger.Checked);
						komut.Parameters.AddWithValue("@yardimciEkipman", cbyardimciekipman.Checked);
						komut.Parameters.AddWithValue("@gozleKontrol", cbgozlekontrol.Checked);
						komut.Parameters.AddWithValue("@ambalajKontrol", cbambalaj.Checked);
						komut.ExecuteNonQuery();
						baglanti.Close();

						if (MessageBox.Show("Firma ve Numune Başarılı Bir Şekilde Kaydedilmiştir.") == DialogResult.OK)
						{
							this.Close();
						};
					}
					else
					{
						MessageBox.Show($"Girmiş olduğunuz {txtistekno.Text.ToLower()} istek numarası daha önceden kayıt edilmiştir.");
					}

				}
			}
			catch (Exception hata)
			{

				MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
			}
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

		public void urunlistesigetir()
		{
			DataTable urunlerTable = new DataTable();
			SqlCommand comm = new SqlCommand($"SELECT numune_id,numune_numarasi, numune_ad, deney_methodu FROM [numune_tablosu] where numune_numarasi LIKE '{txtistekno.Text}%'", baglanti);
			SqlDataAdapter adapter = new SqlDataAdapter(comm);
			adapter.Fill(urunlerTable);
			grdurun.DataSource = urunlerTable;
			grdurun.Columns[0].Visible = false;
		}

		private void grdurun_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			idal();
			urunveridoldur();
		}
		private void idal()
		{
			int SelectValue = grdurun.CurrentRow.Index;
			txturunid.Text = grdurun.Rows[SelectValue].Cells[0].Value.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			urunsil();

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
					komut.ExecuteNonQuery();
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
		private void urunveridoldur()
		{
			int SelectValue = grdurun.CurrentRow.Index;
			txturunid.Text = grdurun.Rows[SelectValue].Cells["numune_id"].Value.ToString();
			txtnumuneNo.Text = grdurun.Rows[SelectValue].Cells["numune_numarasi"].Value.ToString();
			txtnumuneAdi.Text = grdurun.Rows[SelectValue].Cells["numune_ad"].Value.ToString();
			cmbDeneyMethodu.Text = grdurun.Rows[SelectValue].Cells["deney_methodu"].Value.ToString();
		}

		private void txtnumuneNo_MouseDown(object sender, MouseEventArgs e)
		{
			TextBox tiklananTextbox = sender as TextBox;
			if (tiklananTextbox.Text == "Numune No Giriniz")
			{
				tiklananTextbox.Clear();
				tiklananTextbox.ForeColor = Color.Black;
			}
		}

		private void txtnumuneAdi_MouseDown(object sender, MouseEventArgs e)
		{
			TextBox tiklananTextbox = sender as TextBox;
			if (tiklananTextbox.Text == "Numune Adını Giriniz")
			{
				tiklananTextbox.Clear();
				tiklananTextbox.ForeColor = Color.Black;
			}
		}


		private void DVPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.Graphics.DrawString("NUMUNE BİLGİ FORMU", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(300, 60));
			e.Graphics.DrawString("İsten  No		:" + txtistekno.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 150));
			e.Graphics.DrawString("Firma Adı		:" +txtfirmaad.Text , new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 170));
			e.Graphics.DrawString("Firma Tel		:" + txtfirmatel.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 190));
			e.Graphics.DrawString("Yetkili Kişi		:" + txtyetkilikisi.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 210));
			e.Graphics.DrawString("Firma Mail		:" + txtfirmamail.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 230));
			e.Graphics.DrawString("Firma Adres		:" + txtfirmaadres.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 250));
			e.Graphics.DrawString("Giriş Tarihi		:" + dtgiristarihi.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 270));
			e.Graphics.DrawString("Girişte Teslim Eden   :" + txtgiristeteslimeden.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 350));
			e.Graphics.DrawString("Girişte Teslim Eden   :" + txtgiristeteslimalan.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 390));
			e.Graphics.DrawString("Çıkışta Teslim Eden   :" + txtcikistateslimeden.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, 350));
			e.Graphics.DrawString("Çıkışta Teslim Alan   :" + txtcikistateslimalan.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, 390));
			e.Graphics.DrawString("NUMUNE KABUL ŞARTLARI", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(280, 450));

			Bitmap bm = new Bitmap(this.grdurun.Width, this.grdurun.Height);
			grdurun.DrawToBitmap(bm, new Rectangle(0, 0, this.grdurun.Width, this.grdurun.Height));
			e.Graphics.DrawImage(bm, 10, 600);
			e.Graphics.DrawString("Hazırlayan", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(70, 950));
			e.Graphics.DrawString("Laboratuvar Teknik Yöneticisi", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 980));
			e.Graphics.DrawString("Kontrol", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(400, 950));
			e.Graphics.DrawString("Kalite Yönetim Temsilcisi", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(350, 980));
			e.Graphics.DrawString("Onay", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(700, 950));
			e.Graphics.DrawString("Genel Müdür", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(675, 980));

			/* checkboxlar */
			e.Graphics.DrawString($"{cbteknikdeger.Text}	{(cbteknikdeger.Checked ? "Var": "Yok")}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 500));
			e.Graphics.DrawString(cbgozlekontrol.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 550));
			e.Graphics.DrawString(cbyardimciekipman.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, 500));
			e.Graphics.DrawString(cbambalaj.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, 550));


		}
		private void btnyazdir_Click(object sender, EventArgs e)
		{
			DVPrintPreviewDialog.Document = DVPrintDocument;
			DVPrintPreviewDialog.ShowDialog();
		}

	}

}



