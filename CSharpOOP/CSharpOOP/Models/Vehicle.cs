using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CSharpOOP.Models
{
    [Table("vehicle")]
    class Vehicle
    {
        [Key]
        [Column("ID", TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Manufacturer { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Model { get; set; }

        [Column(TypeName = "int(10)")]
        public string ModelYear { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Colour { get; set; }
    }
}
