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
    public partial class GameMode : Form
    {
        public GameMode()
        {
            InitializeComponent();
        }
        public GameMode(Player player, int players = 1)
        {
            InitializeComponent();
            try
            {
                if (players == 1)
                {
                    lblPlayerMode.Text = "Single Player";

                }
                else if (players == 2)
                {
                    lblPlayerMode.Text = "Multiplayer";
                }
                else
                {
                    throw new playerModeException("sorry there was a error, please try again");
                }
            }
            catch(playerModeException e)
            {
                MessageBox.Show(e.Message);
                Menu menuForm = new Menu(player);
                menuForm.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void btnArtToSong_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenreToArt_Click(object sender, EventArgs e)
        {

        }
    }
}
