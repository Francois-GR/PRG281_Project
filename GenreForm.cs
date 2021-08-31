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


        Player player1;
        Player player2 = null;
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
                    
          

        }

       


        

        
     

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time > 0)
            {
                TimeLabel.Text = Time--.ToString();
            }
            else
            {

            }

        }

    }
}
