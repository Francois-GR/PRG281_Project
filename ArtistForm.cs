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
        private int Time = 60;
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
            //StartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time > 0)
                lblTime.Text = Time--.ToString();
        }
    }
}
