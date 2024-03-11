using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DropDownDemo.Models
{
    public class StreamingService
    {
        [Key] public int StreamingServiceID { get; set; }
        public string ServiceName { get; set; }
        public virtual ICollection<Series> Series { get; set; }
    }
}