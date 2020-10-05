﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalFoodAB
{
    public class Account
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
            //alt2
         /*   string Username = "Admin";
            string Password = "King123";
            string Email = "Admin1@gmail.com";

           if (Username != "Admin" && Password != "King123" && Email != "Admin1@gmail.com")
            {
                //Messagebox visar att inloggningen är felaktig.
            } */


            //alt1
            if (UserName != "Admin" && Password != "King123" && Email != "Admin1@gmail.com")
            {
                //Messagebox visar att inloggningen är felaktig.
            }
        }




    }
}