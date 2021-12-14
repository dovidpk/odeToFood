using System;
using Microsoft.EntityFrameworkCore;
using proj_studyno_http.core;

namespace proj_studyno_http.data
{
    public class proj_studyno_httpDBContext: DbContext
    {
        public proj_studyno_httpDBContext()
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
