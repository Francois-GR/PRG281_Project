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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMoveToLogIn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();// navigate to login
            loginForm.Show();
            this.Hide();


        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // todo: validate user data, check is user exists, add user to database
            bool validated = false;
            Validation validation = new Validation();
            DataHandler data = new DataHandler();
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string passwordConfirm = txtConfirm.Text;

            try
            {
                if (validation.validatePassword(password) && validation.validateUserName(username)){
                    if (password == passwordConfirm)
                    {
                        if (!validation.searchUser(username))// see if username already exists, username has to be unique
                        {
                            validated = true;
                        }
                        else
                        {
                            txtUserName.Clear();// promt user to enter new username
                            validated = false;
                            throw new validationException("User already exists");
                        }

                    }
                    else
                    {
                        txtPassword.Clear();
                        txtConfirm.Clear();
                        txtPassword.Focus();
                        validated = false;
                        throw new validationException("passwords do not match, please try again");
                    }
                }
                

               
            }
            catch(validationException err)
            {
                MessageBox.Show(err.Message);
                validated = false;

            }

            if (validated)
            {
                Player player = new Player(username, password);// create new player to add to simulated database
                data.AddPlayer(player);// add player to database
                Menu menuForm = new Menu(player);// send current player data into the menu for further use
                menuForm.Show();
                this.Hide();
            }

            
        }
    }
}
