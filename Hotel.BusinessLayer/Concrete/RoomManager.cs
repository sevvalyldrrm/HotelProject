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
	public class RoomManager : IRoomService
	{
		private readonly IRoomDal _roomDal;
        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }
        public void TDelete(Room item)
		{
			_roomDal.Delete(item);
		}

		public Room TGetByID(int id)
		{
			return _roomDal.GetByID(id);
		}

		public List<Room> TGetList()
		{
			return _roomDal.GetList();
		}

		public void TInsert(Room item)
		{
			_roomDal.Insert(item);
		}

		public void TUpdate(Room item)
		{
			_roomDal.Update(item);
		}
	}
}
