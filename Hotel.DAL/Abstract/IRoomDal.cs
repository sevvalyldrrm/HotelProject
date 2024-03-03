using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL.Abstract
{
	public interface IRoomDal : IGenericDal<Room>
	{
		public void Delete(Room item)
		{
			throw new NotImplementedException();
		}

		public Room GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Room> GetList()
		{
			throw new NotImplementedException();
		}

		public void Insert(Room item)
		{
			throw new NotImplementedException();
		}

		public void Update(Room item)
		{
			throw new NotImplementedException();
		}
	}
}
