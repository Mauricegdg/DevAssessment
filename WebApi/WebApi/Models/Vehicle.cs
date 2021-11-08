using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Column(TypeName = "int")]
        public int ModelId { get; set; }
        [Column(TypeName = "int")]
        public int StatusId { get; set; }
        [Column(TypeName = "int")]
        public int Year { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Colour { get; set; }
    }
}
