using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL.Abstract
{
	public interface IServiceDal : IGenericDal<Service>
	{
		public void Delete(Service item)
		{
			throw new NotImplementedException();
		}

		public Service GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Service> GetList()
		{
			throw new NotImplementedException();
		}

		public void Insert(Service item)
		{
			throw new NotImplementedException();
		}

		public void Update(Service item)
		{
			throw new NotImplementedException();
		}
	}
}
