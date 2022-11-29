using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting.Domain.Entities
{
    public class Protocol
    {
        public int ProtocolID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Camera> Camera { get; set; }

    }
}
