using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Bid
	{
		public int Id { get; set; }
		public string BSN { get; set; }
		public int ProductId { get; set; }
		public int UserId { get; set; }
		public int PaymentId { get; set; }
		public double Amount { get; set; }
		public double WarrantPrice { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
