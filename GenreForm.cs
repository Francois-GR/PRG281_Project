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
        int turn = 1;

        DataHandler data = new DataHandler();

        List<Artist> artistList = new List<Artist>();

        List<int> checkedIndices = new List<int>();

        Player player1;
        Player player2 = null;
        Player currentPlayer;

        Artist currentArtist;
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
            artistList = data.GetArtist();
            currentPlayer = this.player1;
 


        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            ArtistGroupBox.Visible = false;
            grpGenres.Visible = false;
            btnSubmit.Visible = false;
            lblInstruction.Text = "select the correct genres you think the artist is in";

        }

        private  void btnStart_Click(object sender, EventArgs e)
        {
            ArtistGroupBox.Visible = true;
            grpGenres.Visible = true;
            btnSubmit.Visible = true;
            btnStart.Visible = false;
            timer1.Start();


            lblPlayerNameLabel.Text = player1.Name;           
            


            Random r = new Random();
            int randomIndex = r.Next(artistList.Count);
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
                TimeLabel.Text = Time--.ToString();
            }
            else
            {
                if (player2 == null)
                {
                    //call endgame fomr
                }
                else if (turn == 1)
                {

                    lblPlayerNameLabel.Text = player2.Name;
                    Time = 60;
                    turn++;
                    currentPlayer = player2;
                    MessageBox.Show("Player 2's turn");
                    timer1.Stop();
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
            if (turn == 2)
            {
                timer1.Start();
                turn++;
            }
            Random r = new Random();
            int randomIndex = r.Next(artistList.Count);
            
            int count = 0;
            while (checkedIndices.Contains(randomIndex))
            {
                randomIndex = r.Next(artistList.Count);
                count++;
                if(count> artistList.Count)
                {
                    break;
                }

            }

            Artist RandomArtist = artistList[randomIndex];
            lblArtsistName.Text = RandomArtist.GetArtistName();

            CheckAnswers(currentArtist);

            clearGenreBoxes();

            currentArtist = RandomArtist;


        }

        public void CheckAnswers(Artist artist)
        {
            List<Music> artistMusic = artist.GetMusic();
            List<Genre> artistGenres = new List<Genre>();
           
       

            foreach (Music music  in artistMusic)
            {
                artistGenres.Add(music.GetGenre());
            }

            foreach (Genre artistGen in artistGenres)
            {
                if (lsbGenre.SelectedIndices.Contains((int)artistGen))
                {                                     
                    ++currentPlayer.Score;
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
