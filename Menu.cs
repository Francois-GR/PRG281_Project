using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG
{
    public partial class Menu : Form
    {
        Player player; //global player within form
        private int singlePlayer = 1;
        private int multiplayer = 2;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(Player player)// recieve player as parameter
        {
            InitializeComponent();
            this.player = player;// make player global within from
            lblWelcome.Text += this.player.Name.ToUpper(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            GameMode playSinglePlayer = new GameMode(this.player, singlePlayer);// send player along with integer to signify single player
            playSinglePlayer.Show();
            this.Hide();
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            GameMode playMultiplayer = new GameMode(this.player, multiplayer); //send player along with int to signify multiplayer
            playMultiplayer.Show();
            this.Hide();
        }
    }
}
