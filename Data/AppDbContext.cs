using Microsoft.EntityFrameworkCore;
using System;
using FarmFeed.Models.User;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;


namespace FarmFeed.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Models.User.User> Users { get; set; }
        public DbSet<Models.User.Notifications> Notifications { get; set; }

        
        public DbSet<Models.Product.Feed_products> FeedProducts { get; set; }
        public DbSet<Models.Product.Feed_product_materials> FeedProductMaterials { get; set; }  
        public DbSet<Models.Product.Orders> Orders { get; set; }
        public DbSet<Models.Product.Order_items> Order_items { get; set; }
        public DbSet<Models.Product.Production_orders> Production_Orders { get; set; }
        public DbSet<Models.Product.Production_order_materials> Production_Order_Materials { get; set; }
        public DbSet<Models.Product.Product_translations> Product_translations { get; set; }
        public DbSet<Models.Product.raw_materials> Raw_materials { get; set; }

        
        public DbSet<Models.Animal.Animal_types> Animal_Types { get; set; } 


        public DbSet<Models.Delivery.Deliveries> Deliveries { get; set; }
        public DbSet<Models.Delivery.Delivery_tracking> Delivery_Trackings { get; set; }


        public DbSet<Models.Quality.Quality_tests> Quality_Tests { get; set; }  
        public DbSet<Models.Quality.Quality_test_details> Quality_Test_Details { get; set; }

        public DbSet<Models.Quality.Quality_test_types> Quality_Tests_Types { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;port=3306;user=root;password=;database=csd_farmfeed",
                ServerVersion.Parse("8.0.30")
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed users
            modelBuilder.Entity<Models.User.User>().HasData(
                new Models.User.User
                {
                    UserId = 1,
                    Name = "Admin Gebruiker",
                    Email = "admin@example.com",
                    Password = "admin123", // In productie: wachtwoorden hashen!
                    Role = "Admin"
                }

            );


        }
    }
}

