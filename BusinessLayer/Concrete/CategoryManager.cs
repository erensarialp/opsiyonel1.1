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
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void Add(Category entity)
		{
			_categoryDal.Insert(entity);
		}

		public void Delete(Category entity)
		{
			throw new NotImplementedException();
		}

		public Category GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Category> GetList()
		{
			return _categoryDal.GetList();
		}

		public void Update(Category entity)
		{
			throw new NotImplementedException();
		}
	}
}
