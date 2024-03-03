using Hotel.BusinessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _roomService;

		public RoomController(IRoomService roomService)
		{
			_roomService = roomService;
		}

		// GET: api/Room
		[HttpGet]
		public IActionResult RoomList()
		{
			var rooms = _roomService.TGetList();
			return Ok(rooms);
		}

		// POST: api/Room
		[HttpPost]
		public IActionResult AddRoom(Room room)
		{
			_roomService.TInsert(room);
			return Ok();
		}

		// DELETE: api/Room/{id}
		[HttpDelete("{id}")]
		public IActionResult DeleteRoom(int id)
		{
			var room = _roomService.TGetByID(id);
			_roomService.TDelete(room);
			return Ok();
		}

		// PUT: api/Room
		[HttpPut]
		public IActionResult UpdateRoom(Room room)
		{
			_roomService.TUpdate(room);
			return Ok();
		}

		// GET: api/Room/{id}
		[HttpGet("{id}")]
		public IActionResult GetRoom(int id)
		{
			var room = _roomService.TGetByID(id);
			return Ok(room);
		}
	}
}
