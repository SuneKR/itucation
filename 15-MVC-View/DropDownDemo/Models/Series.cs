using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DropDownDemo.Models
{
    public class Series
    {
        [Key] public int SeriesID { get; set; }
        public string SeriesName { get; set; }
        public int StreamingServiceID { get; set; }
    }
}