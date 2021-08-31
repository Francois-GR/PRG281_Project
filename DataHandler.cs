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
            Artist a = new Artist("Twenty One Pilots");
            a.AddMusic("Stressed Out", Genre.Pop);
            a.AddMusic("A Car, a Torch, a Death", Genre.Pop);
            a.AddMusic("Tear in My Heart", Genre.Pop);
            a.AddMusic("Jumpsuit", Genre.Pop);
            artists.Add(a);
            //
            Artist i = new Artist("Ed  Sheeran");
            i.AddMusic("Bad Habits", Genre.Pop);
            i.AddMusic("Afterglow", Genre.Pop);
            i.AddMusic("Visiting Hours", Genre.Pop);
            artists.Add(i);

            //Country Artists            
            Artist b = new Artist("Taylor Swift");
            b.AddMusic("If I die young", Genre.Country);
            b.AddMusic("Blank Space", Genre.Country);
            b.AddMusic("ME!", Genre.Country);
            b.AddMusic("Ready For TI", Genre.Country);
            artists.Add(b);
            //
            Artist j = new Artist("Dolly Parton");
            j.AddMusic("Jolene", Genre.Country);
            j.AddMusic("Silevr and Gold", Genre.Country);
            j.AddMusic("9 To 5", Genre.Country);
            artists.Add(j);

            //Reggae Artists
            Artist c = new Artist("Jaz Elise");
            c.AddMusic("Good Over Evil", Genre.Reggae);
            c.AddMusic("Straying", Genre.Reggae);
            artists.Add(c);
            //
            Artist k = new Artist("Bob Marley");
            k.AddMusic("Redemption song", Genre.Reggae);
            k.AddMusic("Three Little Birds", Genre.Reggae);
            artists.Add(k);

            //Rock Artists
            Artist d = new Artist("Panic! At The Disco");
            d.AddMusic("High Hopes", Genre.Rock);
            d.AddMusic("LA Devotee", Genre.Rock);
            artists.Add(d);
            //
            Artist l = new Artist("The Beatles");
            l.AddMusic("Here ccomes the Sun", Genre.Rock);
            l.AddMusic("Something", Genre.Rock);
            artists.Add(l);

            //Jazz Artists
            Artist e = new Artist("Django Bates");
            e.AddMusic("Tenacity", Genre.Jazz);
            e.AddMusic("Interval Song", Genre.Jazz);
            artists.Add(e);
            //
            Artist m = new Artist("Frank Sinatra");
            m.AddMusic("Fly me to the Moon", Genre.Jazz);
            m.AddMusic("New York, New York", Genre.Jazz);
            artists.Add(m);

            //Heavy metal Artists
            Artist f = new Artist("Nightwish");
            f.AddMusic("Decades", Genre.HeavyMetal);
            f.AddMusic("Imaginaerum", Genre.HeavyMetal);
            artists.Add(f);
            //
            Artist n = new Artist("Ozzy Osbourne");
            n.AddMusic("Crasy Train", Genre.HeavyMetal);
            n.AddMusic("War Pigs", Genre.HeavyMetal);
            artists.Add(n);

            //Gospel artists
            Artist g = new Artist("There is more");
            g.AddMusic("Touch of Heaven", Genre.Gospel);
            g.AddMusic("Be Still", Genre.Gospel);
            artists.Add(g);
            //
            Artist o = new Artist("Yolanda Adams");
            o.AddMusic("Open My Heart", Genre.Gospel);
            o.AddMusic("I'm Gonna Be Ready", Genre.Gospel);
            artists.Add(o);

            //Dubstep artists
            Artist h = new Artist("Skrillex");
            h.AddMusic("Don't Go", Genre.Dubstep);
            h.AddMusic("First of the year", Genre.Dubstep);
            artists.Add(h);
            //
            Artist p = new Artist("Skream");
            p.AddMusic("LOL OK", Genre.Dubstep);
            p.AddMusic("Rutten", Genre.Dubstep);
            artists.Add(p);

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
