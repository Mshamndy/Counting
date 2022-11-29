using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counting.Domain.Entities;
using Counting.Domain.Abstract;

namespace Counting.Domain.Concrete
{
   public class EFProtocolRepository:IProtocol
    {
        private EFDbContext context = new EFDbContext();


        public IEnumerable<Protocol> protocols
        {
            get
            {
                return context.Protocols;
            }
        }

        public Protocol DeleteProtocol(int protocolID)
        {
            Protocol dbEntry = context.Protocols.Find(protocolID);
            if (dbEntry != null)
            {
                context.Protocols.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void Saveprotocol(Protocol protocol)
        {
            if (protocol.ProtocolID == 0)
            {
                context.Protocols.Add(protocol);


            }
            else
            {
                Protocol dbEntry = context.Protocols.Find(protocol.ProtocolID);
                if (dbEntry != null)
                {

                    dbEntry.Name = protocol.Name;


                }
            }
            context.SaveChanges();
        }


    }
}

