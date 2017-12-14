using MyECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Command> Comments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<ProductPictures> ProductPictures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Campaigns> Campaigns { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Liked> Likes { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<BasketProduct> BasketProducts { get; set; }

    }
}
