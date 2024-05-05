using EntityLayer.Concrete;
using System.Collections.Generic;

namespace guncelopsiyonel.DTO
{
	public class CategoryAndSubCategories
	{
		public Category Category { get; set; }
		public List<SubCategory> SubCategories { get; set; }
	}
}
