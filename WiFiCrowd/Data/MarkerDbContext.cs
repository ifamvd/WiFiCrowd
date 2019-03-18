using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiFiCrowd.Models;

namespace WiFiCrowd.Data
{
    public class MarkerDbContext : DbContext
    {

        public DbSet<Marker> Markers { get; set; }

        public MarkerDbContext(DbContextOptions<MarkerDbContext> options)
            : base(options)
        {
        }
    }
}
