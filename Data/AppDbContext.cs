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

        
        public DbSet<Models.Product.FeedProducts> FeedProducts { get; set; }
        public DbSet<Models.Product.FeedProductMaterials> FeedProductMaterials { get; set; }  
        public DbSet<Models.Product.Orders> Orders { get; set; }
        public DbSet<Models.Product.OrderItems> Order_items { get; set; }
        public DbSet<Models.Product.ProductionOrders> Production_Orders { get; set; }
        public DbSet<Models.Product.ProductionOrderMaterials> Production_Order_Materials { get; set; }
        public DbSet<Models.Product.ProductTranslations> Product_translations { get; set; }
        public DbSet<Models.Product.RawMaterials> Raw_materials { get; set; }

        
        public DbSet<Models.Animal.AnimalTypes> Animal_Types { get; set; } 


        public DbSet<Models.Delivery.Deliveries> Deliveries { get; set; }
        public DbSet<Models.Delivery.DeliveryTracking> Delivery_Trackings { get; set; }


        public DbSet<Models.Quality.QualityTests> Quality_Tests { get; set; }  
        public DbSet<Models.Quality.QualityTestDetails> Quality_Test_Details { get; set; }

        public DbSet<Models.Quality.QualityTestTypes> Quality_Tests_Types { get; set; }




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
                    Id = 1,
                    Name = "Admin Gebruiker",
                    Email = "admin@example.com",
                    Password = "admin123", // In productie: wachtwoorden hashen!
                    Role = "Admin"
                }

            );


        }
    }
}

