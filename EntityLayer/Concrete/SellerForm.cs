using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class SellerForm
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Phone { get; set; }
		public string City { get; set; }
		public string District { get; set; }
	}
}
