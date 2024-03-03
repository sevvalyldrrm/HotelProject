using AutoMapper;
using Hotel.DtoLayer.Dtos.RoomDto;
using Hotel.EntityLayer.Concrete;

namespace Hotel.WebApi.Mapping
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig()
		{ 
			CreateMap<RoomAdDto, Room>();
			CreateMap<Room, RoomAdDto>();

			CreateMap<UpdateRoomDto, Room>().ReverseMap(); //yukardaki iki satırı tek satırda yaptırdı
		}
	}
}
