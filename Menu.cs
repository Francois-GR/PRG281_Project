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
        Player player = new Player();
        private int singlePlayer = 1;
        private int multiplayer = 2;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(Player player)
        {
            InitializeComponent();
            this.player = player;
            lblWelcome.Text += this.player.Name.ToUpper();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            GameMode playSinglePlayer = new GameMode(this.player, singlePlayer);
            playSinglePlayer.Show();
            this.Hide();
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            GameMode playMultiplayer = new GameMode(this.player, multiplayer);
            playMultiplayer.Show();
            this.Hide();
        }
    }
}
