using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counting.Domain.Entities;
using Counting.Domain.Abstract;

namespace Counting.Domain.Concrete
{
   public  class EFCameraRepository:ICamera
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Camera> Cameras
        {
            get
            {
                return context.Cameras;
            }
        }

        public Camera DeleteCamera(int cameraID)
        {
            Camera dbEntry = context.Cameras.Find(cameraID);

            if (dbEntry != null)
            {
                
                context.Cameras.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveCameraConf(Camera camera)
        {
            if (camera.CameraID == 0)
            {
                
                    context.Cameras.Add(camera);

                

            }
            else
            {
                Camera dbEntry = context.Cameras.Find(camera.CameraID);
                if (dbEntry != null)
                {
                    dbEntry.Name = camera.Name;
                    dbEntry.IP = camera.IP;
                    dbEntry.Port = camera.Port;
                    dbEntry.ProtocolID = camera.ProtocolID;
                    dbEntry.LocationID = camera.LocationID;
                    dbEntry.URL = camera.URL;
                    dbEntry.Alias = camera.Alias;







                }
            }
            context.SaveChanges();
        }
    }

}
