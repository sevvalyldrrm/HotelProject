using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL.Abstract
{
	public interface ITestimonialDal : IGenericDal<Testimonial>
	{
		public void Delete(Testimonial item)
		{
			throw new NotImplementedException();
		}

		public Testimonial GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Testimonial> GetList()
		{
			throw new NotImplementedException();
		}

		public void Insert(Testimonial item)
		{
			throw new NotImplementedException();
		}

		public void Update(Testimonial item)
		{
			throw new NotImplementedException();
		}
	}
}
