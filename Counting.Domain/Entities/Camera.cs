using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counting.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Counting.Domain.Entities
{
   public  class Camera
    {
        public int CameraID { get; set; }
        public string  Name { get; set; }
        public int Port { get; set; }
        public string Alias { get; set; }
        public string IP { get; set; }
        [Display(Name = "Location")]
        public int? LocationID { get; set; }
        public int? ProtocolID { get; set; }
        public string URL { get; set; }
        [ForeignKey("LocationID")]
        public virtual Location Location { get; set; }
        public virtual Protocol Protocol { get; set; }

        public virtual ICollection<CameraCount> CameraCount { get; set; }



    }
}
