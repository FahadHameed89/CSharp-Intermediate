using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpOOP.Models
{
    // Data annotiations provide EF Core some information about the tables and columns in order to make an accurate model.
    // Defines the name of the table this model references.
    [Table("manufacturer")]
    public partial class Manufacturer
    {
        // Constructor for initializing the virtual property, required because we have the virtual collection. Initialized so it isn't null.
        public Manufacturer()
        {
            Vehicle = new HashSet<Vehicle>();
        }
        // Specifies a PRIMARY KEY
        [Key]
        // Specifies a columnName and data type. If the column name is not provided in the [Column], it will infer that it is identical to the property name
        [Column("ID", TypeName = "int(10)")]
        public int Id { get; set; }

        // Specifies NOT NULL on nullable C# types (Like strings)
        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Name { get; set; }

        // InverseProperty draws a link to a property in another model (used for foreign keys)
        [InverseProperty("Manufacturer")]

        // Prepresents the list of associated records through the foreign key (the records with this record as their parent)
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
