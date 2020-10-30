using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CSharpOOP.Models
{
    [Table("vehicle")]
    public class Vehicle
    {
        [Key]
        [Column("ID", TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column("Manufacturer", TypeName = "varchar(30)")]
        public string Manufacturer { get; set; }

        [Column("Model", TypeName = "varchar(30)")]
        public string Model { get; set; }

        [Column("ModelYear", TypeName = "int(10)")]
        public int ModelYear { get; set; }

        [Column("Colour", TypeName = "varchar(30)")]
        public string Colour { get; set; }

    }
}