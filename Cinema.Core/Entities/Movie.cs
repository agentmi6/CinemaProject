using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string ImgCover { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
        public Actors Actors { get; set; }
        public cinemaHall cinemaHall { get; set; }
    }
}
