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
	public class SubCategoryManager : ISubCategoryService
	{
		ISubCategoryDal _subcategory;

		public SubCategoryManager(ISubCategoryDal subcategory)
		{
			_subcategory = subcategory;
		}

		public void Add(SubCategory entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(SubCategory entity)
		{
			throw new NotImplementedException();
		}

		public SubCategory GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<SubCategory> GetList()
		{
			return _subcategory.GetList();
		}

		public List<SubCategory> GetSubCategories(int parentId)
		{
			return _subcategory.GetSubCategories(parentId);
		}

		public void Update(SubCategory entity)
		{
			throw new NotImplementedException();
		}
	}
}
