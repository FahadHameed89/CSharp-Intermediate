using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CSharpOOP.Models
{
    // Inheriting from Dbcontext provides us most of the functionality. The rest of the fileis customizing to suit our database. 
    public partial class VehicleContext : DbContext
    {
        // Skeleton constructors to add to in the future. 
        public VehicleContext()
        {
        }

        // DbContextOptions is the name of a class that has options. 
        public VehicleContext(DbContextOptions<VehicleContext> options)
            : base(options)
        {
        }

        // Collection properties that allow you to access records from a given table through the context. 
        // These should typically be plural, but some EF Core implementations (like this one) decide to make them singular.
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }

        // Allows configuration options to be specified. By default the connection string is here, but can be moved. 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=cars_makes_models", x => x.ServerVersion("10.4.14-mariadb"));
            }
        }

        // All the options pertaining to model relationships and string collation are specified. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Speicifes options for a given model (in the angle brackets).
            modelBuilder.Entity<Manufacturer>(entity =>
            {
                // Because we don't have AUTO_INCREMENT on, this was added. IT normally won't be here.
                entity.Property(e => e.Id).ValueGeneratedNever();

                // Specifies collation for text types. This is only needed for strings (varchar, char, text, etc)
                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                // Specifies an index (typically for foreign keys, but not always)
                entity.HasIndex(e => e.ManufacturerId)
                    .HasName("FK_Vehicle_Manufacturer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Colour)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                // Specifies the relationship between two records. 
                // This entitity has one manufacturer.
                entity.HasOne(d => d.Manufacturer)
                // That entity (manufacturer) has many of this record (vehicles).
                    .WithMany(p => p.Vehicles)
                    // This entity has a foreign key property called ManufacturerId.
                    .HasForeignKey(d => d.ManufacturerId)
                    // When the parent is deleted, this controls behaviour. 
                    // Typically this is CASCADE, but we will discuss alternatives later. 
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    // The name of the foreign key constraint. 
                    .HasConstraintName("FK_Vehicle_Manufacturer");
            });
            // Skeleton method to call. 
            OnModelCreatingPartial(modelBuilder);
        }
        // More skeleton methods to call
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
