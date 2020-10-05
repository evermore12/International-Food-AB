using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalFoodAB
{
    public abstract class Account
    {
        //Properties
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        //Constructor overloadar
        public Account()
        {

        }

        //Constructor med 2 parameter
        public Account(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

        //Constructor med 3 parameter
        public Account(string UserName, string Password, string Email)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Email = Email;
        }

        public void AdminLogin()
        {
            if (UserName != "Admin" && Password != "King123")
            {
                //Messagebox visar att inloggningen är felaktig.
            }
        }




    }
}
