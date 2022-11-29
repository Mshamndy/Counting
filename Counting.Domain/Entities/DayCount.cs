using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting.Domain.Entities
{
   public class DayCount
    {
        public int ID { get; set; }
        public DateTime  Date { get; set; }

        public int CountIN { get; set; }
        public int CountOUT { get; set; }
        public int TotalVistors { get; set; }
    }
}
