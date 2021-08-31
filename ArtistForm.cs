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
        public ArtistForm()
        {
            InitializeComponent();
        }
        public ArtistForm(Player player1, Player player2 = null)
        {
           
            InitializeComponent();
            this.player1 = player1;
            lblPlayerNameLabel.Text = player1.Name;
            if (player2 != null)
            {
                this.player2 = player2;
                lblPlayerNameLabel.Text += $" and {player2.Name}";
            }
        }
    }
}
