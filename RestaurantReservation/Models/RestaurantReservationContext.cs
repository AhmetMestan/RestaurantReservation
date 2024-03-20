using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Models
{
    public class RestaurantReservationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-D2UVJQ0; Database = RestaurantReservation; trusted_connection =true; trustServerCertificate=true");
        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Orders> Orders { get; set; }

    }
}
