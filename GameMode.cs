using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Project_PRG
{
    public partial class GameMode : Form
    {
        bool multiplayer = false;
        Player MainPlayer;
        public GameMode()
        {
            InitializeComponent();
        }
        public GameMode(Player player, int players = 1)
        {
            InitializeComponent();
            try
            {
                if(player!= null)
                {
                    this.MainPlayer = player;
                }
                if (players == 1)
                {
                    lblPlayerMode.Text = "Single Player";

                }
                else if (players == 2)
                {
                    lblPlayerMode.Text = "Multiplayer";
                    multiplayer = true;
                    
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
            if (multiplayer)
            {
                string SecondPlayername = txtSecondPlayer.Text;
                if (SecondPlayername == string.Empty)
                {
                    SecondPlayername = "Guest";                     
                    
                }
                Player SecondPlayer = new Player(SecondPlayername, "");
                ArtistForm artistForm = new ArtistForm(MainPlayer, SecondPlayer);
                artistForm.Show();
                this.Hide();
            }
            else
            {
                ArtistForm genreFrom = new ArtistForm(MainPlayer);
                genreFrom.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenreToArt_Click(object sender, EventArgs e)
        {
            if (multiplayer)
            {
                string SecondPlayername = txtSecondPlayer.Text;
                Player SecondPlayer = new Player(SecondPlayername, "");
                GenreForm genreForm = new GenreForm(MainPlayer, SecondPlayer);
                genreForm.Show();
                this.Hide();
            }
            else
            {
                GenreForm genreFrom = new GenreForm(MainPlayer);
                genreFrom.Show();
                this.Hide();
            }
        }


        
        private void GameMode_Load(object sender, EventArgs e)
        {
            if (!multiplayer)
            {
                lblPromtName.Visible = false;
                txtSecondPlayer.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
