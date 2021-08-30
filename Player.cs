using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG
{
    class Player
    {
        private string name;
        private string password;
        private int score;

        public Player(string Name, string Password)
        {
            this.name = Name;
            this.password = Password;
        }

        public string Name { get => name; set => name = value; }
        public int Score { get => score; set => score = value; }

        // Add score to the player by a custom amount. Default is 1
        public void AddScore(int Amount = 1) { Score += Amount; }

        // Reset player score back to zero
        public void ResetScore() { Score = 0; }
    }
}
