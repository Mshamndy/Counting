using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counting.Domain.Entities;
using Counting.Domain.Abstract;

namespace Counting.Domain.Concrete
{
  public  class EFLocationRepository:ILocation
    {
        private EFDbContext context = new EFDbContext();


        public IEnumerable<Location> locations
        {
            get
            {
                return context.Locations;
            }
        }

        
        public Location DeleteLocation(int locationID)
        {
            Location dbEntry = context.Locations.Find(locationID);
            if (dbEntry != null)
            {
                context.Locations.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveLocation(Location location)
        {
            if (location.LocationID == 0)
            {
                context.Locations.Add(location);


            }
            else
            {
                Location dbEntry = context.Locations.Find(location.LocationID);
                if (dbEntry != null)
                {
                  
                    dbEntry.Name = location.Name;
                    dbEntry.Description = location.Description;


                }
            }
            context.SaveChanges();
        }








    }
}
