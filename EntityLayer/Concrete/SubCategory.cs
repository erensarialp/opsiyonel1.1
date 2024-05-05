using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class SubCategory
	{
		public int Id { get; set; }
		public int ParentCategoryId { get; set; }
		public string Name { get; set; }
	}
}
