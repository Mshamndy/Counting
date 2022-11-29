using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Counting.Domain.Entities;

namespace Counting.Domain.Concrete
{
    public class EFDbContext:DbContext
    {
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Location> Locations { get; set; }

        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<CameraCount> CameraCounts { get; set; }





    }
}
