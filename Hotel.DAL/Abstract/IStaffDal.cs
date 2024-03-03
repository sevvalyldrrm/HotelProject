using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL.Abstract
{
	public interface IStaffDal : IGenericDal<Staff>
	{
		public void Delete(Staff item)
		{
			throw new NotImplementedException();
		}

		public Staff GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Staff> GetList()
		{
			throw new NotImplementedException();
		}

		public void Insert(Staff item)
		{
			throw new NotImplementedException();
		}

		public void Update(Staff item)
		{
			throw new NotImplementedException();
		}
	}
}
