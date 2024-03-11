using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DropDownDemo.Models
{
    public class StreamingInit : CreateDatabaseIfNotExists<StreamingDB>
    {
        protected override void Seed(StreamingDB context)
        {
            base.Seed(context);
            var streamingServices = new List<StreamingService>
            {
                new StreamingService { ServiceName = "Netflix" },
                new StreamingService { ServiceName = "HBO Max" },
                new StreamingService { ServiceName = "Disney Plus" },
            };
            streamingServices.ForEach(streamingService => context.StreamingServices.Add(streamingService));
            context.SaveChanges();

            var seriesList = new List<Series>
            {
                new Series { SeriesName = "The Office", StreamingServiceID = 1},
                new Series { SeriesName = "Altered Carbon", StreamingServiceID = 1},
                new Series { SeriesName = "The Wire", StreamingServiceID = 2},
                new Series { SeriesName = "Silicon Valley", StreamingServiceID = 2},
                new Series { SeriesName = "Firefly", StreamingServiceID = 3},
                new Series { SeriesName = "Scrubs", StreamingServiceID = 3},
            };
            seriesList.ForEach(s => context.Series.Add(s));
            context.SaveChanges();
        }
    }
}