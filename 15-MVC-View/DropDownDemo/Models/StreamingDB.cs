using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DropDownDemo.Models
{
    public class StreamingDB : DbContext
    {
        public DbSet<StreamingService> StreamingServices { get; set; }
        public DbSet<Series> Series { get; set; }
    }
}