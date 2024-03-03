using Hotel.DAL.Abstract;
using Hotel.EntityLayer.Concrete;
using Hotel.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BusinessLayer.Concrete
{
	public class StaffManager : IStaffService
	{
		private readonly IStaffDal _staffDal;
		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}
		public void TDelete(Staff item)
		{
			_staffDal.Delete(item);
		}

		public Staff TGetByID(int id)
		{
			return _staffDal.GetByID(id);
		}

		public List<Staff> TGetList()
		{
			return _staffDal.GetList();
		}

		public void TInsert(Staff item)
		{
			_staffDal.Insert(item);
		}

		public void TUpdate(Staff item)
		{
			_staffDal.Update(item);
		}
	}
}
