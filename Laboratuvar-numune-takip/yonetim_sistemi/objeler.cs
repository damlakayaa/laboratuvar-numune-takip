using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yonetim_sistemi
{
	public class objeler
	{
		public class veritabanibaglanti {
			SqlConnection baglanti = new SqlConnection("Data Source=mssql.sislan.net;Initial Catalog=yeni_crm;Persist Security Info=True;User ID=sa;Password=q1w2E3r4@!");

		}

		public class Kullanicilar {
			public string username { get; set; }
			public string password { get; set; }
			public string yetki { get; set; }
			public string kullanici_image { get; set; }
		}

		public enum KullaniciYetkileri
		{
			satış_personeli = 1,
			belgelendirme_personeli = 2,
			laboratuvar_personeli = 3,
			yonetici = 4
		}

		public enum BelgeDurum
		{
			dosyalar_gonderildi_draft_bekliyor = 1,
			draft_cikti_onay_bekliyor = 2,
			orjinal_belge_cikti = 3,
			teslim_edildi = 4
		}

	}

}
