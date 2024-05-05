using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=LAPTOP-HUES47C3;database=Opsiyonel;integrated security=true;");
		}

		public DbSet<Bid> Bids { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductImage> ProductImages { get; set; }
		public DbSet<SellerForm> SellerForms { get; set; }
		public DbSet<SellerFormCategory> SellerFormCategories { get; set; }
		public DbSet<SellerFormDocumentation> SellerFormDocumentations { get; set; }
		public DbSet<SubCategory> SubCategories { get; set; }
		public DbSet<Newsletter> Newsletters { get; set; }
		public DbSet<Notification> Notifications { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }

	}

}

