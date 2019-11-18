using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yonetim_sistemi.Objeler
{
	public static class SistemdekiKullanici
	{
		public static Kullanicilar LoginOlanKullanici { get; set; }
	}

	public class Kullanicilar
	{
		public int user_id { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public KullaniciYetkileri yetki { get; set; }
		public byte[] kullanici_image { get; set; }
		public string ad_soyad { get; set; }

		public override string ToString()
		{
			return ad_soyad;
		}
	}

	public enum KullaniciYetkileri
	{
		satış_personeli = 1,
		laboratuvar_personeli = 2,
		yonetici = 3,
	}
}
