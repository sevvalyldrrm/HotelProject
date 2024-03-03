using Hotel.BusinessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		// GET: api/Testimonial
		[HttpGet]
		public IActionResult TestimonialList()
		{
			var testimonials = _testimonialService.TGetList();
			return Ok(testimonials);
		}

		// POST: api/Testimonial
		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial)
		{
			_testimonialService.TInsert(testimonial);
			return Ok();
		}

		// DELETE: api/Testimonial/{id}
		[HttpDelete("{id}")]
		public IActionResult DeleteTestimonial(int id)
		{
			var testimonial = _testimonialService.TGetByID(id);
			_testimonialService.TDelete(testimonial);
			return Ok();
		}

		// PUT: api/Testimonial
		[HttpPut]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			_testimonialService.TUpdate(testimonial);
			return Ok();
		}

		// GET: api/Testimonial/{id}
		[HttpGet("{id}")]
		public IActionResult GetTestimonial(int id)
		{
			var testimonial = _testimonialService.TGetByID(id);
			return Ok(testimonial);
		}
	}
}
