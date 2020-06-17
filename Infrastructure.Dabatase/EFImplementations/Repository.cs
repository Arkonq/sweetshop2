using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Database.Interface;
using Infrastructure.EntityFramework;

namespace Infrastructure.Database.EFImplementations
{
	class Repository<T> : IRepository<T> where T : class
	{
		private SweetShopDataContext context;

		public Repository()
		{
			context = new SweetShopDataContext();
		}

		public bool Add(T entity)
		{
			throw new NotImplementedException();
		}

		public bool Edit(T entity)
		{
			throw new NotImplementedException();
		}

		public bool Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public T Get(params object[] id)
		{
			throw new NotImplementedException();
		}

		public IList<T> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Save()
		{
			throw new NotImplementedException();
		}
	}
}
