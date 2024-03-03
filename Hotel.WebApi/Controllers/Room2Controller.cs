using AutoMapper;
using Hotel.BusinessLayer.Abstract;
using Hotel.DtoLayer.Dtos.RoomDto;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Room2Controller : ControllerBase
	{
		private readonly IRoomService _roomService;
		private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _mapper = mapper;
			_roomService = roomService;
        }

		[HttpGet]
		public IActionResult Index()
		{
			var values = _roomService.TGetList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddRoom(RoomAdDto roomAddDto) 
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}
			var values = _mapper.Map<Room>(roomAddDto);
			_roomService.TInsert(values);
			return Ok();
		}

    }
}
