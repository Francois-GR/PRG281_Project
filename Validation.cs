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

        public Validation() { }

        public bool validatePassword(string password)
        {
            bool validated = true;
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

        public bool validateUser(string username,string password)
        {
            bool validated = false;
            DataHandler data = new DataHandler();
            List<Player> players = data.GetPlayers();
            Player playerToValidate = new Player(username, password);
            try
            {
                foreach (Player person in players)
                {
                    if (person.Name == playerToValidate.Name)
                    {
                        if (person.CompareTo(playerToValidate) == 0)
                        {
                            return validated = true;
                        }
                    }
                }
                throw new validationException("invalid username or password");
            }
            catch(validationException e)
            {
                MessageBox.Show(e.Message);
                validated = false; 
            }
            return validated;

        }

        public bool searchUser(string username)
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
