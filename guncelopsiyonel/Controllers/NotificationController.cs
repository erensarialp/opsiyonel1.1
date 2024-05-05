using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace guncelopsiyonel.Controllers
{
	public class NotificationController : Controller
	{
		NotificationManager nm = new NotificationManager(new EfNotificationDal());
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult AllNotification()
		{
			return View();
		}
	}
}
