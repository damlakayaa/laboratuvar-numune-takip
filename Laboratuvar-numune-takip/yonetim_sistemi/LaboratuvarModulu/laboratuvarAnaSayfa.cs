using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yonetim_sistemi.LaboratuvarModulu
{
	public partial class laboratuvarAnaSayfa : Form
	{
		public laboratuvarAnaSayfa()
		{
			InitializeComponent();
		}

		private void btnotorumuKapat_Click(object sender, EventArgs e)
		{		
				this.Close();
				anaSayfa anasayfa = new anaSayfa();
				anasayfa.Show();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnMusteri_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["LaboratuvarModulu"] == null)
			{
				musteriTakip takip = new musteriTakip();
				takip.Show();
				this.Close();
			}
		}

		private void btnNumune_Click(object sender, EventArgs e)
		{
			numuneKayit kayit = new numuneKayit();
			kayit.ShowDialog();
		}

		private void laboratuvarAnaSayfa_Load(object sender, EventArgs e)
		{

		}
		private void btnNumuneTakip_Click(object sender, EventArgs e)
		{
			numuneTakip takip = new numuneTakip();
			takip.ShowDialog();
		}
	}
}
