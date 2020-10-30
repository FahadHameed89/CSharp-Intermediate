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
                    "server=;" +
                    "ports=;" +
                    "user=;" +
                    "database=;";
                string version = "10.4.14-MariaDB";
                optionsBuilder.UseMySql(connection, x => x.ServerVersion(version));
            }
        }
    }
}
