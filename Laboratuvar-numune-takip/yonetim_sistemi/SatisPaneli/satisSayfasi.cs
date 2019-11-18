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
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
using yonetim_sistemi.Objeler;



namespace yonetim_sistemi
{


	public partial class satisSayfasi : Form
	{

		static string conString = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(conString);
		SqlDataAdapter adapter = new SqlDataAdapter();
		long maksimumKayit = 0;
		DataSet ds = new DataSet();
		int start;
		DialogResult guvenlik = System.Windows.Forms.DialogResult.No;
		private bool Kapatsorgu;

		public satisSayfasi()
		{
			InitializeComponent();
			start = 0;
		}

		private void TabloyuTemizle(FiltreTipi filtreTipi = FiltreTipi.TANIMSIZ, string filtreDegeri = null)
		{
			ds.Clear();
			maksimumKayit = MaksimumKayitSayisiGetir(filtreTipi, filtreDegeri);
		}

		private void btnmusteriKaydet_Click(object sender, EventArgs e)
		{

			try
			{
				if (!string.IsNullOrEmpty(txtfirmaAd.Text) && !string.IsNullOrEmpty(txtfirmaTel.Text)
					&& !string.IsNullOrEmpty(txtgorusulenKisi.Text) && !string.IsNullOrEmpty(txtgorusenKisi.Text)
					&& !string.IsNullOrEmpty(txtfirmaMail.Text))
				{
					if (cmbsektor.SelectedItem != null && cmbil.SelectedItem != null)
					{
						if (baglanti.State == ConnectionState.Closed)
						{
							baglanti.Open();
							string kayit = "insert into musteri_tablosu(firma_ad,firma_tel,firma_mail,gorusulenKisi,gorusenPersonel,firma_adres,notlar,gorusme_tarihi,sektor,il) values (@firma_ad,@firma_tel,@firma_mail,@gorusulenKisi,@gorusenPersonel,@firma_adres,@notlar,@gorusme_tarihi,@sektor,@il)";
							SqlCommand komut = new SqlCommand(kayit, baglanti);
							komut.Parameters.AddWithValue("@firma_ad", txtfirmaAd.Text);
							komut.Parameters.AddWithValue("@firma_tel", txtfirmaTel.Text);
							komut.Parameters.AddWithValue("@firma_mail", txtfirmaMail.Text);
							komut.Parameters.AddWithValue("@gorusulenKisi", txtgorusulenKisi.Text);
							komut.Parameters.AddWithValue("@gorusenPersonel", txtgorusenKisi.Text);
							komut.Parameters.AddWithValue("@firma_adres", txtfirmaAdres.Text);
							komut.Parameters.AddWithValue("@notlar", txtfirmaNotlar.Text);
							komut.Parameters.AddWithValue("@gorusme_tarihi", dtpgorusmeTarihi.Text);
							komut.Parameters.AddWithValue("@sektor", cmbsektor.Text);
							komut.Parameters.AddWithValue("@il", cmbil.Text);
							komut.ExecuteNonQuery();
							musterigetir();
							baglanti.Close();
							MessageBox.Show("Müşteri Başarılı Bir Şekilde Eklenmişti");
							alanlarıTemizle();
						}
					}
					else
					{
						MessageBox.Show("Lütfen sektör veya il seçiniz.");
					}
				}
				else
				{
					MessageBox.Show("Lütfen ilgili alanları doldurunuz.");
				}
			}
			catch (Exception hata)
			{

				MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
			}

		}

		private void veridoldur()
		{
			int SelectValue = grdMusteri.CurrentRow.Index;
			txtfirmaid.Text = grdMusteri.Rows[SelectValue].Cells["firma_id"].Value.ToString();
			txtfirmaAd.Text = grdMusteri.Rows[SelectValue].Cells["firma_ad"].Value.ToString();
			txtfirmaTel.Text = grdMusteri.Rows[SelectValue].Cells["firma_tel"].Value.ToString();
			txtfirmaMail.Text = grdMusteri.Rows[SelectValue].Cells["firma_mail"].Value.ToString();
			txtgorusulenKisi.Text = grdMusteri.Rows[SelectValue].Cells["gorusulenKisi"].Value.ToString();
			txtgorusenKisi.Text = grdMusteri.Rows[SelectValue].Cells["gorusenPersonel"].Value.ToString();
			txtfirmaAdres.Text = grdMusteri.Rows[SelectValue].Cells["firma_adres"].Value.ToString();
			txtfirmaNotlar.Text = grdMusteri.Rows[SelectValue].Cells["notlar"].Value.ToString();
			dtpgorusmeTarihi.Text = grdMusteri.Rows[SelectValue].Cells["gorusme_tarihi"].Value.ToString();
			cmbsektor.Text = grdMusteri.Rows[SelectValue].Cells["sektor"].Value.ToString();
			cmbil.Text = grdMusteri.Rows[SelectValue].Cells["il"].Value.ToString();
		}

		private void musterigetir()
		{

			btnfirmaSil.Enabled = false;
			if (SistemdekiKullanici.LoginOlanKullanici.yetki == KullaniciYetkileri.yonetici)
			{
				SqlCommand cmd;
				TabloyuTemizle(FiltreTipi.ILK_ACILIS_HEPSI);
				string sorgu = "select firma_id,firma_ad,firma_tel,firma_mail,gorusulenkisi,gorusenPersonel,firma_adres,notlar,gorusme_tarihi,sektor,il,musteri_durum from musteri_tablosu order by firma_id desc";
				cmd = new SqlCommand(sorgu, baglanti);
				adapter.SelectCommand = cmd;
				start = 0;
				adapter.Fill(ds, start, 50, "musteri_tablosu");
				grdMusteri.DataSource = ds.Tables[0];
				btngeri.Enabled = false;
				grdMusteri.Columns[0].Visible = false;
				grdMusteri.Columns[11].Visible = false;
				kolonlariRenklendir(grdMusteri);
			}
            else
            {
                SqlCommand komut = new SqlCommand();
                TabloyuTemizle(FiltreTipi.ILK_ACILIS_KULLANICI, SistemdekiKullanici.LoginOlanKullanici.ad_soyad);
                komut.CommandText = "select firma_id,firma_ad,firma_tel,firma_mail,gorusulenkisi,gorusenPersonel,firma_adres,notlar,gorusme_tarihi,sektor,il,musteri_durum from musteri_tablosu where gorusenPersonel=@gorusenPersonel order by firma_id desc";
                komut.Connection = baglanti;
                komut.Parameters.AddWithValue("@gorusenPersonel", SistemdekiKullanici.LoginOlanKullanici.ad_soyad);
                start = 0;
                adapter.SelectCommand = komut;
                adapter.Fill(ds);
                grdMusteri.DataSource = ds.Tables[0];
                grdMusteri.Columns[0].Visible = false;
                grdMusteri.Columns[11].Visible = false;
                kolonlariRenklendir(grdMusteri);
                int kayitsayisi;
                kayitsayisi = grdMusteri.RowCount;
                //txtkayitsayisi.Text = (kayitsayisi.ToString());
                cmbpersonelegorelistele.Visible = false;
                btnpersonelegore.Visible = false;
            }
		}

		private void kolonlariRenklendir(DataGridView grdMusteri)
		{
			if (grdMusteri.Rows.Count > 0)
			{
				foreach (DataGridViewRow item in grdMusteri.Rows)
				{
					int musteriDurum = Convert.ToInt32(item.Cells[11].Value);

					switch (musteriDurum)
					{
						case 2:
							item.DefaultCellStyle.BackColor = Color.Orange;
							item.DefaultCellStyle.ForeColor = Color.White;
							break;
						case 3:
							item.DefaultCellStyle.BackColor = Color.Green;
							item.DefaultCellStyle.ForeColor = Color.White;
							break;
						case 4:
							item.DefaultCellStyle.BackColor = Color.OrangeRed;
							item.DefaultCellStyle.ForeColor = Color.White;
							break;
					}
				}
			}
		}

		private void alanlarıTemizle()
		{
			txtfirmaAd.Clear();
			txtfirmaTel.Clear();
			txtfirmaMail.Clear();
			txtgorusulenKisi.Clear();
			txtfirmaAdres.Clear();
			txtfirmaNotlar.Clear();
			txtfirmaid.Clear();
			cmbil.SelectedIndex = -1;
			cmbsektor.SelectedIndex = -1;

		}

		private long MaksimumKayitSayisiGetir(FiltreTipi filtreTipi = FiltreTipi.TANIMSIZ, string filtreDegeri = null)
		{
            long sayi = 0;
            string komutcumlesi = string.Empty;
            switch (filtreTipi)
            {
                case FiltreTipi.TANIMSIZ:
                case FiltreTipi.ILK_ACILIS_HEPSI:
                    komutcumlesi = "select count(firma_id) from musteri_tablosu";
                    break;
                case FiltreTipi.PERSONELE_GORE:
                case FiltreTipi.ILK_ACILIS_KULLANICI:
                    komutcumlesi = $"select count(gorusenPersonel) from musteri_tablosu where gorusenPersonel = '{filtreDegeri}'";
                    break;
                case FiltreTipi.ILE_GORE_HEPSI:
                    komutcumlesi = $"select count(firma_id) from musteri_tablosu where il = '{filtreDegeri}'";
                    break;
                case FiltreTipi.ILE_GORE_KULLANICI:
                    komutcumlesi = $"select count(firma_id) from musteri_tablosu where il = '{filtreDegeri} and gorusenPersonel=@gorusenPersonel'";
                    break;
                case FiltreTipi.TANITIM_GONDERILENLER_HEPSI:
                    komutcumlesi = $"select count(firma_id) from musteri_tablosu where musteri_durum=4";
                    break;
                case FiltreTipi.TANITIM_GONDERILENLER_KULLANICI:
                    komutcumlesi = $"select count(gorusenPersonel) from musteri_tablosu where musteri_durum=4 and gorusenPersonel='{filtreDegeri}'";
                    break;
                case FiltreTipi.TEKLIF_GONDERILENLER_HEPSI:
                    komutcumlesi = $"select count(firma_id) from musteri_tablosu where musteri_durum=2";
                    break;
                case FiltreTipi.TEKLIF_GONDERILENLER_KULLANICI:
                    komutcumlesi = $"select count(gorusenPersonel) from musteri_tablosu where musteri_durum=2 and gorusenPersonel='{filtreDegeri}'";
                    break;
                case FiltreTipi.CALISILANLAR_HEPSI:
                    komutcumlesi = $"select count(firma_id) from musteri_tablosu where musteri_durum=3";
                    break;
                case FiltreTipi.CALISILANLAR_KULLANICI:
                    komutcumlesi = $"select count(gorusenPersonel) from musteri_tablosu where musteri_durum=3 and gorusenPersonel='{filtreDegeri}'";
                    break;
            }

            using (SqlConnection conn = new SqlConnection(conString))
            {

                using (SqlCommand comm = new SqlCommand(komutcumlesi, conn))
                {
                    conn.Open();
                    sayi = Convert.ToInt64(comm.ExecuteScalar());
                    conn.Close();
                }

            }

            txtkayitsayisi.Text = sayi.ToString();
            IleriButonuDenetle(); GeriButonuDenetle();
            return sayi;
        }


		private void satisModulu_Load(object sender, EventArgs e)
		{
			txtgorusenKisi.Text = SistemdekiKullanici.LoginOlanKullanici.ad_soyad;
			baglanti.Open();
			musterigetir();
			baglanti.Close();




		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void grdMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btnfirmaSil.Enabled = true;
			veridoldur();
		}

		private void btntemizle_Click(object sender, EventArgs e)
		{
			alanlarıTemizle();
		}
		private void BtnfirmaSil_Click(object sender, EventArgs e)
		{
			if (!Kapatsorgu)
			{
				guvenlik = MessageBox.Show("Firmayı Silmek İstediğinize Eminmisiniz?", "UYARI", MessageBoxButtons.YesNo);
				Kapatsorgu = guvenlik == System.Windows.Forms.DialogResult.Yes;
			}
			if (guvenlik == System.Windows.Forms.DialogResult.Yes)
			{
				if (Kapatsorgu)
				{
					baglanti.Open();
					string kayit = "delete from musteri_tablosu where firma_id=@firma_id";
					SqlCommand komut = new SqlCommand(kayit, baglanti);
					komut.Parameters.AddWithValue("@firma_id", txtfirmaid.Text);
					komut.ExecuteNonQuery();
					musterigetir();
					baglanti.Close();
				}
				Kapatsorgu = false;
			}
			else
			{
				baglanti.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * from musteri_tablosu where firma_ad like '%" + txtmusteriara.Text + "%'", baglanti);
			SqlDataAdapter da = new SqlDataAdapter(komut);
			DataSet ds1 = new DataSet();
			da.Fill(ds1);
			grdMusteri.DataSource = ds1.Tables[0];
			baglanti.Close();
			kolonlariRenklendir(grdMusteri);
		}

		private void btnguncelle_Click(object sender, EventArgs e)
		{
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
					SqlCommand guncelle = new SqlCommand(" Update musteri_tablosu set firma_ad='" + txtfirmaAd.Text + "',firma_tel='" + txtfirmaTel.Text + "',firma_mail='" + txtfirmaMail.Text + "',gorusulenKisi='" + txtgorusulenKisi.Text + "',gorusenPersonel='" + txtgorusenKisi.Text + "',firma_adres='" + txtfirmaAdres.Text + "',notlar='" + txtfirmaNotlar.Text + "',gorusme_tarihi='" + dtpgorusmeTarihi.Text + "' ,sektor='" + cmbsektor.Text + "' ,il='" + cmbil.Text + "' where firma_id='" + txtfirmaid.Text + "'", baglanti);
					guncelle.ExecuteNonQuery();
					musterigetir();
					baglanti.Close();
				}
				Kapatsorgu = false;
			}
			else
			{
				baglanti.Close();
			}

		}

		private void btnilegoreListele_Click(object sender, EventArgs e)
		{
			TabloyuTemizle(FiltreTipi.ILE_GORE_KULLANICI, cmbilegorelistele.Text);
			SqlCommand komut = new SqlCommand();
			komut.CommandText = "select * from musteri_tablosu where il like '%" + cmbilegorelistele.Text + "%'"; ;
			komut.Connection = baglanti;
			start = 0;
			adapter.SelectCommand = komut;
			adapter.Fill(ds, start, 50, "musteri_tablosu");
			grdMusteri.DataSource = ds.Tables[0];
			kolonlariRenklendir(grdMusteri);
		}

		private void btnpersonelegore_Click(object sender, EventArgs e)
		{
			TabloyuTemizle(FiltreTipi.PERSONELE_GORE, cmbpersonelegorelistele.Text);
			SqlCommand komut = new SqlCommand();
			komut.CommandText = "select * from musteri_tablosu where gorusenPersonel = @parametre";
			komut.Parameters.AddWithValue("@parametre", cmbpersonelegorelistele.Text);
			komut.Connection = baglanti;
			start = 0;
			adapter.SelectCommand = komut;
            adapter.Fill(ds);
			grdMusteri.DataSource = ds.Tables[0];
			kolonlariRenklendir(grdMusteri);
		}

		private void btntumunuListele_Click_1(object sender, EventArgs e)
		{
			baglanti.Open();
			musterigetir();
			baglanti.Close();
		}

		private void btnexcel_Click(object sender, EventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
			uyg.Visible = true;
			Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
			Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
			for (int i = 0; i < grdMusteri.Columns.Count; i++)
			{
				Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
				myRange.Value2 = grdMusteri.Columns[i].HeaderText;
			}

			for (int i = 0; i < grdMusteri.Columns.Count; i++)
			{
				for (int j = 0; j < grdMusteri.Rows.Count; j++)
				{
					Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
					myRange.Value2 = grdMusteri[i, j].Value;
				}
			}


		}

		private void btncalisildi_Click(object sender, EventArgs e)
		{
			if (!Kapatsorgu)
			{
				guvenlik = MessageBox.Show("Çalışıldı Olarak İşaretlemek İstediğinize Eminmisiniz?", "UYARI", MessageBoxButtons.YesNo);
				Kapatsorgu = guvenlik == System.Windows.Forms.DialogResult.Yes;
			}
			if (guvenlik == System.Windows.Forms.DialogResult.Yes)
			{
				if (Kapatsorgu)
				{
					baglanti.Open();
					SqlCommand calisildiisaretle = new SqlCommand(" Update musteri_tablosu Set musteri_durum=3 where firma_id='" + txtfirmaid.Text + "'", baglanti);
					calisildiisaretle.ExecuteNonQuery();
					musterigetir();
					baglanti.Close();
				}
				Kapatsorgu = false;
			}
			else
			{
				baglanti.Close();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (!Kapatsorgu)
			{
				guvenlik = MessageBox.Show("Teklif Gönderildi Olarak İşaretlemek İstediğinize Eminmisiniz?", "UYARI", MessageBoxButtons.YesNo);
				Kapatsorgu = guvenlik == System.Windows.Forms.DialogResult.Yes;
			}
			if (guvenlik == System.Windows.Forms.DialogResult.Yes)
			{
				if (Kapatsorgu)
				{
					baglanti.Open();
					SqlCommand calisildiisaretle = new SqlCommand(" Update musteri_tablosu Set musteri_durum=2 where firma_id='" + txtfirmaid.Text + "'", baglanti);
					calisildiisaretle.ExecuteNonQuery();
					musterigetir();
					baglanti.Close();
				}
				Kapatsorgu = false;
			}
			else
			{
				baglanti.Close();
			}

		}
		private void button2_Click_1(object sender, EventArgs e)
		{
			if (!Kapatsorgu)
			{
				guvenlik = MessageBox.Show("Tanıtım Gönderildi Olarak İşaretlemek İstediğinize Eminmisiniz?", "UYARI", MessageBoxButtons.YesNo);
				Kapatsorgu = guvenlik == System.Windows.Forms.DialogResult.Yes;
			}
			if (guvenlik == System.Windows.Forms.DialogResult.Yes)
			{
				if (Kapatsorgu)
				{
					baglanti.Open();
					SqlCommand calisildiisaretle = new SqlCommand(" Update musteri_tablosu Set musteri_durum=4 where firma_id='" + txtfirmaid.Text + "'", baglanti);
					calisildiisaretle.ExecuteNonQuery();
					musterigetir();
					baglanti.Close();
				}
				Kapatsorgu = false;
			}
			else
			{
				baglanti.Close();
			}
		}

		private void btncalisilanlariListele_Click(object sender, EventArgs e)
		{
            if (SistemdekiKullanici.LoginOlanKullanici.yetki == KullaniciYetkileri.yonetici)
            {
                SqlCommand cmd;
                TabloyuTemizle(FiltreTipi.CALISILANLAR_HEPSI);
                string sorgu = "select * from musteri_tablosu where musteri_durum=3";
                cmd = new SqlCommand(sorgu, baglanti);
                adapter.SelectCommand = cmd;
                start = 0;
                adapter.Fill(ds, start, 50, "musteri_tablosu");
                grdMusteri.DataSource = ds.Tables[0];
                btngeri.Enabled = false;
                grdMusteri.Columns[0].Visible = false;
                grdMusteri.Columns[11].Visible = false;
                kolonlariRenklendir(grdMusteri);
            }

            else
            {
                SqlCommand komut = new SqlCommand();
                TabloyuTemizle(FiltreTipi.CALISILANLAR_KULLANICI, SistemdekiKullanici.LoginOlanKullanici.ad_soyad);
                komut.CommandText = "select * from musteri_tablosu where musteri_durum=3 and gorusenPersonel=@gorusenPersonel order by firma_id desc";
                komut.Connection = baglanti;
                komut.Parameters.AddWithValue("@gorusenPersonel", SistemdekiKullanici.LoginOlanKullanici.ad_soyad);
                start = 0;
                adapter.SelectCommand = komut;
                adapter.Fill(ds);
                grdMusteri.DataSource = ds.Tables[0];
                kolonlariRenklendir(grdMusteri);

            }
        }

		private void btnteklifgonderilenleriListele_Click(object sender, EventArgs e)
		{
			if (SistemdekiKullanici.LoginOlanKullanici.yetki == KullaniciYetkileri.yonetici)
			{
				SqlCommand cmd;
				TabloyuTemizle(FiltreTipi.TEKLIF_GONDERILENLER_HEPSI);
				string sorgu = "select * from musteri_tablosu where musteri_durum=2";
				cmd = new SqlCommand(sorgu, baglanti);
				adapter.SelectCommand = cmd;
				start = 0;
				adapter.Fill(ds, start, 50, "musteri_tablosu");
				grdMusteri.DataSource = ds.Tables[0];
				btngeri.Enabled = false;
				grdMusteri.Columns[0].Visible = false;
				grdMusteri.Columns[11].Visible = false;
				kolonlariRenklendir(grdMusteri);
			}
			else
			{
                SqlCommand komut = new SqlCommand();
                TabloyuTemizle(FiltreTipi.TEKLIF_GONDERILENLER_KULLANICI, SistemdekiKullanici.LoginOlanKullanici.ad_soyad);
                komut.CommandText = "select * from musteri_tablosu where musteri_durum=2 and gorusenPersonel=@gorusenPersonel order by firma_id desc";
                komut.Connection = baglanti;
                komut.Parameters.AddWithValue("@gorusenPersonel", SistemdekiKullanici.LoginOlanKullanici.ad_soyad);
                start = 0;
                adapter.SelectCommand = komut;
                adapter.Fill(ds);
                grdMusteri.DataSource = ds.Tables[0];
                kolonlariRenklendir(grdMusteri);

            }
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (SistemdekiKullanici.LoginOlanKullanici.yetki == KullaniciYetkileri.yonetici)
			{
				SqlCommand cmd;
				TabloyuTemizle(FiltreTipi.TANITIM_GONDERILENLER_HEPSI);
				string sorgu = "select * from musteri_tablosu where musteri_durum=4";
				cmd = new SqlCommand(sorgu, baglanti);
				adapter.SelectCommand = cmd;
				start = 0;
                adapter.Fill(ds);
                grdMusteri.DataSource = ds.Tables[0];
				btngeri.Enabled = false;
				grdMusteri.Columns[0].Visible = false;
				grdMusteri.Columns[11].Visible = false;
				kolonlariRenklendir(grdMusteri);
			}
			else
			{
				SqlCommand komut = new SqlCommand();
				TabloyuTemizle(FiltreTipi.TANITIM_GONDERILENLER_KULLANICI, SistemdekiKullanici.LoginOlanKullanici.ad_soyad);
				komut.CommandText = "select * from musteri_tablosu where musteri_durum=4 and gorusenPersonel=@gorusenPersonel order by firma_id desc";
				komut.Connection = baglanti;
				komut.Parameters.AddWithValue("@gorusenPersonel", SistemdekiKullanici.LoginOlanKullanici.ad_soyad);
				start = 0;
				adapter.SelectCommand = komut;
                adapter.Fill(ds);
                grdMusteri.DataSource = ds.Tables[0];
				kolonlariRenklendir(grdMusteri);

			}
		}

		private void IleriButonuDenetle()
		{
			if (start > maksimumKayit)
			{
				start = (int)maksimumKayit;
				btnileri.Enabled = false;
			}
			else
			{
				btnileri.Enabled = true;
			}
		}

		private void GeriButonuDenetle()
		{
			if (start < 0)
			{
				start = 0;
				btngeri.Enabled = false;
				btnileri.Enabled = true;
			}
			else
			{
				btngeri.Enabled = true;
			}
		}

		private void btnileri_Click(object sender, EventArgs e)
		{
			start = start + 50;
			btngeri.Enabled = true;
			IleriButonuDenetle();

			ds.Clear();
			adapter.Fill(ds, start, 50, "musteri_tablosu");
			kolonlariRenklendir(grdMusteri);
		}

		private void btngeri_Click(object sender, EventArgs e)
		{
			start = start - 50;
			GeriButonuDenetle();

			ds.Clear();
			adapter.Fill(ds, start, 50, "musteri_tablosu");
			kolonlariRenklendir(grdMusteri);
		}

		private void txtgorusenKisi_TextChanged(object sender, EventArgs e)
		{
			txtgorusenKisi.Text = txtgorusenKisi.Text.ToUpper();
		}

		private void txtkayitsayisi_TextChanged(object sender, EventArgs e)
		{
			IleriButonuDenetle();
			GeriButonuDenetle();
		}
	}

	enum FiltreTipi
	{
        TANIMSIZ = 0,
        PERSONELE_GORE = 1,
        ILE_GORE_HEPSI = 2,
        ILK_ACILIS_HEPSI = 3,
        ILK_ACILIS_KULLANICI = 4,
        TANITIM_GONDERILENLER_HEPSI = 5,
        TANITIM_GONDERILENLER_KULLANICI = 6,
        TEKLIF_GONDERILENLER_HEPSI = 7,
        TEKLIF_GONDERILENLER_KULLANICI = 8,
        CALISILANLAR_HEPSI = 9,
        CALISILANLAR_KULLANICI = 10,
        ILE_GORE_KULLANICI = 11
    }
}