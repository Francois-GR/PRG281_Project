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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //empty
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //empty
        }

     

        private void btnLogIn_Click(object sender, EventArgs e)
        {       
            Validation validation = new Validation();// create class for validation, this will handle the exceptions and validation
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if(validation.validateUserName(userName) && validation.validatePassword(password))
            {
                if (validation.validateUser(userName, password))
                {
                    MessageBox.Show($"Welcome back {userName}");
                    Menu menuForm = new Menu(new Player(userName, password));// send current player data into the menu for further use
                    menuForm.Show();
                    this.Hide();
                    
                }
              
            }
           

        }

        

        private void btnMoveToSignUp_Click(object sender, EventArgs e)
        {
            Signup signupFrom = new Signup();// move to signup form
            signupFrom.Show();
            this.Hide();
        }
    }
}
