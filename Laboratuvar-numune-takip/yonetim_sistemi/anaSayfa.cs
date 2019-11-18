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
	public partial class anaSayfa : Form
	{
		public anaSayfa()
		{
			InitializeComponent();
		}
		static string veritabanibaglanti = "Data Source=DESKTOP-MN92GN0\\SQLEXPRESS;Initial Catalog=laboratuvarYonetimSistemi;Integrated Security=True";
		SqlConnection baglanti = new SqlConnection(veritabanibaglanti);
		private SqlCommand cmd;
		private SqlDataReader dr;
		private SqlDataAdapter adapter;


		private void anaSayfa_Load(object sender, EventArgs e)
		{
			lblKullaniciAdi.Text = SistemdekiKullanici.LoginOlanKullanici.ToString();
			switch (SistemdekiKullanici.LoginOlanKullanici.yetki)
			{
				case KullaniciYetkileri.satış_personeli:
					btnyoneticiGit.Enabled = false;
					btnlabaratuvarGit.Enabled = false;
					break;
				case KullaniciYetkileri.laboratuvar_personeli:
					btnsatisGit.Enabled = false;
					btnyoneticiGit.Enabled = false;
					break;
				case KullaniciYetkileri.yonetici:
					break;
				default:
					break;
			}

			duyurugetir(listDuyurular);
			notgetir(listView1);
		}

		private void notgetir(ListView listView1)
		{
			SqlCommand komut = new SqlCommand();
			listView1.Items.Clear();
			komut.CommandText = "SELECT not_id,notlar from notlar where user_id = @user_id order by not_id desc";
			komut.Connection = baglanti; komut.Parameters.AddWithValue("@user_id", SistemdekiKullanici.LoginOlanKullanici.user_id);
			SqlDataAdapter adap = new SqlDataAdapter(komut);
			DataTable tablo = new DataTable();
			adap.Fill(tablo);

			for (int i = 0; i < tablo.Rows.Count; i++)
			{
				string not = tablo.Rows[i]["notlar"].ToString();
				int not_id = Convert.ToInt32(tablo.Rows[i]["not_id"]);
				ListViewItem eklenecekItem = new ListViewItem(not);
				eklenecekItem.Tag = not_id;

				listView1.Items.Add(eklenecekItem);
			}


		}

		public void duyurugetir(ListView duyuruListesi)
		{
			SqlCommand komut = new SqlCommand();
			komut.CommandText = "SELECT duyurular from duyurular order by duyuru_id desc";
			komut.Connection = baglanti;
			SqlDataAdapter adap = new SqlDataAdapter(komut);
			DataTable tablo = new DataTable();
			adap.Fill(tablo);
			for (int i = 0; i < tablo.Rows.Count; i++)
			{
				duyuruListesi.Items.Add(tablo.Rows[i]["duyurular"].ToString());


			}
		}


		private void btnsatisGit_Click(object sender, EventArgs e)
		{
            satisSayfasi satisform = new satisSayfasi();
            satisform.ShowDialog();

		}

		public void btnoturumuKapat_Click(object sender, EventArgs e)
		{
			DialogResult sonuc;
			sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (sonuc == DialogResult.No)
			{
				//MessageBox.Show("");// hiçbir işlem yaptırmıyorum
			}
			if (sonuc == DialogResult.Yes)
			{
				this.Close();
				Application.Exit();
			}
		}

		

		private void btnlabaratuvarGit_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["LaboratuvarModulu"] == null)
			{
				LaboratuvarModulu.laboratuvarAnaSayfa laboratuvar = new LaboratuvarModulu.laboratuvarAnaSayfa();
				laboratuvar.Show();
				this.Close();
			}
		}


		private void btnyoneticiGit_Click(object sender, EventArgs e)
		{
			YoneticiModulu.yeniKullaniciKayit panel = new YoneticiModulu.yeniKullaniciKayit();
			panel.ShowDialog();
		}

		private void btnsimgedurumunaTamekran_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}


		private void btnDoviz_Click(object sender, EventArgs e)
		{
			dovizKurlari kursayfasi = new dovizKurlari();
			kursayfasi.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			yeniDuyuru duyuru = new yeniDuyuru(listDuyurular);
			duyuru.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			yeniNot not = new yeniNot(listView1);
			not.ShowDialog();
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			notdetay detay = new notdetay();
			detay.ShowDialog();
		}
		private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			notdetay detay = new notdetay();
			string not = listView1.SelectedItems[0].SubItems[0].Text;
			detay.txtNotDetay.Text = not;
			detay.ShowDialog();
		}

		private void notSil(int id)
		{

			try
			{
				if (MessageBox.Show("Notu Silmek İstediğinize Emin Misiniz?", "SİL", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					string sql = "delete from notlar where not_id=" + id + "";
					cmd = new SqlCommand(sql, baglanti);

					baglanti.Open();
					int etkilenenSatir = cmd.ExecuteNonQuery();
					if (etkilenenSatir > 0)
					{
						MessageBox.Show("Notunuz Başarılı Bir Şekilde Silinmiştir.");
						notgetir(listView1);
					}

					baglanti.Close();
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Bir Hata Oluştu");
				baglanti.Close();
			}
		}
		private void btnNotSil_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				var secilenItem = listView1.SelectedItems[0];
				int secilenNotId = Convert.ToInt32(secilenItem.Tag);

				notSil(secilenNotId);
			}
			else
			{
				MessageBox.Show("Lütfen silinecek bir not seçiniz.");
			}

		}

		private void listDuyurular_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			duyurulardetayi sayfa = new duyurulardetayi();
			string duyurutexti = listDuyurular.SelectedItems[0].SubItems[0].Text;
			sayfa.txtduyurudetayi.Text = duyurutexti;
			sayfa.ShowDialog();
		}

        private void btnYardim_Click(object sender, EventArgs e)
        {
           
        }
    }
}
