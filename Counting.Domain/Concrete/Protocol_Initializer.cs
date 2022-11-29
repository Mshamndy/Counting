using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Counting.Domain.Entities;

namespace Counting.Domain.Concrete
{
    public class Protocol_Initializer:DropCreateDatabaseIfModelChanges<EFDbContext>
    {


        protected override void Seed(EFDbContext context)
        {
            Protocol webrtc = new Protocol() { Name = "WebRTC", Description = "Fast Video Streaming" };
            Protocol RTSP = new Protocol() { Name = "RTSP", Description = "Traditional Video Streaming" };

            context.Protocols.Add(webrtc);
            context.Protocols.Add(RTSP);
            context.SaveChanges();


        }
    }
}
