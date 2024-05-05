using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace guncelopsiyonel.Controllers
{
	public class ProductController : Controller
	{
		ProductManager pm = new ProductManager(new EfProductDal());
		public IActionResult Index()
		{
			var values = pm.GetList();
			return View(values);
		}
	}
}
