using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using guncelopsiyonel.DTO;

namespace guncelopsiyonel.Controllers
{
	public class CategoryController : Controller
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
		SubCategoryManager subCategoryManager = new SubCategoryManager(new EfSubCategoryDal());
		ProductManager productManager = new ProductManager(new EfProductDal());
		public IActionResult Index()
		{
			List<CategoryAndSubCategories> dto = new List<CategoryAndSubCategories>();
			var c = categoryManager.GetList();
			foreach (var item in c)
			{
				var sc = subCategoryManager.GetSubCategories(item.Id);

				CategoryAndSubCategories cas = new CategoryAndSubCategories();
				cas.Category = item;
				cas.SubCategories = sc;

				dto.Add(cas);

			}

			return View(dto);
		}

		[HttpGet]
		public IActionResult CategoryProducts(int categoryId, int subcategoryId)
		{
			var pc = productManager.GetByCategory(categoryId, subcategoryId);
			return View(pc);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(Category category, IFormFile iconFile)
		{
			Console.WriteLine("Category:", category, "\niconfile:", iconFile);

			if (iconFile != null)
			{
				var folderName = "categorypics";
				var uniqueFileName = Guid.NewGuid().ToString();
				if (await FileUploaderOperations.UploadFile(iconFile, uniqueFileName, folderName)== true) 
				{
					category.Icon = "/" + folderName + "/" + uniqueFileName + iconFile.FileName;
					categoryManager.Add(category);
					return RedirectToAction("Index", "Category");
				}
			}

			return View();
		}
	}
}
