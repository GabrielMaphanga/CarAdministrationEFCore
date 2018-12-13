using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;


namespace CARSAmind.API.Models
{
    public class CarContext:DbContext
    {
        public CarContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(new Car
            {
               Id = 1,
                Make = "Mecedeze",
                Model = "6x6",
                HorsePower = 800,
                TopSpeed =380,
                Year =2018
            },new Car {


               Id = 2,
                Make = "BMW",
                Model = "x6",
                HorsePower = 300,
                TopSpeed = 280,
                Year = 2018



            });
        }
    }
}
