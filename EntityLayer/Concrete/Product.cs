using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Product
	{
		public int Id { get; set; }
		public string psn { get; set; }
		public int SellerUserId { get; set; }
		public int CategoryId { get; set; }
		public int SubCategoryId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public double MainPrice { get; set; }
		public double WarrantPrice { get; set; }
		public double StartingPrice { get; set; }
		public DateTime StartAt { get; set; }
		public DateTime EndAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Status { get; set; }
		public bool IsPublished { get; set; }
	}
}
