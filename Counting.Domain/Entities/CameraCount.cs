using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Counting.Domain.Entities
{
    public class CameraCount
    {
        public int ID { get; set; }
        public int? CameraID { get; set; }
        public DateTime Date { get; set; }
        public int CountIN { get; set; }
        public int CountOut { get; set; }
        public DateTime Timestamp { get; set; }
        public virtual Camera Camera { get; set; }


    }
}
