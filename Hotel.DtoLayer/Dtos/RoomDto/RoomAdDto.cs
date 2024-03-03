using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DtoLayer.Dtos.RoomDto
{
	public class RoomAdDto
	{
		[Required(ErrorMessage = "Lütfen oda numarasını giriniz")]
		public string RoomNumber { get; set; }
		public string RoomCoverImage { get; set; }

		[Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz")]
		//[MaxLength(100, ErrorMessage = "")]
		public int Price { get; set; }

		[Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Lütfen yatak sayısı giriniz")]
		public string BedCount { get; set; }

		[Required(ErrorMessage = "Lütfen banyo sayısı giriniz")]
		[StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakter girişi yapınız")]
		public string BathCount { get; set; }

		public string Wifi { get; set; }

		[Required(ErrorMessage = "Lütfen açıklama giriniz")]

		public string Description { get; set; }
	}
}
