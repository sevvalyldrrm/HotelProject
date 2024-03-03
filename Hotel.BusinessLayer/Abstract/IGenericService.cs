﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void TInsert(T item);

		void TUpdate(T item);

		void TDelete(T item);

		List<T> TGetList();

		T TGetByID(int id);
	}
}
