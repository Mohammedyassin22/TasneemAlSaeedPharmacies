using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Context
{
    public class PharmaciesDbContext:IdentityDbContext<AppUser>
    {
        public static List<Discounts> GetDiscounts()
        {
            var startDate = DateTime.Now;
            return new List<Discounts>
    {
        new Discounts { Discount = 10, Description = "خصم 10%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 20, Description = "خصم 20%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 30, Description = "خصم 30%", Start = startDate, End = startDate.AddMonths(2) },
        new Discounts { Discount = 40, Description = "خصم 40%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 50, Description = "خصم 50%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 60, Description = "خصم 60%", Start = startDate, End = startDate.AddMonths(2) },
        new Discounts { Discount = 70, Description = "خصم 70%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 80, Description = "خصم 80%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 90, Description = "خصم 90%", Start = startDate, End = startDate.AddMonths(2) },
        new Discounts { Discount = 15, Description = "خصم 15%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 25, Description = "خصم 25%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 35, Description = "خصم 35%", Start = startDate, End = startDate.AddMonths(2) },
        new Discounts { Discount = 45, Description = "خصم 45%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 55, Description = "خصم 55%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 65, Description = "خصم 65%", Start = startDate, End = startDate.AddMonths(2) },
        new Discounts { Discount = 75, Description = "خصم 75%", Start = startDate, End = startDate.AddMonths(1) },
        new Discounts { Discount = 85, Description = "خصم 85%", Start = startDate, End = startDate.AddMonths(1) }
    };
        }
        public static List<Category> GetCategory()
        {
            return new List<Category>
    {
        new Category { CategoryId = 1, CategoryName = "Electronics", totalcategory = 0, Sold = 0 },
        new Category { CategoryId = 2, CategoryName = "Clothing", totalcategory = 0, Sold = 0 },
        new Category { CategoryId = 3, CategoryName = "Home Appliances", totalcategory = 0, Sold = 0 },
        new Category { CategoryId = 4, CategoryName = "Books", totalcategory = 0, Sold = 0 },
        new Category { CategoryId = 5, CategoryName = "Sports", totalcategory = 0, Sold = 0 },
        new Category { CategoryId = 6, CategoryName = "Toys", totalcategory = 0, Sold = 0 },
        new Category { CategoryId = 7, CategoryName = "Furniture", totalcategory = 0, Sold = 0 },
        new Category { CategoryId = 8, CategoryName = "Beauty", totalcategory = 0, Sold = 0 }
    };
        }


        public PharmaciesDbContext(DbContextOptions<PharmaciesDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Discounts> Discounts { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Evaluation> Evaluation { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItme> OrdersItme { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

    }
}
