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
        bool multiplayer = false;// keep track of state
        Player MainPlayer; // keep track of original player that signed in
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
                //unown error occured, send user back to menu form to try again
                MessageBox.Show(e.Message);
                Menu menuForm = new Menu(player);
                menuForm.Show();
                this.Dispose();
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void btnArtToSong_Click(object sender, EventArgs e)
        {
            if (multiplayer)
            {
                //initiate mulitplayer sequence
                string SecondPlayername = txtSecondPlayer.Text;// second user will be playing as guest
                if (SecondPlayername == string.Empty)
                {
                    SecondPlayername = "Guest";    // avoid uneccasarry error                
                    
                }
                Player SecondPlayer = new Player(SecondPlayername, "");// no need for a password, player is temporary and won't be added to the database
                ArtistForm artistForm = new ArtistForm(MainPlayer, SecondPlayer);// send both players information to the game
                artistForm.Show();
                this.Hide();
            }
            else
            {
                ArtistForm genreFrom = new ArtistForm(MainPlayer);// send only the main player, because second player does not exist
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
                //same sequence as above
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
            // if it is multiplayer a second user needs to be created, all we need is a name.
            if (!multiplayer)
            {
                // if multiplayer the text box needs to be visible other wise it should not be shown
                lblPromtName.Visible = false;
                txtSecondPlayer.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
