using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<ProductieBeheerder> ProductieBeheerders  { get; set; }
        public DbSet<Kwaliteitscontrole> KwaliteitsControles { get; set; }
        public DbSet<LogistiekTeam> LogistiekTeams  { get; set; }
        public DbSet<Veeboer> Veeboeren { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;port=3306;user=root;password=;database=csd_farmfeed",
                ServerVersion.Parse("8.0.30")
            );
        }

    }
}
