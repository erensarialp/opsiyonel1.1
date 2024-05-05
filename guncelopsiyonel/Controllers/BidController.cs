using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace guncelopsiyonel.Controllers
{
	public class BidController : Controller
	{
		BidManager bidManager = new BidManager(new EfBidDal());
		ProductManager productManager = new ProductManager(new EfProductDal());
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateBid(Bid bid, int productId, string PSN, int paymentId)
		{
			int userId = 72;
			DateTime now = DateTime.Now;

			Product product = productManager.GetById(productId);

			if (!((product.StartAt < now) && (now < product.EndAt)))
			{
				return BadRequest("Teklif Verme Süresi İçinde Değil!");
			}

			bid.BSN = PSN.Substring(Math.Max(0, PSN.Length - 5)) + "BID" + userId; //C75X2BID72
			bid.ProductId = productId;
			bid.CreatedAt = now;
			bid.PaymentId = paymentId;

			bidManager.Add(bid);
			return View();
		}
	}
}
