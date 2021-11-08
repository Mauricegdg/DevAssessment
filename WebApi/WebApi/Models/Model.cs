using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Model
    {
        [Key]
        public int ModelId { get; set; }
        [Column(TypeName = "int")]
        public int ManufacturerId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string ModelName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ProductionDate { get; set; }
    }
}
