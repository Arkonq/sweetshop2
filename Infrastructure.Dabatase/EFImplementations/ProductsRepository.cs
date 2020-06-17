using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Model;
using Infrastructure.Database.Interface;
using Infrastructure.EntityFramework;

namespace Infrastructure.Database.Implementations
{
	public class ProductsRepository : IRepository<Product>
	{
		private SweetShopDataContext context;

		public ProductsRepository()
		{
			context = new SweetShopDataContext();
		}

		public bool Add(Product entity)
		{
			var product = context.Products.Add(entity);
			return (product != null);

		}

		public bool Edit(Product entity)
		{
			throw new NotImplementedException();
		}

		public bool Delete(Product entity)
		{
			throw new NotImplementedException();
		}

		public Product Get(params object[] id)
		{
			throw new NotImplementedException();
		}

		public IList<Product> GetAll()
		{
			return context.Products.ToList();
		}

		public void Save()
		{
			context.SaveChanges();
		}
	}
}
