using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace FarmFeed.Models
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

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
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "Admin Gebruiker",
                    Email = "admin@example.com",
                    Password = "admin123", // In productie: wachtwoorden hashen!
                    Role = "Admin"
                },
                new User
                {
                    UserId = 2,
                    Name = "John Doe",
                    Email = "john.doe@example.com",
                    Password = "john123",
                    Role = "Manager"
                },
                new User
                {
                    UserId = 3,
                    Name = "Jane Smith",
                    Email = "jane.smith@example.com",
                    Password = "jane123",
                    Role = "Operator"
                }
            );
        }
    }
}

