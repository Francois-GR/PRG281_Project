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
    public partial class ArtistForm : Form
    {
        Player player1;
        Player player2;
        Player ActivePlayer;
        private static int MaxTime = 60;
        private int Time = MaxTime;
        DataHandler dataHandler = new DataHandler();
        List<int> previousIndecies = new List<int>();
        Artist activeArtist;
        int SelectecdArtistIndex = 0;
        int MaxAttempts = 10;
        int Player1Attempts = 0;
        int Player2Attempts = 0;

        public ArtistForm()
        {
            InitializeComponent();
        }
        public ArtistForm(Player player1, Player player2 = null)
        {
            InitializeComponent();
            this.player1 = player1;
            lblPlayerNameLabel.Text = this.player1.Name;
            if (player2 != null)
            {
                this.player2 = player2;
                lblPlayerNameLabel.Text += $" and {this.player2.Name}";
            }
            ActivePlayer = this.player1;
            lblPlayerNameLabel.Text = ActivePlayer.GetPlayerName();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ArtistForm_Load(object sender, EventArgs e)
        {
            grpArtist.Visible = false;
            grpSongName.Visible = false;
            btnSubmit.Visible = false;
            lblTime.Visible = false;
            lblPlayerNameLabel.Text = ActivePlayer.GetPlayerName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpArtist.Visible = true;
            grpSongName.Visible = true;
            btnSubmit.Visible = true;
            lblTime.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            grpArtist.Visible = true;
            grpSongName.Visible = true;
            btnSubmit.Visible = true;
            lblTime.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            grpArtist.Visible = true;
            grpSongName.Visible = true;
            btnSubmit.Visible = true;
            lblTime.Visible = true;
            btnStart.Visible = false;
            UpdateSongList();
            timer1.Start();

            ArtistListBox.Items.Clear();
            foreach (Artist a in dataHandler.GetArtist())
                ArtistListBox.Items.Add(a.GetArtistName(), false);

            ArtistListBox.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time > 0)
                lblTime.Text = "Time Remaining: " + Time--.ToString();
            else
            {
                if (ActivePlayer == player1)
                {
                    if (player2 != null)
                    {
                        ActivePlayer = player2;
                        lblPlayerNameLabel.Text = player2.Name;
                        ScoreLabel.Text = player2.Score.ToString();
                        Time = MaxTime;
                        lblPlayerNameLabel.Text = ActivePlayer.GetPlayerName();
                    }
                    else
                        EndGame();
                }
                else
                    EndGame();
            }
        }

        private void EndGame()
        {
            timer1.Stop();
            Score gameSummary;

            if (player2 == null)
                gameSummary = new Score(player1);
            else
                gameSummary = new Score(player1, player2);

            gameSummary.Show();
            this.Dispose();
        }

        private void UpdateSongList()
        {
            Random random = new Random();
            int index = random.Next(dataHandler.GetArtist().Count);

            int counter = 0;
            while (previousIndecies.Contains(index))
            {
                index = random.Next(dataHandler.GetArtist().Count);
                counter++;

                if (counter > dataHandler.GetArtist().Count)
                    break;
            }

            previousIndecies.Add(index);

            activeArtist = dataHandler.GetArtist()[index];

            SongListRichTextbox.Clear();
            foreach (Music song in activeArtist.GetMusic())
            {
                SongListRichTextbox.Text += song.GetSongName() + "\n";
            }
        }

        private void ArtistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ArtistListBox.SelectedIndex;
            for (int i = 0; i < ArtistListBox.Items.Count; i++)
                ArtistListBox.SetItemChecked(i, false);

            ArtistListBox.SetItemChecked(index, true);
            SelectecdArtistIndex = index;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ArtistListBox.CheckedItems.Count <= 0)
            {
                MessageBox.Show("No artist was selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedArtistName = ArtistListBox.Items[SelectecdArtistIndex].ToString();

            // the correct artist was selected
            if (activeArtist.GetArtistName() == selectedArtistName)
            {
                ActivePlayer.AddScore();
                ScoreLabel.Text = "Score: " + ActivePlayer.Score;
            }

            if (ActivePlayer == player1)
            {
                if (++Player1Attempts >= MaxAttempts)
                {
                    if (player2 != null)
                    {
                        ActivePlayer = player2;
                        lblPlayerNameLabel.Text = player2.Name;
                        ScoreLabel.Text = player2.Score.ToString();
                        Time = MaxTime;
                        lblPlayerNameLabel.Text = ActivePlayer.GetPlayerName();
                    }
                    else
                        EndGame();
                }
            }
            else
            {
                if (++Player2Attempts >= MaxAttempts)
                    EndGame();
            }

            UpdateSongList();
        }
    }
}
