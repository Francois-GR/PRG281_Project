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

    public partial class GenreForm : Form
    {
        int turn = 1;// keep track of who's turn it is

        DataHandler data = new DataHandler();// get database ready

        List<Artist> artistList = new List<Artist>(); //get temp list of artist names

        List<int> checkedIndices = new List<int>(); //this is to keep track of the artist already shown

        Player player1;
        Player player2 = null;// default
        Player currentPlayer;// keep track of who needs to play

        Artist currentArtist;// keep track of current artist reltive to next random artist
        public int Time = 60;
        public GenreForm()
        {
            InitializeComponent();
        }
        public GenreForm(Player player1, Player player2 = null)
        {
            InitializeComponent();
            this.player1 = player1;
            lblPlayerNameLabel.Text = player1.Name; 
            if(player2 != null)
            {
                this.player2 = player2;
                lblPlayerNameLabel.Text += $" and {this.player2.Name}";
            }
            artistList = data.GetArtist();// initiate temp list
            currentPlayer = this.player1;
 


        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            // hide game elements
            ArtistGroupBox.Visible = false;
            grpGenres.Visible = false;
            btnSubmit.Visible = false;
            lblInstruction.Text = "select the correct genres you think the artist is in";

        }

        private  void btnStart_Click(object sender, EventArgs e)
        {
            //show game elements
            ArtistGroupBox.Visible = true;
            grpGenres.Visible = true;
            btnSubmit.Visible = true;
            btnStart.Visible = false;
            timer1.Start();
            lblPlayerNameLabel.Text = "First Player: "+player1.Name;  // show whose turn it is         
          // determine new random artist and keep track of artist
            Random r = new Random();
            int randomIndex = r.Next(artistList.Count);// get random value to get random artist
            Artist RandomArtist = artistList[randomIndex];
            lblArtsistName.Text = RandomArtist.GetArtistName();
            checkedIndices.Add(randomIndex);
            currentArtist = RandomArtist;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time >= 0)
            {
                TimeLabel.Text ="Time remaining: " + Time--.ToString();//update label
            }
            else
            {
                if (player2 == null)
                {
                    //call endgame fomr
                }
                else if (turn == 1)// player one's turn ended
                {

                    lblPlayerNameLabel.Text = "Player two: "+player2.Name;
                    Time = 60; //reset time
                    turn++;// update turn
                    currentPlayer = player2;// next player
                    
                    
                    lblScore.Text = "Score: 0";
                   
                    

                }
                else
                {
                    //call end game form
                }
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            //get new random artist without it beng a a previously had one
                       
            Random r = new Random();
            int randomIndex = r.Next(artistList.Count);
            
            int count = 0;

            while (checkedIndices.Contains(randomIndex) || currentArtist.GetArtistName() == lblArtsistName.Text)
            {
                randomIndex = r.Next(artistList.Count);
                count++;// stop infinite loop scenario
                if(count> artistList.Count)
                {
                    break;
                }
              

            }

            Artist RandomArtist = artistList[randomIndex];
            checkedIndices.Add(randomIndex);
            lblArtsistName.Text = RandomArtist.GetArtistName();

            CheckAnswers(currentArtist);// update score according to correct answeres

            clearGenreBoxes();

            currentArtist = RandomArtist; // update 


        }

        public void CheckAnswers(Artist artist)
        {
            List<Music> artistMusic = artist.GetMusic();//extract artist music
            List<Genre> artistGenres = new List<Genre>();// store genres 
           
       

            foreach (Music music  in artistMusic)
            {
                artistGenres.Add(music.GetGenre()); // extract artist genre from artist music
            }

            foreach (Genre artistGen in artistGenres)
            {
                if (lsbGenre.SelectedIndices.Contains((int)artistGen))// cast enum type to int and test if the user selected the same indecies from the list box
                {                                     
                    ++currentPlayer.Score;// increment score before updating 
                    lblScore.Text = "Score: "+currentPlayer.Score.ToString();

                };
               



            }
            
         

           
        }

        private void clearGenreBoxes()
        {
            for (int i = 0; i < 8; i++)
            {
                lsbGenre.SetItemChecked(i, false);
            }
        }

    }
}
