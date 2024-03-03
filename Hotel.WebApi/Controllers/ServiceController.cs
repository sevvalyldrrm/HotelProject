using Hotel.BusinessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IServiceService _serviceService;

		public ServiceController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		// GET: api/Service
		[HttpGet]
		public IActionResult ServiceList()
		{
			var services = _serviceService.TGetList();
			return Ok(services);
		}

		// POST: api/Service
		[HttpPost]
		public IActionResult AddService(Service service)
		{
			_serviceService.TInsert(service);
			return Ok();
		}

		// DELETE: api/Service/{id}
		[HttpDelete("{id}")]
		public IActionResult DeleteService(int id)
		{
			var service = _serviceService.TGetByID(id);
			_serviceService.TDelete(service);
			return Ok();
		}

		// PUT: api/Service
		[HttpPut]
		public IActionResult UpdateService(Service service)
		{
			_serviceService.TUpdate(service);
			return Ok();
		}

		// GET: api/Service/{id}
		[HttpGet("{id}")]
		public IActionResult GetService(int id)
		{
			var service = _serviceService.TGetByID(id);
			return Ok(service);
		}
	}
}
