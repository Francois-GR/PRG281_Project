using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG
{
    class Validation : validationException
    {

        public Validation() { }// default constructor

        public bool validatePassword(string password)
        {
            bool validated = true;// keeping track of validation
            try
            {
                if(password == string.Empty)
                {
                   throw new validationException("please enter password");
                   
                }
                

            }
            catch(validationException e)
            {
                MessageBox.Show(e.Message);
                validated =  false;

            }

            return validated;
        }

        public bool validateUserName(string name)
        {
            bool validated = true;
            try
            {
                if(name == string.Empty)
                {
                    throw new validationException("please enter a valid User name");
                }
                
            }
            catch(validationException e)
            {
                MessageBox.Show(e.Message);
                validated = false;
            }
            return validated;
        }

        public bool validateUser(string username,string password) //the purpose of this method is to find the user in the existing simulated database and then compare the passwords.
        {
            bool validated = false;
            DataHandler data = new DataHandler();// get simulated database
            List<Player> players = data.GetPlayers(); //use database to get a list of pre-registered players
            Player playerToValidate = new Player(username, password); // generate temporary player object with given parameters for comparaison
            try
            {
                foreach (Player person in players)
                {
                    if (person.Name == playerToValidate.Name)
                    {
                        if (person.CompareTo(playerToValidate) == 0) // the CompareTo method uses the player Property password for comparison
                        {
                            return validated = true;
                        }
                    }
                }
                throw new validationException("invalid username or password");// this won't be reached if the validation was a success, because of the return statment.
            }
            catch(validationException e)
            {
                MessageBox.Show(e.Message);
                validated = false; 
            }
            return validated;

        }

        public bool searchUser(string username)// this is a simpler veriosn of the validateUser because this is only to check if the user exists in the database.
        {
            bool found = false;
            DataHandler data = new DataHandler();
            List<Player> players = data.GetPlayers();

            foreach (Player player in players)
            {
                if(player.Name == username)
                {
                    found = true;
                    return found;
                }
            }
            return found;

        }



    }
}
