﻿
namespace Movie.Models
{
    public class Actor_Film
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
