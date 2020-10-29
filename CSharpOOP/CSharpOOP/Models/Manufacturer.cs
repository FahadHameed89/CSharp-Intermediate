using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpOOP.Models
{
    [Table("manufacturer")]
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        [Key]
        [Column("ID", TypeName = "int(10)")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Name { get; set; }

        [InverseProperty("Manufacturer")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
