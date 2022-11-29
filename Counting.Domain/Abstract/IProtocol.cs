using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counting.Domain.Entities;

namespace Counting.Domain.Abstract
{
  public interface IProtocol
    {
        IEnumerable<Protocol> protocols { get; }
        void Saveprotocol(Protocol protocol);
        Protocol DeleteProtocol(int protocolID);
    }
}
