using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG
{
    public enum Genre
    {
        Rock,
        Pop,
        Jazz,
        Country,
        Reggae,
        HeavyMetal,
        Gospel,
        Dubstep
    };

    public class Music
    {
        private string Name;
        private Genre Genre;

        public Music(string Name, Genre Genre)
        {
            this.Name = Name;
            this.Genre = Genre;
        }

        public string GetSongName() { return Name; }

        public Genre GetGenre() { return Genre; }
    }
}
