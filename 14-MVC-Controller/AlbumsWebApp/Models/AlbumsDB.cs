using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; // EF : Enitity Framework

namespace AlbumsWebApp.Models
{
    public class AlbumsDB : DbContext // database name AlbumsDB
    {
        public DbSet<Album> Albums { get; set; } // table Albums
    }
}