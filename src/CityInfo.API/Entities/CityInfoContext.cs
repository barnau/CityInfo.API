using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class CityInfoContext : DbContext
    {
        //enables you to connect this dbcontext in start up under configure ConfigureServices
        //Injecting dbContext options into constructor to be called by base constructor
        public CityInfoContext(DbContextOptions<CityInfoContext> options) 
            : base(options)
        {
            //If database already created nothing will happen. If not will create database specified in connection string in Startup ConfigureServices method.
            //Database.EnsureCreated(); 
            //Will create and add migration
            Database.Migrate();
        } 
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}
