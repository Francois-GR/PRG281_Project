using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG
{
    public class DataHandler
    {

        private List<Player> Players = new List<Player>();
        private List<Artist> artists = new List<Artist>();
           


        public DataHandler()
        {
            Players.Add(new Player("Piet", "1234567890"));
            Players.Add(new Player("Snoop", "Password1234"));
            Players.Add(new Player("Eddie", "ThisIsASafePassword"));
            Players.Add(new Player("Scarlett", "Pass1234567890"));
            Players.Add(new Player("a", "a"));

            //pop artists
            Artist a = new Artist("21 Pilots");
            a.AddMusic("Stressed Out", Genre.Pop);
            a.AddMusic("A Car, a Torch, a Death", Genre.Pop);
            artists.Add(a);
            //Country Artists            
            Artist b = new Artist("Taylor Swift");
            b.AddMusic("If I die young", Genre.Country);
            b.AddMusic("Blank Space", Genre.Pop);
            artists.Add(b);

            //Reggae Artists
            Artist c = new Artist("Jaz Elise");
            c.AddMusic("Good Over Evil", Genre.Reggae);
            c.AddMusic("Straying", Genre.Reggae);
            artists.Add(c);

            //Rock Artists
            Artist d = new Artist("Panic! At The Disco");
            d.AddMusic("High Hopes", Genre.Rock);
            d.AddMusic("LA Devotee", Genre.Rock);
            artists.Add(d);

            //Jazz Artists
            Artist e = new Artist("Django Bates");
            e.AddMusic("Tenacity", Genre.Jazz);
            e.AddMusic("Interval Song", Genre.Jazz);
            artists.Add(e);
            //Heavy metal Artists
            Artist f = new Artist("Nightwish");
            f.AddMusic("Decades", Genre.HeavyMetal);
            f.AddMusic("Imaginaerum", Genre.HeavyMetal);
            artists.Add(f);

            //Gospel artists
            Artist g = new Artist("There is more");
            g.AddMusic("Touch of Heaven", Genre.Gospel);
            g.AddMusic("Be Still", Genre.Gospel);
            artists.Add(g);

            //Dubstep artists
            Artist h = new Artist("Skrillex");
            h.AddMusic("Don't Go", Genre.Dubstep);
            h.AddMusic("First of the year", Genre.Dubstep);
            artists.Add(h);

        }

        public List<Player> GetPlayers() { return Players; }
        public List<Artist> GetArtist() { return artists;  }
        public void AddPlayer(object player)
        {
            Player playerToAdd = (Player)player;
            Players.Add(playerToAdd);
        }

        
    }
}
