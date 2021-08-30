using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG
{
    public class Player
    {
        private string Name;
        private string Password;
        private int Score;

        public Player(string Name, string Password)
        {
            this.Name = Name;
            this.Password = Password;
        }

        // Get the name of the player
        public string GetPlayerName() { return Name; }

        // Get the player password
        public string GetPassword() { return Password; }

        // Add score to the player by a custom amount. Default is 1
        public void AddScore(int Amount = 1) { Score += Amount; }

        // Reset player score back to zero
        public void ResetScore() { Score = 0; }
    }
}
