using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.EntiyLayer.Concrete;

namespace TeaShopApi.DataAccessLayer.Context
{
	public class TeaContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-40G2DNI\\SQLEXPRESS;initial Catalog=TeaShopDb;integrated Security=true;");
		}
		public DbSet<Drink> Drinks { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Question> Questions { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
	}
}
