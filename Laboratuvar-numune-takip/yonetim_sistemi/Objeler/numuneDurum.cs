using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yonetim_sistemi.Objeler
{
	class numuneDurum
	{
		public static Durumlar numune_durum { get; set; }
	}
	public class Durumlar
		{
		public numunedurumlari durumisimleri { get; set; }
	}
	public enum numunedurumlari {

		test_icin_onay_bekliyor=1,
		test_asamasinda=2,
		test_tamamlandi=3

	}
}
