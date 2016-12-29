using CityInfo.API.Entities;
using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        // this keyword tells complier that method extends CityInfoContext
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>()
            {
                 new City()
                {

                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {

                            Name = "Central Park",
                            Description = "The most visited urban park in the United States"
                        },
                        new PointOfInterest()
                        {

                            Name = "Empire State Building",
                            Description = "A 102 story skyscraper in midtown Manhattan"
                        }
                    }
                },
                new City()
                {
                    
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {

                            Name = "Diamond mine",
                            Description = "Big ole diamonds"
                        },
                        new PointOfInterest()
                        {

                            Name = "Cathedral of Our lady",
                            Description = "Lazy Notre Damme"
                        }
                    }
                },
                new City()
                {
                    
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {

                            Name = "Eifel Tower",
                            Description = "Big pointless tower"
                        },
                        new PointOfInterest()
                        {

                            Name = "Louvre",
                            Description = "Super museum."
                        }
                    }
                }
            };
            context.Cities.AddRange(cities);
            context.SaveChanges();

        }
    }
}
