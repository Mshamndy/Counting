using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counting.Domain.Entities;

namespace Counting.Domain.Abstract
{
   public interface ILocation
    {
        IEnumerable<Location> locations { get; }
        void SaveLocation(Location location);
        Location DeleteLocation(int locationID);
    }
}
