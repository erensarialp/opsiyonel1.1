using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Payment
	{
		public int Id { get; set; }
		public string ConversationId { get; set; }
		public string Token { get; set; }
		public int Price { get; set; }
		public string Status { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
