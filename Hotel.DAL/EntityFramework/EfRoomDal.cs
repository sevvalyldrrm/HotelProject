using Hotel.DAL.Abstract;
using Hotel.EntityLayer.Concrete;
using Hotel.DataAccessLayer.Concrete;
using Hotel.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccessLayer.EntityFramework
{
	public class EfRoomDal:GenericRepository<Room>, IRoomDal
	{
		public EfRoomDal(Context context):base(context) { }
	}
}
