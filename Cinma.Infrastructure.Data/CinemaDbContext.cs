using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Core.Entities;


namespace Cinema.Infrastructure.Data
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(string cnnString)
            :base(cnnString)
        {

        }

            public DbSet<Movie> Movies { get; set; }

            public DbSet<Genre> Genres{ get; set; }

           

    }
}
