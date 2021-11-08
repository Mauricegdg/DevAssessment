using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Manufacturer> tblManufacturer { get; set; }
        public DbSet<Model> tblModel { get; set; }
        public DbSet<Vehicle> tblVehicle { get; set; }
        public DbSet<VehicleStatus> tblVehicleStatuse { get; set; }
    }
}
