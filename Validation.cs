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
                else if(password.Length < 8)
                {
                    throw new validationException("you password needs at least 8 characters");
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

        }



    }
}
