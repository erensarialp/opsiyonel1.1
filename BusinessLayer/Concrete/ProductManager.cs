using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ProductManager : IProductService
	{
		IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void Add(Product entity)
		{
			_productDal.Insert(entity);
		}

		public void Delete(Product entity)
		{
			_productDal.Delete(entity);
		}

		public List<Product> GetByCategory(int categoryId, int subcategoryId)
		{
			return _productDal.GetByCategory(categoryId, subcategoryId);
		}

		public Product GetById(int id)
		{
			return new Product { Id = id };
		}

		public List<Product> GetList()
		{
			return _productDal.GetList();
		}

		public void Update(Product entity)
		{
			_productDal.Update(entity);
		}
	}
}
