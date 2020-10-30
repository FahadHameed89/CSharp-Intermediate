using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CSharpOOP.Models
{
    // Inheriting from Dbcontext provides us most of the functionality. The rest of the fileis customizing to suit our database. 
    public partial class DealershipContext : DbContext
    {
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connection = 
                    "server=localhost;" +
                    "port=3306;" +
                    "user=root;" +
                    "database=codefirst_4point2;";

                string version = "10.4.14-MariaDB";
                optionsBuilder.UseMySql(connection, x => x.ServerVersion(version));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>(entity =>
            {
                // This should be set automatically.
                entity.Property(e => e.Manufacturer)
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Colour)
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_general_ci");
            });
        }
    }
}
