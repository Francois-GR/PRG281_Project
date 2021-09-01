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
    public partial class Score : Form
    {
        Player player1;
        Player player2;
        int players = 1;
        public Score()
        {
            InitializeComponent();
        }
        public Score(Player player1, Player player2=null)
        {
            InitializeComponent();
            this.player1 = player1;

            if (player2 != null)
            {
                //multiplayer
                this.player2 = player2;

                lblPlayer1Name.Text = this.player1.Name;
                lblPlayer1Score.Text = this.player1.Score.ToString();

                lblPlayer2Name.Text = this.player2.Name;
                lblPlayer2Score1.Text = this.player2.Score.ToString();

                players++;


               
            }
            else
            {
                //single player
                lblPlayer1Name.Text = this.player1.Name;
                lblPlayer1Score.Text = this.player1.Score.ToString();

                lblPlayer2.Visible = false;
                lblPlayer2Name.Visible = false;
                lblPlayer2Score1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(player1);
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameMode gamemode = new GameMode(player1, players);
            gamemode.Show();
            this.Hide();
        }
    }
}
 