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
	public class SubscribeManager : ISubscribeService
	{
		private readonly ISubscribeDal _subscribeDal;
		public SubscribeManager(ISubscribeDal subscribeDal)
		{
			_subscribeDal = subscribeDal;
		}
		public void TDelete(Subscribe item)
		{
			_subscribeDal.Delete(item);
		}

		public Subscribe TGetByID(int id)
		{
			return _subscribeDal.GetByID(id);
		}

		public List<Subscribe> TGetList()
		{
			return _subscribeDal.GetList();
		}

		public void TInsert(Subscribe item)
		{
			_subscribeDal.Insert(item);
		}

		public void TUpdate(Subscribe item)
		{
			_subscribeDal.Update(item);
		}
	}
}
