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
        

        public DataHandler()
        {
            Players.Add(new Player("Piet", "1234567890"));
            Players.Add(new Player("Snoop", "Password1234"));
            Players.Add(new Player("Eddie", "ThisIsASafePassword"));
            Players.Add(new Player("Scarlett", "Pass1234567890"));

        }

        public List<Player> GetPlayers() { return Players; }
        public void AddPlayer(object player)
        {
            Player playerToAdd = (Player)player;
            Players.Add(playerToAdd);
        }
    }
}
