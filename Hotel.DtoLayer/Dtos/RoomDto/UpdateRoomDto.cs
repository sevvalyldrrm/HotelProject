using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DtoLayer.Dtos.RoomDto
{
	public class UpdateRoomDto
	{
		public int RoomID { get; set; }

		[Required(ErrorMessage = "Lutfen oda numarasini yaziniz")]
		public string RoomNumber { get; set; }

		[Required(ErrorMessage = "Lutfen oda gorseli giriniz")]
		public string RoomCoverImage { get; set; }

		[Required(ErrorMessage = "Lutfen fiyat bilgisini yaziniz")]

		public int Price { get; set; }

		[Required(ErrorMessage = "Lutfen oda basligi bilgisini yaziniz")]
		[StringLength(100, ErrorMessage = "Luften en fazla 100 karakter veri girisini yapiniz")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Lutfen yatak sayisi yaziniz")]
		public string BedCount { get; set; }

		[Required(ErrorMessage = "Lutfen banyo sayisi yaziniz")]
		public string BathCount { get; set; }

		public string Wifi { get; set; }

		[Required(ErrorMessage = "Lutfen aciklamayi yaziniz")]
		public string Description { get; set; }
	}
}
