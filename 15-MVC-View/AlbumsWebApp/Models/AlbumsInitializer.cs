using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AlbumsWebApp.Models
{
    public class AlbumsInitializer : CreateDatabaseIfNotExists<AlbumsDB>
    {
        protected override void Seed(AlbumsDB db)
        {
            base.Seed(db);
            var albumsList = new List<Album>
            {
                new Album{ Title = "Demon Days", Artist = "Gorillaz", ReleaseYear = 2005 },
                new Album{ Title = "Automatic for the People", Artist = "R. E. M.", ReleaseYear = 1992 },
                new Album{ Title = "Lost Isles", Artist = "Oceans Ate Alaska", ReleaseYear = 2015 },
                new Album{ Title = "Illmatic", Artist = "Nas", ReleaseYear = 1994 },
                new Album{ Title = "Punk in Drublic", Artist = "NOFX", ReleaseYear = 1994 }
            };
            albumsList.ForEach(album => db.Albums.Add(album));
            db.SaveChanges();
        }


    }
}