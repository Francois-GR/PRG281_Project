using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG
{
    public class Artist
    {
        private List<Music> ArtistMusic = new List<Music>();
        private string ArtistName;

        public Artist(string ArtistName)
        {
            this.ArtistName = ArtistName;
        }

        public void AddMusic(string songname, Genre genre)
        {
            ArtistMusic.Add(new Music(songname, genre));
        }

        public List<Music> GetMusic() { return ArtistMusic; }

        public string GetArtistName() { return ArtistName; }
    }
    
}
