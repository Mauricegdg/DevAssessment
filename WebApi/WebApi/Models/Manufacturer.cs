using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string ManufacturerName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Country { get; set; }
    }
}
