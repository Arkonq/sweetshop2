using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Database.Interface
{
	public interface IRepository<T> where T : class
	{
		bool Add(T entity);

		bool Edit(T entity);

		bool Delete(T entity);

		T Get(params object[] id);

		IList<T> GetAll();

		void Save();
	}
}