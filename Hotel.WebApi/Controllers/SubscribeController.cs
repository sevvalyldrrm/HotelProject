using Hotel.BusinessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscribeController : ControllerBase
	{
		private readonly ISubscribeService _subscribeService;

		public SubscribeController(ISubscribeService subscribeService)
		{
			_subscribeService = subscribeService;
		}

		// GET: api/Subscribe
		[HttpGet]
		public IActionResult SubscribeList()
		{
			var subscribes = _subscribeService.TGetList();
			return Ok(subscribes);
		}

		// POST: api/Subscribe
		[HttpPost]
		public IActionResult AddSubscribe(Subscribe subscribe)
		{
			_subscribeService.TInsert(subscribe);
			return Ok();
		}

		// DELETE: api/Subscribe/{id}
		[HttpDelete("{id}")]
		public IActionResult DeleteSubscribe(int id)
		{
			var subscribe = _subscribeService.TGetByID(id);
			_subscribeService.TDelete(subscribe);
			return Ok();
		}

		// PUT: api/Subscribe
		[HttpPut]
		public IActionResult UpdateSubscribe(Subscribe subscribe)
		{
			_subscribeService.TUpdate(subscribe);
			return Ok();
		}

		// GET: api/Subscribe/{id}
		[HttpGet("{id}")]
		public IActionResult GetSubscribe(int id)
		{
			var subscribe = _subscribeService.TGetByID(id);
			return Ok(subscribe);
		}
	}
}
