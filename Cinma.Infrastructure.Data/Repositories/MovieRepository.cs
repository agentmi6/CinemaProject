using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Core.Entities;
using Cinema.Core.Interfaces;

namespace Cinema.Infrastructure.Data.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(CinemaDbContext context)
            : base(context)
        {

        }

        public int Count()
        {
            return _context.Movies.Count();
        }
    }
}
